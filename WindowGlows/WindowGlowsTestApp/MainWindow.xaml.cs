using System.Windows;

namespace WindowGlowsTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new WindowGlowsTestApp.Window1();
            w1.Show();
        }
    }
}
