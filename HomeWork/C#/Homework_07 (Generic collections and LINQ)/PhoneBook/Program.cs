using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    // Task
    #region 
    /*
        Create a PhoneBook Dictionary with 5 names and phone numbers. 
        Through the console ask the person to enter a name.
        Try and find that names phone number in your PhoneBook
        If you can find it, print it in the console
        If you can’t, print an error message
    */
    #endregion

    class Program
    {
        static void Main()
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Dejan", 070111111 },
                {"Nikola", 070222222 },
                {"Dimitar", 070333333 },
                {"Marijan", 070444444 },
            };
            phoneBook.Add("Trajce", 070555555) ;
           
            Console.WriteLine("Please enter a name that you are searching in the phonebook");
            string input = Console.ReadLine();

           
            if (phoneBook.ContainsKey(input))
            {
                long value = phoneBook[input];
                Console.WriteLine("0"+value);
            }
            else
            {
                Console.WriteLine("The name is not existent");
            }
            Console.ReadLine();
        }
    }
}
