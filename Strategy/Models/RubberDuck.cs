using Strategy.Behaviors;

namespace Strategy.Models;

public class RubberDuck() : Duck(new FlyNoWay(), new Squeak())
{
    public override string Display()
    {
        return "I'm a rubber duckie";
    }
}
