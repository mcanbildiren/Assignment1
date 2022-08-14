using Assignment1.SOLID.LıskovSubstitution;

// Liskov Substitution Bad Example
Console.WriteLine("Liskov Substitution Bad Example");
AppleBadExampleLS apple = new Orange();
Console.WriteLine(apple.GetColor());

Console.WriteLine("----------------------");

// Liskov Substitution Good Example
Console.WriteLine("Liskov Substitution Good Example");
AppleGoodExampleLS fruit = new OrangeGood();
Console.WriteLine(fruit.GetColor());
fruit = new AppleGood();
Console.WriteLine(fruit.GetColor());

