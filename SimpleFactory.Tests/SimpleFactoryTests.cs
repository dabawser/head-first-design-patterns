using SimpleFactory.Models;

namespace SimpleFactory.Tests;

public class SimpleFactoryTests
{
    [Theory]
    [InlineData("Cheese", typeof(CheesePizza))]
    [InlineData("Veggie", typeof(VeggiePizza))]
    [InlineData("Clam", typeof(ClamPizza))]
    [InlineData("Pepperoni", typeof(PepperoniPizza))]
    public void CreatePizza_WhenKnownPizzaType_CreatesCorrectPizzaVariant(string type, Type expectedPizzaType)
    {
        // Arrange
        var sut = new SimplePizzaFactory();

        // Act
        var actualPizza = sut.CreatePizza(type);

        // Assert
        Assert.Equal(expectedPizzaType, actualPizza.GetType());
    }

    [Fact]
    public void CreatePizza_WhenUnknownPizzaType_ThrowArgumentException()
    {
        // Arrange
        var unknownType = "Hawaiian";
        var sut = new SimplePizzaFactory();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => sut.CreatePizza(unknownType));
    }
}
