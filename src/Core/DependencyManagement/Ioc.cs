using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.DependencyManagement
{
    public class Ioc
    {
        protected static readonly Dictionary<Type, IEnumerable<Func<object>>> Container = 
            new Dictionary<Type, IEnumerable<Func<object>>>();

        public static TService Resolve<TService>() where TService : class
        {
            var allServices = ResolveMany<TService>();
            return allServices.First();
        }

        public static bool IsRegistered<TService>() where TService : class
        {
            return Container.Keys.Any(x => x == typeof(TService));
        }

        public static void Register<TService, TImplementation>() 
            where TImplementation : TService, 
            new() where TService : class
        {
            var serviceType = typeof(TService);
            Func<object> newImpl = () => new TImplementation();

            if (IsRegistered<TService>())
            {
                var impList = Container[serviceType].ToList();

                impList.Add(newImpl);
                Container[serviceType] = impList;
            }
            else
            {
                Container.Add(serviceType, new [] { newImpl});
            }
        }

        public static void Flush()
        {
            Container.Clear();
        }

        public static IEnumerable<TService> ResolveMany<TService>() where TService : class
        {
            var serviceType = typeof(TService);

            if (!IsRegistered<TService>())
                throw new ServiceNotRegisteredException(serviceType);

            var result = new List<TService>();
            foreach (var a in Container[serviceType])
                result.Add(a() as TService);

            return result;
        }
    }
}