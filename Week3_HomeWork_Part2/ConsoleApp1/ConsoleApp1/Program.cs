using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Program to Display the ATM Transaction
            //Here The types of ATM transaction are
            //    1) Balance checking
            //    2) Cash withdrawal
            //    3) Cash deposition.
            //You can opt any of the above transaction according to your need of transaction.

            int balance = 10000;           
            int pin;
            int option1 = 1;
            int option2 = 2;
            int option3 = 3;
            Console.WriteLine("Welcome! Please enter your pin:");
            pin = Convert.ToInt32(Console.ReadLine());
            bool add = true;
            while (add)
            {
                Console.WriteLine("Please choose which operation you want to perform (write the indicative number only):\n1. Balance checking?\n2. Cash withdrawal?\n3. Cash deposition?");
                int insert = Convert.ToInt32(Console.ReadLine());

                //Balance checking
                if (insert == option1)
                {
                    Console.WriteLine("Your current balance is {0} $.", balance);
                }

                // Cash withdrawal
                else if (insert == option2)
                {
                    Console.WriteLine("Please insert the amount of money you want to withdraw");                    
                    {
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (balance >= withdraw)
                        {
                           
                                Console.WriteLine("Please collect the {0} $ amount.", withdraw);
                                int current = balance - withdraw;
                                Console.WriteLine("The current balance is now {0} $.", current);                            
                        }
                        else if (balance < withdraw)
                            Console.WriteLine("Your account does not have sufficient balance (current amount is {0} $).", balance);
                    }
                   
                }

                // Cash deposition
                else if (insert == option3)
                {
                    Console.WriteLine("Enter the amount you want to deposite");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    int current = balance + deposite;
                    Console.WriteLine("The current balance in the account is of {0} $.", current);
                }                
                else
                {
                    Console.WriteLine("You've entered an invalid option. Please try again!");
                    break;
                }
                Console.WriteLine("Do you want to perform a new operation? y/n");
                if (Console.ReadLine() == "y")
                    add = true;
                    else break;                  
            }
                Console.ReadKey();
        }
        
    }
}
