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

namespace Cook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zaKlik = 1;  // toto později zvýší upgrade

        public MainWindow()
        {
            InitializeComponent();
            Pocet_Susenek_kliknuti.Text = zaKlik.ToString();  // zobrazí výchozí hodnotu
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int celkem = int.Parse(Pocet_susenek.Text);
            celkem += zaKlik;
            Pocet_susenek.Text = celkem.ToString();
        }
    }
}
