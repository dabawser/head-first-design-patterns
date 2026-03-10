using SimpleFactory;

var simplePizzaFactory = new SimplePizzaFactory();
var pizzaStore = new PizzaStore(simplePizzaFactory);

var cheesePizza = pizzaStore.OrderPizza("Cheese");
Console.WriteLine($"Created pizza of type: {cheesePizza.GetType()}");

var clamPizza = pizzaStore.OrderPizza("Clam");
Console.WriteLine($"Created pizza of type: {clamPizza.GetType()}");

var pepperoniPizza = pizzaStore.OrderPizza("Pepperoni");
Console.WriteLine($"Created pizza of type: {pepperoniPizza.GetType()}");

var veggiePizza = pizzaStore.OrderPizza("Veggie");
Console.WriteLine($"Created pizza of type: {veggiePizza.GetType()}");
