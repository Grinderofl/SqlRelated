using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SqlRelated.Wpf.Core.Factories.Impl;

namespace SqlRelated.Wpf.Core.Modules
{
    public class WindowFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WindowFactory>().AsImplementedInterfaces().SingleInstance();
        }
    }
}
