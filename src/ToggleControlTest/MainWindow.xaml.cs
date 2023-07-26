using System.Windows;

namespace ToggleControlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }

        private void OnToggleChecked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(">>> OnChecked");
        }

        private void OnToggleUnchecked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(">>> OnUnchecked");
        }
    }
}
