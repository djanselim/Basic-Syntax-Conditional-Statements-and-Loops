using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lostGamesCount = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double crashedHeadset = Math.Floor(lostGamesCount / 2) * headsetPrice;
            double crashedMouse = Math.Floor(lostGamesCount / 3) * mousePrice;
            double keyboardsCrashed = Math.Floor(lostGamesCount / 6) * keyboardPrice;
            double displaysCrashed = Math.Floor(lostGamesCount / 12) * displayPrice;

            
            double totalCost = crashedHeadset + crashedMouse + keyboardsCrashed + displaysCrashed;

            Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
        }
    }
}
