namespace FactoryMethod.Pizzas;

public class ChicagoStyleCheesePizza : IPizza
{
    public string Name => "Chicago Style Cheese Pizza";

    public string Dough => "Extra Thick Crust Dough";

    public string Sauce => "Plum Tomato Sauce";

    public List<string> Toppings => ["Shredded Mozzarella Cheese"];
}
