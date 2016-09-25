using System;

namespace Core.DependencyManagement
{
    public class ServiceNotRegisteredException : Exception
    {
        public ServiceNotRegisteredException(string message):base(message)
        {
        }

        public ServiceNotRegisteredException(Type serviceType)
            :this($"The type {serviceType.Name} was not registered")
        {
        }
    }
}