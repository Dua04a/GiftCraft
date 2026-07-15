using GiftCraft.Interfaces;

namespace GiftCraft.Strategies;

public class EconomyStrategy : IBudgetStrategy
{
    public decimal MaxPrice => 100;
}