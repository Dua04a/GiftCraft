using GiftCraft.Interfaces;

namespace GiftCraft.Strategies;

public class StandardStrategy : IBudgetStrategy
{
    public decimal MaxPrice => 180;
}