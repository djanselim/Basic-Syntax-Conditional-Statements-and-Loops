using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double extraLightsabers = Math.Ceiling((countOfStudents / 100) * 10);
            double lightSabersPrice = (countOfStudents + extraLightsabers) * priceOfLightsabers;
            double robesPrice = countOfStudents * priceOfRobes;
            double FreeBelts = Math.Ceiling(countOfStudents / 6);
            double beltsPrice = countOfStudents * priceOfBelts;
            double discountBeltsPrice = beltsPrice - (FreeBelts * priceOfBelts);
            double total = 0;

            if(countOfStudents >= 6)
            {
                total = lightSabersPrice + robesPrice + discountBeltsPrice;
            }
            else
            {
                total = lightSabersPrice + robesPrice + beltsPrice;
            }

            if(amountOfMoney >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(amountOfMoney - total):F2}lv more.");
            }

        }
    }
}
