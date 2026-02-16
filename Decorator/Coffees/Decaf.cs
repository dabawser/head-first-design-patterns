namespace Decorator.Coffees;

public class Decaf : IBeverage
{
    public string GetDescription()
    {
        return "Decaf";
    }

    public decimal Cost()
    {
        return 1.05m;
    }
}
