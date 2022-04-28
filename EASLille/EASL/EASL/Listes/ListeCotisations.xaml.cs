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

namespace EASL.Listes
{
    /// <summary>
    /// Logique d'interaction pour ListeCotisations.xaml
    /// </summary>
    public partial class ListeCotisations : Window
    {
        MyDbContext _context;
        CotisationsControllers _cotisationsControllers;
        public ListeCotisations(MyDbContext context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = context;
            _cotisationsControllers = new CotisationsControllers(_context);
            // On rempli la datagrid 
         DgListeCotisations.ItemsSource = _cotisationsControllers.GetAllCotisations();
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
            CotisationsDTOIn cotisation = (CotisationsDTOIn)DgListeCotisations.SelectedItem;
                string nom = (string)((Button)sender).Content;
                // Si pas d'article sélectionné et click sur le bouton modifier ou supprimer, on affiche un message d'erreur
                if (cotisation == null && (nom == "Modifier" || nom == "Supprimer"))
                {
                    MessageBox.Show("Vous devez sélectionner une ligne", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
                else
                {
                // On ouvre la fenêtre de détail
                // Elle prend les arguments suivants : l'action cliqué, la fenêtre mère, l'article selectionné, le context
                FormulaireCotisations actions = new FormulaireCotisations(nom, this, cotisation, _context);

                    this.Opacity = 0.7;
                    actions.ShowDialog();
                    this.Opacity = 1;
                }

            }
            public void ActionCotisation(CotisationsDTOIn cotisation, string action, int id)
            {
                // On met à jour la chambre en base de données
                // en fonction de l'action
                switch (action)
                {
                    case "Ajouter":
                    _cotisationsControllers.CreateCotisation(cotisation);
                        break;
                    case "Modifier":
                    _cotisationsControllers.UpdateCotisation(id, cotisation);
                        break;
                    case "Supprimer":
                    _cotisationsControllers.DeleteCotisation(id);
                        break;
                }

                ActualiserTableau();
            }

            private void ActualiserTableau()
            {
            // on recharge le datagrid
             DgListeCotisations.ItemsSource = _cotisationsControllers.GetAllCotisations();
            }

            public void Retour(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }
    }
