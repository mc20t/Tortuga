using System.Windows;

namespace Restoran
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new Table();
        }
    }
}
