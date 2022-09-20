using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Restoran
{
    public partial class Menu : Page
    {
        public Menu(int a)
        {
            InitializeComponent();
            TblNum.Text = a + "";
        }
    }
}