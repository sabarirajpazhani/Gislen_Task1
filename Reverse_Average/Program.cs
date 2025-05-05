using System;

//Exercise: Reverse & Average

//Read 5 numbers into an array.

//Reverse the array using a loop and print it.

//Calculate and print the average of the numbers.


namespace Task_1
{
    public class Reverse_Average
    {
        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine("Enter the Give Integer Array Element : ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            Console.WriteLine("Reverse of Array");
            for (int i = n - 1; i >= 0; i--)
            {
                total += arr[i];
                Console.Write(arr[i] + " ");
            }

            //int ii = 0;                        //Another methods
            //int j = arr.Length-1;
            //while (ii < j)
            //{
            //    arr[ii] ^= arr[j];
            //    arr[j] ^= arr[ii];
            //    arr[ii] ^= arr[j];

            //    ii++;
            //    j--;
            //}

            foreach (int num in arr)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            Console.Write("Average: ");
            Console.WriteLine(total / n);
        }
    }
}

