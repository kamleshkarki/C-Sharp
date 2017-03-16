using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrograms
{
    class Bike
    {
        String Bikename;
        double Bikeprise;
        String BikeModel;
        public void AcesspriseDetail()
        {
            Console.WriteLine("Bike information is :");
            Console.WriteLine("Enter the Bike_Name :");
            Bikename = Console.ReadLine();
            Console.WriteLine("Enter the Bike_prise :");
            Bikeprise = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Bike_Model");
            BikeModel = Console.ReadLine();
        }
        public void DisplayBikeDetails()
        {
            /*Console.WriteLine("Bike_Name is {0},Bike_prise is{1},Bike_Model is{2}",Bikename,Bikeprise,BikeModel);*/
            Console.WriteLine("Bike Name is :" + Bikename);
            Console.WriteLine("Bike Name is :" + Bikeprise);
            Console.WriteLine("Bike Name is :" + BikeModel);

        }
        static void Main(string[] args)
        {
            Bike t = new Bike();
            t.AcesspriseDetail();
            t.DisplayBikeDetails();
            Console.ReadLine();

        }
    }
}
