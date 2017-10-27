using System;

namespace _3_MileToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal km = miles * 1.60934m;
           
            Console.WriteLine($"{km:F2}");
        }
    }
}
