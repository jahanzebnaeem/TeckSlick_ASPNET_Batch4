using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                // Iteraion 1
                //if (i <= 5)
                //{
                //    Console.WriteLine("Hello to you and welcome to the first class of ASP.NET");

                //}
                //else
                //{
                //    Console.WriteLine("The value is greater than 5");
                //}

                // Iteration 2
                string name = Console.ReadLine();
                while (i <= 10)
                {
                    Console.WriteLine("S.No " + i + " - Welcome " + name + " to the Lecture 1 of ASP.NET");

                    i++;
                }
            }
        }
    }
}
