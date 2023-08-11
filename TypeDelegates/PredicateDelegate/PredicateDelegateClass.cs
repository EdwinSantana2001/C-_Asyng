namespace PredicateDelegate;
/*
 * The predicate too is a delegate pre made.
 * This delegate is of a boolean type since it'll return true or false.
 */
public class PredicateDelegateClass
{
    public void PredicateDelegateFunction(int age)
    {
        Predicate<int> predicate = Age => Age >=18;
        bool adult = predicate(age);
        Console.WriteLine($"Your are adult? :{adult}");
    }
}