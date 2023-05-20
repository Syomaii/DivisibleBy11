/*
    Name: Christian Jay Putol
    Date created: 03/17/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Positive Integer: ");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            bool add = true;
            while (n > 0) 
            { 
                int digit = n % 10;
                if (add)
                    t += digit;
                else
                    t -= digit;
                add = !add;
                n /= 10;
            }
            if (t % 11 == 0)
                Console.WriteLine("The number is divisible by 11.");
            else
                Console.WriteLine("The number is not divisible by 11.");
        }
    }
}
