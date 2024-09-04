using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBeanContainer_
{
    // Abstract base class for coffee bean containers
    public abstract class CoffeeBeanContainer
    {
        // Indicates whether the container is open (this might be used in a derived class)
        public bool ContainerOpen;

        // Abstract method to add seeds to the container
        public abstract void AddSeedsCoffee();

        // Abstract method to use seeds from the container
        public abstract void UseSeedsCoffee(int count);

        // Abstract method to check the level of seeds in the container
        public abstract void CheckLevelCoffee();

        // Maximum capacity of the container
        protected int MaxLevel = 1000;
    }

    // Class for Irish coffee bean container
    public class ContainerIrish : CoffeeBeanContainer
    {
        // Current level of Irish coffee beans
        public int LevelIrish { get; private set; }

        // Constructor to initialize the container with a specified level
        public ContainerIrish(int InitializingLevelIrish)
        {
            LevelIrish = InitializingLevelIrish;
        }

        // Method to add Irish coffee beans to the container
        public override void AddSeedsCoffee()
        {
            int count = 0;
            int permittedVolume = MaxLevel - LevelIrish;

            Console.Write($"How many Irish seeds do you want to add? Maximum you can add is {permittedVolume} grams. Write here: ");

            bool validInput = false;

            while (!validInput)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out count))
                {
                    if (count <= 0)
                    {
                        Console.WriteLine("Amount must be greater than zero. Please enter a valid amount.");
                        Console.Write($"Write here: ");
                    }
                    else if (count > permittedVolume)
                    {
                        Console.WriteLine("That much won't fit in the container. Please enter a smaller amount.");
                        Console.Write($"Write here: ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Write here: ");
                }
            }

            LevelIrish += count;
            Console.WriteLine($"\nYou have successfully added {count} grams of Irish seeds. There are currently {LevelIrish} grams of seeds in the container.\n");
        }

        // Method to use Irish coffee beans from the container
        public override void UseSeedsCoffee(int count)
        {
            if (count <= LevelIrish)
            {
                LevelIrish -= count;
            }
            else
            {
                Console.WriteLine("Not enough seeds to use!");
            }
        }

        // Method to check the level of Irish coffee beans in the container
        public override void CheckLevelCoffee()
        {
            Console.WriteLine($"Level Irish is {LevelIrish}");
        }
    }

    // Class for chocolate bean container
    public class ContainerChocolate : CoffeeBeanContainer
    {
        // Current level of chocolate beans
        public int LevelChocolate { get; private set; }

        // Constructor to initialize the container with a specified level
        public ContainerChocolate(int InitializingLevelChocolate)
        {
            LevelChocolate = InitializingLevelChocolate;
        }

        // Method to add chocolate beans to the container
        public override void AddSeedsCoffee()
        {
            int count = 0;
            int permittedVolume = MaxLevel - LevelChocolate;

            Console.Write($"How many chocolate seeds do you want to add? Maximum you can add is {permittedVolume} grams. Write here: ");

            bool validInput = false;

            while (!validInput)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out count))
                {
                    if (count <= 0)
                    {
                        Console.WriteLine("Amount must be greater than zero. Please enter a valid amount.");
                        Console.Write($"Write here: ");
                    }
                    else if (count > permittedVolume)
                    {
                        Console.WriteLine("That much won't fit in the container. Please enter a smaller amount.");
                        Console.Write($"Write here: ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Write here: ");
                }
            }

            LevelChocolate += count;
            Console.WriteLine($"\nYou have successfully added {count} grams of chocolate seeds. There are currently {LevelChocolate} grams of seeds in the container.\n");
        }

        // Method to use chocolate beans from the container
        public override void UseSeedsCoffee(int count)
        {
            if (count <= LevelChocolate)
            {
                LevelChocolate -= count;
            }
            else
            {
                Console.WriteLine("Not enough seeds to use!");
            }
        }

        // Method to check the level of chocolate beans in the container
        public override void CheckLevelCoffee()
        {
            Console.WriteLine($"Level chocolate is {LevelChocolate}");
        }
    }

    // Class for coffee bean container
    public class ContainerCoffee : CoffeeBeanContainer
    {
        // Current level of coffee beans
        public int LevelCoffee { get; private set; }

        // Constructor to initialize the container with a specified level
        public ContainerCoffee(int InitializingLevelCoffee)
        {
            LevelCoffee = InitializingLevelCoffee;
        }

        // Method to add coffee beans to the container
        public override void AddSeedsCoffee()
        {
            int count = 0;
            int permittedVolume = MaxLevel - LevelCoffee;

            Console.Write($"How many coffee seeds do you want to add? Maximum you can add is {permittedVolume} grams. Write here: ");

            bool validInput = false;

            while (!validInput)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out count))
                {
                    if (count <= 0)
                    {
                        Console.WriteLine("Amount must be greater than zero. Please enter a valid amount.");
                        Console.Write($"Write here: ");
                    }
                    else if (count > permittedVolume)
                    {
                        Console.WriteLine("That much won't fit in the container. Please enter a smaller amount.");
                        Console.Write($"Write here: ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Write here: ");
                }
            }

            LevelCoffee += count;
            Console.WriteLine($"\nYou have successfully added {count} grams of coffee seeds. There are currently {LevelCoffee} grams of seeds in the container.\n");
        }

        // Method to use coffee beans from the container
        public override void UseSeedsCoffee(int count)
        {
            if (count <= LevelCoffee)
            {
                LevelCoffee -= count;
            }
            else
            {
                Console.WriteLine("Not enough seeds to use!");
            }
        }

        // Method to check the level of coffee beans in the container
        public override void CheckLevelCoffee()
        {
            Console.WriteLine($"Level coffee is {LevelCoffee}");
        }
    }
}
