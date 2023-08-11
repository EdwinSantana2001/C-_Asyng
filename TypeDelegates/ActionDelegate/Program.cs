// See https://aka.ms/new-console-template for more information


using ActionDelegates;

ActionDelegateClass actionDelegateClass = new ActionDelegateClass();
string message;

Console.WriteLine($"What is the message that you want share to the creator?");
Console.WriteLine($"Write here!");
message = Console.ReadLine();

actionDelegateClass.ActionDelegateExample($"The message is: {message}");
