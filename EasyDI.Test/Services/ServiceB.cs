using EasyDI.Test.Contracts;

namespace EasyDI.Test.Services
{
    public class ServiceB : IServiceB
    {
        public string Do()
        {
            return "B";
        }
    }
}