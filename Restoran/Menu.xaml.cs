using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Input;

namespace Restoran
{
    public partial class Menu : Page
    {
        List<Dish> DishList = new List<Dish>();
        public int tn;

        public Menu(int a)
        {
            InitializeComponent();
            TblNum.Text = "Столик " + a;
            tn = a;

            cmbSort.ItemsSource = new List<String> { "По умолчанию", "Название", "Цена" };

            Filter();
        }

        public void Discount()
        {
            DishList = AppData.Context.Dish.ToList();
            //DishList.
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Order(tn));
        }

        private void Filter()
        {
            DishList = AppData.Context.Dish.ToList();
            DishList = DishList.     //ПОИСК
                Where(i =>
                    i.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
                    i.Cost.ToString().ToLower().Contains(txtSearch.Text.ToLower())
                ).ToList();

            switch (cmbSort.SelectedIndex)      //СОРТИРОВКА
            {
                case 0:
                    DishList = DishList.OrderBy(i => i.ID).ToList();
                    break;
                case 1:
                    DishList = DishList.OrderBy(i => i.Title).ToList();
                    break;
                case 2:
                    DishList = DishList.OrderBy(i => i.Cost).ToList();
                    break;
                default:
                    DishList = DishList.OrderBy(i => i.ID).ToList();
                    break;
            }

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

        private void lvDish_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Space)
            //{
            //    if (lvDish.SelectedItem is Dish && lvDish.SelectedIndex != -1)
            //    {
            //        try
            //        {
            //            var item = lvDish.SelectedItem as Dish;
            //            OrderDish newOrderDish = new OrderDish();
            //            newOrderDish.DishID = item;
            //            AppData.Context.OrderDish.Add(newOrderDish);
            //            AppData.Context.SaveChanges();
            //            Filter();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //    }
            //}
            //else if (e.Key == Key.Space)
            //{

            //}
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
    }
}