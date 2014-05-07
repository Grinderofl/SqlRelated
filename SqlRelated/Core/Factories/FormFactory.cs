using System.Windows.Forms;
using Autofac;

namespace SqlRelated.Core.Factories
{
    public class FormFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public FormFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public TForm CreateForm<TForm>() where TForm : Form
        {
            var formScope = _lifetimeScope.BeginLifetimeScope("FormScope");
            var form = formScope.Resolve<TForm>();
            form.Closed += (o, args) => formScope.Dispose();
            return form;
        }

    }
}
