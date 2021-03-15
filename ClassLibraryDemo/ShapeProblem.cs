using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo.Kata
{
    public interface IShape
    {
        bool Validate();
    }
    public class Shape : IShape
    {
        public virtual bool Validate()
        {
            return false;
        }

        public virtual string Type { get; set; } = "";
    }

    public class Rectangle : Shape
    {
        public int length;
        public int breadth;

        public Rectangle(int L,int B)
        {
            length = L;
            breadth = B;
        }
        public override string Type { get => "Rectangle"; set => this.Type=value; }
        
        public override bool Validate()
        {
            if(length <=0 || breadth <= 0)
            {
                return false;
            }
            else
            return true;
        }

        public double Area(Shape s)
        {
            var v = (Rectangle)s;

            return v.length * v.breadth;
        }
    }
    public class Circle : Shape
    {
        public int radius;

        public Circle(int R)
        {
            radius = R;
        }
        public override string Type { get => "Circle"; set => this.Type = value; }

        public override bool Validate()
        {
            if (radius <= 0 )
            {
                return false;
            }
            else
                return true;
        }

        public double Area(Shape s)
        {
            var v = (Circle)s;

            return Math.PI * v.radius * v.radius;
        }
    }


    public class Validator
    {
        public bool ValidateShape(IShape shape)
        {
            return shape.Validate();
        }
    }

    public class AreaCalculator
    {
        public delegate double DelCalc(Shape s);
        DelCalc myCalc;
        public AreaCalculator(DelCalc c)
        {
            myCalc = c;
        }

        public void Area(Shape s)
        {
            double result = 0;
            if(s.Type == "Rectangle")
            {
                result=myCalc(s as Rectangle);
            }
            else if (s.Type == "Circle")
            {
                result=myCalc(s as Circle);
            }

            Console.WriteLine($"The area of {s.Type} is {result}");
        }
    }
}
