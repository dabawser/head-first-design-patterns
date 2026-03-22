namespace FactoryMethod.Pizzas;

public class ChicagoStyleVeggiePizza : IPizza
{
    public string Name => "Chicago Style Veggie Pizza";

    public string Dough => "Extra Thick Crust Dough";

    public string Sauce => "Plum Tomato Sauce";

    public List<string> Toppings => ["Shredded Mozzarella Cheese", "Black Olives", "Spinach", "Eggplant"];
}
