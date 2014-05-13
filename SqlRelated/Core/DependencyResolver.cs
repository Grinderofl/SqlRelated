using Autofac;
using SqlRelated.Core.Connection.Impl;

namespace SqlRelated.Core
{
    public class DependencyResolver
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof (Program).Assembly, typeof (ConnectionResolverFacility).Assembly);
            return builder.Build();
        }
    }
}