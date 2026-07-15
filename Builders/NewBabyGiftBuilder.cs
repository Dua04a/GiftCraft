using GiftCraft.Models;

namespace GiftCraft.Builders;

public class NewBabyGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.BabyCard);
    }
}