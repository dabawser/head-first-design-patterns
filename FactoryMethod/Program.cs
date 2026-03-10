using FactoryMethod.Stores;

IPizzaStore newYorkPizzaStore = new NewYorkPizzaStore();
IPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

Console.WriteLine();
newYorkPizzaStore.OrderPizza("Cheese");

Console.WriteLine();
chicagoPizzaStore.OrderPizza("Pepperoni");
