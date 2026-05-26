using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Cook
{
    public partial class Shop : Window
    {
        GameState game;

        public Shop(GameState game)
        {
            InitializeComponent();
            this.game = game;


        }

        private void Upgbutton1_Click(object sender, RoutedEventArgs e)
        {
            if (game.Cookies >= game.CenaKurzor)
            {
                game.CookiesPerClick += 1;
                game.Cookies -= game.CenaKurzor;
                game.CenaKurzor = game.CenaKurzor * 1.5;
                game.TotalUpgradesBought += 1;
            }
            else
            {
                MessageBox.Show("Nemas dost love ");
            }
        }

        private void Upgbutton2_Click(object sender, RoutedEventArgs e)
        {
            if (game.Cookies >= game.CenaDvojKlik)
            {
                game.CookiesPerClick += 5;
                game.Cookies -= game.CenaDvojKlik;
                game.CenaDvojKlik = game.CenaDvojKlik * 1.5;
                game.TotalUpgradesBought += 1;
            }
            else
            {
                MessageBox.Show("Nemas dost love ");
            }
        }

        private void Upgbutton3_Click(object sender, RoutedEventArgs e)
        {
            if (game.Cookies >= game.CenaBabicka)
            {
                game.CookiesPerSecond += 1;
                game.Cookies -= game.CenaBabicka;
                game.CenaBabicka = game.CenaBabicka * 1.5;
                game.TotalUpgradesBought += 1;
            }
            else
            {
                MessageBox.Show("Nemas dost love");
            }
        }
        private void Upgbutton4_Click(object sender, RoutedEventArgs e)
        {
            if (game.Cookies >= game.CenaPekarna)
            {
                game.CookiesPerSecond += 5;
                game.Cookies -= game.CenaPekarna;
                game.CenaPekarna = game.CenaPekarna * 1.5;
                game.TotalUpgradesBought += 1;
            }
            else
            {
                MessageBox.Show("Nemas dost love");
            }
        }
        private void Upgbutton5_Click(object sender, RoutedEventArgs e)
        {
            if (game.Cookies >= game.CenaPekarna)
            {
                game.CookiesPerSecond += 25;
                game.Cookies -= game.CenaTovarna;
                game.CenaTovarna = game.CenaTovarna * 1.5;
                game.TotalUpgradesBought += 1;
            }
            else
            {
                MessageBox.Show("Nemas dost love");
            }
        }
    }
}
