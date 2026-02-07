using Strategy.Behaviors;

namespace Strategy.Models;

public class RedheadDuck() : Duck(new FlyWithWings(), new Quack())
{
    public override string Display()
    {
        return "I'm a real Redhead duck";
    }
}