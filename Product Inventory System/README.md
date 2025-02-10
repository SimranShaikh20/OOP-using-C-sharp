# Product Inventory System

A simple C# console application that allows users to manage and update an inventory of products. This system provides functionality to add items, update their prices, and display the details of specific items from the inventory.

## Features

- **Add Item**: Add new products to the inventory with a name and price.
- **Update Item**: Update the price of an existing item in the inventory.
- **Display Item**: Search and display the details (name and price) of a specific item from the inventory.

## Prerequisites

To run this application, you need to have the following installed on your system:

- .NET SDK (preferably .NET Core 3.1 or later)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/product-inventory-system.git
    ```

2. Navigate to the project directory:

    ```bash
    cd product-inventory-system
    ```

3. Build the project:

    ```bash
    dotnet build
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

## Usage

### Add Item
- To add a new item, you will be prompted to enter the item name and price.
  
### Update Item
- To update the price of an item, you will be prompted to enter the item name and the new price.

### Display Item
- To display the details of an item, you will need to enter the name of the item. If it exists in the inventory, its details (name and price) will be displayed; otherwise, a "not found" message will appear.

