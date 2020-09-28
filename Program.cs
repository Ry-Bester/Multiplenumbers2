using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplenumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number .");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now Pick a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Integers intobj1 = new Integers();
            intobj1.myMethod(num2, num1);
            Console.ReadLine();
          
        }
    }
}