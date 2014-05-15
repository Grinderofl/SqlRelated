using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using NUnit.Framework;
using SqlRelated.Wpf.Core.Factories;
using SqlRelated.Wpf.Windows;
using UnitTests.Base;

namespace UnitTests.Wpf
{
    public class WindowFactorySpecs
    {
        [RequiresSTA]
        public class WindowFactoryContext : SharedContext
        {
            protected Window Window;
            protected IWindowFactory WindowFactory;

            protected override void SetupShared()
            {
                WindowFactory = Container.Resolve<IWindowFactory>();
            }
        }

        [RequiresSTA]
        public class WhenResolvingLoginWindow : WindowFactoryContext
        {
            protected override void Because()
            {
                Window = WindowFactory.Resolve<LoginWindow>();
            }

            [Test]
            public void should_return_login_window()
            {
                Assert.That(Window, Is.TypeOf<LoginWindow>());
            }
        }
    }
}
