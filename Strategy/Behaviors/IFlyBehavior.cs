namespace Strategy.Behaviors;

/// <summary>
/// The IFlyBehavior interface defines the contract for fly behaviors that can be assigned to ducks.
/// </summary>
public interface IFlyBehavior
{
    /// <summary>
    /// The PerformFly method is the method that will be called by the Duck class to perform the fly behavior. It
    /// returns a string that describes the fly behavior.
    /// </summary>
    string PerformFly();
}