using GiftCraft.Interfaces;

namespace GiftCraft.Strategies;

public class LuxuryStrategy : IBudgetStrategy
{
    public decimal MaxPrice => decimal.MaxValue;
}