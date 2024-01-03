using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Abstract class rules
    public abstract class Shape
    {
        int a = 10;
        public abstract double CalculateArea();
        public int Number()
        {
            return 10;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Implementation of the abstract method from the base class
        public override double CalculateArea()
        {
           
            return Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            Circle circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine(circle.Number());
            Console.WriteLine(circle.CalculateArea());
            //circle.DisplayArea();
            //Console.WriteLine("hello how are you");
            Console.ReadLine();
        }
    }
}
