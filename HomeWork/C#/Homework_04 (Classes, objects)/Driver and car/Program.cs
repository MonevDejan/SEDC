using System;
using Driver_and_car.Classes;
using Driver_and_car.Class_Functions;
namespace Driver_and_car
{
    // Task
    #region
    /*
    Make a class Driver. Add properties: Name, Skill
    Make a class Car. Add properties: Model, Speed and Driver
    Make a method of the Car class called : CalculateSpeed() that takes a driver
    object and calculates the skill multiplied by the speed of the car and return it as a result.

    Make a method RaceCars() that will get two Car objects that will determine which 
    car will win and print the result in the console. 

    Make 4 car objects and 4 driver objects.
    Ask the user to select a two cars and two drivers for the cars. 
    Add the drivers to the cars and call the RaceCars() methods

    Test Data:
    Choose a car no.1: 
    1)	Hyundai
    2)	Mazda
    3)	Ferrari
    4)	Porsche

    Choose Driver:
    1)	Bob
    2)	Greg
    3)	Jill
    4)	Anne

    Choose a car no.2:
    1)	Hyundai
    2)	Mazda
    3)	Ferrari
    4)	Porsche

    Choose Driver:
    1)	Bob
    2)	Greg
    3)	Jill
    4)	Anne

    Expected Output:
    Car no. 2 was faster.

    BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two. 
    BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.
    BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.
    */

    #endregion

    class Program
    {
        static void Main()
        {
            bool RunProgram = true;
            do
            {
                Car[] CarArray = new Car[4];

                CarArray[0] = new Car("Hyundai", 180);
                CarArray[1] = new Car("Mazda", 220);
                CarArray[2] = new Car("Ferrari", 250);
                CarArray[3] = new Car("Porsche", 300);

                Driver[] DriverArray = new Driver[4];

                DriverArray[0] = new Driver("Bob", 7);
                DriverArray[1] = new Driver("Greg", 5);
                DriverArray[2] = new Driver("Jill", 2);
                DriverArray[3] = new Driver("Anne", 3);

                Car firstCar = Functions.ChoseCarWithDriver(CarArray, DriverArray);
                Car secondCar = Functions.ChoseCarWithDriver(CarArray, DriverArray);

                Functions.RaceCars(firstCar, secondCar);
                Console.WriteLine("________________________________________");
                Console.WriteLine("Do you want to chek another number Y/N ");
                RunProgram = Functions.RunAgain();

            } while (RunProgram);
        }
    }
}
