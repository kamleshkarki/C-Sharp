/*This is the Example of Parameterized Constructor */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class paraconstrctor
    {
        int var1, var2, var3;
        public paraconstrctor(int x, int y)// decalaring Paremetrized Constructor with (ing x,int y) parameter
        {
            Console.WriteLine("This Program Perform Multiplication between two number");
            var1 = x;
            var2 = y;
            var3 = var2 * var1;
            Console.WriteLine("Multiplaction of two Number is: " + var3);

        }
        static void Main(string[] args)
        {
            paraconstrctor p = new paraconstrctor(10, 20);
            Console.ReadLine();
        }
    }
}
