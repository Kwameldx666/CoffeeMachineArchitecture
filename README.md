Отлично, теперь у нас есть полный код для программы кофемашины. Я составлю `README.md` файл, который будет включать описание проекта, инструкции по установке и запуску, а также основные функции программы.

### `README.md`

```markdown
# Coffee Machine Simulation

This project is a simulation of a coffee machine, implemented in C#. The simulation includes functionalities for preparing various types of coffee, managing ingredient levels, and performing cleaning operations.

## Features

- **Coffee Preparation:**
  - Cappuccino
  - Espresso
  - Hot Chocolate
  - Irish Coffee
- **Ingredient Management:**
  - Water tank management
  - Milk tank management
  - Coffee bean container management (regular coffee, chocolate, Irish coffee)
- **System Maintenance:**
  - Automatic and manual cleaning processes
  - Monitoring of coffee waste and spilled liquids

## Classes

### 1. `CoffeeMachine`
This class simulates the main coffee machine. It includes methods for warming up the machine and controlling the temperature. Once the machine is warmed up, it shows the main menu for user interaction.

### 2. `MenuPanel`
The main class for managing the user interface. It includes methods for adding ingredients, preparing drinks, checking levels, and performing cleaning tasks.

### 3. `CompartmentSpilledLiquids`
This class handles the management of spilled liquids within the machine. It allows for checking and resetting the liquid levels.

### 4. `CoffeeWasteCompartment`
This class manages the coffee waste produced by the machine. It allows for checking and clearing the waste compartment.

### 5. `WaterTank`
Handles the management of the water tank, including adding water and checking the water level.

### 6. `MilkTank`
Manages the milk tank with methods for adding milk and checking the milk level.

### 7. `CoffeeBeanContainer` (Abstract Class)
The base class for coffee bean containers, defining common properties and methods. Derived classes include:
- `ContainerCoffee`
- `ContainerChocolate`
- `ContainerIrish`

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Kwameldx666/coffeemachine-simulation.git
   ```
2. **Open the project in Visual Studio:**
   - Open the `.sln` file in Visual Studio.

3. **Build the project:**
   - Ensure all dependencies are installed, and build the project.

## Usage

1. **Run the application:**
   - Start the application. The machine will warm up before showing the main menu.

2. **Interacting with the menu:**
   - Use the numerical input to navigate through the options.
   - Follow on-screen instructions for adding ingredients, preparing drinks, and performing maintenance.

## Automatic Cleaning

The system includes an automatic cleaning function that triggers after a set interval (defined by the `cleaningInterval` parameter in `MenuPanel`). Manual cleaning can also be initiated through the menu.

## Notes

- The simulation includes basic input validation to ensure the correct operation of the machine.
- Make sure to monitor the ingredient levels before attempting to prepare any drinks.



