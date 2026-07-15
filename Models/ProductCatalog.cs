namespace GiftCraft.Models;

public static class ProductCatalog
{
    // ===== Flowers =====
    public static Product WhiteTulips =>
        new("White Tulips Bouquet", 85, "Flowers");

    public static Product PinkRoses =>
        new("Pink Roses Bouquet", 110, "Flowers");

    public static Product WhiteRoses =>
        new("White Roses Bouquet", 120, "Flowers");

    public static Product LuxuryBouquet =>
        new("Luxury Flower Bouquet", 190, "Flowers");


    // ===== Chocolate =====
    public static Product Lindt =>
        new("Lindt Chocolate Box", 55, "Chocolate");

    public static Product Ferrero =>
        new("Ferrero Rocher", 45, "Chocolate");

    public static Product Patchi =>
        new("Patchi Chocolate Box", 95, "Chocolate");


    // ===== Drinks =====
    public static Product GraduationMug =>
        new("Graduation Mug", 65, "Drinks");

    public static Product TravelMug =>
        new("Travel Mug", 80, "Drinks");

    public static Product StanleyCup =>
        new("Stanley Tumbler", 180, "Drinks");

    public static Product MatchaSet =>
        new("Matcha Gift Set", 140, "Drinks");

    public static Product TeaCollection =>
        new("Tea Collection", 95, "Drinks");


    // ===== Makeup & Beauty =====
    public static Product Lipstick =>
        new("Luxury Lipstick", 145, "Makeup");

    public static Product EyeshadowPalette =>
        new("Eyeshadow Palette", 220, "Makeup");

    public static Product MakeupBrushSet =>
        new("Makeup Brush Set", 180, "Makeup");

    public static Product MakeupOrganizer =>
        new("Makeup Organizer", 95, "Makeup");


    // ===== Skincare =====
    public static Product SkincareSet =>
        new("Skincare Gift Set", 210, "Skincare");

    public static Product FaceMaskSet =>
        new("Face Mask Collection", 65, "Skincare");


    // ===== Books =====
    public static Product Novel =>
        new("Best Seller Novel", 80, "Books");

    public static Product Planner =>
        new("Daily Planner", 65, "Books");

    public static Product ReadingJournal =>
        new("Reading Journal", 55, "Books");


    // ===== Tech =====
    public static Product AirTag =>
        new("Apple AirTag", 149, "Tech");

    public static Product PowerBank =>
        new("Power Bank", 120, "Tech");

    public static Product WirelessCharger =>
        new("Wireless Charger", 160, "Tech");


    // ===== Home =====
    public static Product VanillaCandle =>
        new("Vanilla Scented Candle", 75, "Home");

    public static Product LavenderCandle =>
        new("Lavender Candle", 85, "Home");

    public static Product ReedDiffuser =>
        new("Reed Diffuser", 95, "Home");


    // ===== Baby =====
    public static Product BabyCareSet =>
        new("Baby Care Set", 180, "Baby");

    public static Product BabyBlanket =>
        new("Soft Baby Blanket", 95, "Baby");

    public static Product BabyToy =>
        new("Baby Plush Toy", 60, "Baby");


    // ===== Perfumes =====
    public static Product MiniPerfume =>
        new("Mini Perfume", 120, "Perfume");

    public static Product LuxuryPerfume =>
        new("Luxury Perfume", 220, "Perfume");

    public static Product BodyMist =>
        new("Body Mist", 90, "Perfume");


    // ===== Cards =====
    public static Product GraduationCard =>
        new("Graduation Card", 15, "Card");

    public static Product BirthdayCard =>
        new("Birthday Card", 15, "Card");

    public static Product WeddingCard =>
        new("Wedding Card", 20, "Card");

    public static Product BabyCard =>
        new("Welcome Baby Card", 15, "Card");

    public static Product MothersCard =>
        new("Mother's Day Card", 20, "Card");

    public static Product FathersCard =>
        new("Father's Day Card", 20, "Card");
}