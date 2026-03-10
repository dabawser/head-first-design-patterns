namespace FactoryMethod.Pizzas;

public class ChicagoStylePepperoniPizza : IPizza
{
    public string Name => "Chicago Style Pepperoni Pizza";

    public string Dough => "Extra Thick Crust Dough";

    public string Sauce => "Plum Tomato Sauce";

    public List<string> Toppings => ["Shredded Mozzarella Cheese", "Sliced Pepperoni"];
}
