using Autofac;
using SqlRelated.Core.Connection.Impl;

namespace SqlRelated.Wpf.Core
{
    public class DependencyResolver
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof (App).Assembly, typeof (ConnectionResolverFacility).Assembly);
            return builder.Build();
        }
    }
}