namespace DependencyInjectionsAndInterface;

public class LoggerOperation
{
    private readonly ITransientOperation _transientOperation;
    private readonly IScopedOperation    _scopedOperation;
    private readonly ISingletonOperation _singletonOperation;

    public LoggerOperation(    
        ITransientOperation transientOperation,
        IScopedOperation    scopedOperation,
        ISingletonOperation singletonOperation)=>
        (_transientOperation,_scopedOperation,_singletonOperation) = (transientOperation,scopedOperation,singletonOperation);

    public void LogOperations(string scope)
    {
        LogOperation(_transientOperation,scope,$"Desde TransientOperation");
        LogOperation(_scopedOperation,scope,$"Desde ScopeOperacion");
        LogOperation(_singletonOperation,scope,$"Desde SingletonOperation");
    }
    
    private static void LogOperation<T>(T operation, string scope, string message)
        where T : IOperation =>
        Console.WriteLine(
            $"{scope}: {typeof(T).Name} [{operation.OperationId} -- {message}]"
            );




}