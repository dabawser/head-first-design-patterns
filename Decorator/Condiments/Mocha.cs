namespace Decorator.Condiments;

public class Mocha(IBeverage beverage) : ICondimentDecorator
{
    public string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public decimal Cost()
    {
        return beverage.Cost() + 0.2m;
    }
}
