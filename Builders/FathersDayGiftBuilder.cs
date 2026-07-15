using GiftCraft.Models;

namespace GiftCraft.Builders;

public class FathersDayGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.FathersCard);
    }
}