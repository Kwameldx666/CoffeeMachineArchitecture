using System;
using System.Threading.Tasks;
using Menu;
using CoffeeMachine_;

class Program
{
    static async Task Main(string[] args)
    {
        bool correctInput = false;

        while (!correctInput)
        {
            Console.Write("Write 'start' to start the device: ");
            string start = Console.ReadLine();

            if (start.Equals("start", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("Device starting...");
                CoffeeMachine coffeeMachine = new CoffeeMachine();
                coffeeMachine._energy = true;
                await coffeeMachine.StartWarmingAsync();
                correctInput = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You are mistaken. To start you need to write \"start\"");
            }
        }
    }
}
