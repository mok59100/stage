using EASL.Controllers;
using EASL.Data;
using EASL.Data.Dtos;
using EASL.Formulaires;
using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using EASL.Listes;

namespace EASL.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour FormulaireCotisations.xaml
    /// </summary>
    public partial class FormulaireCotisations : Window
    {
        // Attributs
        ListeCotisations FenetreAppel;
        CotisationsDTOIn Cotisation;
        CotisationsControllers CotisationsControllers;
        UtilisateursControllers UtilisateursControllers;
        string Action;
        int Id;

        // Constructeurs
        public FormulaireCotisations(string action, ListeCotisations window, CotisationsDTOIn cotisation, MyDbContext _context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Cotisation = cotisation;
            this.FenetreAppel = window;
            //on récupère l'id
            UtilisateursControllers = new UtilisateursControllers(_context);
            cbIdUtilisateur.ItemsSource = UtilisateursControllers.GetAllUtilisateursModele();
            cbIdUtilisateur.DisplayMemberPath = "Nom";
            cbIdUtilisateur.SelectedValuePath = "IdUtilisateur";
            this.Id = (cotisation == null) ? 0 : cotisation.IdCotisation;
            // On récupère le type d'action Ajouter, Modifier, Supprimer à partir de l'information du bouton cliqué
            this.Action = action;


            CotisationsControllers = new CotisationsControllers(_context);

            InitPage();
        }

        private void InitPage()
        {
            //on met à jour le titre de la fenetre
            labTitreFormulaire.Content = this.Action + " une cotisation";

            //Button valider
            
            btn_Valider.Click += (s, e) => ActionCotisation(); // On affecte la fonction au bouton
            btn_Valider.Content = this.Action;

            switch (this.Action)
            {
                case "Ajouter":
                    // rien à faire
                    break;
                case "Modifier":
                    txbEtatCotisation.Text = Cotisation.EtatCotisation;
                    txbMontantCotisation.Text = Cotisation.MontantCotisation;
                    txbModePaiement.Text = Cotisation.ModePaiement;
                    dpDateCotisation.SelectedDate = Cotisation.DateCotisation;
                    // On sélectionne par défaut la valeur de id utilisateur
                    cbIdUtilisateur.SelectedValue = Cotisation.IdUtilisateur;

                    break;
                case "Supprimer":
                    txbEtatCotisation.Text = Cotisation.EtatCotisation;
                    txbEtatCotisation.IsEnabled = false;
                    txbMontantCotisation.Text = Cotisation.MontantCotisation;
                    txbMontantCotisation.IsEnabled = false;
                    txbModePaiement.Text = Cotisation.ModePaiement;
                    txbModePaiement.IsEnabled = false;
                    dpDateCotisation.SelectedDate = Cotisation.DateCotisation;
                    dpDateCotisation.IsEnabled = false;
                    cbIdUtilisateur.SelectedValue = Cotisation.IdUtilisateur;
                    cbIdUtilisateur.IsEnabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ActionCotisation()
        {
            CotisationsDTOIn cotisation= new CotisationsDTOIn
            {
                IdCotisation = this.Id,
                EtatCotisation = txbEtatCotisation.Text,
                MontantCotisation = txbMontantCotisation.Text,
                ModePaiement = txbModePaiement.Text,
                DateCotisation = (DateTime)Cotisation.DateCotisation,
                IdUtilisateur = (int)cbIdUtilisateur.SelectedValue,

            };
            // on appelle la méthode de la fenêtre mère (parce qu'elle contient le controller)
            this.FenetreAppel.ActionCotisation(cotisation, this.Action, this.Id);
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
