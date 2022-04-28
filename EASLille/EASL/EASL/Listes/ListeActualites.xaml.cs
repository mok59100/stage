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
    /// Logique d'interaction pour ListeActualites.xaml
    /// </summary>
    public partial class ListeActualites : Window
    {
        MyDbContext _context;
        ActualitesControllers _actualitesControllers;
        public ListeActualites(MyDbContext context)
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = context;
            _actualitesControllers = new ActualitesControllers(_context);
            // On rempli la datagrid
            DgListeActualites.ItemsSource = _actualitesControllers.GetAllActualites();
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
            ActualitesDTOIn actualite = (ActualitesDTOIn)DgListeActualites.SelectedItem;
            string nom = (string)((Button)sender).Content;
            // Si pas d'article sélectionné et click sur le bouton modifier ou supprimer, on affiche un message d'erreur
            if (actualite == null && (nom == "Modifier" || nom == "Supprimer"))
            {
                MessageBox.Show("Vous devez sélectionner une ligne", "Erreur de sélection",MessageBoxButton.OK, MessageBoxImage.Information); 
            }
            else
            {
                // On ouvre la fenêtre de détail
                // Elle prend les arguments suivants : l'action cliqué, la fenêtre mère, l'article selectionné, le context
                FormulaireActualites actions = new FormulaireActualites(nom, this ,actualite , _context);
                this.Opacity = 0.7;
                actions.ShowDialog();
                this.Opacity = 1;

            }

        }
            public void ActionActualite (ActualitesDTOIn actualite, string action,int id)
            {
                // On met à jour la chambre en base de données
                // en fonction de l'action
                switch (action)
                {
                    case "Ajouter":
                        _actualitesControllers.CreateActualite(actualite);
                        break;
                    case "Modifier":
                        _actualitesControllers.UpdateActualite(id,actualite);
                        break;
                    case "Supprimer":
                        _actualitesControllers.DeleteActualite(id);
                        break;
                }

                ActualiserTableau();
            }

            private void ActualiserTableau()
            {
                // on recharge le datagrid
                DgListeActualites.ItemsSource = _actualitesControllers.GetAllActualites();
            }

            public void Retour(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }
    }
