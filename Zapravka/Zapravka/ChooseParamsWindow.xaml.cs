﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zapravka
{
    /// <summary>
    /// Логика взаимодействия для ChooseParamsWindow.xaml
    /// </summary>
    public partial class ChooseParamsWindow : Window
    {
        public static double TotalPrice;
        public static double PricePerLitr;
        public static double TotalLiters;
        public ChooseParamsWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MainWindow.windowMain.Visibility = Visibility.Visible;
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MainWindow.windowPayment.Visibility = Visibility.Visible;
            //Инициализация
            MainWindow.windowPayment.Count1000.Text = MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count.ToString();
            MainWindow.windowPayment.Count500.Text = MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count.ToString();
            MainWindow.windowPayment.Count100.Text = MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count.ToString();
            MainWindow.windowPayment.Count50.Text = MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count.ToString();
            MainWindow.windowPayment.TotalSum.Text = "Сумма к оплате:  " + TotalPrice.ToString();

            //update
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count > 0)
            {
                MainWindow.windowPayment.Nominal50.IsEnabled = true;
            }
            else
            {
                MainWindow.windowPayment.Nominal50.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count > 0)
            {
                MainWindow.windowPayment.Nominal100.IsEnabled = true;
            }
            else
            {
                MainWindow.windowPayment.Nominal100.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count > 0)
            {
                MainWindow.windowPayment.Nominal500.IsEnabled = true;
            }
            else
            {
                MainWindow.windowPayment.Nominal500.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count > 0)
            {
                MainWindow.windowPayment.Nominal1000.IsEnabled = true;
            }
            else
            {
                MainWindow.windowPayment.Nominal1000.IsEnabled = false;
            }
            MainWindow.windowPayment.PayButton.IsEnabled = false;
            MainWindow.windowPayment.BorderTotalSum.Background = new SolidColorBrush(Colors.Azure);
        }

        private void ChangeValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TotalPriceTextBox.Text = "Итоговая сумма:  [" + (sender as Slider).Value * PricePerLitr + "]  руб";
            TotalPrice = (sender as Slider).Value * PricePerLitr;
            TotalLiters = (sender as Slider).Value;

            if (TotalPrice > 0)
            {
                PaymentButton.IsEnabled = true;
            }
            else
            {
                PaymentButton.IsEnabled = false;
            }
           
        }
    }
}
