namespace AnonymousDelegate;
/*
 * Hi again!, we´ll see another delegate function in this chance the Anonymous function using
 * Action since this is a pre made delegate.
 *
 * well, now we can see that the Action yes we define with "delegate" word since
 * we'll go to have a object like function take the form of a function this is a anonymous function
 */
public class AnonymousDelegateClass
{
    //we make a class because if not make it, we can't call to the anonymous function.
    public void ExampleAnonymousDelegateFunction(int age)
    {
        Action<int> printWithActions = delegate(int ages)
        {
            Console.WriteLine($"Your age receive from anonymousDelegateClass is: {ages}");
        };
        printWithActions(age);
    }
} 
/*  we can see that the object is define with the parameters that he going to receive since that is a anonymous function and need in this
 *  case receive something although it can or not receive something.
 */