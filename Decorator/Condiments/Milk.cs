namespace Decorator.Condiments;

public class Milk(IBeverage beverage) : ICondimentDecorator
{
    public string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }

    public decimal Cost()
    {
        return beverage.Cost() + 0.19m;
    }
}
