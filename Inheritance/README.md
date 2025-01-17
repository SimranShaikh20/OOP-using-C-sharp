# Inheritance Examples in C#

This repository demonstrates two types of inheritance in C#: **Single Inheritance** and **Multilevel Inheritance**.

## 1. Single Inheritance Example

This part of the project demonstrates the concept of **Single Inheritance** in C#. It consists of two classes: `FruitDetail` and `UserInput`. The `UserInput` class inherits from `FruitDetail`, allowing it to access its properties and methods.

### Classes:
1. **FruitDetail**
   - Contains a property `f_name` to store the name of the fruit.
   - Contains a method `GetData()` that prompts the user to input the name of a fruit.

2. **UserInput** (inherits from `FruitDetail`)
   - Contains a method `PrintData()` that displays the fruit name entered by the user.

### How It Works
1. The program creates an instance of `UserInput` and calls the `GetData()` method from the `FruitDetail` class.
2. The `GetData()` method prompts the user to input the name of a fruit, which is stored in the `f_name` property.
3. The `PrintData()` method prints the name of the fruit that was entered.


## 2. Multilevel Inheritance Example

This part of the project demonstrates **Multilevel Inheritance** in C#. The program uses three classes: `Student`, `StudentDetails`, and `Marks`. The classes are part of a multilevel inheritance structure, where each class extends the functionality of the previous one.

### Classes:
1. **Student**
   - Contains three properties: `name`, `id`, and `percentage`.
   
2. **StudentDetails** (inherits from `Student`)
   - Contains the `GetData()` method, which allows the user to input the student's name, roll number, and percentage.

3. **Marks** (inherits from `StudentDetails`)
   - Contains the `Check()` method, which checks the student's percentage and assigns a grade based on the percentage.

### How It Works
1. The program creates an instance of `Marks` and calls the `GetData()` method from `StudentDetails`.
2. The `GetData()` method prompts the user to input the student's name, roll number, and percentage.
3. The `Check()` method is called to evaluate the student's percentage and assign a grade.
4. Based on the percentage, the program assigns grades as follows:
   - 90% and above: Grade A+
   - 80% to 89.99%: Grade A
   - 70% to 79.99%: Grade B+
   - 60% to 69.99%: Grade B
   - Below 60%: Grade C (not eligible)


## Prerequisites

- .NET 5.0 or later

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or any C# IDE.
3. Build and run the program.
4. For the **Single Inheritance** example, the console will prompt you to enter the name of the fruit and print the name entered.
5. For the **Multilevel Inheritance** example, the console will prompt you to enter the student's name, roll number, and percentage, and then display the calculated grade.
