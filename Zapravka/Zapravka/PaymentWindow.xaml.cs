using System;
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
using System.Threading;

namespace Zapravka
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public static double CurrentSumVar = 0;
        public static int Count1000f = 0;
        public static int Count500f = 0;
        public static int Count100f = 0;
        public static int Count50f = 0;
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MainWindow.windowChooseParams.Visibility=Visibility.Visible;
        }

        private void PayClick(object sender, RoutedEventArgs e)
        {
          
           

            //Изъятие купюр
            for (int i = 0; i < Count1000f; i++)
            {
                Banknote toRemove = MainWindow.db.Banknote.Where(p => p.BanknoteType.Price == 1000).FirstOrDefault();
                MainWindow.db.Banknote.Remove(toRemove);
                MainWindow.db.SaveChanges();
            }
            for (int i = 0; i < Count100f; i++)
            {
                Banknote toRemove = MainWindow.db.Banknote.Where(p => p.BanknoteType.Price == 100).FirstOrDefault();
                MainWindow.db.Banknote.Remove(toRemove);
                MainWindow.db.SaveChanges();
            }
            for (int i = 0; i < Count500f; i++)
            {
                Banknote toRemove = MainWindow.db.Banknote.Where(p => p.BanknoteType.Price == 500).FirstOrDefault();
                MainWindow.db.Banknote.Remove(toRemove);
                MainWindow.db.SaveChanges();
            }
            for (int i = 0; i < Count50f; i++)
            {
                Banknote toRemove = MainWindow.db.Banknote.Where(p => p.BanknoteType.Price == 50).FirstOrDefault();
                MainWindow.db.Banknote.Remove(toRemove);
                MainWindow.db.SaveChanges();
            }

            MessageBox.Show("Вы оплатили бензин на сумму: " + CurrentSumVar + "\nВаша сдача составила: " + (CurrentSumVar - ChooseParamsWindow.TotalPrice) + " рублей");
            this.Visibility = Visibility.Hidden;
            MainWindow.windowProcess.Visibility = Visibility.Visible;
            Thread td = new Thread(new ThreadStart(MainWindow.windowProcess.ProcessZaliv));
            td.Start();
        }

        private void Add1000Click(object sender, RoutedEventArgs e)
        {
            CurrentSumVar += 1000;
            Count1000f++;
            CurrentSum.Text = "Внесённая сумма:  " + CurrentSumVar;
            int countAnotehr = int.Parse(Count1000.Text);
            countAnotehr--;
            Count1000.Text = countAnotehr.ToString();
            if (int.Parse(Count1000.Text) <= 0)
            {
                Nominal1000.IsEnabled = false;
            }
            else
            {
                Nominal1000.IsEnabled = true;
            }
            if (CurrentSumVar >= ChooseParamsWindow.TotalPrice)
            {
                PayButton.IsEnabled = true;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PayButton.IsEnabled = false;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Azure);
            }
        }

        private void Add500Click(object sender, RoutedEventArgs e)
        {
            CurrentSumVar += 500;
            Count500f++;
            CurrentSum.Text = "Внесённая сумма:  " + CurrentSumVar;
            int countAnotehr = int.Parse(Count500.Text);
            countAnotehr--;
            Count500.Text = countAnotehr.ToString();
            if (int.Parse(Count500.Text) <= 0)
            {
                Nominal500.IsEnabled = false;
            }
            else
            {
                Nominal500.IsEnabled = true;
            }
            if (CurrentSumVar >= ChooseParamsWindow.TotalPrice)
            {
                PayButton.IsEnabled = true;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PayButton.IsEnabled = false;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Azure);
            }
        }

        private void Add100Click(object sender, RoutedEventArgs e)
        {
            CurrentSumVar += 100;
            Count100f++;
            CurrentSum.Text = "Внесённая сумма:  " + CurrentSumVar;
            int countAnotehr = int.Parse(Count100.Text);
            countAnotehr--;
            Count100.Text = countAnotehr.ToString();
            if (int.Parse(Count100.Text) <= 0)
            {
                Nominal100.IsEnabled = false;
            }
            else
            {
                Nominal100.IsEnabled = true;
            }
            if (CurrentSumVar >= ChooseParamsWindow.TotalPrice)
            {
                PayButton.IsEnabled = true;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PayButton.IsEnabled = false;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Azure);
            }
        }

        private void Add50Click(object sender, RoutedEventArgs e)
        {
            CurrentSumVar += 50;
            Count50f++;
            CurrentSum.Text = "Внесённая сумма:  " + CurrentSumVar;
            int countAnotehr = int.Parse(Count50.Text);
            countAnotehr--;
            Count50.Text = countAnotehr.ToString();
            if (int.Parse( Count50.Text) <= 0)
            {
                Nominal50.IsEnabled = false;
            }
            else
            {
                Nominal50.IsEnabled = true;
            }
            if(CurrentSumVar >= ChooseParamsWindow.TotalPrice)
            {
                PayButton.IsEnabled = true;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PayButton.IsEnabled = false;
                BorderTotalSum.Background = new SolidColorBrush(Colors.Azure);
            }
        }
    }
}
