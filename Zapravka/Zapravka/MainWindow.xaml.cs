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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zapravka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Entities db = new Entities();
        public static MainWindow windowMain;
        public static Client currentClinet = db.Client.Where(p => p.Name == "Вадим").FirstOrDefault();
        public static ChooseParamsWindow windowChooseParams = new ChooseParamsWindow();
        public static PaymentWindow windowPayment = new PaymentWindow();
        public static WindowPetrolProcess windowProcess = new WindowPetrolProcess();
        public static int ChoosedOil = 0;
        public static double AmounOf92Fuel = 100;
        public static double AmounOf95Fuel = 25;

        public MainWindow()
        {
            windowMain = this;
            InitializeComponent();
            windowMain = this;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Choose95(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Background = new SolidColorBrush(Colors.Red);
            ChooseTextBlock.Text = "95";
        }

        private void Choose92(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Background = new SolidColorBrush(Colors.DeepSkyBlue);
            ChooseTextBlock.Text = "92";
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            PaymentWindow.Count1000f = 0;
            PaymentWindow.Count500f = 0;
            PaymentWindow.Count50f = 0;
            PaymentWindow.Count100f = 0;
            PaymentWindow.CurrentSumVar = 0;
            windowPayment.CurrentLiters.Text = "Получаемый бензин: ";
            //Инициализация
            windowPayment.Count1000.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count.ToString();
            windowPayment.Count500.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count.ToString();
            windowPayment.Count100.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count.ToString();
            windowPayment.Count50.Text = currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count.ToString();

            //update
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 50).ToList().Count > 0)
            {
                windowPayment.Nominal50.IsEnabled = true;
            }
            else
            {
                windowPayment.Nominal50.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 100).ToList().Count > 0)
            {
                windowPayment.Nominal100.IsEnabled = true;
            }
            else
            {
                windowPayment.Nominal100.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 500).ToList().Count > 0)
            {
                windowPayment.Nominal500.IsEnabled = true;
            }
            else
            {
                windowPayment.Nominal500.IsEnabled = false;
            }
            if (MainWindow.currentClinet.Banknote.Where(p => p.BanknoteType.Price == 1000).ToList().Count > 0)
            {
                windowPayment.Nominal1000.IsEnabled = true;
            }
            else
            {
                windowPayment.Nominal1000.IsEnabled = false;
            }
            windowPayment.CurrentSum.Text = "Внесённая сумма: ";
            if (ChooseTextBlock.Text == "")
            {
                MessageBox.Show("Вы не выбрали бензин");
            }
            else
            {
                if(ChooseTextBlock.Text == "95")
                {
                    if (MainWindow.AmounOf95Fuel > 5)
                    {
                      
                        ChooseParamsWindow.PricePerLitr = 48.55;
                        windowChooseParams.PricePerLitrBox.Text = "Цена за литр:  48.55";
                        this.Visibility = Visibility.Hidden;
                        windowPayment.Visibility = Visibility.Visible;
                        ChoosedOil = 95;
                    }
                    else
                    {
                        MessageBox.Show("Бензин закончился");
                    }
                 }
                if (ChooseTextBlock.Text == "92")
                {
                    if (MainWindow.AmounOf92Fuel > 5)
                    {
                      
                        this.Visibility = Visibility.Hidden;
                        windowPayment.Visibility = Visibility.Visible;
                        ChooseParamsWindow.PricePerLitr = 45.45;
                        windowChooseParams.PricePerLitrBox.Text = "Цена за литр:  45.45";
                        ChoosedOil = 92;
                    }
                    else
                    {
                        MessageBox.Show("Бензин закончился");
                    }
                }
            }
        }
    }
}
