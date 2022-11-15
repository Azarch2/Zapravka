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
    /// Логика взаимодействия для WindowPetrolProcess.xaml
    /// </summary>
    public partial class WindowPetrolProcess : Window
    {
        public WindowPetrolProcess()
        {
            InitializeComponent();
        
        }

        public void ProcessZaliv()
        {
            
            Dispatcher.Invoke(new Action(() => TextBlockPricePerLitr.Text = ChooseParamsWindow.PricePerLitr.ToString() + " руб."));
            double currLiter = 0.1;
            Dispatcher.Invoke(new Action(() => FinalButton.IsEnabled = false ));
            
            for (; ; )
            {
                
                Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = Math.Round( currLiter,2).ToString() + " лтр."));
                Dispatcher.Invoke(new Action(() => TextBlockSum.Text = Math.Round(currLiter * ChooseParamsWindow.PricePerLitr,2).ToString() + " руб."));
                currLiter += 0.1;
                if(currLiter>= PaymentWindow.AllLiters)
                {
                   // Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = currLiter.ToString() + " лтр."));
                    //Dispatcher.Invoke(new Action(() => TextBlockSum.Text = (currLiter * ChooseParamsWindow.PricePerLitr).ToString() + " руб."));
                    if (MainWindow.ChoosedOil == 95)
                    {
                        MainWindow.AmounOf95Fuel -= currLiter;
                    }
                    if (MainWindow.ChoosedOil == 92)
                    {
                        MainWindow.AmounOf92Fuel -= currLiter;
                    }
                    MessageBox.Show("Вы успешно залили бензин!");
                    PaymentWindow.Count1000f = 0;
                    PaymentWindow.Count500f = 0;
                    PaymentWindow.Count50f = 0;
                    PaymentWindow.Count100f = 0;
                    Dispatcher.Invoke(new Action(() => FinalButton.IsEnabled = true));
                    break;
                }
              /*  if (MainWindow.currentClinet.Automobile.MaxTankVolume <= (ChooseParamsWindow.CurretPetrolVolume + currLiter))
                {
                   Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = currLiter.ToString() + " лтр."));
                   Dispatcher.Invoke(new Action(() => TextBlockSum.Text = (currLiter * ChooseParamsWindow.PricePerLitr).ToString() + " руб."));
                  if(MainWindow.ChoosedOil == 95)
                    {
                        MainWindow.AmounOf95Fuel -= currLiter;
                    }
                    if (MainWindow.ChoosedOil == 92)
                    {
                        MainWindow.AmounOf92Fuel -= currLiter;
                    }
                    MessageBox.Show("Вы успешно залили бензин!");
                    MessageBox.Show("Вы заплатили на" + ( PaymentWindow.CurrentSumVar - currLiter * ChooseParamsWindow.PricePerLitr) + " руб. больше");
                    
                    break;
                }*/
                Thread.Sleep(20);
            }
            
            foreach (var item in MainWindow.db.Client)
            {
                if(item.Id == MainWindow.currentClinet.Id)
                {
                    item.Automobile.TankVolume += currLiter;
                    MessageBox.Show("У вас сейчас в баке: " + item.Automobile.TankVolume + "/" + item.Automobile.MaxTankVolume + " лтр.");
                    break;
                }
            }
            MainWindow.db.SaveChanges();

        }

  

        private void Leave(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Visibility = Visibility.Hidden;
            MainWindow.windowMain.Visibility = Visibility.Visible;
            MainWindow.windowMain.ChooseTextBlock.Text = "";
            MainWindow.windowMain.StackPanelMain.Background = new SolidColorBrush(Colors.White);
        }
    }
}
