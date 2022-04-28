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
    /// Logique d'interaction pour ListeDons.xaml
    /// </summary>
    public partial class ListeDons : Window
    {
        MyDbContext _context;
        DonsControllers _donsControllers;
        public ListeDons(MyDbContext context)
        {


            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            _context = context;
            _donsControllers = new DonsControllers(_context);
            // On rempli la datagrid
            DgListeDons.ItemsSource = _donsControllers.GetAllDons();
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
            DonsDTOIn don = (DonsDTOIn)DgListeDons.SelectedItem;
            string nom = (string)((Button)sender).Content;
            // Si pas d'article sélectionné et click sur le bouton modifier ou supprimer, on affiche un message d'erreur
            if (don == null && (nom == "Modifier" || nom == "Supprimer"))
            {
                MessageBox.Show("Vous devez sélectionner une ligne", "Erreur de sélection");
            }
            else
            {
                // On ouvre la fenêtre de détail
                // Elle prend les arguments suivants : l'action cliqué, la fenêtre mère, l'article selectionné, le context
                FormulaireDons actions = new FormulaireDons(nom, this, don, _context);

                this.Opacity = 0.7;
                actions.ShowDialog();
                this.Opacity = 1;
            }

        }
        public void ActionDon(DonsDTOIn don, string action, int id)
        {
            // On met à jour don en base de données
            // en fonction de l'action
            switch (action)
            {
                case "Ajouter":
                    _donsControllers.CreateDon(don);
                    break;
                case "Modifier":
                    _donsControllers.UpdateDon(id, don);
                    break;
                case "Supprimer":
                    _donsControllers.DeleteDon(id);
                    break;
            }

            ActualiserTableau();
        }

        private void ActualiserTableau()
        {
            // on recharge le datagrid
            DgListeDons.ItemsSource = _donsControllers.GetAllDons();
        }

        public void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
