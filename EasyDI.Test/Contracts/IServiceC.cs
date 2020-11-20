using EasyDI.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace EasyDI.Test.Contracts
{
    [InjectThisServiceAs(ServiceLifetime.Transient)]
    public interface IServiceC
    {
        string Get();
    }
}