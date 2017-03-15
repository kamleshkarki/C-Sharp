using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrograms
{
    class Sample3
    {
        public int a;
        public int b, c;
        public void Addition(int a)
        {
            c = a + b;
        }
    }
    class mainclass
    { 
        static void Main(string[] args)
        {
            Sample3 s3 = new Sample3();
            s3.a = 10;
            s3.b = 20;
            s3.Addition(30);
            Console.WriteLine("Addition of a and b is {0} ",s3.c);
            Console.ReadLine();
            
        }
    }
}
