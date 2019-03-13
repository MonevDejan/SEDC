using System;
using ATM_Functions;

namespace ATM
{
    //Task
    #region
    /*
        Create an ATM application. A customer should be able to authenticate with card number
        and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:

        Balance checking - This should print out the current balance of money on their account

        Cash withdrawal - This should try and withdraw cash from the users account and print a message.
        If it has enough it should print a success message that contains the money withdrawn and 
        the balance of money after the withdrawal

        Cash deposition - This should deposit cash on the account and give a message 
        with the new balance of money on the account after the deposit.

        In order for the ATM app to work we need Customers. 
        This ATM asks for the number( string ) of the card and searches through the customers if a card like that exists.
        After that it asks for a pin. 
        If the Pin matches that customer a welcome message is shown  and the customer can now choose the options.

        Example

        Welcome to the ATM app

        Please enter your card numer:

        > 1234-1234-1234-1234

        Enter Pin:

        > 4325

        Welcome Bob Bobsky!

        What would you like to do:

        Check Balance
        Cash Withdrawal
        Cash Deposit
        > 2

        You withdrew 250$. You have 400$ left on your account.

        Thank you for using the ATM app.

        Bonus: The balance and pin should not be public

        Bonus: The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.

        Bonus: When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action. 
        If not it should print a goodbye message and show up the login menu again.

        Bonus: Add an option to register a new card in the system that store the customer in the system if the card number is not used for any other customer
    */
    #endregion

    public class User
    {
        public string Username { get; set; }
        public long CardNumber { get; set; }
        private string Pin { get; set; }
        private double Balance;

        public User(string username, long cardNumber, string pin, double balance)
        {
            CardNumber = cardNumber;
            Username = username;
            Pin = pin;
            Balance = balance;
        }

        public void CashWithdraw(double sum)
        {
            Balance -= sum;
        }
        public void CashDeposit(double sum)
        {
            Balance += sum;
        }
        public double GetBalance()
        {
            return Balance;
        }

        public string GetPin()
        {
            return Pin;
        }

    }

    class Program
    {
        static void Main()
        {
           
            User[] userArray = new User[3];
            userArray[0] = new User("Dejan", 1234123412341234, "2365", 5033.2);
            userArray[1] = new User("Dime", 1234123412341234, "2365", 5033.2);
            userArray[2] = new User("Nikola", 1234123412341234, "2365", 5033.2);

            while (true)
            {
                Console.WriteLine("Please chose from the folowing options (1 or 2 or 3) ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                string chosenOption = Functions.CheckInput();

                switch (chosenOption)
                {
                    case "1":
                        User logedInUser = Functions.ValidateUser(userArray);
                        Console.WriteLine($"Welcome {logedInUser.Username}!");

                        bool RunProgram1 = true;

                        do
                        {
                            Console.WriteLine("What do you want to do?");
                            Functions.PrinOptions();
                            Functions.AvailabelOptios(logedInUser, ref userArray);
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Do you want another transaction? Y/N ");
                            RunProgram1 = Functions.RunAgain();
                        } while (RunProgram1);
                        Console.WriteLine("Thank you for using our app. Good bye! ");
                        break;

                    case "2":

                        bool RunProgram2 = true;

                        do
                        {
                            Console.Write("Please insert User name: ");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Please enter your card number in the folowing format (ex.: 1234-1234-1234-1234)");
                            long cardNumber = Functions.CardNumberForRegister(userArray);
                            Console.WriteLine("Inser your pin");
                            string userPin = Console.ReadLine();
                            Console.WriteLine("Please insert ballance:");
                            double userBalance = Functions.StringToDouble();

                            Array.Resize(ref userArray, userArray.Length + 1);
                            userArray[userArray.Length - 1] = new User(userName, cardNumber, userPin, userBalance);

                            Functions.PrintUsers(userArray);

                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Do you want another user registration? Y/N ");
                            RunProgram2 = Functions.RunAgain();

                        } while (RunProgram2);
                        Console.WriteLine("Thank you for using our app. Good bye! ");
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using our app. Good bye! ");
                        break;
                }
            }
        }
    }
}
