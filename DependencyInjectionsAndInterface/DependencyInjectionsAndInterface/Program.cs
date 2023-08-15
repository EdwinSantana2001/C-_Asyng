// Injection of dependencies


using DependencyInjectionsAndInterface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_,services)=> 
        services
            .AddTransient<ITransientOperation,DefaultOperation>()
            .AddScoped<IScopedOperation,DefaultOperation>()
            .AddSingleton<ISingletonOperation,DefaultOperation>()
            .AddTransient<LoggerOperation>())
    .Build();

ScopeExample(host.Services,"Scope 1");

await host.StartAsync(); //start async

static void ScopeExample(IServiceProvider services, string scope)
{
    IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    LoggerOperation loggerOperation = provider.GetRequiredService<LoggerOperation>();
    loggerOperation.LogOperations($"{scope} -- executing... GetRequiredService<LoggerOperation>()"); //for know, when we have arrived here.  
    Console.WriteLine();
    
    loggerOperation = provider.GetRequiredService<LoggerOperation>();
    loggerOperation.LogOperations($"{scope} -- executing... GetRequiredService<LoggerOperation>()");
    Console.WriteLine();
} 


