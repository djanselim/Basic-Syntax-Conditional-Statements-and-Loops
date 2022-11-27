using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int userNameLength = userName.Length - 1;
            string password = String.Empty;
            bool isTrue = false;

            for(int i = userNameLength; i >= 0; i--)
            {
                password += userName[i];
            }
            
            for(int i = 1; i < 4; i++)
            {
                string input = Console.ReadLine();

                if(input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    isTrue = true;
                    break;
                }  else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if(isTrue == false)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
