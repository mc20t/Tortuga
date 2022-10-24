using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Restoran
{
    public partial class Menu : Page
    {
        List<Dish> DishList = new List<Dish>();

        public Menu(int a)
        {
            InitializeComponent();
            TblNum.Text = "Столик " + a;

            //cmbSort.ItemsSource = listSort;
            //cmbSort.SelectedIndex = 0;

            Filter();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Order());
        }

        private void Filter()
        {
            DishList = AppData.Context.Dish.ToList();
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

            lvDish.ItemsSource = DishList;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Table());
        }

        private void lvDish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var vvv = new OrderDish();
            //if (lvDish.SelectedItem is OrderDish)
            //{
            //    vvv = lvDish.SelectedItem as OrderDish;
            //}

            //this.Opacity = 0.2;
            //lvDish.ItemsSource = AppData.Context.OrderDish.ToList();
            //this.Opacity = 1;


            //OrderDish orderDish = new OrderDish();

            //orderDish.Count++;

            //AppData.Context.OrderDish.Add(orderDish);
            //AppData.Context.SaveChanges();

            //Filter();
        }
    }
}