using System;


class Program
{
    static void Main()
    {
        // User selects the type of product to create
        Console.WriteLine("Choose the type of product (1 - Phone, 2 - Laptop, 3 - Tablet):");
        int choice = int.Parse(Console.ReadLine());

        // Create the corresponding factory based on user choice
        ITechnologicalProductFactory factory = choice switch
        {
            1 => new PhoneFactory(),
            2 => new LaptopFactory(),
            3 => new TabletFactory(),
            _ => throw new ArgumentException("Invalid choice"),
        };

        // Create the client and assemble the product
        TechnologicalProductClient client = new TechnologicalProductClient(factory);
        client.AssembleProduct();
    }
}
