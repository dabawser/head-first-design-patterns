namespace Decorator.Condiments;

public class Whip(IBeverage beverage) : ICondimentDecorator
{
    public string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }

    public decimal Cost()
    {
        return beverage.Cost() + 0.1m;
    }
}
