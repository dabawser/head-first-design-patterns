using Strategy.Behaviors;

namespace Strategy.Models;

/// <summary>
/// The Duck class is an abstract class that represents a duck. It has two behaviors: fly behavior and quack behavior.
/// The fly behavior is represented by the IFlyBehavior interface, and the quack behavior is represented by the
/// IQuackBehavior interface. The Duck class has a constructor that takes in the fly behavior and quack behavior as
/// parameters and assigns them to the respective fields. The Duck class also has methods to perform the fly and quack
/// behaviors, as well as a method to swim and an abstract method to display the duck's appearance.
/// </summary>
public abstract class Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
{
    public string PerformFly()
    {
        return flyBehavior.PerformFly();
    }

    public string PerformQuack()
    {
        return quackBehavior.PerformQuack();
    }

    public string Swim()
    {
        return "All ducks float!";
    }

    public abstract string Display();
}