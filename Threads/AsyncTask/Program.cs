using System.Diagnostics;
using AsyncTask;


//we give a name to us MainThread
Thread mainThread = Thread.CurrentThread;
mainThread.Name = "PrincpalThread"; //Assign a name to mainThread
Console.WriteLine($"Estamos llamando a : {mainThread.Name}");

//start the second thread
//ThreadStart: make references to the thread that will start
//Too i can verify with "StopWhatch" how mutch delay it has
Stopwatch crono = new Stopwatch();
//Start the chronometer
crono.Start();
//----------------------------------------------------------------------------
ThreadStart refThread = new ThreadStart(MultiThreading.StartThreads);
//we init the Tasks 
var task1 = new Task(() =>
{
    //i'll start a other tread 
    Thread secundThread = new Thread(refThread);
    secundThread.Start();
});
//we init the Tasks 
var task2 = new Task(() =>
{
    //i'll start a other tread 
    Thread thirdThread = new Thread(refThread);
    thirdThread.Start();
    
});
//we init the Tasks 
var task3 = new Task(() =>
{
    //i'll start a other tread 
    Thread fourthThread = new Thread(refThread);
    fourthThread.Start();
});
//----------------------------------------------------------------------------
//we will start the task (Task:Tarea)
task1.Start();
task2.Start();
task3.Start();

//in this point 
//Task.WhenAll(task1,task2,task3);
await task1;
await task2;
await task3;
/*
* or too we can do(depends of situation) -> await task();
 * the diff between that both is what the (Task.WhenAll(task1,task2,task3);) await for that all task ended and other not await to all
 * ended and he go give the responses as soon as go out them responses (as soon as : en cuanto vaya).   
*/
//i stop the chronometer  
crono.Stop();
Console.WriteLine($"The MainThread has delay of: {crono.Elapsed}");