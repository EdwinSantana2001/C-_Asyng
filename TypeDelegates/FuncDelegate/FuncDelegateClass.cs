namespace FuncDelegate;

public class FuncDelegateClass
{
    public void FuncFunction(int value)
    {
        Func<int, string> FuncDelegate = func => $"Your favorite number is: {func}";
        Console.WriteLine(FuncDelegate(value));
    }

}