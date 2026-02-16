using Decorator.Coffees;
using Decorator.Condiments;

var darkRoast = new DarkRoast();
var darkRoastWithMilk = new Milk(darkRoast);
var darkRoastWithMilkAndMocha = new Mocha(darkRoastWithMilk);

Console.WriteLine("****** Coffee Order Nr. 1 ******");
Console.WriteLine($"{darkRoastWithMilkAndMocha.GetDescription()}");
Console.WriteLine($"Price: ${darkRoastWithMilkAndMocha.Cost()}");
Console.WriteLine("********************************");
Console.WriteLine();

var espresso = new Espresso();
var espressoWithMilk = new Milk(espresso);
var espressoWithMilkAndMocha = new Mocha(espressoWithMilk);
var espressoWithMilkAndMochaAndSoy = new Soy(espressoWithMilkAndMocha);
var espressoWithMilkAndMochaAndSoyAndWhip = new Whip(espressoWithMilkAndMochaAndSoy);

Console.WriteLine("****** Coffee Order Nr. 2 ******");
Console.WriteLine($"{espressoWithMilkAndMochaAndSoyAndWhip.GetDescription()}");
Console.WriteLine($"Price: ${espressoWithMilkAndMochaAndSoyAndWhip.Cost()}");
Console.WriteLine("********************************");
Console.WriteLine();
