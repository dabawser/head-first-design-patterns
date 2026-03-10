namespace FactoryMethod.Pizzas;

public class NewYorkStyleCheesePizza : IPizza
{
    public string Name => "New York Style Cheese Pizza";

    public string Dough => "Thin Crust Dough";

    public string Sauce => "Marinara Sauce";

    public List<string> Toppings => ["Grated Reggiano Cheese"];
}
