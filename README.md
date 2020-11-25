# EasyDI in .Net core 
How many times have you run your .Net core application and boom you got an error message saying

```
System.InvalidOperationException: Unable to resolve service for type ... 
 at Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetService(IServiceProvider sp, Type type, Type requiredBy, Boolean isDefaultParameterRequired) ...
```
And what has happened is you coded your service interface and its implementation and even you have used constructor injection in your controller but still you have forgotten to register your service in the Startup.cs.

Or even if you have registered it in the startup class or in a separated extension class after a while you may face with something like this 

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


