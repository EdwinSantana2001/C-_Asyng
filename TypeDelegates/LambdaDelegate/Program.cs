
using LambdaDelegate;

LambdaDelegateClass lambdaDelegateClass = new LambdaDelegateClass();
string mother, father;

Console.WriteLine("What is the name of your parents?");
Console.WriteLine("Mother: ");
mother = Console.ReadLine();
Console.WriteLine("Father: ");
father = Console.ReadLine();

lambdaDelegateClass.ExampleLambdaDelegate(mother,father);