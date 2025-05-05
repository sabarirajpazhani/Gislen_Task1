using System;

//Exercise: Safe Number Collector

//Continuously read inputs from the user.

//Try to convert each to an int. If successful, add to an array.

//Stop when the user types "exit".

//Display all valid integers collected.

namespace Task_1
{
    public class Safe_Number_Collector
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------- Safe Number Collector -------------------");
            Console.WriteLine("||  ~  ||    ||    ||    ||   ~   ||    ||    ||     || ~  ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("           Enter 'exit' for Stoping the Iteration            ");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("              Safe Number Colleter is Started                ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Elements Here");
            Console.ResetColor();

            List<int> l = new List<int>();                                   //List to store the Element

            while (true)
            {

                string input = Console.ReadLine();                           //Reading the input from the user

                if (input == "exit")
                {
                    break;
                }

                bool success = int.TryParse(input, out int number);          // It tries to check whether the entered number is an integer. If it is, the number is stored in the list l.
                if (success)
                {
                    l.Add(number);                                           // adding int element in list
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Displaying the valid Integers Collections");
            Console.ResetColor();


            foreach (int i in l)                        //Displaying only the int data type elements
            {
                Console.Write(i + " ");
            }
        }
    }
}
