using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WaterTank_;
using CoffeeBeanContainer_;
using MilkTank_;
using CoffeeWasteCompartment_;
using CompartmentSpilledLiquids_;

namespace Menu
{
    public class MenuPanel
    {
        // Declare instances of components and compartments
        private WaterTank waterTank;
        private ContainerCoffee containerCoffee;
        private ContainerChocolate containerChocolate;
        private ContainerIrish containerIrish;
        private MilkTank milkTank;
        private CoffeeWasteCompartment coffeeWasteCompartment;
        private CompartmentSpilledLiquids compartmentSpilled;
        private Stopwatch stopwatch;
        private readonly int timeCleaning; // Time interval for automatic cleaning (in seconds)
        private bool isSystemBusy; // Flag to indicate if the system is busy

        // Constructor to initialize components and set cleaning interval
        public MenuPanel(int cleaningInterval)
        {
            // Initialize the stopwatch for cleaning intervals
            stopwatch = new Stopwatch();
            timeCleaning = cleaningInterval;
            coffeeWasteCompartment = new CoffeeWasteCompartment();
            compartmentSpilled = new CompartmentSpilledLiquids();

            // Initialize tanks and containers with default values
            waterTank = new WaterTank(100);
            containerCoffee = new ContainerCoffee(100);
            containerChocolate = new ContainerChocolate(100);
            containerIrish = new ContainerIrish(100);
            milkTank = new MilkTank(100);

            // Start the stopwatch to track elapsed time
            stopwatch.Start();
        }

        // Main menu display and user interaction
        public async Task ShowMainMenu()
        {
            bool menuOn = true;
            while (menuOn)
            {
                Console.Clear();
                Console.WriteLine("Choose the option that suits you:");
                Console.WriteLine("0. Add milk");
                Console.WriteLine("1. Add water");
                Console.WriteLine("2. Add coffee");
                Console.WriteLine("3. Add chocolate powder");
                Console.WriteLine("4. Make cappuccino");
                Console.WriteLine("5. Make espresso");
                Console.WriteLine("6. Make hot chocolate");
                Console.WriteLine("7. Make Irish coffee");
                Console.WriteLine("8. Check container levels");
                Console.WriteLine("9. Check water and milk levels");
                Console.WriteLine("10. System cleaning");
                Console.WriteLine("11. Exit");
                Console.Write("\nWrite your choice: ");

                int choose;
                bool validInput = false;

                // Input validation for menu choice
                do
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out choose))
                    {
                        validInput = true;
                    }
                    else if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a valid number.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid number.");
                    }
                } while (!validInput);

                try
                {
                    // Set system busy flag to true
                    isSystemBusy = true;

                    // Process user choice and execute corresponding actions
                    switch (choose)
                    {
                        case 0:
                            milkTank.AddMilk();
                            break;
                        case 1:
                            waterTank.AddWater();
                            break;
                        case 2:
                            Console.WriteLine("What coffee seeds to add?");
                            Console.Write("1. Coffee simple\n2. Irish coffee\nYour choice is ");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                containerCoffee.AddSeedsCoffee();
                            }
                            else if (choice == 2)
                            {
                                containerIrish.AddSeedsCoffee();
                            }
                            else
                            {
                                Console.WriteLine("You are mistaken");
                            }
                            break;
                        case 3:
                            containerChocolate.AddSeedsCoffee();
                            break;
                        case 4:
                            await MakeCappuccino();
                            break;
                        case 5:
                            await MakeEspresso();
                            break;
                        case 6:
                            await MakeHotChocolate();
                            break;
                        case 7:
                            await MakeIrishCoffee();
                            break;
                        case 8:
                            Console.Clear();
                            CheckContainerLevels();
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case 9:
                            Console.Clear();
                            CheckFluidLevels();
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case 10:
                            Console.Clear();
                            await PerformCleaning();
                            break;
                        case 11:
                            menuOn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    // Handle format exceptions for invalid input
                    Console.WriteLine($"Invalid input format: {fe.Message}");
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    // Reset system busy flag
                    isSystemBusy = false;
                }

                // Automatic cleaning based on elapsed time
                if (!isSystemBusy && stopwatch.Elapsed.TotalSeconds >= timeCleaning)
                {
                    await FlushingSystem();
                    stopwatch.Restart();
                }

                await Task.Delay(1000); // Wait for 1 second before the next loop iteration
            }
        }

        // Perform automatic system flushing
        private async Task FlushingSystem()
        {
            Console.WriteLine("Performing automatic flushing...");
            int i = 5;
            while (i != 0)
            {
                Console.Write($"Please wait {i} seconds. System flushing in progress.");
                i--;
                await Task.Delay(1000); // Wait for 1 second
                Console.Clear();
            }
            compartmentSpilled.WatereLevel += 10; // Example increase in water level

            Console.Write("Flushing was successful.\nPress any key to continue.");
            Console.ReadKey();
        }

        // Perform manual cleaning of the system
        private async Task PerformCleaning()
        {
            Console.WriteLine("Performing cleaning...");
            int i = 5;
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine($"Please wait {i} seconds. System cleaning in progress.");
                i--;
                await Task.Delay(1000); // Wait for 1 second
                coffeeWasteCompartment.Clear();
            }
            coffeeWasteCompartment.Clear();
            compartmentSpilled.PourOutTheWater();
            Console.Write("Cleaning was successful.\nPress any key to continue.");
            Console.ReadKey();
        }

        // Check the levels of fluids in various compartments
        private void CheckFluidLevels()
        {
            coffeeWasteCompartment.WasteCoffeeLevel();
            compartmentSpilled.WasteLiquidLevel();
            milkTank.CheckMilkLevel();
            waterTank.CheckWaterLevel();
        }

        // Check the levels of coffee seeds in different containers
        private void CheckContainerLevels()
        {
            containerChocolate.CheckLevelCoffee();
            containerCoffee.CheckLevelCoffee();
            containerIrish.CheckLevelCoffee();
        }

        // Prepare Irish Coffee if ingredients are sufficient
        private async Task MakeIrishCoffee()
        {
            int useIrish = 3;
            int useMilk = 5;

            if (containerIrish.LevelIrish >= useIrish && milkTank.MilkLevel >= useMilk)
            {
                Console.WriteLine("Preparing your Irish Coffee...");
                for (int i = 4; i > 0; i--)
                {
                    Console.Clear();
                    coffeeWasteCompartment.CoffeeWaste += 1;
                    Console.WriteLine($"Starting in {i} seconds...");
                    await Task.Delay(1000); // Wait for 1 second
                }

                containerIrish.UseSeedsCoffee(useIrish);
                milkTank.UseMilk(useMilk);

                Console.Clear();
                Console.WriteLine("The Irish Coffee is ready. Take your Irish Coffee and press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make Irish Coffee.");
            }
        }

        // Prepare Hot Chocolate if ingredients are sufficient
        private async Task MakeHotChocolate()
        {
            int useHotChocolate = 3;

            if (containerChocolate.LevelChocolate >= useHotChocolate)
            {
                Console.WriteLine("Preparing your hot chocolate...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Clear();
                    coffeeWasteCompartment.CoffeeWaste += 1;
                    Console.WriteLine($"Starting in {i} seconds...");
                    await Task.Delay(1000); // Wait for 1 second
                }

                containerChocolate.UseSeedsCoffee(useHotChocolate);

                Console.Clear();
                Console.WriteLine("The hot chocolate is ready. Take your hot chocolate and press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make hot chocolate.");
            }
        }

        // Prepare Espresso if ingredients are sufficient
        private async Task MakeEspresso()
        {
            int useCoffee = 3;

            if (containerCoffee.LevelCoffee >= useCoffee)
            {
                Console.WriteLine("Preparing your espresso...");
                for (int i = 4; i > 0; i--)
                {
                    Console.Clear();
                    coffeeWasteCompartment.CoffeeWaste += 1;
                    Console.WriteLine($"Starting in {i} seconds...");
                    await Task.Delay(1000); // Wait for 1 second
                }

                containerCoffee.UseSeedsCoffee(useCoffee);

                Console.Clear();
                Console.WriteLine("The espresso is ready. Take your espresso and press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make espresso.");
            }
        }

        // Prepare Cappuccino if ingredients are sufficient
        private async Task MakeCappuccino()
        {
            int useCoffee = 3;
            int useMilk = 5;

            try
            {
                if (containerCoffee.LevelCoffee >= useCoffee && milkTank.MilkLevel >= useMilk)
                {
                    Console.WriteLine("Preparing your cappuccino...");
                    for (int i = 4; i > 0; i--)
                    {
                        Console.Clear();
                        coffeeWasteCompartment.CoffeeWaste += 1;
                        Console.WriteLine($"Starting in {i} seconds...");
                        await Task.Delay(1000); // Wait for 1 second
                    }

                    containerCoffee.UseSeedsCoffee(useCoffee);
                    milkTank.UseMilk(useMilk);

                    Console.Clear();
                    Console.WriteLine("The cappuccino is ready. Take your cappuccino and press any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Not enough ingredients to make cappuccino.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }
}
