using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
   
    class Program
    {
        public class User
        {
            public int MyProperty1 { get; set; }
 
            public User(int x)
            {
                MyProperty1 = x;
            }

            public string WriteMsg(string msg)
            {
                return msg + MyProperty1.ToString();
            }
        }

        static void Main(string[] args)
        {
            // Anonymous method
            Func<int, int, int> SumTwoNumber = delegate (int x, int y) { return x + y; };
            Console.WriteLine(SumTwoNumber(3, 4));

            // Lambda 
            Func<int, int, int[]> SumTwoNumber1 = (x, y) => 
            {
                int[] number = new int[1];
                number[0] = x + y;
                return number;
             };
            Console.WriteLine(SumTwoNumber1(3, 4));

           //Can have custom type
            Func<User, bool> Above18 = delegate (User user)
            {
                return user.MyProperty1 > 18;
            };

            User user1 = new User(14);
            User user2 = new User(19);
            Console.WriteLine(Above18(user1));
            Console.WriteLine(Above18(user2));

            // Func passes ref to a method
            Func<string, string> newString = user1.WriteMsg;
            string msg = "Hello Func";
            Console.WriteLine(newString(msg));
            

            Func<string, string> selector = str => str.ToUpper();
            string[] words = { "orange", "apple", "Article", "elephant" };
            IEnumerable<String> aWords = words.Select(selector);
            foreach (String word in aWords)
                Console.WriteLine(word);
            
            Console.ReadLine();
        }
    }
}
