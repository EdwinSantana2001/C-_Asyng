

using FuncDelegate;

FuncDelegateClass funcDelegateClass = new FuncDelegateClass();
int favoriteNumber;

Console.WriteLine("Which you favorite number?");
favoriteNumber = Convert.ToInt32(Console.ReadLine());

funcDelegateClass.FuncFunction(favoriteNumber);