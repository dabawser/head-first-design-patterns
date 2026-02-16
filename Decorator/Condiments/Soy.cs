namespace Decorator.Condiments;

public class Soy(IBeverage beverage) : ICondimentDecorator
{
    public string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }

    public decimal Cost()
    {
        return beverage.Cost() + 0.15m;
    }
}
