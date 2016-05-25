using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank_pd2
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney;
            Console.WriteLine("Number of Pennies: ");
            int pennies = int.Parse(Console.ReadLine());

            totalMoney = 0.01 * pennies;

            Console.WriteLine("Number of Nickles: ");
            int nickles = int.Parse(Console.ReadLine());

            totalMoney += 0.05 * nickles;

            Console.WriteLine("Number of Dimes: ");
            int dimes = int.Parse(Console.ReadLine());

            totalMoney += 0.10 * dimes;

            Console.WriteLine("Number of Quarters: ");
            int quarters = int.Parse(Console.ReadLine());

            totalMoney += 0.25 * quarters;

            Console.WriteLine("Number of Half Dollars: ");
            int halfDollar = int.Parse(Console.ReadLine());

            totalMoney += 0.50 * halfDollar;

            Console.WriteLine("Number of Gold Dollars: ");
            int goldDollar = int.Parse(Console.ReadLine());

            totalMoney += 1.00 * goldDollar;

            
            Console.WriteLine("$" + totalMoney);

            if (totalMoney >= 20.00)
            {
                Console.WriteLine("Number of $20 bills " + (int)(totalMoney / 20.00)); 
            }

        }
    }
}
