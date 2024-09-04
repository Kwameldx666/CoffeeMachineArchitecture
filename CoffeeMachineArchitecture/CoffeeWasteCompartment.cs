using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeWasteCompartment_
{
    public class CoffeeWasteCompartment
    {
        // Property to store the amount of coffee waste
        public int CoffeeWaste { get; set; }

        // Method to clear the coffee waste by setting it to zero
        public void Clear()
        {
            CoffeeWaste = 0;
        }

        // Method to display the current level of coffee waste
        public void WasteCoffeeLevel()
        {
            Console.WriteLine($"Waste coffee level is {CoffeeWaste}");
        }
    }
}
