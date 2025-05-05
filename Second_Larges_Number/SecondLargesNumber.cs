using System;

public class Task_1
{
    public class SecondLargesNumber
    {
        //Exercise: Find Second Largest Number

        //Read 10 integers from the user into an array.

        //Loop through the array to find and print the second largest unique number.

        //Do not use built -in sorting methods.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||     ||");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();

            int[] arr = new int[10];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the 10 Array Elements: ");
            Console.ResetColor();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());          //Reading an integer input from the user and storing it in the array arr
            }

            int max = arr[0];  //First largest number
            int secondMax = 0; //Second largest number

            foreach (int i in arr)
            {
                int currentmax = max;
                if (i > max)           //"Compare the current element with the maximum; if it is larger, it becomes the new maximum.
                {
                    max = i;
                    secondMax = currentmax;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Second Lasted Number in the Array is " + secondMax);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.ResetColor();
        }
    }
}
