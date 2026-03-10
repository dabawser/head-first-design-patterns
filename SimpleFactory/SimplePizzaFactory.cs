using SimpleFactory.Models;

namespace SimpleFactory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "Cheese":
                return new CheesePizza();
            case "Veggie":
                return new VeggiePizza();
            case "Clam":
                return new ClamPizza();
            case "Pepperoni":
                return new PepperoniPizza();
            default:
                throw new ArgumentException("Invalid pizza type");
        }
    }
}
