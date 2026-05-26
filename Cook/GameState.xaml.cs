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

namespace Cook
{
    /// <summary>
    /// Interakční logika pro Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
    }

    public class GameState
    {
        public double Cookies { get; set; } = 0;        
        public double CookiesPerClick { get; set; } = 1; 
        public double CookiesPerSecond { get; set; } = 0; 
        public int TotalClicks { get; set; } = 0;       
        public int TotalUpgradesBought { get; set; } = 0;

        public double CenaKurzor { get; set; } = 10;
        public double CenaDvojKlik { get; set; } = 50;
        public double CenaBabicka { get; set; } = 100;
        public double CenaPekarna { get; set; } = 500;
        public double CenaTovarna { get; set; } = 2500;

    }

}
