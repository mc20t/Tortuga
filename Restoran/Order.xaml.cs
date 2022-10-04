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

        public Order()
        {
            InitializeComponent();

            Filter();
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Filter()
        {
            OrderList = AppData.Context.OrderDish.ToList();
            //DishList = DishList.     //ПОИСК
            //    Where(i =>
            //        i.ID.ToString().ToLower().Contains(txtSearch.Text.ToLower()) ||
            //        i.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
            //        i.Cost.ToString().ToLower().Contains(txtSearch.Text.ToLower())
            //    ).ToList();

            //switch (cmbSort.SelectedIndex)      //СОРТИРОВКА
            //{
            //    case 0:
            //        DishList = DishList.OrderBy(i => i.ID).ToList();
            //        break;
            //    case 1:
            //        DishList = DishList.OrderBy(i => i.Title).ToList();
            //        break;
            //    case 2:
            //        DishList = DishList.OrderBy(i => i.Cost).ToList();
            //        break;
            //    default:
            //        DishList = DishList.OrderBy(i => i.ID).ToList();
            //        break;
            //}

            lvOrder.ItemsSource = OrderList;
        }
    }
}