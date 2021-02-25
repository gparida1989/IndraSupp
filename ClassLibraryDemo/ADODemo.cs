using System;
using System.Data;
using System.Data.SqlClient;


namespace ClassLibraryDemo
{
    public class ADODemo
    {
        SqlConnection connection = new SqlConnection("data source=DESKTOP-6HQSAGG\\SQLEXPRESS; database=demo; integrated security=SSPI");
        public void ReadTable()
        {
            try
            {
                string sql = "select * from [dbo].[myTable]";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    var name = reader[0]; //indexers
                    var country = reader[1];

                    Console.WriteLine($"Name is = {name} and country is = {country}");
                }
               
                

                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //ExecuteReader requires an open and available Connection. The connection's current state is closed.
            }

        }


        public void FetchTableDisconnected()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [dbo].[myTable]", connection);

            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    var currentRow = dt.Rows[i];
                    Console.WriteLine($"name is {currentRow[0]} and country is {currentRow[1]}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void InsertRow()
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into [dbo].[myTable]([Name],[country]) values('biden','US')", connection);
                connection.Open();

                int affectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"affected rows = {affectedRows}");

                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ReadTable(bool singleValue)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select [id] from [dbo].[DemoUsers]", connection);

                connection.Open();
                int response = (int)cmd.ExecuteScalar();

                Console.WriteLine($" country is = {response}");

                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //ExecuteReader requires an open and available Connection. The connection's current state is closed.
            }

        }

       
    }
}
