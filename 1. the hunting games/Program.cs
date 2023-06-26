using System;
using System.ComponentModel.Design;

namespace _1._the_hunting_games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double daysPlay = double.Parse(Console.ReadLine());
            double playersQty = double.Parse(Console.ReadLine());
            double energyTotal = double.Parse(Console.ReadLine());
            double waterDay = double.Parse(Console.ReadLine());
            double foodDay = double.Parse(Console.ReadLine());


            double waterHaveTotal = daysPlay * playersQty * waterDay;
            double foodHaveTotal = daysPlay * playersQty * foodDay;

            bool winner = false;

            double energyConsDay = double.Parse(Console.ReadLine());

            double dayPass = 1;
            energyTotal -= energyConsDay;
            if (energyTotal <= 0) { goto TheBadEnd; }

            while (energyTotal > 0)
            {
                dayPass++;

                energyConsDay = double.Parse(Console.ReadLine());


                if (dayPass % 2 == 0)
                {
                    waterHaveTotal = waterHaveTotal * 0.7;
                    energyTotal = (energyTotal - energyConsDay) * 1.05;
                    Console.WriteLine(energyTotal + " 2 days");
                }
                else
                {
                    foodHaveTotal = foodHaveTotal * (1 - 1 / playersQty);
                    energyTotal = (energyTotal - energyConsDay) * 1.1;
                    Console.WriteLine(energyTotal + " 1 days");
                }

                if (dayPass == daysPlay) { winner = true;  break; }
            }

            if (winner == true) { Console.WriteLine("You are ready for the quest. You will be left with - {0:f2} energy!", energyTotal) ; }

            TheBadEnd:
            if (winner == false) { Console.WriteLine("You will run out of energy. You will be left with {0:f2} food and {1:f2} water.", foodHaveTotal, waterHaveTotal); }
                      
           
                  
           





        }
    }
}
