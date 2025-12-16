using System;

class Program
{
    static void Main(string[] args)
    {
        // USA customer
        Address address1 = new Address("123 Main St", "Austin", "TX", "USA");

        Customer customer1 = new Customer("John Smith", address1);

        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P-100", 3.25, 5));
        order1.AddProduct(new Product("Pen", "P-200", 1.50, 10));

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine("Total Price:");
        Console.WriteLine(order1.GetTotalPrice());
        Console.WriteLine();

        // International customer
        Address address2 = new Address("45 Queen Street", "Toronto", "ON", "Canada");

        Customer customer2 = new Customer("Sarah Lee", address2);

        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "P-300", 45.00, 2));
        order2.AddProduct(new Product("Water Bottle", "P-400", 12.20, 1));
        order2.AddProduct(new Product("Notebook", "P-100", 3.25, 4));

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine("Total Price:");
        Console.WriteLine(order2.GetTotalPrice());
    }
}