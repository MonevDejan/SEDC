using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            Console.WriteLine("please enter sign of a card");
            string n = Console.ReadLine();
            switch (n)
            {
                case "2":
                    {
                        for (int i = 2; i <= 2; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i,(char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "3":
                    {
                        for (int i = 2; i <= 3; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "4":
                    {
                        for (int i = 2; i <= 4; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "5":
                    {
                        for (int i = 2; i <= 5; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "6":
                    {
                        for (int i = 2; i <= 6; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "7":
                    {
                        for (int i = 2; i <= 7; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "8":
                    {
                        for (int i = 2; i <= 8; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "9":
                    {
                        for (int i = 2; i <= 9; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "10":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        break;
                    }
                case "J":
                case "j":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0}{1}, {0}{2}, {0}{3}, {0}{4}", i, (char)6, (char)5, (char)4, (char)3);
                        }
                        Console.WriteLine("J{0}, J{1}, J{2}, J{3}", (char)6, (char)5, (char)4, (char)3);
                        break;
                    }
                case "Q":
                case "q":
                        {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
                        }
                            Console.WriteLine("J{0}, J{1}, J{2}, J{3}", (char)6, (char)5, (char)4, (char)3);
                            Console.WriteLine("Q{0}, Q{1}, Q{2}, Q{3}", (char)6, (char)5, (char)4, (char)3);
                            break;
                    }
                case "K":
                    case "k":
                        {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
                        }
                            Console.WriteLine("J{0}, J{1}, J{2}, J{3}", (char)6, (char)5, (char)4, (char)3);
                            Console.WriteLine("Q{0}, Q{1}, Q{2}, Q{3}", (char)6, (char)5, (char)4, (char)3);
                            Console.WriteLine("K{0}, K{1}, K{2}, K{3}", (char)6, (char)5, (char)4, (char)3);
                            break;
                    }
                case "A":
                    case "a":
                        {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
                        }
                        Console.WriteLine("J{0}, J{1}, J{2}, J{3}", (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine("Q{0}, Q{1}, Q{2}, Q{3}", (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine("K{0}, K{1}, K{2}, K{3}", (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine("A{0}, A{1}, A{2}, A{3}", (char)6, (char)5, (char)4, (char)3);
                        break;
                    }
                default: Console.WriteLine("{0} isn't in a card deck", n); break;
            }
            }
        }
    }
}
