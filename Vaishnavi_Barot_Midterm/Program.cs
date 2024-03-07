using System;

// Student Name: Vaishnavi Barot
// Student ID: 8975398

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;   // Update the price
        Console.WriteLine($"Price of {ItemName} updated to {Price:C}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;   // Increase the quantity in stock
        Console.WriteLine($"{additionalQuantity} {ItemName}(s) restocked. Total quantity: {QuantityInStock}");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;   // Decrease the quantity in stock
            Console.WriteLine($"{quantitySold} {ItemName}(s) sold. Remaining quantity: {QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"Insufficient stock. Unable to sell {quantitySold} {ItemName}(s).");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;    // Return true if quantity in stock is greater than 0, otherwise false
    }

    // Print item details
    public void PrintDetails()
    {
        // Print details of the item
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem laptop = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem smartphone = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        Console.WriteLine("Details of all items:");
        laptop.PrintDetails();
        smartphone.PrintDetails();

        int transactionCount = 0; // Counter to keep track of transactions

        while (true)
        {
            // User buys laptops
            Console.WriteLine("\nHow many laptops do you want to buy?");
            int laptopsToBuy = int.Parse(Console.ReadLine());
            laptop.SellItem(laptopsToBuy);

            // User buys smartphones
            Console.WriteLine("How many smartphones do you want to buy?");
            int smartphonesToBuy = int.Parse(Console.ReadLine());
            smartphone.SellItem(smartphonesToBuy);

            // Increment transaction count
            transactionCount++;

            // Update price after every 3 transactions
            if (transactionCount % 3 == 0)
            {
                laptop.UpdatePrice(laptop.Price * 1.1); // Increase price by 10%
                smartphone.UpdatePrice(smartphone.Price * 1.05); // Increase price by 5%
            }

            // Check availability and restock if necessary
            if (laptop.QuantityInStock < 5)
            {
                laptop.RestockItem(10);
                Console.WriteLine("Laptops restocked.");
            }
            if (smartphone.QuantityInStock < 5)
            {
                smartphone.RestockItem(10);
                Console.WriteLine("Smartphones restocked.");
            }

            // Display available items after purchase and restock
            Console.WriteLine("\nAvailable items after purchase:");
            laptop.PrintDetails();
            smartphone.PrintDetails();

            // Check if everything is sold out
            if (!laptop.IsInStock() && !smartphone.IsInStock())
            {
                Console.WriteLine("Everything is sold out.");
                break;
            }

            // Ask user if they want to buy more
            Console.WriteLine("\nSome items are still available. Would you like to buy more? (yes/no)");
            string buyMore = Console.ReadLine();

            if (buyMore.ToLower() != "yes")
            {
                Console.WriteLine("Thank you for shopping with us!");
                break;
            }
        }

        // Pause to see final output
        Console.ReadLine();
    }
}
