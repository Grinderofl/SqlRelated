using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SqlRelated.Core.Domain;

namespace SqlRelated.Core.Modules
{
    public class UserBinderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<User>().AsSelf().SingleInstance();
        }
    }
}
