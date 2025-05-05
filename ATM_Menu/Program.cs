using System;
using System.Collections;
using System.Security.Principal;

//Exercise: ATM Menu(Switch +If - Else)
//Write a program with a loop that:

//Displays options: Check Balance, Deposit, Withdraw, Exit.

//Uses switch to handle menu choices.

//Uses if-else for validation like minimum balance check.

//Maintains the balance using a variable.

namespace ATM_Menu
{
    public class BankDetails
    {
        public int AC_Num { get; set; }
        public string name { get; set; }

        public long PhoneNumber { get; set; }

        public DateOnly BOD { get; set; }

        public string Gender { get; set; }

        public string PAN { get; set; }

        public string AccountType { get; set; }

        public int balance { get; set; }
    }

    public class Program 
    {
        public static void checkBalance(int acNum, Hashtable bank)
        {

            int balance = 0;
            if (bank.Contains(acNum))
            {
                foreach (DictionaryEntry i in bank)
                {
                    BankDetails details = (BankDetails)i.Value;

                    if (i.Key.Equals(acNum))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------- Bank Balance ---------------------");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Account Holder Name  : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(details.name);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Your Account Type   : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(details.AccountType);
                        Console.ResetColor();

                        balance = details.balance;
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Your Account Number  : ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(acNum);
                Console.ResetColor();

               

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Your Account Balance : ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(balance);
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account Not Found :(");
                Console.ResetColor();
            }
        }

        public static void moneyDeposit(int acNum, int dMoney, Hashtable bank)
        {
            if (bank.Contains(acNum))
            {

                BankDetails details = (BankDetails)bank[acNum];
                details.balance += dMoney;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("||     ~~~~~~    Bill for the Money Deposit     ~~~~~~    ||");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();

                Console.WriteLine("Account Number      : " + details.AC_Num);
                Console.WriteLine("Account Holder Name : " + details.name);
                Console.WriteLine("Account Type        : " + details.AccountType);
                Console.WriteLine("Balance             : " + details.balance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You'r amount was Successfully Deposited :)");
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account Not Found :(");
                Console.ResetColor();
            }
        }

        public static void moneyWithdraw(int acNum, int money, Hashtable bank)
        {

            BankDetails details = (BankDetails)bank[acNum];

            if (details.balance >= money)
            {
                details.balance -= money;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("||     ~~~~~~    Bill for the Money withdraw     ~~~~~~    ||");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();

                Console.WriteLine("Account Number      : " + details.AC_Num);
                Console.WriteLine("Account Holder Name : " + details.name);
                Console.WriteLine("Account Type        : " + details.AccountType);
                Console.WriteLine("Balance             : " + details.balance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You'r amount was Successfully Withdraw :)");
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insuffient Bank Balance :(");
                Console.ResetColor();
            }

        }


        public static bool isValidPin(int acNum, int pin, Hashtable pinNumber)
        {
            bool flag = false;

            if (pinNumber.Contains(acNum))
            {
                if ((int)pinNumber[acNum] == pin)
                {
                    flag = true;
                }
            }
            
            return flag;
        }

        public static int isValidAC(Hashtable bank)
        {
            acNumber = 0;
            Account:
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Account Number A/C: ");
                Console.ResetColor();
                int ac = int.Parse(Console.ReadLine());

                if (!bank.ContainsKey(ac))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Account Not Found :(");
                    Console.ResetColor();
                    goto Account;
                }

                acNumber = ac;
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the Account number using digits only — no alphabets, whitespace, or special symbols.");
                Console.ResetColor();
                goto Account;
            }

            return acNumber;
        }

        static int acNumber = 3267;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================= ATM Menu =========================");
            Console.WriteLine("||                           ||                           ||");
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("                    Choose the Operations                   ");
            Console.WriteLine("                    1. Check Balance                        ");
            Console.WriteLine("                    2. Deposit                              ");
            Console.WriteLine("                    3. Withdraw                             ");
            Console.WriteLine("                    4. Change Pin                           ");
            Console.WriteLine("                    5. Exist                                ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Hashtable bank = new Hashtable()
            {
                {2041, new BankDetails
                    {
                        AC_Num = 2041,
                        name = "Thamizh",
                        PhoneNumber = 9876543210,
                        BOD = new DateOnly(1998, 4, 15),
                        Gender = "Male",
                        PAN = "ABCDE1234F",
                        AccountType = "Savings",
                        balance = 60000
                    }
                },

                {2065, new BankDetails
                    {
                        AC_Num = 2065,
                        name = "Sharmila",
                        PhoneNumber = 9123456789,
                        BOD = new DateOnly(1995, 12, 5),
                        Gender = "Female",
                        PAN = "FGHIJ5678K",
                        AccountType = "Current",
                        balance = 70000
                    }
                 },

                {4034, new BankDetails
                    {
                        AC_Num = 4034,
                        name = "Subha",
                        PhoneNumber = 9876512345,
                        BOD = new DateOnly(2000, 7, 22),
                        Gender = "Female",
                        PAN = "LMNOP9101Q",
                        AccountType = "Savings",
                        balance = 90000
                    }
                },

                {5621, new BankDetails
                    {
                        AC_Num = 5621,
                        name = "Sabari",
                        PhoneNumber = 7890123456,
                        BOD = new DateOnly(1999, 11, 3),
                        Gender = "Male",
                        PAN = "QRSTU2345V",
                        AccountType = "Savings",
                        balance = 50000
                    }
                }
            };

            Hashtable pinNumber = new Hashtable()
            {
                {2041, 996565},
                {2065, 123456},
                {4034, 654321},
                {5621, 098765}
            };

            

            while (true)
            {
                int choice = 0;
                int pin = 0;
                
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

                int acNum = 0;
                switch (choice)
                {
                    
                    case 1:

                        Main:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("            You Enter 1 for Check the Bank Balance          ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();

                        Account:
                        acNum = isValidAC(bank);


                        Balance:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your 6 Digit Pin Number: ");
                            Console.ResetColor();
                            //Console.BackgroundColor = ConsoleColor.Yellow;
                            pin = int.Parse(Console.ReadLine());
                            Console.ResetColor();

                            if (isValidPin(acNum, pin, pinNumber))
                            {
                                checkBalance(acNum, bank);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Pin :(");
                                Console.ResetColor();
                                goto Balance;
                            }
                        }
                        catch(FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter the Pin Properly...");
                            Console.ResetColor();
                            goto Account;
                        }

                        pin = 0;
                        acNum = 0;  
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("          You Enter 2 for Deposit the Money in Bank         ");
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();


                        Amount1:
                        acNum = isValidAC(bank);

                        Pin1:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your 6 Digit Pin Number: ");
                            Console.ResetColor();
                            //Console.BackgroundColor = ConsoleColor.Yellow;
                            pin = int.Parse(Console.ReadLine());
                            Console.ResetColor();

                            if (isValidPin(acNum, pin, pinNumber))
                            {
                                Deposite:
                                try
                                {
                                    Console.Write("Enter the Amount for Deposit : ");
                                    int dMoney = int.Parse(Console.ReadLine());
                                    if(dMoney < 500)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Deposite Amount should be atleast Rs.500");
                                        Console.ResetColor();
                                        goto Amount1;
                                    }
                                    moneyDeposit(acNum, dMoney, bank);
                                }
                                catch (FormatException e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter the Amount to be deposite using digits only — no alphabets, whitespace, or special symbols.");
                                    Console.ResetColor();
                                    goto Deposite;
                                }
                               
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Pin :(");
                                Console.ResetColor();
                                goto Pin1;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter the Pin Properly...");
                            Console.ResetColor();
                            goto Pin1;
                        }

                        pin = 0;
                        acNum = 0;
                        break;

                    case 3:

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("          You Enter 3 for Withdraw the Money from Bank"      );
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();

                        Amount2:
                        acNum = isValidAC(bank);

                        Pin2:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your 6 Digit Pin Number: ");
                            Console.ResetColor();
                            //Console.BackgroundColor = ConsoleColor.Yellow;
                            pin = int.Parse(Console.ReadLine());
                            Console.ResetColor();

                            if (isValidPin(acNum, pin, pinNumber))
                            {
                                Withdraw:
                                try
                                {
                                    Console.Write("Enter the Amount for Widthdraw : ");
                                    int WMoney = int.Parse(Console.ReadLine());
                                    if (WMoney < 500)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Withdraw Amount should be atleast Rs.500");
                                        Console.ResetColor();
                                        goto Amount2;
                                    }
                                    moneyWithdraw(acNum, WMoney, bank);
                                }
                                catch (FormatException e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter the Amount to be deposite using digits only — no alphabets, whitespace, or special symbols.");
                                    Console.ResetColor();
                                    goto Withdraw;
                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Pin :(");
                                Console.ResetColor();
                                goto Pin2;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter the Pin Properly...");
                            Console.ResetColor();
                            goto Pin2;
                        }

                        pin = 0;
                        acNum = 0;

                        break;

                    case 4:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                You Enter 4 to Change the Pin               ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();

                        acNum = isValidAC(bank);

                        Pin3:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your Current 6 Digit Pin Number: ");
                            Console.ResetColor();
                            //Console.BackgroundColor = ConsoleColor.Yellow;
                            pin = int.Parse(Console.ReadLine());
                            Console.ResetColor();

                            if (isValidPin(acNum, pin, pinNumber))
                            {
                                PinChaange:
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Enter the New Pin               : ");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    int newPin = int.Parse(Console.ReadLine()); 
                                    Console.ResetColor();



                                    Confirm:
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Enter the Confirmation Pin      : ");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    int ConPin = int.Parse(Console.ReadLine());
                                    Console.ResetColor();
                                    if(newPin != ConPin)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Enter the correct confirmation PIN as you provided in the new PIN");
                                        Console.ResetColor();
                                        goto Confirm;
                                    }
                                    else
                                    {
                                        pinNumber[acNum] = ConPin;

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Successfully PIN changed.. :)");
                                        Console.ResetColor();
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter the Pin Number using digits only — no alphabets, whitespace, or special symbols.");
                                    Console.ResetColor();
                                    goto PinChaange;
                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Pin :(");
                                Console.ResetColor();
                                goto Pin3;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter the Pin Properly...");
                            Console.ResetColor();
                            goto Pin2;
                        }
                        pin = 0;
                        acNum = 0;

                        break;

                    case 5:
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

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please make a correct choice. :(");
                        Console.ResetColor();
                        break;
                }
                if (choice == 5)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("                      ~ * Thank You * ~                    ");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}