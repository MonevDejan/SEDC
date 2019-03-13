using System;


namespace Users
{
         /*
            Create a class User with the following:

            Id - int
            Username - string
            Password - string
            Messages - Array of strings 
            
            Create an array of users and add 3 users to it manually ( hard-coded ).

            Create a Console UI that will ask the user:

            Log in - When selected the user should be asked for username and password. 
            If the user is found print welcome message and the messages that the user
            has in the Messages property: Welcome NAME. Here are your messages:
            Message1

            Message2

            If not found, it should print an error message

            Register - When selected the user should be asked to enter ID, Username and password. 
            It should then check if a there is already a username in the array of users like that. 
            If there is, print a message that there is already a user called like that. 
            If not, create a new user object from the information given in the console and add it to the Users array. 
            Then print all the users by Id and Username Registration complete! Users:

            23 Username1

            44 Username2

            1 Username3

            56 Username4

         */
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = new string[] { "Empty message1", "Empty message2" };
        }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }
    }

    class Program
    {
        public static void LogIn(User[] listOfUsers)
        {
            Console.WriteLine("Please insert username");
            string inputUser = Console.ReadLine();
            Console.WriteLine("Please insert password");
            string inputPassword = Console.ReadLine();

            bool foundUser = false;
            foreach (User person in listOfUsers)
            {
                if ((person.Username == inputUser) && (person.Password == inputPassword))
                {
                    Console.WriteLine($"Hello {person.Username}. Here are your messages");
                    foreach (string messages in person.Messages)
                    {
                        Console.WriteLine(messages);
                    }
                    foundUser = true;
                }
            }
            if (!foundUser)
            {
                Console.WriteLine("User not found");
            }

        }

        public static string CheckInput()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2"))
            {
                Console.WriteLine("Please chose options from 1 or 2");
                input = CheckInput();
            }
            return input;
        }

        public static void RegisterUser(ref User[] listOfUsers)
        {
            bool foundUser = false;

            Console.WriteLine("Please insert username");
            string registerName = Console.ReadLine();
            Console.WriteLine("Please insert password");
            string registerPassword = Console.ReadLine();

            foreach (User person in listOfUsers)
            {
                if ((person.Username == registerName))
                {
                    Console.WriteLine($"The username {registerName} is already exist!");
                    //Console.WriteLine("Please insert new username");
                    foundUser = true;
                    break;
                }
            }

            if (!foundUser)
            {
                Array.Resize(ref listOfUsers, (listOfUsers.Length + 1));
                listOfUsers[listOfUsers.Length - 1] = new User(listOfUsers.Length, registerName, registerPassword);
                Console.WriteLine("Registration is coplete!");
                Console.WriteLine("Here are the all users");

                foreach (User person in listOfUsers)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Username}");
                }
            }
        }

        public static bool RunAgain()
        {
            bool check;
            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                check = true;
            }
            else if (input == "N" || input == "n")
            {
                check = false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                check = RunAgain();
            }
            return check;
        }
        static void Main()
        {
            bool RunProgram = true;

            string[] messages = { "Message 1", "Message 2" };
            User[] userArray = new User[3];
            userArray[0] = new User(1, "Dejan", "qwer", messages);
            userArray[1] = new User(2, "Dime", "1234", messages);
            userArray[2] = new User(3, "Nikola", "asdf", messages);

            do
            {
                Console.WriteLine("Please chose from the folowing options (1 or 2) ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");

                string inputChose = CheckInput();

                if (inputChose == "1")
                {
                    LogIn(userArray);
                }
                else if (inputChose == "2")
                {
                    RegisterUser(ref userArray);
                }

                Console.WriteLine("_________________________________");
                Console.WriteLine("Do you want to chek another number Y/N ");
                RunProgram = RunAgain();

            } while (RunProgram);
        }
    }
}
