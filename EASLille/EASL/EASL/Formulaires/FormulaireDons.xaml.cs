using EASL.Controllers;
using EASL.Data;
using EASL.Data.Dtos;
using EASL.Listes;
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

namespace EASL.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour FormulaireDons.xaml
    /// </summary>
    public partial class FormulaireDons : Window
    {
       
        ListeDons FenetreAppel;
        DonsDTOIn Don;
        DonsControllers DonsControllers;
        string Action;
        int Id;
        public FormulaireDons(string action, ListeDons window, DonsDTOIn don, MyDbContext _context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Don = don;
            this.FenetreAppel = window;

            // on récupère l'id
            this.Id = (don == null) ? 0 : don.IdDon;
            // On récupère le type d'action Ajouter, Modifier, Supprimer à partir de l'information du bouton cliqué


            this.Action = action;
            DonsControllers = new DonsControllers(_context);

            InitPage();
        }

        private void InitPage()
        {
            //on met à jour le titre de la fenetre
            labTitreFormulaire.Content = this.Action + " un don";

            //Button valider
            btn_Valider.Click += (s, e) => ActionDon();
            btn_Valider.Content = this.Action;

            switch (this.Action)
            {
                case "Ajouter":
                    // rien à faire
                    break;
                case "Modifier":
                    txbNom.Text = Don.Nom;
                    txbPrenom.Text = Don.Prenom;
                    txbLibelleDon.Text = Don.LibelleDon;
                    txbMontantDon.Text = Don.MontantDon.ToString();

                    break;
                case "Supprimer":
                    txbNom.Text = Don.Nom;
                    txbNom.IsEnabled = false;
                    txbPrenom.Text = Don.Prenom;
                    txbPrenom.IsEnabled = false;
                    txbLibelleDon.Text = Don.LibelleDon;
                    txbLibelleDon.IsEnabled = false;
                    txbMontantDon.Text = Don.MontantDon.ToString();
                    txbMontantDon.IsEnabled = false;

                    break;
                default:
                    break;
            }
        }

        private void ActionDon()
        {
            DonsDTOIn don = new DonsDTOIn
         {
                IdDon = this.Id,
                Nom = txbNom.Text,
                Prenom = txbPrenom.Text,
                LibelleDon = txbLibelleDon.Text,
                MontantDon = decimal.Parse(txbMontantDon.Text),
        };
            // on appelle la méthode de la fenêtre mère (parce qu'elle contient le controller)
            this.FenetreAppel.ActionDon(don, this.Action, this.Id);
            Retour();
        }

        public void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Retour()
        {
            this.Close();
        }
        private void txbNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Int32.TryParse(((TextBox)sender).Text, out Int32 result))
            {
                ((TextBox)sender).Text = "";
                MessageBox.Show("Cette valeur doit être un entier", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
