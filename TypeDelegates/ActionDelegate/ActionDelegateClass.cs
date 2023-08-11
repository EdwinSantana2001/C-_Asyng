namespace ActionDelegates;

/*Hello guys!!
 *in this chance we'll be watching the first of delegates pre made that is Action<> . 
 * Note.
 * we were not used the delegate Word because the Action<> is a pre made delegate since the
 * program assume that is a delegate .
 */
public class ActionDelegateClass
{
    
    private void PrivatePrint(string message)
    {
        Console.WriteLine(message);
    }

    public void ActionDelegateExample(string publicMessenger)
    {
        Action<string> printDelegateAction = PrivatePrint;
        printDelegateAction(publicMessenger);
    }
}
/*
 * 1-   one more time we use the private function
 * 2-   like in the before example, we give permission in the public function of the class
 *      "ActionDelegateClass" for the any person from my MainFunction named "program.cs"
 *      can called to my private function through my public delegate. 
 */