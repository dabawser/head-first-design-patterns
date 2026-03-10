using FactoryMethod.Pizzas;
using FactoryMethod.Stores;

namespace FactoryMethod.Tests;

public class PizzaStoreTests
{
    [Theory]
    [InlineData("Cheese", typeof(NewYorkStyleCheesePizza))]
    [InlineData("Pepperoni", typeof(NewYorkStylePepperoniPizza))]
    [InlineData("Veggie", typeof(NewYorkStyleVeggiePizza))]
    [InlineData("Clam", typeof(NewYorkStyleClamPizza))]
    public void NewYorkPizzaStore_ShouldCreateNewYorkStylePizza(
        string pizzaType, Type expectedPizzaType)
    {
        // Arrange
        IPizzaStore pizzaStore = new NewYorkPizzaStore();

        // Act
        var pizza = pizzaStore.OrderPizza(pizzaType);

        // Assert
        Assert.Equal(expectedPizzaType, pizza.GetType());
    }

    [Theory]
    [InlineData("Cheese", typeof(ChicagoStyleCheesePizza))]
    [InlineData("Pepperoni", typeof(ChicagoStylePepperoniPizza))]
    [InlineData("Veggie", typeof(ChicagoStyleVeggiePizza))]
    [InlineData("Clam", typeof(ChicagoStyleClamPizza))]
    public void ChicagoPizzaStore_ShouldCreateNewYorkStylePizza(
        string pizzaType, Type expectedPizzaType)
    {
        // Arrange
        IPizzaStore pizzaStore = new ChicagoPizzaStore();

        // Act
        var pizza = pizzaStore.OrderPizza(pizzaType);

        // Assert
        Assert.Equal(expectedPizzaType, pizza.GetType());
    }
}
