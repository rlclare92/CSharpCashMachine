using System;

namespace cSharpCashMachine
{
    class Program
    {
        string userPin = "1234";
        string accountNumber = "123456789";
        string userInput;
        string bankBalance = "100";

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
        void mainOptions(string userInput)
        {
            Console.WriteLine("Please select an option");
            Console.ReadLine();
            if (userInput == "1") 
            {
                checkBalance();
            }
            else if (userInput == "2")
            {
                withdrawl(userInput, bankBalance);
             }
            else if (userInput == "3")
            {
                deposit(userInput, bankBalance);
            }
            else if (userInput == "4")
            {
                cancel();
            }
        }

    void checkBalance()
    {
        Console.ReadLine();
        string CurrentBankBalance = "100";
        Console.WriteLine("Your Bank Balance is {0}", CurrentBankBalance);
    } 

    void withdrawl(string bankBalances, string userInputs)
        {

            Console.ReadLine();
            int parsedNumberUserInput = int.Parse(userInputs);
            int parsedNumberBankBalances = int.Parse(bankBalances);

            Console.WriteLine(parsedNumberBankBalances -= parsedNumberUserInput);
            Console.WriteLine("Your New  Balance is {0}", bankBalances);

        }
    
    void deposit(string userInput, string bankBalance)
    {

            Console.ReadLine();
            int parsedNumberUserInput = int.Parse(userInput);
            int parsedNumberBankBalances = int.Parse(bankBalance);
            Console.WriteLine(parsedNumberBankBalances += parsedNumberUserInput);
            userInput += bankBalance;
            Console.WriteLine("Your New balance is {0}", bankBalance);
     }          

    void cancel()
    {
       Console.WriteLine("Please remove your card");
    }


    static void Main(string[] args)
        {
            Program cashMachine = new Program();
                cashMachine.checkPin();
        }
    }
}
