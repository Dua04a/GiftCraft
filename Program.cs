using GiftCraft.Factories;
using GiftCraft.Interfaces;
using GiftCraft.Models;
using GiftCraft.Services;
using GiftCraft.Strategies;

bool exit = false;

while (!exit)
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("          Welcome to GiftCraft");
    Console.WriteLine("======================================");

    Console.WriteLine("\nChoose an Occasion:");
    Console.WriteLine("1. Graduation");
    Console.WriteLine("2. Birthday");
    Console.WriteLine("3. Wedding");
    Console.WriteLine("4. New Baby");
    Console.WriteLine("5. Mother's Day");
    Console.WriteLine("6. Father's Day");

    Console.Write("\nYour choice: ");

    if (!int.TryParse(Console.ReadLine(), out int occasionChoice))
    {
        Console.WriteLine("Invalid input.");
        Console.ReadKey();
        continue;
    }

    try
    {
        var builder = GiftFactory.CreateGiftBuilder(occasionChoice);

        GiftService giftService = new();

        GiftBox gift = giftService.BuildGift(builder);

        Console.WriteLine("\nChoose Budget:");
        Console.WriteLine("1. Economy");
        Console.WriteLine("2. Standard");
        Console.WriteLine("3. Luxury");

        Console.Write("\nYour choice: ");

        int budgetChoice = Convert.ToInt32(Console.ReadLine());

        IBudgetStrategy strategy = budgetChoice switch
        {
            1 => new EconomyStrategy(),
            2 => new StandardStrategy(),
            3 => new LuxuryStrategy(),
            _ => throw new Exception("Invalid budget.")
        };

        GiftCategoryService categoryService = new();

        bool checkout = false;

        while (!checkout)
        {
            Console.WriteLine("\nChoose Gift Category:");
            Console.WriteLine("1. Drinks");
            Console.WriteLine("2. Makeup & Beauty");
            Console.WriteLine("3. Skincare");
            Console.WriteLine("4. Books");
            Console.WriteLine("5. Tech");
            Console.WriteLine("6. Chocolate");
            Console.WriteLine("7. Flowers");

            Console.Write("\nYour choice: ");

            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            Product selectedProduct = categoryService.GetCategoryItem(categoryChoice);

            if (selectedProduct.Price <= strategy.MaxPrice)
            {
                gift.AddProduct(selectedProduct);
                Console.WriteLine($"\n✓ {selectedProduct.Name} added to your gift box.");
            }
            else
            {
                Console.WriteLine($"\n✗ {selectedProduct.Name} exceeds your selected budget.");
            }

            Console.WriteLine("\n==============================");
            Console.WriteLine("1. Add Another Gift");
            Console.WriteLine("2. Checkout");
            Console.WriteLine("==============================");

            Console.Write("\nYour choice: ");

            int nextChoice = Convert.ToInt32(Console.ReadLine());

            if (nextChoice == 2)
            {
                checkout = true;
            }
        }

        string occasion = occasionChoice switch
        {
            1 => "Graduation",
            2 => "Birthday",
            3 => "Wedding",
            4 => "New Baby",
            5 => "Mother's Day",
            6 => "Father's Day",
            _ => "Unknown"
        };

        string budget = budgetChoice switch
        {
            1 => "Economy",
            2 => "Standard",
            3 => "Luxury",
            _ => "Unknown"
        };

        Console.WriteLine("\n======================================");
        Console.WriteLine("             Gift Summary");
        Console.WriteLine("======================================");

        Console.WriteLine($"Occasion : {occasion}");
        Console.WriteLine($"Budget   : {budget}");

        Console.WriteLine("\nItems");
        Console.WriteLine("--------------------------------------");

        foreach (var product in gift.Products)
        {
            Console.WriteLine($"{product.Name} - {product.Price} SAR");
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Total Price : {gift.TotalPrice()} SAR");
        Console.WriteLine("======================================");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nError: {ex.Message}");
    }

    Console.Write("\nWould you like to create another gift box? (Y/N): ");

    string? answer = Console.ReadLine();

    if (answer?.ToUpper() != "Y")
    {
        exit = true;
    }
}

Console.WriteLine("\nThank you for using GiftCraft!");