using System;
namespace ConsolePrograms
{
    class sample
    {
        int a, b, c;
        public void Subtraction()
        {
            c = a - b;
            // Console.WriteLine("Subtraction of a and b is  " + c);
            Console.WriteLine("Subtraction of a and b is {0} ",c);
        }
        static void Main(string[] args)
        {
            sample s = new sample();
            s.a = 10;
            s.b = 50;
            s.Subtraction();
            Console.ReadLine();
        }
    }
   
}
