using System;
using System.Data.SqlClient;


namespace ClassLibraryDemo
{
    public class ADODemo
    {
        public void ReadTable()
        {
            string connectionSrting = "data source=DESKTOP-6HQSAGG\\SQLEXPRESS; database=demo; integrated security=SSPI";

            try
            {
                SqlConnection connection = new SqlConnection(connectionSrting);
                string sql = "select * from [dbo].[myTable]";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    var name = reader[0];
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
    }
}
