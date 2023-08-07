
using System.Diagnostics;

Stopwatch crono = new Stopwatch();
//inicio de el cronometro
crono.Start();

//Tarea Principal
Thread.Sleep(1000); //Pone el hilo principal a dormir 1 seg

//Tarea 2 Principal
Thread.Sleep(1000); //Pone el hilo principal a dormir 1 seg

//Tarea 3 Principal
Thread.Sleep(1000); //Pone el hilo principal a dormir 1 seg

//Fin de cronometro
crono.Stop();
Console.WriteLine($"Este proceso demoró: {crono.Elapsed}");


