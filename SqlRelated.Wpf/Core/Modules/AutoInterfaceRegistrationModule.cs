using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SqlRelated.Core.Domain;

namespace SqlRelated.Wpf.Core.Modules
{
    public class AutoInterfaceRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var impl = ThisAssembly.GetExportedTypes();
            var implementations =
                ThisAssembly.GetExportedTypes()
                    .Union(typeof (User).Assembly.GetExportedTypes())
                    .Where(x => x.Namespace != null && x.Namespace.EndsWith("Impl"));

            foreach (var implementation in implementations)
                builder.RegisterType(implementation).AsImplementedInterfaces();
        }
    }
}
