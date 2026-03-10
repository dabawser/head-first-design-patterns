using FactoryMethod.Pizzas;

namespace FactoryMethod.Stores;

public class NewYorkPizzaStore : IPizzaStore
{
    public IPizza CreatePizza(string type)
    {
        return type switch
        {
            "Cheese" => new NewYorkStyleCheesePizza(),
            "Pepperoni" => new NewYorkStylePepperoniPizza(),
            "Veggie" => new NewYorkStyleVeggiePizza(),
            "Clam" => new NewYorkStyleClamPizza(),
            _ => throw new ArgumentException($"Pizza type '{type}' is not recognized."),
        };
    }
}
