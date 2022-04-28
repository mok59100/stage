using EASL.Data;
using EASL.Listes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EASL
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        MyDbContext _context;
        public Accueil()
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = new MyDbContext();
        }


        private void btnActualites_Click(object sender, RoutedEventArgs e)
        {
            ListeActualites actions = new ListeActualites(_context);

            this.Opacity = 0.7;
            actions.ShowDialog();
            this.Opacity = 1;
        }

        private void btnAdhesions_Click(object sender, RoutedEventArgs e)
        {
            ListeAdhesions actions = new ListeAdhesions(_context);

            this.Opacity = 0.7;
            actions.ShowDialog();
            this.Opacity = 1;
        }
        private void btnCotisations_Click(object sender, RoutedEventArgs e)
        {
            ListeCotisations actions = new ListeCotisations(_context);

            this.Opacity = 0.7;
            actions.ShowDialog();
            this.Opacity = 1;
        }

        private void btnDons_Click(object sender, RoutedEventArgs e)
        {
            ListeDons actions = new ListeDons(_context);

            this.Opacity = 0.7;
            actions.ShowDialog();
            this.Opacity = 1;
        }
        private void btnUtilisateurs_Click(object sender, RoutedEventArgs e)
        {
            ListeUtilisateurs actions = new ListeUtilisateurs(_context);

            this.Opacity = 0.7;
            actions.ShowDialog();
            this.Opacity = 1;
        }
        private void Deconnexion(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




    }
}

        //private void RedirectionVersListe(object sender, RoutedEventArgs e)
        //{
        //    string nom = (string)((Button)sender).Name;
        //    var window = new Window();
        //    switch (nom)
        //    {
        //        case "btn_Actualites":
        //            window = new ListeActualites();
        //            break;
        //        case "btn_Adhesions":
        //            window = new ListeAdhesions();
        //            break;
        //        case "btn_Cotisations":
        //            window = new ListeCotisations();
        //            break;
        //        case "btn_Dons":
        //            window = new ListeDons();
        //            break;
        //        case "btn_Utilisateurs":
        //            window = new ListeUtilisateurs();
        //            break;

        //    }
        //    this.Visibility = Visibility.Hidden;
        //    window.ShowDialog();
        //    this.Visibility = Visibility.Visible;
        //}
    
   

