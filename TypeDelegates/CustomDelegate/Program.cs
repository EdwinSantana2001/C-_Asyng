

//We going call to Delegates method

using TypeDelegates;

Delegates delegates = new Delegates();
String valueName;

Console.WriteLine("What is your name?");
valueName = Console.ReadLine();
delegates.DelegateExample(valueName);