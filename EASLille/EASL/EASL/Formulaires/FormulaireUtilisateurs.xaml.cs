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
    /// Logique d'interaction pour FormulaireUtilisateurs.xaml
    /// </summary>
    public partial class FormulaireUtilisateurs : Window
    {
        // Attributs
        ListeUtilisateurs FenetreAppel; // fenêtre d'appel
        UtilisateursDTOIn Utilisateur;
        UtilisateursControllers UtilisateursControllers;
        string Action;
        int Id;

        public FormulaireUtilisateurs(string action, ListeUtilisateurs window, UtilisateursDTOIn utilisateur, MyDbContext _context)
        {
            InitializeComponent();

            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Utilisateur = utilisateur;
            this.FenetreAppel = window;

            // on récupère l'id
            this.Id = (Utilisateur == null) ? 0 : Utilisateur.IdUtilisateur;

            // On récupère le type d'action Ajouter, Modifier, Supprimer à partir de l'information du bouton cliqué
            this.Action = action;

            UtilisateursControllers = new UtilisateursControllers(_context);

            InitPage();
        }

        private void InitPage()
        {
            labTitreFormulaire.Content = this.Action + " un utilisateur";

            //Button valider
            btn_Valider.Click += (s, e) => ActionUtilisateur();// On affecte la fonction au bouton
            btn_Valider.Content = this.Action;

            switch (this.Action)
            {
                case "Ajouter":
                    // rien à faire
                    break;
                case "Modifier":
                    txbNom.Text = Utilisateur.Nom;
                    txbPrenom.Text = Utilisateur.Prenom;
                    txbAdresseMail.Text = Utilisateur.AdresseMail;
                    txbMotDePasse.Text = Utilisateur.MotDePasse;
                    cbIdRole.SelectedValue = Utilisateur.IdRole;

                    break;
                case "Supprimer":
                    txbNom.Text = Utilisateur.Nom;
                    txbNom.IsEnabled = false;
                    txbPrenom.Text = Utilisateur.Prenom;
                    txbPrenom.IsEnabled = false;
                    txbAdresseMail.Text = Utilisateur.AdresseMail;
                    txbAdresseMail.IsEnabled = false;
                    txbMotDePasse.Text = Utilisateur.MotDePasse;
                    txbMotDePasse.IsEnabled = false;
                    cbIdRole.SelectedValue = Utilisateur.IdRole;
                    cbIdRole.IsEnabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ActionUtilisateur()
        {
            UtilisateursDTOIn utilisateur = new UtilisateursDTOIn
            {
                IdUtilisateur = this.Id,
                Nom = txbNom.Text,
                Prenom = txbPrenom.Text,
                AdresseMail = txbAdresseMail.Text,
                MotDePasse = txbMotDePasse.Text,
                IdRole = (int)cbIdRole.SelectedValue,

            };
        
            // on appelle la méthode de la fenêtre mère (parce qu'elle contient le controller)
            this.FenetreAppel.ActionUtilisateur(utilisateur, this.Action, this.Id);
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
        //private void txbNumber_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (!Int32.TryParse(((TextBox)sender).Text, out Int32 result))
        //    {
        //        ((TextBox)sender).Text = "";
        //        MessageBox.Show("Cette valeur doit être un entier", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //}
    }
}