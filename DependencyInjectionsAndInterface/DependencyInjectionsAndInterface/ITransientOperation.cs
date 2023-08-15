namespace DependencyInjectionsAndInterface;

//we go make a inherit of IOperation
public interface ITransientOperation : IOperation 
{
    
}
/*Transient: Transitorio > Operación transitoria
 *  Transient operation: Is an Object that is created one time is start the service 
 *      and it is rewrite each time that the service is called.
 */