# Payment System Using Interfaces

This project simulates a **payment system** with multiple payment methods (Online Payment and Cash Payment) by utilizing **interfaces** in C#. The system allows users to choose a payment method and process a transaction based on their selection. The project demonstrates the use of **interfaces** and **polymorphism** in C# to handle different types of payment processing.

## Project Overview

In this payment system, users can select one of the two payment methods:

- **Online Payment**: The user can make payments through an online payment method (simulated as "Card Payment").
- **Cash Payment**: The user can opt to pay with cash.

Both payment methods are handled using an interface called `IPaymentSystem`, and each class implements this interface to perform payment processing.

## Project Structure

1. **IPaymentSystem Interface**:
   - This interface defines the methods and properties required for any type of payment method.
   - Methods:
     - `ProcessPayment()`: Process the payment based on the user's input.
     - `GetData()`: Prompt the user to enter the amount for payment.
   - Property:
     - `amount`: A property to hold the payment amount.

2. **OnlinePayment Class**:
   - Implements the `IPaymentSystem` interface.
   - Simulates online card payment processing by taking user input for the amount and processing it.

3. **CashPayment Class**:
   - Implements the `IPaymentSystem` interface.
   - Simulates cash payment processing by taking user input for the amount and processing it.

4. **ServiceType Class**:
   - Prompts the user to choose between online payment or cash payment.

### How Interface is Implemented

In C#, an **interface** defines the contract that any class implementing the interface must follow. Here's how interfaces are used in the project:

1. **Defining the Interface**:  
   The `IPaymentSystem` interface defines the methods `ProcessPayment()` and `GetData()`, as well as the `amount` property.

   ```csharp
   public interface IPaymentSystem
   {
       void ProcessPayment();   // Method to process payment
       void GetData();          // Method to get the amount for payment
       double amount { get; set; } // Property to hold the payment amount
   }   

## Technologies Used

- **C#**: The programming language used to implement the system.
- **.NET Framework**: The runtime environment for C#.

## Getting Started

To run this project locally, follow the instructions below:

### Prerequisites

Ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) or any other C# IDE.
- .NET Core or .NET Framework.

### Installation

1. Clone or download the repository to your local machine.
   
   ```bash
   git clone <repository-url>
