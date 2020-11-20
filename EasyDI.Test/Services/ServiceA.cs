using System;
using EasyDI.Test.Contracts;

namespace EasyDI.Test.Services
{
    public class ServiceA :IServiceA
    {
        private readonly DateTime _dateTime = DateTime.Now;
        public string Get()
        {
            return $"A {_dateTime}";
        }
    }
}