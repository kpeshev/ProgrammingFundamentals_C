using System;

namespace _4_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Volume = int.Parse(Console.ReadLine());
			int Energy = int.Parse(Console.ReadLine());
			int Sugar = int.Parse(Console.ReadLine());

			double kcal = (Volume * Energy) / 100.00;
			double gram= (Volume * Sugar)/ 100.00;

			Console.WriteLine($"{Volume}ml {Name}:");
			Console.WriteLine($"{kcal}kcal, {gram}g sugars");
        }
    }
}
