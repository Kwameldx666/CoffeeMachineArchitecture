using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank_
{
    public class WaterTank
    {
        public int WaterLevel { get; private set; } // Current water level in the tank
        private int MaxLevel = 1000; // Maximum capacity of the tank in milliliters

        // Constructor to initialize the water tank with a specified amount of water
        public WaterTank(int waterCountInit)
        {
            WaterLevel = waterCountInit;
        }

        // Method to check and display the current water level
        public void CheckWaterLevel()
        {
            Console.WriteLine($"Water level is: {WaterLevel} ml");
        }

        // Method to add water to the tank
        public void AddWater()
        {
            // Calculate the volume of water that can still be added to the tank
            int permittedVolume = MaxLevel - WaterLevel;

            Console.Write($"There are {permittedVolume} ml of space left to fill. Enter the amount of water to add: ");

            int waterCount = 0;
            bool validInput = false;

            // Loop to ensure the entered amount of water is valid
            while (!validInput)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out waterCount))
                {
                    waterCount = Convert.ToInt32(input);

                    if (waterCount <= 0)
                    {
                        // Handle case where the entered amount is zero or negative
                        Console.WriteLine("Amount must be greater than zero. Please enter a valid amount.");
                        Console.Write($"Enter the amount of water to add: ");
                    }
                    else if (waterCount > permittedVolume)
                    {
                        // Handle case where the entered amount exceeds the permitted volume
                        Console.WriteLine("That much water won't fit in the vessel. Please enter a smaller amount.");
                        Console.Write($"Enter the amount of water to add: ");
                    }
                    else
                    {
                        // If input is valid, exit the loop
                        validInput = true;
                    }
                }
                else
                {
                    // Handle case where the input is not a number
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Enter the amount of water to add: ");
                }
            }

            // Add the water to the tank and display the updated level
            WaterLevel += waterCount;
            Console.WriteLine($"\nYou have successfully added {waterCount} ml of water. There are currently {WaterLevel} ml of water in the tank.\n");
        }

        // Method to use a specified amount of water and update the water level
        public string UseWater(int useWaterCount)
        {
            return useWaterCount <= WaterLevel
                ? $"Used {useWaterCount} ml of water. Remaining water level: {WaterLevel -= useWaterCount} ml."
                : "Not enough water!"; // Return a message if there is not enough water
        }
    }
}
