using System;

//Exercise: Age Category Checker

//Ask for a user's age.

//Use a ternary operator to print: "Child"(under 13), "Teen"(13 - 17), "Adult"(18 - 59), or "Senior" (60+).

namespace Age_Category_Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------- Age Category Checker --------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.Write("Enter You Age for Category Checking: ");
            int age = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Your Category :");
            Console.ResetColor();

            string category = (age < 13) ? "  Child" :
                (age <= 17) ? "  Teen" :
                (age <= 59) ? "Adult" :
                "Senior";

            Console.WriteLine(category);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ResetColor();
        }
    }
    
}