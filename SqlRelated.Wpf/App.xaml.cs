using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using SqlRelated.Wpf.Core;
using SqlRelated.Wpf.Windows;

namespace SqlRelated.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private IContainer _container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container = DependencyResolver.Register();
            InitializeComponents();
            Current.MainWindow.Show();
        }

        private void InitializeComponents()
        {
            Current.MainWindow = _container.Resolve<MainWindow>();
        }
    }
}
