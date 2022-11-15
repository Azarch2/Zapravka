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
        public static Entities db = new Entities();
        public static Client currentClinet = db.Client.Where(p => p.Name == "Вадим").FirstOrDefault();
        public static double CurrentSumVar = 0;
        public static int Count1000f = 0;
        public static int Count500f = 0;
        public static int Count100f = 0;
        public static int Count50f = 0;
        public PaymentWindow()
        {
            InitializeComponent();
            //this.Visibility = Visibility.Visible;
            PaymentWindow.CurrentSumVar = 0;
            //Инициализация
            Count1000.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count.ToString();
            Count500.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count.ToString();
            Count100.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count.ToString();
            Count50.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count.ToString();

            //update
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count > 0)
            {
                Nominal50.IsEnabled = true;
            }
            else
            {
                Nominal50.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count > 0)
            {
                Nominal100.IsEnabled = true;
            }
            else
            {
                Nominal100.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count > 0)
            {
                Nominal500.IsEnabled = true;
            }
            else
            {
                Nominal500.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count > 0)
            {
                Nominal1000.IsEnabled = true;
            }
            else
            {
                Nominal1000.IsEnabled = false;
            }
            CurrentSum.Text = "Внесённая сумма: ";
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MainWindow.windowMain.Visibility=Visibility.Visible;
        }
        public static double AllLiters = 0;

        private void PayClick(object sender, RoutedEventArgs e)
        {
            double result = 0;
            
            if(MainWindow.ChoosedOil == 95)
            {
                MainWindow.windowChooseParams.textblockAllLitres.Text = "Количество литров бензина: " + Math.Round((CurrentSumVar / 48.55),2).ToString();
                result = (CurrentSumVar / 48.55);
                AllLiters = result;
                if(result> MainWindow.AmounOf95Fuel)
                {
                    MessageBox.Show("На введённую вами сумму недостаточно бензина");
                }
                else
                {
                    this.Visibility = Visibility.Hidden;
                    MainWindow.windowChooseParams.Visibility = Visibility.Visible;
                }
            }
            if (MainWindow.ChoosedOil == 92)
            {
                MainWindow.windowChooseParams.textblockAllLitres.Text = "Количество литров бензина: " + Math.Round((CurrentSumVar / 45.45), 2).ToString();
                result = (CurrentSumVar / 45.45);
                AllLiters = result;
                if (result > MainWindow.AmounOf92Fuel)
                {
                    MessageBox.Show("На введённую вами сумму недостаточно бензина");
                }
                else
                {
                    this.Visibility = Visibility.Hidden;
                    MainWindow.windowChooseParams.Visibility = Visibility.Visible;
                }
            }
            MainWindow.windowChooseParams.TotalPriceTextBox.Text = "Внесённая сумма: " + CurrentSumVar.ToString() + " руб.";

            //Изъятие купюр
            ///ОПЛАТИТЬ
            /* for (int i = 0; i < Count1000f; i++)
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
             td.Start();*/
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
            }
            else
            {
                PayButton.IsEnabled = false;
            }
            if (MainWindow.ChoosedOil == 95) {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 48.55 , 2);
            }
            if (MainWindow.ChoosedOil == 92)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 45.45, 2);
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
            }
            else
            {
                PayButton.IsEnabled = false;
            }
            if (MainWindow.ChoosedOil == 95)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 48.55, 2);
            }
            if (MainWindow.ChoosedOil == 92)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 45.45, 2);
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
            }
            else
            {
                PayButton.IsEnabled = false;
            }
            if (MainWindow.ChoosedOil == 95)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 48.55, 2);
            }
            if (MainWindow.ChoosedOil == 92)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 45.45, 2);
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
            }
            else
            {
                PayButton.IsEnabled = false;
            }
            if (MainWindow.ChoosedOil == 95)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 48.55, 2);
            }
            if (MainWindow.ChoosedOil == 92)
            {
                CurrentLiters.Text = "Получаемый бензин: " + Math.Round(CurrentSumVar / 45.45, 2);
            }
        }
    }
}
