namespace FactoryMethod.Pizzas;

/// <summary>
/// The <see cref="IPizza"/> interface defines the operations that pizzas can perform.
/// </summary>
public interface IPizza
{
    /// <summary>
    /// Name of pizza.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Pizza dough.
    /// </summary>
    string Dough { get; }

    /// <summary>
    /// Pizza sauce.
    /// </summary>
    string Sauce { get; }

    /// <summary>
    /// List of pizza toppings.
    /// </summary>
    List<string> Toppings { get; }

    /// <summary>
    /// Prepare pizza.
    /// </summary>
    void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Console.WriteLine($"Rolling {Dough}");
        Console.WriteLine($"Spreading {Sauce}");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($"   {topping}");
        }
    }

    /// <summary>
    /// Bake pizza.
    /// </summary>
    void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350 degrees");
    }

    /// <summary>
    /// Cut pizza.
    /// </summary>
    void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    /// <summary>
    /// Box pizza.
    /// </summary>
    void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}
