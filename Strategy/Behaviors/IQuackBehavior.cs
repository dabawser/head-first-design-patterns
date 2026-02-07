namespace Strategy.Behaviors;

/// <summary>
/// The IQuackBehavior interface defines the contract for quack behaviors that can be assigned to ducks.
/// </summary>
public interface IQuackBehavior
{
    /// <summary>
    /// The PerformQuack method is the method that will be called by the Duck class to perform the quack behavior. It
    /// returns a string that describes the quack behavior.
    /// </summary>
    string PerformQuack();
}
