/*This is the Example of default constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Addition
    {
        int var1, var2, var3;
        public Addition()   //Default constructor
        {
            Console.WriteLine("This program Perform Addition please Enter Any two number");
            Console.WriteLine("Enter The First Number");
            var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            var2 = int.Parse(Console.ReadLine());
            var3 = var2 + var1;
            Console.WriteLine("Addition of two Number is: " + var3);
        }

        static void Main(string[] args)
        {
            Addition a = new Addition(); //an object is created , constructor is called
            Console.ReadLine();
        }
    }
}
