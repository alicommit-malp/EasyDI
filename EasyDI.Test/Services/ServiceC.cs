using EasyDI.Test.Contracts;

namespace EasyDI.Test.Services
{
    public class ServiceC : IServiceC
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;


        public ServiceC(IServiceA serviceA, IServiceB serviceB)
        {
            _serviceA = serviceA;
            _serviceB = serviceB;
        }

        public string Do()
        {
            return $"{_serviceA.Do()}{_serviceB.Do()}";
        }
    }
}