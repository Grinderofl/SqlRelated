using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SqlRelated.Core.Connection.Impl;

namespace SqlRelated.Core.Modules
{
    public class ConnectionResolverModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SqlServerAuthenticationConnectionResolver>().AsImplementedInterfaces();
            builder.RegisterType<WindowsAuthenticationConnectionResolver>().AsImplementedInterfaces();
        }
    }
}
