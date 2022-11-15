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
        public static MainWindow windowMain;
        public static ChooseParamsWindow windowChooseParams = new ChooseParamsWindow();
        public static PaymentWindow windowPayment = new PaymentWindow();
        public static WindowPetrolProcess windowProcess = new WindowPetrolProcess();

        public static Entities db = new Entities();
        public static Client currentClinet = db.Client.Where(p => p.Name == "Вадим").FirstOrDefault();
        public MainWindow()
        {
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
            if(ChooseTextBlock.Text == "")
            {
                MessageBox.Show("Вы не выбрали бензин");
            }
            else
            {
                this.Visibility = Visibility.Hidden;
                windowChooseParams.Visibility = Visibility.Visible;
                windowChooseParams.ThisSlider.Maximum = currentClinet.Automobile.MaxTankVolume;
                if(ChooseTextBlock.Text == "95")
                {
                    ChooseParamsWindow.PricePerLitr = 48.55;
                    windowChooseParams.PricePerLitrBox.Text = "Цена за литр:  48.55";
                 }
                if (ChooseTextBlock.Text == "92")
                {
                    ChooseParamsWindow.PricePerLitr = 45.45;
                    windowChooseParams.PricePerLitrBox.Text = "Цена за литр:  45.45";
                }
            }
        }
    }
}
