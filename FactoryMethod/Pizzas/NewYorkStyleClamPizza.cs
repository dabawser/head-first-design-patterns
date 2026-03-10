namespace FactoryMethod.Pizzas;

public class NewYorkStyleClamPizza : IPizza
{
    public string Name => "New York Style Clam Pizza";

    public string Dough => "Thin Crust Dough";

    public string Sauce => "Marinara Sauce";

    public List<string> Toppings => ["Grated Reggiano Cheese", "Fresh Clams from Long Island Sound"];
}
