using FactoryMethod.Pizzas;

namespace FactoryMethod.Stores;

public class ChicagoPizzaStore : IPizzaStore
{
    public IPizza CreatePizza(string type)
    {
        return type switch
        {
            "Cheese" => new ChicagoStyleCheesePizza(),
            "Pepperoni" => new ChicagoStylePepperoniPizza(),
            "Veggie" => new ChicagoStyleVeggiePizza(),
            "Clam" => new ChicagoStyleClamPizza(),
            _ => throw new ArgumentException($"Pizza type '{type}' is not recognized."),
        };
    }
}
