using System;
using Microsoft.Extensions.DependencyInjection;

namespace EasyDI.Attributes
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class InjectThisServiceAs : Attribute
    {
        public readonly ServiceLifetime ServiceLifetime;

        public InjectThisServiceAs(ServiceLifetime serviceLifetime)
        {
            ServiceLifetime = serviceLifetime;
        }
    }
}