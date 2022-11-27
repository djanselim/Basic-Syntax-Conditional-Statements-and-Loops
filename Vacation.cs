using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double totalSum = 0;
            
            if(typeOfPeople == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        totalSum += countOfPeople * 8.45;
                        break;
                    case "Saturday":
                        totalSum += countOfPeople * 9.80;
                        break;
                    case "Sunday":
                        totalSum += countOfPeople * 10.46;
                        break;
                }
            }
            else if(typeOfPeople == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        totalSum += countOfPeople * 10.90;
                        break;
                    case "Saturday":
                        totalSum += countOfPeople * 15.60;
                        break;
                    case "Sunday":
                        totalSum += countOfPeople * 16;
                        break;
                }
            }
            else if(typeOfPeople == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        totalSum += countOfPeople * 15;
                        break;
                    case "Saturday":
                        totalSum += countOfPeople * 20;
                        break;
                    case "Sunday":
                        totalSum += countOfPeople * 22.50;
                        break;
                }
            }
            if(typeOfPeople == "Students" && countOfPeople >= 30)
            {
                totalSum *= 0.85;
            } 
            else if(typeOfPeople == "Business" && countOfPeople >= 100)
            {
                double discount = 0;
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        discount = 10 * 10.90;
                        break;
                    case "Saturday":
                        discount = 10 * 15.60;
                        break;
                    case "Sunday":
                        discount = 10 * 16;
                        break;
                }
                totalSum -= discount;
            }
            else if(typeOfPeople == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                totalSum *= 0.95;
            }
            Console.WriteLine($"Total price: {totalSum:F2}");
            
            
        }
    }
}
