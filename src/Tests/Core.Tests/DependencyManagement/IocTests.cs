using System;
using System.Collections.Generic;
using System.Linq;
using Core.DependencyManagement;
using Xunit;

namespace Core.Tests.DependencyManagement
{
    public class IocTests : IDisposable
    {
        [Fact]
        public void Ioc_ResolveService()
        {
            Ioc.Register<IMyService, MyService>();
            var impl = Ioc.Resolve<IMyService>();

            Assert.IsAssignableFrom<IMyService>(impl);
        }

        [Fact]
        public void Ioc_ResolveMany()
        {
            Ioc.Register<IMyService, MyService>();
            Ioc.Register<IMyService, MyService2>();
            var allServices = Ioc.ResolveMany<IMyService>();

            Assert.Equal(2, allServices.Count());
        }

        [Fact]
        public void Ioc_IsRegistered()
        {
            Assert.False(Ioc.IsRegistered<IMyService>());

            Ioc.Register<IMyService, MyService>();
            Assert.True(Ioc.IsRegistered<IMyService>());
        }

        [Fact]
        public void Ioc_ThrowsOnNotRegistered()
        {
            Action testCode = () => Ioc.Resolve<IMyService>();
            Assert.Throws<ServiceNotRegisteredException>(testCode);
        }

        [Fact]
        public void Ioc_Flush()
        {
            FlushIoc.Register<IMyService, MyService>();
            Assert.True(Ioc.IsRegistered<IMyService>());
            FlushIoc.Flush();

            Assert.False(FlushIoc.GetContainer().Any());
        }

        public void Dispose()
        {
            Ioc.Flush();
        }
    }

    public class FlushIoc : Ioc
    {
        public static Dictionary<Type, IEnumerable<Func<object>>> GetContainer()
        {
            return Container;
        }

    }

    public class MyService : IMyService
    {
    }
    public class MyService2 : IMyService
    {
    }

    public interface IMyService
    {
    }
}
