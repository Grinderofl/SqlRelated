using Autofac;

namespace SqlRelated.Core
{
    public class DependencyResolver
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof (Program).Assembly);
            return builder.Build();
        }
    }
}