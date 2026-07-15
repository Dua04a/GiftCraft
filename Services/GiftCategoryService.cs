using GiftCraft.Models;

namespace GiftCraft.Services;

public class GiftCategoryService
{
    public Product GetCategoryItem(int category)
    {
        return category switch
        {
            1 => GetDrink(),
            2 => GetMakeup(),
            3 => GetSkincare(),
            4 => GetBook(),
            5 => GetTech(),
            6 => GetChocolate(),
            7 => GetFlower(),
            _ => throw new Exception("Invalid category.")
        };
    }

    private Product GetDrink()
    {
        Console.WriteLine("\nChoose a Drink Gift:");
        Console.WriteLine("1. Stanley Tumbler");
        Console.WriteLine("2. Graduation Mug");
        Console.WriteLine("3. Travel Mug");
        Console.WriteLine("4. Matcha Gift Set");
        Console.WriteLine("5. Tea Collection");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.StanleyCup,
            2 => ProductCatalog.GraduationMug,
            3 => ProductCatalog.TravelMug,
            4 => ProductCatalog.MatchaSet,
            5 => ProductCatalog.TeaCollection,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetMakeup()
    {
        Console.WriteLine("\nChoose a Makeup Gift:");
        Console.WriteLine("1. Luxury Lipstick");
        Console.WriteLine("2. Eyeshadow Palette");
        Console.WriteLine("3. Makeup Brush Set");
        Console.WriteLine("4. Makeup Organizer");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.Lipstick,
            2 => ProductCatalog.EyeshadowPalette,
            3 => ProductCatalog.MakeupBrushSet,
            4 => ProductCatalog.MakeupOrganizer,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetSkincare()
    {
        Console.WriteLine("\nChoose a Skincare Gift:");
        Console.WriteLine("1. Skincare Gift Set");
        Console.WriteLine("2. Face Mask Collection");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.SkincareSet,
            2 => ProductCatalog.FaceMaskSet,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetBook()
    {
        Console.WriteLine("\nChoose a Book Gift:");
        Console.WriteLine("1. Best Seller Novel");
        Console.WriteLine("2. Daily Planner");
        Console.WriteLine("3. Reading Journal");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.Novel,
            2 => ProductCatalog.Planner,
            3 => ProductCatalog.ReadingJournal,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetTech()
    {
        Console.WriteLine("\nChoose a Tech Gift:");
        Console.WriteLine("1. AirTag");
        Console.WriteLine("2. Power Bank");
        Console.WriteLine("3. Wireless Charger");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.AirTag,
            2 => ProductCatalog.PowerBank,
            3 => ProductCatalog.WirelessCharger,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetChocolate()
    {
        Console.WriteLine("\nChoose Chocolate:");
        Console.WriteLine("1. Lindt");
        Console.WriteLine("2. Ferrero");
        Console.WriteLine("3. Patchi");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.Lindt,
            2 => ProductCatalog.Ferrero,
            3 => ProductCatalog.Patchi,
            _ => throw new Exception("Invalid choice.")
        };
    }

    private Product GetFlower()
    {
        Console.WriteLine("\nChoose Flowers:");
        Console.WriteLine("1. White Tulips");
        Console.WriteLine("2. Pink Roses");
        Console.WriteLine("3. White Roses");
        Console.WriteLine("4. Luxury Bouquet");

        Console.Write("\nYour choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => ProductCatalog.WhiteTulips,
            2 => ProductCatalog.PinkRoses,
            3 => ProductCatalog.WhiteRoses,
            4 => ProductCatalog.LuxuryBouquet,
            _ => throw new Exception("Invalid choice.")
        };
    }
}