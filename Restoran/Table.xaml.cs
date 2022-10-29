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

        private void TblBtn_Click16(object sender, RoutedEventArgs e)
        {
            Next(16);
        }

        private void TblBtn_Click17(object sender, RoutedEventArgs e)
        {
            Next(17);
        }

        private void TblBtn_Click18(object sender, RoutedEventArgs e)
        {
            Next(18);
        }

        private void TblBtn_Click19(object sender, RoutedEventArgs e)
        {
            Next(19);
        }

        private void TblBtn_Click20(object sender, RoutedEventArgs e)
        {
            Next(20);
        }

        private void TblBtn_Click21(object sender, RoutedEventArgs e)
        {
            Next(21);
        }

        private void TblBtn_Click22(object sender, RoutedEventArgs e)
        {
            Next(22);
        }

        private void TblBtn_Click23(object sender, RoutedEventArgs e)
        {
            Next(23);
        }

        private void TblBtn_Click24(object sender, RoutedEventArgs e)
        {
            Next(24);
        }

        private void TblBtn_Click25(object sender, RoutedEventArgs e)
        {
            Next(25);
        }


    }
}