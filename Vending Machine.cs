using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalCoins = 0;
            
            while(command != "Start")
            {
                double coins = double.Parse(command);
                if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();

            }

            command = Console.ReadLine();
            
            while(command != "End")
            {

                switch (command)
                {
                    case "Nuts":
                        if(totalCoins - 2.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            
                            totalCoins -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (totalCoins - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {

                            totalCoins -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (totalCoins - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {

                            totalCoins -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (totalCoins - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {

                            totalCoins -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (totalCoins - 1.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {

                            totalCoins -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Change: {totalCoins:F2}");
        }
    }
}
