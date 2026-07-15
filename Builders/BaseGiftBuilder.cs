using GiftCraft.Interfaces;
using GiftCraft.Models;

namespace GiftCraft.Builders;

public abstract class BaseGiftBuilder : IGiftBuilder
{
    protected GiftBox giftBox = new();

    public virtual void AddCard()
    {
    }

    public GiftBox GetGiftBox()
    {
        return giftBox;
    }
}