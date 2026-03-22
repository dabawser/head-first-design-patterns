namespace FactoryMethod.Pizzas;

public class NewYorkStylePepperoniPizza : IPizza
{
    public string Name => "New York Style Pepperoni Pizza";

    public string Dough => "Thin Crust Dough";

    public string Sauce => "Marinara Sauce";

    public List<string> Toppings => ["Grated Reggiano Cheese", "Sliced Pepperoni"];
}
