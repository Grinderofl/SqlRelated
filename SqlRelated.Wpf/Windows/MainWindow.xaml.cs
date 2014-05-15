using SqlRelated.Core.Domain;
using SqlRelated.Wpf.Core.Factories;

namespace SqlRelated.Wpf.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private IWindowFactory _windowFactory;
        public MainWindow(IWindowFactory windowFactory)
        {
            _windowFactory = windowFactory;
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _windowFactory.Resolve<LoginWindow>().Show();
        }
    }
}
