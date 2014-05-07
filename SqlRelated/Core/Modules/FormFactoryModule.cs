using Autofac;
using SqlRelated.Core.Factories;

namespace SqlRelated.Core.Modules
{
    public class FormFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FormFactory>().AsSelf().SingleInstance();
        }
    }
}
