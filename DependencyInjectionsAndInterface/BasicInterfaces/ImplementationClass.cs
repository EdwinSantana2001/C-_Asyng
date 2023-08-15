namespace BasicInterfaces;

public class ImplementationRequest : IRequest
{
    public void send(string value)
    {
        Console.WriteLine($"The sale of -{value}- was made");
    }
}

public class SaveProduct : ISaveProducts
{
    public void save(string product)
    {
        Console.WriteLine($"-{product}- was saved in the system");
    }
}