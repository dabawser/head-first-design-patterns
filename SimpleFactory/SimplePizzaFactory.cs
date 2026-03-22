using SimpleFactory.Models;

namespace SimpleFactory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        return type switch
        {
            "Cheese" => new CheesePizza(),
            "Veggie" => new VeggiePizza(),
            "Clam" => new ClamPizza(),
            "Pepperoni" => new PepperoniPizza(),
            _ => throw new ArgumentException("Invalid pizza type"),
        };
    }
}
