using System.Diagnostics;
using MultiThreading;



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

ThreadStart refThread = new ThreadStart(MakerThreads.StartThreads);

//i'll start a other tread 
Thread secundThread = new Thread(refThread);
secundThread.Start();

//i'll start a other tread 
Thread thirdThread = new Thread(refThread);
thirdThread.Start();

//i'll start a other tread 
Thread fourthThread = new Thread(refThread);
fourthThread.Start();

//i stop the chronometer  
crono.Stop();
Console.WriteLine($"The MainThread has delay of: {crono.Elapsed}");