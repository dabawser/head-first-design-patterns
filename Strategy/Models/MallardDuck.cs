using Strategy.Behaviors;

namespace Strategy.Models;

public class MallardDuck() : Duck(new FlyWithWings(), new Quack())
{
    public override string Display()
    {
        return "I'm a real Mallard duck";
    }
}