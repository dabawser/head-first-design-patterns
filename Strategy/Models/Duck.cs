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
    private IFlyBehavior _flyBehavior = flyBehavior;
    private IQuackBehavior _quackBehavior = quackBehavior;

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        _quackBehavior = quackBehavior;
    }
    
    public string PerformFly()
    {
        return _flyBehavior.PerformFly();
    }

    public string PerformQuack()
    {
        return _quackBehavior.PerformQuack();
    }

    public string Swim()
    {
        return "All ducks float!";
    }

    public abstract string Display();
}