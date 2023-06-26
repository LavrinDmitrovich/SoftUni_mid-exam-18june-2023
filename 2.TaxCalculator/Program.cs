using System;
using System.Linq;

namespace _2.TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carList = Console.ReadLine()
                .Split(">>")
                .ToArray();

            double taxFamily;
            double taxHeavy;
            double taxSport;

            double totalTaxFamily = 0;
            double totalTaxHeavy = 0;
            double totalTaxSports = 0;

            foreach (string singleCar in carList) 
            {
                string[] item = singleCar.Split(' ').ToArray();
                string model = item[0];
                double yearTopay = double.Parse(item[1]);
                double distance = double.Parse(item[2]);

                taxFamily = 0;
                taxHeavy = 0;
                taxSport = 0;

                
                if (model != "family" && model != "heavyDuty" && model != "sports") { Console.WriteLine("Invalid car type."); }

                switch (model) 
                {
                    case "family":
                        taxFamily = (50 - 5 * yearTopay + 12 * (int)(distance / 3000));
                        Console.WriteLine("A family car will pay {0:f2} euros in taxes.", taxFamily);
                        break;

                    case "heavyDuty":
                        taxHeavy = (80 - 8 * yearTopay + 14 * (int)(distance / 9000));
                        Console.WriteLine("A heavyDuty car will pay {0:f2} euros in taxes.", taxHeavy);
                        break;
                    case "sports":
                        taxSport = (100 - 9 * yearTopay + 18 * (int)(distance / 2000));
                        Console.WriteLine("A sports car will pay {0:f2} euros in taxes.", taxSport);
                        break;

                }

                totalTaxFamily += taxFamily;
                totalTaxHeavy += taxHeavy;
                totalTaxSports += taxSport;


                
            }
            Console.WriteLine("The National Revenue Agency will collect {0:f2} euros in taxes.", totalTaxFamily + totalTaxHeavy + totalTaxSports);
        }
    }
}
