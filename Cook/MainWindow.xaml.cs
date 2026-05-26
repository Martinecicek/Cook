using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Cook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameState game = new GameState();
        DispatcherTimer timer = new DispatcherTimer();
       

        int zaKlik = 1;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            AktualizujUI();


            Pocet_Susenek_kliknuti.Text = zaKlik.ToString();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            game.Cookies += game.CookiesPerClick;
            game.TotalClicks += 1;
            AktualizujUI();

          
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            game.Cookies += game.CookiesPerSecond;  
            AktualizujUI();                         
        }


        private void AktualizujUI()
        {
            Pocet_susenek.Text = game.Cookies.ToString();
            Pocet_Susenek_kliknuti.Text = game.CookiesPerClick.ToString();
            Pocet_Susenek_sekunda.Text = game.CookiesPerSecond.ToString();
            Celkovy_Pocet_Kliknuti.Text = game.TotalClicks.ToString();
        }
    }
}
