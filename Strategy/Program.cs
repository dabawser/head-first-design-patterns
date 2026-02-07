using Strategy.Models;

var mallardDuck = new MallardDuck();
Console.WriteLine($"{nameof(MallardDuck)}:");
Console.WriteLine(mallardDuck.Display());
Console.WriteLine(mallardDuck.PerformFly());
Console.WriteLine(mallardDuck.PerformQuack());
Console.WriteLine(mallardDuck.Swim());
Console.WriteLine();

var redheadDuck = new RedheadDuck();
Console.WriteLine($"{nameof(RedheadDuck)}:");
Console.WriteLine(redheadDuck.Display());
Console.WriteLine(redheadDuck.PerformFly());
Console.WriteLine(redheadDuck.PerformQuack());
Console.WriteLine(redheadDuck.Swim());
Console.WriteLine();

var rubberDuck = new RubberDuck();
Console.WriteLine($"{nameof(RubberDuck)}:");
Console.WriteLine(rubberDuck.Display());
Console.WriteLine(rubberDuck.PerformFly());
Console.WriteLine(rubberDuck.PerformQuack());
Console.WriteLine(rubberDuck.Swim());
Console.WriteLine();

var decoyDuck = new DecoyDuck();
Console.WriteLine($"{nameof(DecoyDuck)}:");
Console.WriteLine(decoyDuck.Display());
Console.WriteLine(decoyDuck.PerformFly());
Console.WriteLine(decoyDuck.PerformQuack());
Console.WriteLine(decoyDuck.Swim());
