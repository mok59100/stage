using EASL.Controllers;
using EASL.Data;
using EASL.Data.Dtos;
using EASL.Listes;
using EASL.Formulaires;
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
    /// Logique d'interaction pour FormulaireAdhesions.xaml
    /// </summary>
    public partial class FormulaireAdhesions : Window
    {

        // Attributs
        ListeAdhesions FenetreAppel; // fenêtre d'appel
        AdhesionsDTOIn Adhesion;
        AdhesionsControllers AdhesionsControllers;
        string Action;
        int Id;

        // Constructeurs
        public FormulaireAdhesions(string action, ListeAdhesions window, AdhesionsDTOIn adhesion, MyDbContext _context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Adhesion = adhesion;
            this.FenetreAppel = window;
            // on récupère l'id , null si pas id
            this.Id = (adhesion == null) ? 0 : adhesion.IdAdhesion;

            // On récupère le type d'action Ajouter, Modifier, Supprimer à partir de l'information du bouton cliqué
            this.Action = action;
            AdhesionsControllers = new AdhesionsControllers(_context);


            InitPage();
        }

        //Autres méthodes

        /// <summary>
        /// Méthode qui permet de remplir le formulaire à partir des données de la classe
        /// </summary>
        private void InitPage()
        {

            //on met à jour le titre de la fenetre
            labTitreFormulaire.Content = this.Action + " une adhesion";
            //Button valider
            btn_Valider.Click += (s, e) => ActionAdhesion();
            btn_Valider.Content = this.Action;

            switch (this.Action)
            {
                case "Ajouter":
                    // rien à faire
                    break;
                case "Modifier":
                    DateTime txbDateDebutAdhesion= (DateTime)Adhesion.DateDebutAdhesion;
                    DateTime txbDateFinAdhesion = (DateTime)Adhesion.DateFinAdhesion;
                    // On sélectionne par défaut la valeur de id utilisateur
                    cbIdUtilisateur.SelectedValue = Adhesion.IdUtilisateur;


                    break;

                case "Supprimer":
                    // Tous les champs ne sont pas modifiable
                    dpDateDebutAdhesion.SelectedDate = Adhesion.DateDebutAdhesion;
                    dpDateDebutAdhesion.IsEnabled = false;
                    dpDateFinAdhesion.SelectedDate = Adhesion.DateFinAdhesion;
                    dpDateFinAdhesion.IsEnabled = false;
                    cbIdUtilisateur.SelectedValue = Adhesion.IdUtilisateur;
                        cbIdUtilisateur.IsEnabled = false;

                    break;

            }
        }
        private void ActionAdhesion()
        {
            AdhesionsDTOIn adhesion = new AdhesionsDTOIn
            {

                IdAdhesion = this.Id,
                DateDebutAdhesion = (DateTime)dpDateDebutAdhesion.SelectedDate,
                DateFinAdhesion = (DateTime)dpDateFinAdhesion.SelectedDate,
                IdUtilisateur = (int) cbIdUtilisateur.SelectedValue, 
            };
           
            // on appelle la méthode de la fenêtre mère (parce qu'elle contient le controller)
            this.FenetreAppel.ActionAdhesion(adhesion, this.Action, this.Id);
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