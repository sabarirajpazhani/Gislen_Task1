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
            int age = 0;
            Age:
            try
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter You Age for Category Checking: ");
                Console.ResetColor();
                int Age = int.Parse(Console.ReadLine());

                if (age > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Age");
                    Console.ResetColor();
                    goto Age;
                }
                age = Age;
            }
            catch(FormatException ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Age should contain digits only — alphabets, special symbols, and whitespace are not allowed.");
                Console.ResetColor();
                goto Age;
            }
           

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your Category :");
            Console.ResetColor();

            string category = (age < 13) ? "  Child" :
                (age <= 17) ? "  Teen" :
                (age <= 59) ? "Adult" :
                "Senior";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(category);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
        }
    }
    
}
