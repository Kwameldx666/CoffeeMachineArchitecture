# ☕ Coffee Machine Architecture Simulator

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Console](https://img.shields.io/badge/Console-Application-black?style=for-the-badge)

*An advanced coffee machine simulator built with modern C# architecture*

</div>

## 🌟 Overview

This project is a sophisticated **Coffee Machine Simulator** that demonstrates object-oriented programming principles and component-based architecture. The simulator allows users to interact with a virtual coffee machine, managing ingredients, brewing different beverages, and maintaining the system through an intuitive console interface.

### ✨ Key Features

🔹 **Ingredient Management** - Add and monitor water, milk, coffee beans, and chocolate powder  
🔹 **Beverage Brewing** - Create cappuccino, espresso, hot chocolate, and Irish coffee  
🔹 **Smart Monitoring** - Real-time level checking for all containers and tanks  
🔹 **Auto-Cleaning System** - Automated maintenance with manual override options  
🔹 **Heating System** - Realistic warming simulation with temperature monitoring  
🔹 **Waste Management** - Proper handling of coffee grounds and spilled liquids  

---

## 🏗️ Architecture Overview

The application follows a **component-based architecture** with clear separation of concerns:

```
CoffeeMachineArchitecture/
├── 📁 Core Components
│   ├── CoffeeMachine.cs      # Main machine controller with heating system
│   └── Program.cs            # Application entry point
├── 📁 User Interface
│   └── Menu.cs               # Interactive menu system
├── 📁 Storage Components
│   ├── WaterTank.cs          # Water reservoir management
│   ├── MilkTank.cs           # Milk storage system
│   └── CoffeeBeanContainer.cs # Coffee bean containers (Coffee, Irish, Chocolate)
└── 📁 Maintenance
    ├── CoffeeWasteCompartment.cs      # Waste collection
    └── CompartmentSpilledLiquids.cs   # Spill management
```

### 🎯 Design Patterns Used

- **Template Method Pattern** - Abstract base class for coffee bean containers
- **Component Pattern** - Modular design for machine parts
- **State Management** - System state tracking and validation
- **Async/Await Pattern** - Non-blocking heating and cleaning operations

---

## 🚀 Getting Started

### Prerequisites

- **.NET 8.0 SDK** or higher
- Any C# compatible IDE (Visual Studio, VS Code, Rider)
- Terminal/Command Prompt

### 📦 Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kwameldx666/CoffeeMachineArchitecture.git
   cd CoffeeMachineArchitecture
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run --project CoffeeMachineArchitecture
   ```

### 🎮 Usage

1. **Start the machine** by typing `start` when prompted
2. **Wait for heating** - the machine will warm up to optimal temperature (110°C)
3. **Navigate the menu** using number keys (0-11)
4. **Enjoy your virtual coffee!** ☕

#### Menu Options:
```
0. Add milk                 6. Make hot chocolate
1. Add water               7. Make Irish coffee  
2. Add coffee              8. Check container levels
3. Add chocolate powder    9. Check water and milk levels
4. Make cappuccino        10. System cleaning
5. Make espresso          11. Exit
```

---

## 🔧 Technical Details

### System Requirements
- **Runtime**: .NET 8.0+
- **Memory**: ~50MB RAM
- **Platform**: Cross-platform (Windows, macOS, Linux)

### Key Classes & Components

#### 🏭 CoffeeMachine
- **Heating System**: Gradual temperature increase simulation
- **Energy Management**: Power state control
- **Async Operations**: Non-blocking warming process

#### 🎛️ MenuPanel
- **User Interface**: Interactive console menu
- **Input Validation**: Robust error handling
- **Auto-Cleaning**: Time-based maintenance scheduling
- **State Management**: System busy/ready status

#### 🫙 Storage Components
- **WaterTank**: 1000ml capacity with overflow protection
- **MilkTank**: Fresh milk storage with level monitoring
- **CoffeeBeanContainer**: Abstract base for specialized containers
  - ContainerCoffee: Regular coffee beans
  - ContainerIrish: Irish coffee beans
  - ContainerChocolate: Chocolate powder

---

## 🎨 Code Examples

### Creating a Coffee Machine Instance
```csharp
CoffeeMachine coffeeMachine = new CoffeeMachine();
coffeeMachine._energy = true;
await coffeeMachine.StartWarmingAsync();
```

### Making a Cappuccino
```csharp
// The menu system handles this automatically
// User selects option 4, system checks ingredients
// and brews if sufficient materials are available
```

### Adding Ingredients
```csharp
waterTank.AddWater();           // Interactive water addition
milkTank.AddMilk();            // Interactive milk addition
containerCoffee.AddSeedsCoffee(); // Interactive coffee addition
```

---

## 🛠️ Development

### Building from Source
```bash
# Clean build
dotnet clean
dotnet build --configuration Release

# Run tests (if available)
dotnet test

# Create distribution package
dotnet publish -c Release -o ./publish
```

### Contributing
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

## 📋 Planned Features

- [ ] GUI Interface with WPF/MAUI
- [ ] Recipe customization system
- [ ] Maintenance scheduling
- [ ] Energy consumption tracking
- [ ] Multi-language support
- [ ] Sound effects and animations
- [ ] Save/Load machine state

---

## 📜 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🙋‍♂️ Support

If you encounter any issues or have questions:

1. Check the [Issues](https://github.com/Kwameldx666/CoffeeMachineArchitecture/issues) page
2. Create a new issue with detailed description
3. Contact the maintainer: [@Kwameldx666](https://github.com/Kwameldx666)

---

<div align="center">

**Made with ❤️ and lots of ☕**

*Enjoy your virtual coffee experience!*

</div>

---

## 🇷🇺 Русская версия

### Описание проекта

Этот проект представляет собой **продвинутый симулятор кофемашины**, демонстрирующий принципы объектно-ориентированного программирования и компонентной архитектуры. Симулятор позволяет пользователям взаимодействовать с виртуальной кофемашиной через интуитивный консольный интерфейс.

### Основные возможности

🔹 **Управление ингредиентами** - добавление и мониторинг воды, молока, кофейных зерен и шоколадного порошка  
🔹 **Приготовление напитков** - капучино, эспрессо, горячий шоколад и ирландский кофе  
🔹 **Умный мониторинг** - проверка уровней в реальном времени для всех контейнеров  
🔹 **Система автоочистки** - автоматическое обслуживание с возможностью ручного управления  
🔹 **Система нагрева** - реалистичная симуляция разогрева с мониторингом температуры  

### Запуск проекта

1. Клонируйте репозиторий: `git clone https://github.com/Kwameldx666/CoffeeMachineArchitecture.git`
2. Перейдите в директорию: `cd CoffeeMachineArchitecture`
3. Соберите проект: `dotnet build`
4. Запустите: `dotnet run --project CoffeeMachineArchitecture`

### Использование

1. Запустите машину, введя `start`
2. Дождитесь нагрева до 110°C
3. Используйте цифровое меню (0-11) для управления
4. Наслаждайтесь виртуальным кофе! ☕

