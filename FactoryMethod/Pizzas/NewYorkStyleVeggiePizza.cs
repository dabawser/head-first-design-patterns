namespace FactoryMethod.Pizzas;

public class NewYorkStyleVeggiePizza : IPizza
{
    public string Name => "New York Style Veggie Pizza";

    public string Dough => "Thin Crust Dough";

    public string Sauce => "Marinara Sauce";

    public List<string> Toppings => ["Grated Reggiano Cheese", "Garlic", "Onion", "Mushrooms", "Red Pepper"];
}
