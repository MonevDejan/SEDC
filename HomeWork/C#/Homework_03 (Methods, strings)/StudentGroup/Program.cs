using System;


namespace StudentGroup
{
    /*
        Make a new console application called StudentGroup
        Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
        Get a number from the console between 1 and 2 and print the students from that group in the console.
        Ex: studentsG1 [“Zdravko”, “Petko”, “Stanko”, “Branko”, “Trajko”]
        Test Data:
        Enter student group: ( there are 1 and 2 )
        1
 
        Expected Output:
        The Students in G1 are: 
        Zdravko
        Petko
        Stanko
        Branko
        Trajko

    */

    class Program
    {
        static void PrintArray(string [] randomArray)
        {
            foreach (string element in randomArray)
            {
                Console.WriteLine(element);
            }
            
        }
        static void Main()
        {

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Zdravko 2", "Petko 2", "Stanko 2", "Branko 2", "Trajko 2" };

            Console.WriteLine("Enter student group: (chose 1 or 2 ) ");
            string group = Console.ReadLine();

            switch (group)
            {
                case "1":
                    Console.WriteLine("The Students in G1 are:");
                    PrintArray(studentsG1);
                    break;
                case "2":
                    Console.WriteLine("The Students in G2 are:");
                    PrintArray(studentsG2);
                    break;
                default:
                    Console.WriteLine("Please chose from 1 or 2");
                    break;
            }
            Console.WriteLine("");
            Main();

        }

    }
}
