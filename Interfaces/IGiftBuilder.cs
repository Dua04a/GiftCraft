using GiftCraft.Models;

namespace GiftCraft.Interfaces;

public interface IGiftBuilder
{
    void AddCard();

    GiftBox GetGiftBox();
}