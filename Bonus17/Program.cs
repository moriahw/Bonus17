using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;

            while (goAgain == true) //loops program if user wants to continue to input information
            {
                Console.WriteLine("How many cars would you like to enter?");
                int numberofCars = int.Parse(Console.ReadLine());

                //1. create an array to hold the object (number of cars the user wants to enter)
                Car[] CarDetails = new Car[numberofCars];

                //2. creating the Car objects inside of the array 
                for (int i = 0; i < CarDetails.Length; i++)
                {
                    CarDetails[i] = new Car();
                }

                //3. initialize the objects 
                for (int i = 0; i < CarDetails.Length; i++)
                {
                    Console.WriteLine("Please enter the make of the car: ");
                    CarDetails[i].Make = Console.ReadLine();

                    Console.WriteLine("Please enter the model of the car: ");
                    CarDetails[i].Model = Console.ReadLine();

                    Console.WriteLine("Please enter the year of the car: ");
                    CarDetails[i].Year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the price of the car: ");
                    CarDetails[i].Price = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Make \t Model \t Year \t Price");
                foreach (Car Vehicle in CarDetails)
                {
                    Console.WriteLine($"{Vehicle.Make} \t {Vehicle.Model} \t {Vehicle.Year} \t {Vehicle.Price}");

                }



                Console.WriteLine("Would you like to enter more cars?");

                string UserOption = ValidateUserInput(); //assign variable to call on method

                if (UserOption == "no" || UserOption == "n") //checks user input based off called method conditions and kills program if conditions are met
                {
                    Console.WriteLine("See ya later!");
                    goAgain = false;
                }
            }

            
        }

        public static string ValidateUserInput() //create method to validate user response 
        {
            string userResponse = Console.ReadLine().ToLower(); //assigns user input to a variable and converts to lowercase in all instances

            while (userResponse != "y" && userResponse != "yes" && userResponse != "n" && userResponse != "no") //checks if user input is NOT any of the listed options and prompts user to enter yes or no
            {
                Console.WriteLine("Please enter yes or no!");
                userResponse = Console.ReadLine().ToLower();
            }

            return userResponse; //returns the user input to the main method 

        }




    }
}
