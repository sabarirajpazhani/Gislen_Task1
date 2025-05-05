using System;

//Exercise: Calculator with Type Conversion
//Write a program that:

//Accepts two strings from the user.

//Tries to convert them into int or double.

//Performs addition, subtraction, multiplication, division using appropriate operators.

//Uses Convert and TryParse methods.



public class Calculator_with_Type_Conversion
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("------------------------- Calculator  -----------------------");
        Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
        Console.WriteLine("-------------------------------------------------------------");
        Console.ResetColor();

        Console.WriteLine("Choose the Operator to Perform Operation");
        Console.WriteLine(" '+' - Addition ");
        Console.WriteLine(" '-' - Subtration ");
        Console.WriteLine(" '*' - Multiplication ");
        Console.WriteLine(" '/' - Division");
        Console.WriteLine(" '%' - Modulus");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-------------------------------------------------------------");
        Console.ResetColor();

        Console.WriteLine("Enter the two Number for Calculation");

        bool flag = true;
        while (flag)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Number 1: ");
            Console.ResetColor();
            int num1 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Number 2: ");
            Console.ResetColor();
            int num2 = int.Parse(Console.ReadLine());

            double dNum1 = num1;
            double dNum2 = num2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the Operator : ");
            string operators = Console.ReadLine();
            Console.ResetColor();

            switch (operators)
            {
                case "+":
                    double result1 = dNum1 + dNum2;
                    Console.WriteLine($"Result : {num1} + {num2} = {result1}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("If you wnat to Perform Operation: (y/n)");
                    Console.ResetColor();

                    char ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'n')
                    {
                        Console.WriteLine("Thank You !!");
                        flag = false;
                    }
                    break;

                case "-":
                    double result2 = dNum1 - dNum2;
                    Console.WriteLine($"Result : {num1} -{num2} = {result2}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("If you wnat to Perform Operation: (y/n)");
                    Console.ResetColor();

                    char ch2 = char.Parse(Console.ReadLine());
                    if (ch2 == 'n')
                    {
                        Console.WriteLine("Thank You !!");
                        flag = false;
                    }
                    break;

                case "*":
                    double result3 = dNum1 * dNum2;
                    Console.WriteLine($"Result : {num1} *{num2} = {result3}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("If you wnat to Perform Operation: (y/n)");
                    Console.ResetColor();

                    char ch3 = char.Parse(Console.ReadLine());
                    if (ch3 == 'n')
                    {
                        Console.WriteLine("Thank You !!");
                        flag = false;
                    }
                    break;

                case "/":
                    double result4 = dNum1 / dNum2;
                    Console.WriteLine($"Result : {num1} /{num2} = {result4}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("If you wnat to Perform Operation: (y/n)");
                    Console.ResetColor();

                    char ch4 = char.Parse(Console.ReadLine());
                    if (ch4 == 'n')
                    {
                        Console.WriteLine("Thank You !!");
                        flag = false;
                    }
                    break;

                case "%":
                    double result5 = dNum1 % dNum2;
                    Console.WriteLine($"Result : {num1} %{num2} = {result5}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("If you wnat to Perform Operation: (y/n) :");
                    Console.ResetColor();

                    char ch5 = char.Parse(Console.ReadLine());
                    if (ch5 == 'n')
                    {
                        Console.WriteLine("Thank You !!");
                        flag = false;
                    }
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are Entered Worng Operator");
                    break;
            }
        }
    }
}
