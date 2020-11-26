# EasyDI in .Net core 
What if you could register your DI services inside your service interface just like this 

```c#
[InjectThisServiceAs(ServiceLifetime.Transient)]
public interface IServiceA
{
    void Do();
}
```
well you can :) 

Install [**EasyDI**](https://www.nuget.org/packages/EasyDI) package  
```bash
dotnet add package EasyDI
```

And then just add this line to your ConfigureService method of your Startup.cs like this

```c#
services.AddAnnotatedServices(typeof(Startup));
```
and you are good to go. In every service interface by using the **InjectThisServiceAs** annotation and passing your desired service lifetime, your service will be automatically registered in the dotnet core DI engine, isn't it cool :)

>checkout the source code [**here**](https://github.com/alicommit-malp/EasyDI)

>install the Nuget package from [**here**](https://www.nuget.org/packages/EasyDI)

## Why EasyDI ?
### 1. To solve the forgotten service in DI registry
you only need to add the 

```c#
services.AddAnnotatedServices(typeof(Startup));
```
onetime and afterwards your job with the Startup.cs for typical service registering is done.
How many times have you run your .Net core application and then **boom!** you got an error message like this

```
System.InvalidOperationException: Unable to resolve service for type ... 
 at Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetService(IServiceProvider sp, ...
```
And after checking out your code you figured out that  the reason was that **you have forgot to register your service(s) to the DI engine.** This can be so annoying sometimes considering that you have already coded your service interface and its implementation and even used it by constructor injection in your controller or another service 

```c#
public interface IServiceA
{
    void Do();
}

public class ServiceA :IServiceA
{
    void Do(){
        // implementation 
    }
}

public class TestController : ControllerBase
{
    private readonly IServiceA _serviceA;

    public TestController(IServiceA serviceA)
    {
        _serviceA = serviceA;
    }
}
```
**And the only missing part of the puzzle was**
```c#

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        ...
        services.AddScoped<IServiceA, ServiceA>();
        ...
    }
}
```

#### 2. To solve the service registry hell issue 
After your application begin to grow, you will need to add more and more services to your application to take care of the new functionalities. However, as you add more services to the application you need to register them in DI as well somewhere in the Startup.cs or an extension class. No matter how clean you try to be in terms of the folder structure and naming, after a while you end up having a class with hundreds of line like this 

```c#
services.AddTransient<IServiceA, ServiceA>();
services.AddScoped<IServiceB, ServiceB>();
services.AddSingleton<IServiceC, ServiceC>();
services.AddScoped<IServiceD, ServiceD>();
services.AddScoped<IServiceE, ServiceE>();
services.AddScoped<IServiceF, ServiceF>();
services.AddScoped<IServiceH, ServiceH>();
services.AddScoped<IServiceI, ServiceI>();
services.AddScoped<IServiceJ, ServiceJ>();
.
.
.
.
```
by using the EasyDI, you distribute this registration to each interface of your service, therefore you do not need to spend any effort to organize these registrations plus when you open your service interface you have a goof idea that what is the service life time of that service, isn't it cool :)


>checkout the source code [**here**](https://github.com/alicommit-malp/EasyDI)

>install the Nuget package from [**here**](https://www.nuget.org/packages/EasyDI)
