

using PredicateDelegate;

PredicateDelegateClass predicateDelegateClass = new PredicateDelegateClass();
int adultAge;

Console.WriteLine("Hello!, you are adult?");
Console.WriteLine("Type your age here");
adultAge = Convert.ToInt32(Console.ReadLine());

predicateDelegateClass.PredicateDelegateFunction(adultAge);