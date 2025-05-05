using System;
using System.Collections;
using System.ComponentModel;

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

    public class TeachersAuth
    {
        public int TeacherId { get; set; }  
        public string TeacherName { get; set; }
        public string TeacherPassword { get; set; } 
    }
    public class Program
    {
        public static void viewStudRecord(int studId, Hashtable StudentsMarks, Hashtable StudentIDs)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================================================");
            Console.ResetColor();

            Subjects marks = (Subjects)StudentsMarks[studId];


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("    *-------*       Your Progress Report     *--------*     ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Student Name :  ");
            Console.ResetColor();
            Console.WriteLine(StudentIDs[studId]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------");
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
            Console.WriteLine("------------------------------------------------------------------------");
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
            Console.WriteLine("------------------------------------------------------------------------");
        }
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

        static int studId = 105;
        static void Main(string[] args)
        {
            Hashtable StudentIDs = new Hashtable()
            {
                {101, "Sabari"},
                {102, "Raj" },
                {103, "Hari" },
                {104, "Kumar"},
                {105, "Imran"}
            };

            Hashtable StudentsMarks = new Hashtable()
            {
                {
                    101,
                    new Subjects
                    {
                        english = 85,
                        tamil = 78,
                        maths = 92,
                        computerScience = 88,
                        chemistry = 79
                    }
                },
                {
                    102,
                    new Subjects
                    {
                        english = 90,
                        tamil = 82,
                        maths = 95,
                        computerScience = 91,
                        chemistry = 85
                    }
                },
                {
                    103,
                    new Subjects
                    {
                        english = 76,
                        tamil = 80,
                        maths = 84,
                        computerScience = 87,
                        chemistry = 73
                    }
                },
                {
                    104,
                    new Subjects
                    {
                        english = 88,
                        tamil = 85,
                        maths = 90,
                        computerScience = 89,
                        chemistry = 82
                    }
                },
                {
                    105,
                    new Subjects
                    {
                        english = 92,
                        tamil = 89,
                        maths = 96,
                        computerScience = 94,
                        chemistry = 90
                    }
                }
            };

            Hashtable teacherDetails = new Hashtable()
            {
                { 1001, new TeachersAuth { TeacherId = 1001, TeacherName = "Harikumar", TeacherPassword = "996565" } },
                { 1002, new TeachersAuth { TeacherId = 1002, TeacherName = "Sabari", TeacherPassword = "123456" } },
                { 1003, new TeachersAuth { TeacherId = 1003, TeacherName = "Lakshmi", TeacherPassword = "789123" } },
                { 1004, new TeachersAuth { TeacherId = 1004, TeacherName = "Prakash", TeacherPassword = "456321" } },
                { 1005, new TeachersAuth { TeacherId = 1005, TeacherName = "Nandhini", TeacherPassword = "654789" } },
            };
            Main:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================= Students Marks Report ========================");
            Console.WriteLine("||                                 ||                                 ||");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                      Select the Choice                                 ");
            Console.ResetColor();
            Console.WriteLine("               1. Add student marks and display the total, average, and grade.");
            Console.WriteLine("               2. View Particular Students Mark list (Only Teacher)     ");
            Console.WriteLine("               3. Exit                                                  ");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter the Students Details Here...");
            Console.ResetColor();

            //bool flag = true;
            while (true)
            {
                int choice = 0;
                Choice:
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter the Choice : ");
                    Console.ResetColor();
                    int Choice = int.Parse(Console.ReadLine());
                    choice = Choice;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter the Choice Correctly as Given in the Header");
                    Console.ResetColor();
                    goto Choice;
                }


                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("      Add student marks and display the total, average, and grade.      ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        Name:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the Student Name                : ");
                        Console.ResetColor();
                        string stuName = Console.ReadLine();

                        if(stuName.Length < 4)
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Please Enter the Student Name in above 3 Character");
                            Console.ResetColor();
                            goto Name;
                        }

                        studId++;

                        StudentIDs.Add(studId, stuName);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{stuName} 's ID                      : ");
                        Console.ResetColor();
                        Console.WriteLine(studId);

                        Subjects sub = new Subjects();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("---------------------------- Enter the Mark  ---------------------------");
                        Console.ResetColor();

                        English:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the 'English' Mark              : ");
                        Console.ResetColor();
                        int english = int.Parse(Console.ReadLine());
                        if(english > 100)
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("Maximum Mark is 100");
                            Console.ResetColor();
                            goto English;
                        }
                        sub.english = english;

                        Tamil:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the 'Tamil' Mark                : ");
                        Console.ResetColor();
                        int tamil = int.Parse(Console.ReadLine());
                        if (tamil > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maximum Mark is 100");
                            Console.ResetColor();
                            goto Tamil;
                        }
                        sub.tamil = tamil;

                        Maths:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the 'Maths' Mark                : ");
                        Console.ResetColor();
                        int maths = int.Parse(Console.ReadLine());
                        if (maths > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maximum Mark is 100");
                            Console.ResetColor();
                            goto Maths;
                        }

                        sub.maths = maths;

                        Computer:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the 'Computer Science' Mark     : ");
                        Console.ResetColor();
                        int computer = int.Parse(Console.ReadLine());
                        if (computer > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maximum Mark is 100");
                            Console.ResetColor();
                            goto Computer;
                        }
                        sub.computerScience = computer;

                        Chemistry:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter the 'Chemistry' Mark            : ");
                        Console.ResetColor();
                        int chemistry = int.Parse(Console.ReadLine());
                        if (chemistry > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maximum Mark is 100");
                            Console.ResetColor();
                            goto Chemistry;
                        }
                        sub.chemistry = chemistry;

                        StudentsMarks.Add(studId, sub);

                        viewStudRecord(studId, StudentsMarks, StudentIDs);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("If you want to Continue Press 'Y' otherwise Press 'N'  (Y/N) ");
                        Console.ResetColor();



                        char ch = char.Parse(Console.ReadLine());

                        if (ch == 'Y' || ch == 'y')
                        {
                            goto Name;
                        }
                        else
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Okay...... Thank You !!!! ");
                            Console.ResetColor();
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        goto Main;
                        //break;

                    case 2:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("            View Particular Students Mark list (Only Teacher)          ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();


                        TeachersAuth:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter the Teacher ID             : ");
                            Console.ResetColor();
                            int teachId = int.Parse(Console.ReadLine());


                            if (!teacherDetails.ContainsKey(teachId))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Teacher ID not Found");
                                Console.ResetColor();
                                goto TeachersAuth;
                            }
                            else
                            {
                                Subjects marks = (Subjects)StudentsMarks[studId];

                                TeachersAuth teacher = (TeachersAuth)teacherDetails[teachId];

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Enter the Teacher Name           : ");
                                Console.ResetColor();
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine(teacher.TeacherName);
                                Console.ResetColor();

                                Password:
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Enter the Teacher Password       : ");
                                    Console.ResetColor();
                                    string teachPass = Console.ReadLine();

                                    if(teacher.TeacherPassword != teachPass)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Incorrect Teacher Password");
                                        Console.ResetColor();
                                        goto Password;

                                    }
                                    StudId:
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("Enter the Student ID to View the Record :");
                                    Console.ResetColor();

                                    int studId = int.Parse(Console.ReadLine());

                                    if(studId < 101)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("There is no Student ID bellow 100");
                                        Console.ResetColor();
                                        goto StudId;

                                    }
                                    if(!StudentIDs.Contains(studId))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Student ID not Found");
                                        Console.ResetColor();
                                        goto StudId;
                                    }

                                    viewStudRecord(studId, StudentsMarks, StudentIDs);

                                }
                                catch (FormatException e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter in digits only \nalphabets, whitespace, and special symbols are not allowed.");
                                    Console.ResetColor();
                                    goto Password;
                                }

                            }
                        }
                        catch(FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter the Teacher ID Properly...");
                            Console.ResetColor();
                            goto TeachersAuth;
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("If you want to Continue Press 'Y' otherwise Press 'N'  (Y/N) ");
                        Console.ResetColor();



                        char ch1 = char.Parse(Console.ReadLine());

                        if (ch1 == 'Y' || ch1 == 'y')
                        {
                            goto TeachersAuth;
                        }
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Okay...... Thank You !!!! ");
                            Console.ResetColor();
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        goto Main;
                    //break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                     You Choose to Exist :)                  ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();

                        for (int i = 5; i > 0; i--)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("                 Existing From Grocery: ");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($" {i} ");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                        }

                        break;
                }
                if (choice == 3)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("                      ~ * Thank You * ~                    ");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}
