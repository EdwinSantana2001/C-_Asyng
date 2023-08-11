namespace TypeDelegates;

/* DELEGATES: One delegate is a references to a method  
    First i'll create a custom delegate 
*/ 
public class Delegates
{
    private delegate void PrintDelegate(string value);
    
    private void PrintResoponse(string value) 
    { 
        Console.WriteLine($"i have received that your name is: {value}");
    } 
    public void DelegateExample(string value)
    {
        //Declaration object of type delegate called "printDelegate" that too receive one param of type String  
        var printDelegate = new PrintDelegate(PrintResoponse);
        //Now i'll to made the invoke/call
        printDelegate(value);
    }
}
/*Note.
 * 1-   In the public method, be initialize the Object->delegate, we give it a name and it receive private method that need
 *      any delegate (permission).
 *
 * 2-   we are going to use the name of the initialize for give it access to user and too we going pass the value that the method need
 *      that in turn too receive a parameter. 
 * */