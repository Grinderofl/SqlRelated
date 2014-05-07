using System.Windows.Forms;
using Autofac;

namespace SqlRelated.Core.Modules
{
    public class FormModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Form1>().As<Form>().InstancePerLifetimeScope();
        }
    }
}
