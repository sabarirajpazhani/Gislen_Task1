using System;
using System.Collections;

//Exercise: Student Marks Report(No Classes)

//Read student name and marks in 5 subjects.

//Calculate total and average.

//Use if-else to assign grade:

//A(avg >= 90)

//B(avg >= 75)

//C(avg >= 60)

//F(else)

//Repeat for multiple students in a loop. Option to stop via user input.


namespace Student_Marks_Report
{
    public class Subjects
    {
        public int english { get; set; }
        public int tamil { get; set; }
        public int maths { get; set; }
        public int computerScience { get; set; }
        public int chemistry { get; set; }

    }
    public class Program
    {
        public static char studGrade(int avg)
        {
            if (avg >= 90)
            {
                return 'A';
            }
            else if (avg >= 75)
            {
                return 'B';
            }
            else if (avg >= 60)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================== Students Marks Report ==================");
            Console.WriteLine("||                           ||                           ||");
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter the Students Details Here...");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Hashtable students = new Hashtable();

                Subjects sub = new Subjects();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Student Name : ");
                Console.ResetColor();
                string studName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("---------- Enter the Mark  ----------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the 'English' Mark : ");
                Console.ResetColor();
                sub.english = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the 'Tamil' Mark : ");
                Console.ResetColor();
                sub.tamil = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the 'Maths' Mark : ");
                Console.ResetColor();
                sub.maths = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the 'Computer Science' Mark : ");
                Console.ResetColor();
                sub.computerScience = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the 'Chemistry' Mark : ");
                Console.ResetColor();
                sub.chemistry = int.Parse(Console.ReadLine());

                students.Add(studName, sub);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("============================================================");
                Console.ResetColor();

                Subjects marks = (Subjects)students[studName];

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("    *-------*       Your Progress Report     *--------*     ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Student Name :  ");
                Console.ResetColor();
                Console.WriteLine(studName);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    Subject                                Mark              ");
                Console.ResetColor();
                Console.WriteLine($"    English                                {marks.english}  ");
                Console.WriteLine($"    Tamil                                  {marks.tamil}    ");
                Console.WriteLine($"    Maths                                  {marks.maths}    ");
                Console.WriteLine($"    Computer Science                       {marks.computerScience}  ");
                Console.WriteLine($"    Chemistry                              {marks.chemistry}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();


                int totalMark = marks.english + marks.tamil + marks.maths + marks.computerScience + marks.chemistry;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Total Mark : ");
                Console.ResetColor();
                Console.WriteLine(totalMark);


                int average = totalMark / 5;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Average : ");
                Console.ResetColor();
                Console.WriteLine(average);

                char grade = studGrade(average);

                if (grade == 'F')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry :(");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Grade : ");
                    Console.ResetColor();
                    Console.WriteLine(grade);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Congradulation :) ");
                    Console.ResetColor();


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Grade : ");
                    Console.ResetColor();
                    Console.WriteLine(grade);
                }
                Console.WriteLine("------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("If you want to Continue Press 'Y' otherwise Press 'N'  (Y/N) ");
                Console.ResetColor();



                char ch = char.Parse(Console.ReadLine());

                if (ch == 'Y')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Okay...... Thank You !!!! ");
                    Console.ResetColor();
                }
            }








        }
    }
}