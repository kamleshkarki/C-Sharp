using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrograms
{
    class run
    {
        public void go()
        {

            Console.WriteLine("Enter the number :");
            Decimal var1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            Decimal var2 = Convert.ToDecimal(Console.ReadLine());
            if (var1 > var2)
            {
                Console.WriteLine("First is greater");
            }
            else if (var1 == var2)
            {
                Console.WriteLine("Number are the same");
            }
            else
            {
                Console.WriteLine("Second is greater");
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            run s2 = new run();
            s2.go();
            Console.ReadLine();
        }
    }
}


