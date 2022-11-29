using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Restoran
{
    public partial class Order : Page
    {
        List<OrderDish> OrderList = new List<OrderDish>();
        public int tn;

        public Order(int a)
        {
            InitializeComponent();
            tn = a;
            TblNum.Text = "Столик\n" + a;
            Filter();
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e) {}

        private void Filter()
        {
            OrderList = AppData.Context.OrderDish.ToList();

            lvOrder.ItemsSource = OrderList;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu(tn));
        }
    }
}