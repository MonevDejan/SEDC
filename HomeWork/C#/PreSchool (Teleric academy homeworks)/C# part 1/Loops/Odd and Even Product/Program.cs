using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers N=");
            int N = int.Parse(Console.ReadLine());

            if (4 <= N && N <= 50)
            {
                Console.WriteLine("Please enter the array");
                string line = Console.ReadLine();
                string [] masiv = new string[N + 1];
                masiv[0] = "0";
                masiv[1] ="";
                int counter = 1;              
                int odd = 1;
                int even = 1;
                int[] arrayint = new int[N+1];
                arrayint[0] = 0;

                foreach (char element in line)
                {
                    if (element != ' ')
                    {
                        masiv[counter] = masiv[counter] + element;
                    }
                    else
                    {
                        counter++;
                        continue;
                    }
                }
                for (int i = 1; i <= N; i++)                
                {
                    int.TryParse(masiv[i], out arrayint[i]);                  
                    if ((i & 1) == 1)
                    {
                        checked
                        {
                        odd *= arrayint[i]; 
                        }
                    }
                    else
                    {
                        checked
                        {
                        even *= arrayint[i];
                        }
                    }
                }
                
                Console.WriteLine( odd == even ? "yes {0}" : "No {1} {2}", odd, odd, even);
            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }
        }
    }
}
