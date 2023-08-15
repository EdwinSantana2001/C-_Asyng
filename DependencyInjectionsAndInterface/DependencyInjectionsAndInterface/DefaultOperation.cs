namespace DependencyInjectionsAndInterface;

public class DefaultOperation : ITransientOperation , IScopedOperation, ISingletonOperation
{
    public string OperationId { get; }
}

/*
 * we'll create this class because as in a Interface we can't define since we put only the things that going to use.
 * In this class be create for define our operations. 
 */