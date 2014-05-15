using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using SqlRelated.Wpf.Core.Base;

namespace SqlRelated.Wpf.Core.Modules
{
    public class WindowModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            foreach (var window in ThisAssembly.GetExportedTypes().Where(x => x.IsSubclassOf(typeof (Window))))
            {
                if (!window.IsSubclassOf(typeof (InstancedWindow)))
                    builder.RegisterType(window).AsSelf().InstancePerDependency();
                else
                    builder.RegisterType(window).AsSelf().SingleInstance();
            }
        }
    }
}
