using EASL.Controllers;
using EASL.Data;
using EASL.Data.Dtos;
using EASL.Formulaires;
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
    /// Logique d'interaction pour FormulaireActualites.xaml
    /// </summary>
    public partial class FormulaireActualites : Window
    {

        // Attributs
        ListeActualites FenetreAppel; // fenêtre d'appel
        ActualitesDTOIn Actualite;
        ActualitesControllers ActualitesControllers;
        string Action;
        int Id;

        // Constructeurs
        public FormulaireActualites(string action, ListeActualites window, ActualitesDTOIn actualite, MyDbContext _context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Actualite = actualite;
             this.FenetreAppel = window;
            // on récupère l'id , null si pas id

            this.Id = (actualite == null) ? 0 : actualite.IdActualite;
            // On récupère le type d'action Ajouter, Modifier, Supprimer à partir de l'information du bouton cliqué
            this.Action = action;

            ActualitesControllers = new ActualitesControllers(_context);
           

            InitPage();
        }

        //Autres méthodes

        /// <summary>
        /// Méthode qui permet de remplir le formulaire à partir des données de la classe
        /// </summary>
        private void InitPage()
        {

            //on met à jour le titre de la fenetre
            labTitreFormulaire.Content = this.Action + " une actualite";

        

            //Button valider
            btn_Valider.Click += (s, e) => ActionActualite(); // On affecte la fonction au bouton
            btn_Valider.Content = this.Action;

              switch (this.Action)
            {
                case "Ajouter":
                    // rien à faire
                    break;
                case "Modifier":
                    txbTitre.Text = Actualite.Titre;
                    txbContenu.Text = Actualite.Contenu;
                    DateTime txbDateAffichage =(DateTime) Actualite.DateAffichage;
                    



                    break;

                  case "Supprimer":
                    // Tous les champs ne sont pas modifiable
                    txbTitre.Text = Actualite.Titre;
                    txbTitre.IsEnabled = false;
                    txbContenu.Text = Actualite.Contenu;
                    txbContenu.IsEnabled = false;
                    dpDateAffichage.SelectedDate =Actualite.DateAffichage;
                    dpDateAffichage.IsEnabled = false;
                  
                    break;
                default:
                    break;

            }
        }
        private void ActionActualite()
        {
            ActualitesDTOIn actualite = new ActualitesDTOIn
            {
                IdActualite = this.Id,
                Titre = txbTitre.Text,
                Contenu = txbContenu.Text,
                DateAffichage = (DateTime)dpDateAffichage.SelectedDate
            



            };
            
            // on appelle la méthode de la fenêtre mère (parce qu'elle contient le controller)
            this.FenetreAppel.ActionActualite(actualite, this.Action,this.Id);
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
