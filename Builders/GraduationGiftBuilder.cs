using GiftCraft.Models;

namespace GiftCraft.Builders;

public class GraduationGiftBuilder : BaseGiftBuilder
{
    public override void AddCard()
    {
        giftBox.AddProduct(ProductCatalog.GraduationCard);
    }
}