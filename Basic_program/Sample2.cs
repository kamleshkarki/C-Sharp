﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrograms
{
    class Sample2
    {
        public void Addition()
        {
            int a,b,c;
            Console.WriteLine("Please enter a value :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter b value :");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition of a and b is "+c);
        }

        static void Main(string[] args)
        {
            Sample2 s2 = new Sample2();
            s2.Addition();
            Console.ReadLine();
        }
    }
}
