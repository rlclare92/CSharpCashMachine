﻿using System;

namespace cSharpCashMachine
{
    class Program
    {
        string userPin = "1234";
        string accountNumber = "123456789";
        string userInput;

        void checkPin()
        {
            // Checking user pin number is correct 
            Console.WriteLine("Please enter your pin: ");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            if(userInput == userPin){
                      Console.WriteLine("User Pin is correct");
                      checkAccountNumber();
             } else {
                Console.WriteLine("Please try again");
             }
        }

         void checkAccountNumber()
         {
             // Checking user account number is correct 
            //  START:
             Console.WriteLine("Please enter your account number");
             userInput = Console.ReadLine();
             Console.WriteLine(userInput);

            if(userInput == accountNumber){
                Console.WriteLine("User account number is correct");
                mainOptions(userInput);
            } else {
                Console.WriteLine("Please try again"); 
                // goto  START;
            }

         }
        void mainOptions(string OptionUserInput)
        {
            // Main Options Section- what options are avaible for the user to access.
            Console.WriteLine("Please select an option");
            OptionUserInput = Console.ReadLine();
            // Console.WriteLine(OptionUserInput);
        
            if (OptionUserInput == "1") 
            {
                checkBalance();
            }
            else if (OptionUserInput == "2")
            {
                Console.WriteLine("How much would you like to withdraw?");
                withdrawal();
             }
            else if (OptionUserInput == "3")
            {
                Console.WriteLine("How much would you like to deposit?");
                deposit();
            }
            else if (OptionUserInput == "4")
            {
                cancel();
            }
        }

    void checkBalance()
    {
        // Checking user bank balance
        // Console.ReadLine();
        string CurrentBankBalance = "100";
        string OptionUserInput = Console.ReadLine();
        Console.WriteLine("Your Bank Balance is £{0}", CurrentBankBalance);

        Console.WriteLine("Would you like to return to main options? Y/N");
            OptionUserInput = Console.ReadLine();
            if(OptionUserInput == "Y")
            {
               mainOptions(OptionUserInput);

            } else if (OptionUserInput == "N") {
                cancel();
            }
    } 

    void withdrawal()
        {
            // Withdrawal- Requiring withdrawal from users account 
            userInput = Console.ReadLine();
            string bankBalances = "100";
            string OptionUserInput = Console.ReadLine();

            int parsedNumberUserInput = int.Parse(userInput);
            int parsedNumberBankBalances = int.Parse(bankBalances);

            int NewBankBalance = (parsedNumberBankBalances -= parsedNumberUserInput);
            Console.WriteLine("Your New Balance is £{0}", NewBankBalance);

            Console.WriteLine("Would you like to return to main options? Y/N");
            OptionUserInput = Console.ReadLine();
            if(OptionUserInput == "Y")
            {
               mainOptions(OptionUserInput);

            } else if (OptionUserInput == "N") {
                cancel();
            }

        }
    
    void deposit()
   {    
            // Despositing- Despositing amount into the user account
            userInput = Console.ReadLine();
            string bankBalances = "100";
            string OptionUserInput = Console.ReadLine();

            int parsedNumberUserInput = int.Parse(userInput);
            int parsedNumberBankBalances = int.Parse(bankBalances);

            int NewBankBalance = (parsedNumberUserInput += parsedNumberBankBalances);
            Console.WriteLine("Your New  Balance is £{0}", NewBankBalance);

            Console.WriteLine("Would you like to return to main options? Y/N");
            OptionUserInput = Console.ReadLine();
            if(OptionUserInput == "Y")
            {
               mainOptions(OptionUserInput);

            } else if (OptionUserInput == "N") {
                cancel();
            }
        }
    void cancel()
    {
        // Cancel- ends program
       Console.WriteLine("Please remove your card");
    }


    static void Main(string[] args)
        {
            Program cashMachine = new Program();
                cashMachine.checkPin();
        }
    }
}
