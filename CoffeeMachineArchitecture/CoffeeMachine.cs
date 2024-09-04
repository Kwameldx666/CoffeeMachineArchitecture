using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace CoffeeMachine_
{
    public class CoffeeMachine
    {
        // Flag to indicate if the coffee machine is powered on
        public bool _energy = true;

        // Current temperature of the device
        private int _temperatureDevice;

        // Flag to indicate if the warming process is ongoing
        protected bool WarmingWork = false;

        // Asynchronous method to start warming up the coffee machine
        public async Task StartWarmingAsync()
        {
            if (_energy)
            {
                WarmingWork = true;
                Console.Write("Wait for the system to heat up...\n");

                // Continuously warm up the device until it reaches the required temperature
                while (WarmingWork)
                {
                    WarmingUpTheDevice();
                    Console.Write($"Current temperature is {_temperatureDevice}\n");

                    if (_temperatureDevice >= 110)
                    {
                        Console.Clear();
                        Console.Write($"The device has heated up to the required temperature {_temperatureDevice}\n");
                        StopWarming();
                    }
                    await Task.Delay(1000); // Wait for 1 second
                }

                // After warming up, initialize the menu and show it
                MenuPanel menu = new MenuPanel(30);
                await menu.ShowMainMenu();
            }
            else
            {
                Console.Write("There's a problem with the power supply\n");
            }
        }

        // Method to stop the warming process
        private void StopWarming()
        {
            WarmingWork = false;
        }

        // Method to increase the temperature of the device
        private void WarmingUpTheDevice()
        {
            if (WarmingWork)
            {
                _temperatureDevice += 10; // Increase temperature by 10 degrees
            }
        }

        // Method to get the current temperature of the device
        public string GetTemperatureDevice()
        {
            return $"Temperature of the device is {_temperatureDevice}";
        }
    }
}
