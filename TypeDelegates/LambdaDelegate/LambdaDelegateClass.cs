namespace LambdaDelegate;
/*
 * Now with Lambda expression the lambda is easy to recognize for the (=>), ok, we can see
 * that the "Action<List<string>>" (that is a delegate pre made)[is of type List because
 * receive more of 1 parameter].
 * before assign him the variable parent that going to save the response of the Lambda.
 *
 * too we can see that i am initialize a string variable like null because after i'll
 * give him value with the response 
 */
public class LambdaDelegateClass
{
    public void ExampleLambdaDelegate(string mother,string father)
    {
        List<string> parents = null;
        
        Action<List<string>> printParentsWithLambda = parents => 
            Console.WriteLine($"Your mother is named: {mother} " +
                              $"and your father name is: {father}");
        printParentsWithLambda(parents);
    }
}