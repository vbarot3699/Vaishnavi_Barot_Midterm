# Vaishnavi_Barot_Midterm

#System for Inventory Management

This C#-implemented inventory management system is console-based. Users may conduct transactions, keep track of laptop and smartphone inventories, and have the system automatically replenish supplies when they run short. Periodically, the prices of the products are also changed according to predetermined standards.


## How It Operates

### Class of Inventory Items

An item in the inventory is represented by the `InventoryItem` class. It possesses the following qualities:

- `ItemName`: Name of the item.
- `ItemId`: Unique identifier for the item.
- `Price`: Price of the item.
- `QuantityInStock`: Quantity of the item available in stock.

The class also includes methods to perform various operations on items:

- `UpdatePrice(double newPrice)`: Updates the price of the item.
- `RestockItem(int additionalQuantity)`: Restocks the item by adding the specified quantity to the stock.
- `SellItem(int quantitySold)`: Sells the specified quantity of the item, updating the stock accordingly.
- `IsInStock()`: Checks if the item is currently in stock.
- `PrintDetails()`: Prints details of the item including name, ID, price, and quantity in stock.

  ### Primary Program

The primary method in charge of communicating with users and overseeing inventory transactions is located in the {Program` class.

- It creates instances of `InventoryItem` for laptops and smartphones.
- It displays the details of all items at the beginning.
- It enters a loop where users can buy laptops and smartphones.
- After each transaction, it checks if the quantity of any item falls below a threshold (5 in this case) and restocks the item if necessary.
- Additionally, after every three transactions, it updates the price of items based on predefined criteria (10% increase for laptops and 5% increase for smartphones).
- The loop continues until all items are sold out or the user chooses to stop buying more items.
- At the end, it displays a message thanking the user for shopping and waits for user input before exiting.
