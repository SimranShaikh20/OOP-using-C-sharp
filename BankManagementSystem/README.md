# Bank Management System

## Project Description

The **Bank Management System** is a simple console application designed to simulate banking operations such as deposit and withdrawal. The system allows users to input their details (name, account number, balance) and perform various operations on their account. Users can choose to either deposit or withdraw money, and the system will update the balance accordingly. It also includes functionality to handle invalid input and prevent withdrawal of more funds than the available balance.

## Features

- **User Authentication:** 
    - The system allows users to input their name, account number, and account balance to create a virtual account.
  
- **Deposit:** 
    - Users can deposit a specified amount into their account, which will be added to the current balance.

- **Withdrawal:** 
    - Users can withdraw a specified amount from their account, with checks to ensure the withdrawal does not exceed the available balance.

- **Transaction Feedback:**
    - The system provides feedback on successful deposits and withdrawals, including updated balance information.

- **Continue/Exit Option:**
    - After each transaction, users are prompted with the option to continue with more transactions or exit the system.

## How to Use

1. **Run the Application:**
    - Open the project in Visual Studio or your preferred C# IDE.
    - Build and run the application.

2. **Provide User Information:**
    - Enter your name.
    - Enter your account number.
    - Enter your initial account balance.

3. **Choose Transaction Type:**
    - Choose whether you want to deposit or withdraw funds (1 for Deposit, 2 for Withdraw).

4. **Transaction Execution:**
    - The system will execute the transaction, updating the balance accordingly.

5. **Continue or Exit:**
    - After completing a transaction, the system will prompt you to either continue or exit the program.

## Example

```plaintext
Welcome to Bank Management System
--------------------------------------
Enter your Name: John Doe
Enter Your Account Number: 123456789
Enter Account Balance: 5000
Enter how much amount you want to do operation: 1000
Enter either want to deposit or withdraw option 1]Deposit 2]Withdraw: 1
1000 is credited into 123456789 and new balance is 6000
--------------------------------
Do you want to continue? (yes/no)
