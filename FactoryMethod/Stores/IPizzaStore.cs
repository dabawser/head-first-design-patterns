using FactoryMethod.Pizzas;

namespace FactoryMethod.Stores;

/// <summary>
/// The IPizzaStore interface defines the contract for pizza stores.
/// </summary>
public interface IPizzaStore
{
    /// <summary>
    /// Orders a pizza of given type.
    /// </summary>
    IPizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    /// <summary>
    /// Creates a pizza of given type.
    /// </summary>
    protected IPizza CreatePizza(string type);
}
