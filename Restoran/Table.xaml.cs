using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Restoran
{
    public partial class Table : Page
    {
        List<Tables> TableList = new List<Tables>();

        public Table()
        {
            InitializeComponent();
        }

        public void Next(int tn)
        {
            NavigationService.Navigate(new Menu(tn));
        }

        private void TblBtn_Click1(object sender, RoutedEventArgs e)
        {
            Next(1);
        }

        private void TblBtn_Click2(object sender, RoutedEventArgs e)
        {
            Next(2);
        }

        private void TblBtn_Click3(object sender, RoutedEventArgs e)
        {
            Next(3);
        }

        private void TblBtn_Click4(object sender, RoutedEventArgs e)
        {
            Next(4);
        }

        private void TblBtn_Click5(object sender, RoutedEventArgs e)
        {
            Next(5);
        }

        private void TblBtn_Click6(object sender, RoutedEventArgs e)
        {
            Next(6);
        }

        private void TblBtn_Click7(object sender, RoutedEventArgs e)
        {
            Next(7);
        }

        private void TblBtn_Click8(object sender, RoutedEventArgs e)
        {
            Next(8);
        }

        private void TblBtn_Click9(object sender, RoutedEventArgs e)
        {
            Next(9);
        }

        private void TblBtn_Click10(object sender, RoutedEventArgs e)
        {
            Next(10);
        }

        private void TblBtn_Click11(object sender, RoutedEventArgs e)
        {
            Next(11);
        }

        private void TblBtn_Click12(object sender, RoutedEventArgs e)
        {
            Next(12);
        }

        private void TblBtn_Click13(object sender, RoutedEventArgs e)
        {
            Next(13);
        }

        private void TblBtn_Click14(object sender, RoutedEventArgs e)
        {
            Next(14);
        }

        private void TblBtn_Click15(object sender, RoutedEventArgs e)
        {
            Next(15);
        }
    }
}