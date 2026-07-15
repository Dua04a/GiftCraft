using GiftCraft.Interfaces;
using GiftCraft.Models;

namespace GiftCraft.Services;

public class GiftService
{
    public GiftBox BuildGift(IGiftBuilder builder)
    {
        builder.AddCard();

        return builder.GetGiftBox();
    }
}