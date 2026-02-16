namespace Decorator.Coffees;

public class DarkRoast : IBeverage
{
    public string GetDescription()
    {
        return "Dark Roast";
    }

    public decimal Cost()
    {
        return 1.29m;
    }
}
