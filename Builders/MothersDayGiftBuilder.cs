using GiftCraft.Models;

namespace GiftCraft.Builders;

public class MothersDayGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.MothersCard);
    }
}