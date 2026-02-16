namespace Decorator.Coffees;

public class HouseBlend : IBeverage
{
    public string GetDescription()
    {
        return "House Blend";
    }

    public decimal Cost()
    {
        return 0.89m;
    }
}
