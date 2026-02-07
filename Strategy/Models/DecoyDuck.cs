using Strategy.Behaviors;

namespace Strategy.Models;

public class DecoyDuck() : Duck(new FlyNoWay(), new MuteQuack())
{
    public override string Display()
    {
        return "I'm a decoy duck";
    }
}