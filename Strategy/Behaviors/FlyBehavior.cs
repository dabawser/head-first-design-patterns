namespace Strategy.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public string PerformFly()
    {
        return "I'm flying!!";
    }
}

public class FlyNoWay : IFlyBehavior
{
    public string PerformFly()
    {
        return "I can't fly";
    }
}

public class FlyRocketPowered : IFlyBehavior
{
    public string PerformFly()
    {
        return "I'm flying with a rocket!";
    }
}