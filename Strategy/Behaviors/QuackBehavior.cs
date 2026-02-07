namespace Strategy.Behaviors;

public class Quack : IQuackBehavior
{
    public string PerformQuack()
    {
        return "Quack";
    }
}

public class Squeak : IQuackBehavior
{
    public string PerformQuack()
    {
        return "Squeak";
    }
}

public class MuteQuack : IQuackBehavior
{
    public string PerformQuack()
    {
        return "<< Silence >>";
    }
}
