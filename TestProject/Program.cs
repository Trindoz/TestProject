using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle= new Triangle(3, 4, 6);
            Console.WriteLine(triangle.IsSquared());
            Console.ReadLine();
        }
    }
}
