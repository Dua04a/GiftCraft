using GiftCraft.Models;

namespace GiftCraft.Builders;

public class WeddingGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.WeddingCard);
    }
}