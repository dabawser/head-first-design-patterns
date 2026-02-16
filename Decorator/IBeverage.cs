namespace Decorator;

/// <summary>
/// The Beverage interface defines the methods that all concrete beverages and decorators must implement.
/// </summary>
public interface IBeverage
{
    /// <summary>
    /// GetDescription returns a string description of the beverage, including any added condiments.
    /// </summary>
    string GetDescription();

    /// <summary>
    /// Cost returns the cost of the beverage, including any added condiments.
    /// </summary>
    decimal Cost();
}
