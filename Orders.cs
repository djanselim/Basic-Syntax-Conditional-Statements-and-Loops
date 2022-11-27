using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;
            for(int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());

                double totalCost = (days * capsulesCount) * pricePerCapsule;
                total += totalCost;
                Console.WriteLine($"The price for the coffee is: ${totalCost:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
