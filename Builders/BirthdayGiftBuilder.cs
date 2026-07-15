using GiftCraft.Models;

namespace GiftCraft.Builders;

public class BirthdayGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.BirthdayCard);
    }
}