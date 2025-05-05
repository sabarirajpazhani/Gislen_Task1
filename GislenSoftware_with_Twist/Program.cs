using System;

//Exercise: GislenSoftware with a Twist

//Print numbers from 1 to 100.

//For multiples of 3 print "Gislen", for 5 print "Software", for both print "Gislen Software".

//Add: For numbers divisible by 7, skip printing them altogether.


namespace Task1
{
    public class GislenSoftware_with_Twist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ GislenSoftware with a Twist ------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-----------------------------------------------------------------");
            int number = 100;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Gislen Software");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Gislen");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Software");
                }
                else if (i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}