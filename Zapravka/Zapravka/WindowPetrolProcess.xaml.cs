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
            
            Dispatcher.Invoke(new Action(() => TextBlockPricePerLitr.Text = ChooseParamsWindow.PricePerLitr.ToString()));
            double currLiter = 0.5;
            for (; ; )
            {
                
                Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = currLiter.ToString() + " лтр."));
                Dispatcher.Invoke(new Action(() => TextBlockSum.Text = (currLiter * ChooseParamsWindow.PricePerLitr).ToString() + " руб."));
                currLiter += 0.5;
                if(currLiter>= ChooseParamsWindow.TotalLiters)
                {
                    Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = currLiter.ToString()));
                    Dispatcher.Invoke(new Action(() => TextBlockSum.Text = (currLiter * ChooseParamsWindow.PricePerLitr).ToString()));
                    MessageBox.Show("Вы успешно залили бензин!");
                    break;
                }
                if (currLiter >= MainWindow.currentClinet.Automobile.MaxTankVolume - (MainWindow.currentClinet.Automobile.TankVolume + currLiter))
                {
                   Dispatcher.Invoke(new Action(() => TextBlockLitres.Text = currLiter.ToString()));
                   Dispatcher.Invoke(new Action(() => TextBlockSum.Text = (currLiter * ChooseParamsWindow.PricePerLitr).ToString()));
                    MessageBox.Show("Вы успешно залили бензин!");
                    break;
                }
                Thread.Sleep(350);
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
            Application.Current.Shutdown();
        }
    }
}
