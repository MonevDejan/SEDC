using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_as_array
{
    class Program
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        // Write a program that reads two arrays representing positive integers and outputs their sum.
        static int[] StringToArray(string s, int N)
        {
            bool sign = true;
            int value = 0;
            int counter = 0;
            int[] array = new int[N];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    array[counter] = value;
                    counter++;
                    value = 0;
                    sign = true;
                }
                else
                {
                    if ((s[i] == '-'))
                    {
                        sign = false;
                        continue;
                    }
                    if (sign)
                    {
                        value = value * 10 + (s[i] - 48);
                    }
                    else
                    {
                        value = value * 10 + (s[i] - 48) * (-1);
                    }
                    if (i == s.Length - 1)
                    {
                        array[counter] = value;
                    }
                }
            }
            return array;
        }
        static int[] StringToArrayOfDigit(string s, int N)
        {
            int counter = 0;
            int[] array = new int[N];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                else
                {
                    array[counter] = s[i]-'0';
                    counter++;
                }
            }
            return array;
        }
        static int SumOfDigit(int m, int n)
        {
            int sum = n + m;
            return sum;
        }
        static void Main()
        {
            Console.WriteLine("Please enter the the lenght of the two arrays array");
            string lenght = Console.ReadLine();

            Console.WriteLine("PLease enter the numbers for the first array");
            string input1 = Console.ReadLine();

            Console.WriteLine("PLease enter the numbers for the second array");
            string input2 = Console.ReadLine();


            int lenght1 = StringToArray(lenght, 2)[0];
            int lenght2 = StringToArray(lenght, 2)[1];
            int min;
            int max;
            if (lenght1 <= lenght2)
            {
                min = lenght1;
                max = lenght2;
            }
            else
            {
                min = lenght2;
                max = lenght1;
            }
            
            int[] array1 = StringToArrayOfDigit(input1, lenght1);
            int[] array2 = StringToArrayOfDigit(input2, lenght2);
            int[] array3 = new int[max - min];

            for (int i = 0; i < max - min; i++)
            {
                if (min == max)
                {
                    break;
                }
                if (lenght1>lenght2)
                {
                    array3[i] = array1[i + min];
                }
                else
                {
                    array3[i] = array2[i + min];
                }
            }

            for (int i = 0; i < min; i++)
            {
                if (i!=0)
                {
                    int digit = SumOfDigit(array1[i], array2[i]) + (SumOfDigit(array1[i - 1], array2[i - 1]) / 10);
                    Console.Write("{0} ", digit % 10);
                }
                else
                {
                    Console.Write("{0} ", SumOfDigit(array1[i], array2[i]) % 10);
                }
            }
            if (lenght1 == lenght2)
            {
                if ((array1[lenght1 -1] + array2[lenght1 - 1] + (( array1[lenght1 - 2] + array2[lenght1 - 2]) /10 )) >=10) 
                {
                    Console.Write(1);
                }
            }
            else
            {
                int sum = array3[0] + ((array1[min - 1] + array2[min - 1]) / 10);
                Console.Write("{0} ", sum % 10);
                int rem = sum/10;

                if (array3.Length == 1 && (array3[0] == 9 && (array1[min - 1] + array2[min - 1]) > 9))
                {
                    Console.Write(1);
                }
                if (array3.Length == 1)
                {
                    goto end;
                }
                else
                {
                    for (int i = 1; i < array3.Length; i++)
                    {
                        if (array3[i] + rem > 9)
                        {
                        Console.Write("{0} ",( array3[i] + rem)%10);
                        }
                        else
                        {
                            rem = 0;
                            Console.Write("{0} ", array3[i]  % 10);
                        }
                    }
                    if (array3[array3.Length -1] + rem > 9)
                    {
                        Console.Write(1);
                    }
                }
            }
        end:;
            Main();
        }
    }
}
