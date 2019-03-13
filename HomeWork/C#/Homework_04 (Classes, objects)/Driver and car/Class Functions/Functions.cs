using System;
using Driver_and_car.Classes;

namespace Driver_and_car.Class_Functions
{
    public class Functions
    {
        //functions
        #region
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
        public static void PrintCarThatWon(Car winingCar)
        {
            Console.WriteLine("The car that won is:");
            Console.WriteLine($"Model: {winingCar.Model}");
            Console.WriteLine($"Speed of the car combained with driver: {winingCar.CalculateSpeed(winingCar.Driver)}");
            Console.WriteLine($"The driver is: {winingCar.Driver.Name}");

        }
        public static void RaceCars(Car car1, Car car2)
        {
            int resultCar1 = car1.CalculateSpeed(car1.Driver);
            int resultCar2 = car2.CalculateSpeed(car2.Driver);
            
            if (resultCar1 > resultCar2)
            {
                PrintCarThatWon(car1);
            }
            else if (resultCar2 > resultCar1)
            {
                PrintCarThatWon(car2);
            }
            else
            {
                Console.WriteLine("The both car has the same speed");
            }

        }

        public static int StringToInt()
        {
            int randomNumber;
            bool check = int.TryParse(Console.ReadLine(), out randomNumber);

            if (!check)
            {
                Console.WriteLine("Please enter valid number");
                randomNumber = StringToInt();
            }
            return randomNumber;
        }

        public static void PrintCars(Car[] listOfCars)
        {
            for (int i = 0; i < listOfCars.Length; i++)
            {
                if (!listOfCars[i].IsSelected)
                {
                    Console.WriteLine($"{i + 1}. {listOfCars[i].Model}");
                }

            }
        }

        public static void PrinDrivers(Driver[] listOfDrivers)
        {
            for (int i = 0; i < listOfDrivers.Length; i++)
            {
                if (!listOfDrivers[i].IsSelected)
                {
                    Console.WriteLine($"{i + 1}. {listOfDrivers[i].Name}");
                }

            }
        }

        public static Car SelectCar(ref Car[] listOfCars)
        {
            string userInputForCar = Console.ReadLine();
            Car chosenCar = null;

            for (int i = 0; i < listOfCars.Length; i++)
            {
                if (listOfCars[i].IsSelected == false)
                {
                    string convertedInput = Convert.ToString(i + 1);

                    if (userInputForCar == convertedInput)
                    {
                        listOfCars[i].IsSelected = true;
                        chosenCar = listOfCars[i];
                        break;
                    }
                }
            }

            if (chosenCar == null)
            {
                Console.WriteLine("You entered invalid input!");
                Console.WriteLine("Pleae chose again");
                Console.Write("Your chose is: ");
                chosenCar = SelectCar(ref listOfCars);
            }

            return chosenCar;
        }

        public static Driver SelectDriver(ref Driver[] listOfDrivers)
        {
            string userInputForDriver = Console.ReadLine();
            Driver chosenDriver = null;

            for (int i = 0; i < listOfDrivers.Length; i++)
            {
                if (listOfDrivers[i].IsSelected == false)
                {
                    string convertedInput = Convert.ToString(i + 1);

                    if (userInputForDriver == convertedInput)
                    {
                        listOfDrivers[i].IsSelected = true;
                        chosenDriver = listOfDrivers[i];
                        break;
                    }
                }
            }

            if (chosenDriver == null)
            {
                Console.WriteLine("You entered invalid input!");
                Console.WriteLine("Pleae chose again");
                Console.Write("Your chose is: ");
                chosenDriver = SelectDriver(ref listOfDrivers);
            }

            return chosenDriver;
        }

        public static Car ChoseCarWithDriver(Car[] listOfCars, Driver[] listOfDrivers)
        {
            Console.WriteLine("Please chose from the folowing cars");
            PrintCars(listOfCars);

            Console.Write("Your chose is: ");
            Car chosenCar = SelectCar(ref listOfCars);

            Console.WriteLine("Please chose from the folowing Drivers");
            PrinDrivers(listOfDrivers);

            Console.Write("Your chose is: ");
            Driver chosenDriver = SelectDriver(ref listOfDrivers);

            chosenCar.Driver = chosenDriver;
            return chosenCar;

        }
        #endregion

    }

}
