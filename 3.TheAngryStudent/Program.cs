using System;
using System.Linq;

namespace _3.TheAngryStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] goods = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            string position = Console.ReadLine();

            var Left = new int[num];
            var Right = new int[goods.Length - num +1]; 

            for (int i = 0; i < num; i++) 
            { Left[i] = goods[i]; }

            for (int i = 0; i< goods.Length-1-num; i++)
            { Right[i] = goods[i+num+1]; }

            
            int sumLeft = 0;
            int sumRight = 0;

            if (position == "cheap")
            {
                for (int i=0; i< Left.Length; i++)
                { if (Left[i] < goods[num]) sumLeft += Left[i]; }

                for (int i = 0; i < Right.Length; i++ ) 
                { if (Right[i] < goods[num]) sumRight += Right[i]; }
            }



            if (position == "expensive")
            {
                for (int i = 0; i < Left.Length; i++)
                { if (Left[i] >= goods[num]) sumLeft += Left[i]; }

                for (int i = 0; i < Right.Length; i++)
                { if (Right[i] >= goods[num]) sumRight += Right[i]; }
            }

            if (sumLeft >= sumRight) Console.WriteLine("Left - {0}", sumLeft);
            else Console.WriteLine("Right - {0}", sumRight);

           


        }
    }
}
