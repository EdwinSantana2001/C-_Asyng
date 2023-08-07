using System.Diagnostics;

namespace AsyncTask;

public class MultiThreading
{
    public static void StartThreads(){
        Stopwatch crono4 = new Stopwatch();
        crono4.Start();
        Console.WriteLine($"Iniciando hilo nuevo");
        Thread.Sleep(1000);
        Console.WriteLine($"Finalizando Tareas");
        crono4.Stop();
        Console.WriteLine($"The chronometer of the second thread has {crono4.Elapsed} of delay");

    }
}