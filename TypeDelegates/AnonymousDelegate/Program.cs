


using AnonymousDelegate;

AnonymousDelegateClass delegateClass = new AnonymousDelegateClass();
int  myAge;

Console.WriteLine("Hi!, type your age please.");
myAge = Convert.ToInt32(Console.ReadLine());

delegateClass.ExampleAnonymousDelegateFunction(myAge);