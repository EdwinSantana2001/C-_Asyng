//Implementations of the interfaces

using BasicInterfaces;

ImplementationRequest request = new ImplementationRequest();
string value;
int action;

Console.WriteLine("What do you want to do?");
Console.WriteLine("Enter 1 for sale or Enter 2 for save a product");
action = Convert.ToInt32(Console.ReadLine()); //parse to int

switch (action)
{
    case 1 : 
        Console.WriteLine("Enter the product that you will sale");
        value = Console.ReadLine();
        request.send(value);
        break;
    case 2 : 
        Console.WriteLine("what product will you save?");
        value = Console.ReadLine();
        break;
    default:
        Console.WriteLine("oops!, Type a number valid");
        break;
}




