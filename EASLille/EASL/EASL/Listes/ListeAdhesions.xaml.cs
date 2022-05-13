using EASL.Controllers;
using EASL.Data;
using EASL.Data.Dtos;
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

namespace EASL.Listes
{
    /// <summary>
    /// Logique d'interaction pour ListeAdhesions.xaml
    /// </summary>
    public partial class ListeAdhesions : Window
    {
        MyDbContext _context;
        AdhesionsControllers _adhesionsControllers;
        public ListeAdhesions(MyDbContext context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = context;
            _adhesionsControllers = new AdhesionsControllers(_context);
            // On rempli la datagrid
            DgListeAdhesions.ItemsSource = _adhesionsControllers.GetAllAdhesions();
        }

        /// <summary>
        /// Méthode qui capte le click sur l'un des boutons d'actions et ouvre le formulaire dans le mode correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


     

        private void btnActions_Click(object sender, RoutedEventArgs e)
        {
            // On récupère l'article selectionné
            AdhesionsDTOOut adh = (AdhesionsDTOOut) DgListeAdhesions.SelectedItem;
            //AdhesionsDTOIn adhesion = (AdhesionsDTOIn)DgListeAdhesions.SelectedItem;
            AdhesionsDTOIn adhesion = new AdhesionsDTOIn();
            adhesion.IdAdhesion = adh.IdAdhesion;
            adhesion.DateDebutAdhesion = adh.DateDebutAdhesion;
            adhesion.DateFinAdhesion = adh.DateFinAdhesion;
            adhesion.IdUtilisateur = adh.IdUtilisateur;

            string nom = (string)((Button)sender).Content;
            // Si pas d'article sélectionné et click sur le bouton modifier ou supprimer, on affiche un message d'erreur
            if (adhesion == null && (nom == "Modifier" || nom == "Supprimer"))
            {
                MessageBox.Show("Vous devez sélectionner une ligne", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // On ouvre la fenêtre de détail
                // Elle prend les arguments suivants : l'action cliqué, la fenêtre mère, l'article selectionné, le context
                FormulaireAdhesions actions = new FormulaireAdhesions(nom, this, adhesion, _context);

                this.Opacity = 0.7;
                actions.ShowDialog();
                this.Opacity = 1;
            }

        }
        public void ActionAdhesion(AdhesionsDTOIn adhesion, string action, int id)
        {
            // On met à jour la chambre en base de données
            // en fonction de l'action
            switch (action)
            { 
                case "Ajouter":
                    _adhesionsControllers.CreateAdhesion(adhesion);
                    break;
                case "Modifier":
                    _adhesionsControllers.UpdateAdhesion(id, adhesion);
                    break;
                case "Supprimer":
                    _adhesionsControllers.DeleteAdhesion(id);
                    break;
            }

            ActualiserTableau();
        }

        private void ActualiserTableau()
        {
            // on recharge le datagrid
            DgListeAdhesions.ItemsSource = _adhesionsControllers.GetAllAdhesions();
        }

        public void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

