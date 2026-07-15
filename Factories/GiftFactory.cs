using GiftCraft.Builders;
using GiftCraft.Interfaces;

namespace GiftCraft.Factories;

public static class GiftFactory
{
    public static IGiftBuilder CreateGiftBuilder(int choice)
    {
        return choice switch
        {
            1 => new GraduationGiftBuilder(),
            2 => new BirthdayGiftBuilder(),
            3 => new WeddingGiftBuilder(),
            4 => new NewBabyGiftBuilder(),
            5 => new MothersDayGiftBuilder(),
            6 => new FathersDayGiftBuilder(),
            _ => throw new Exception("Invalid choice.")
        };
    }
}