namespace Decorator.Coffees;

public class Espresso : IBeverage
{
    public string GetDescription()
    {
        return "Espresso";
    }

    public decimal Cost()
    {
        return 1.99m;
    }
}
