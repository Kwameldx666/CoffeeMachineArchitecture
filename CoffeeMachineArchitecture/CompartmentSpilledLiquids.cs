using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompartmentSpilledLiquids_
{
    public class CompartmentSpilledLiquids
    {
        // Property to store the level of spilled liquids
        public int WatereLevel { get; set; }

        // Method to reset the level of spilled liquids to zero
        public void PourOutTheWater()
        {
            WatereLevel = 0;
        }

        // Method to display the current level of spilled liquids
        public void WasteLiquidLevel()
        {
            Console.WriteLine($"Waste Liquid Level is {WatereLevel}");
        }
    }
}
