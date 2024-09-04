using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTank_
{
    public class MilkTank
    {
        public int MilkLevel { get; private set; } // Current milk level in the tank
        private int MaxLevel = 2000; // Maximum capacity of the tank in milliliters
        private int PermittedVolume; // Volume of milk that can still be added

        // Constructor to initialize the milk tank with a specified amount of milk
        public MilkTank(int milkCountInit)
        {
            MilkLevel = milkCountInit;
        }

        // Method to check and display the current milk level
        public void CheckMilkLevel()
        {
            Console.WriteLine($"Milk level is: {MilkLevel} ml");
        }

        // Method to add milk to the tank
        public void AddMilk()
        {
            // Calculate the volume of milk that can still be added to the tank
            PermittedVolume = MaxLevel - MilkLevel;
            Console.Write($"There are {PermittedVolume} ml of milk left to fill. Enter amount of milk to add: ");
            int milkCount = Convert.ToInt32(Console.ReadLine());
            bool agree = false;

            // Loop to ensure the entered amount of milk does not exceed the permitted volume
            while (!agree)
            {
                if (PermittedVolume < milkCount)
                {
                    Console.Write("That much won't fit in the vessel. Please enter a valid amount: ");
                    milkCount = Convert.ToInt32(Console.ReadLine()); // Prompt user to enter a valid amount
                }
                else
                {
                    agree = true; // Exit the loop if the amount is valid
                }
            }

            // Add the milk to the tank and display the updated level
            MilkLevel += milkCount;
            Console.WriteLine($"\nYou have successfully added {milkCount} ml of milk. There are currently {MilkLevel} ml of milk in the tank.\n");
            Console.ReadKey(); // Pause to allow the user to read the message
        }

        // Method to use a specified amount of milk and update the milk level
        public string UseMilk(int useMilkCount)
        {
            return useMilkCount <= MilkLevel
                ? $"Used {useMilkCount} ml of milk. Remaining milk level: {MilkLevel -= useMilkCount} ml."
                : "Not enough milk!"; // Return a message if there is not enough milk
        }
    }
}
