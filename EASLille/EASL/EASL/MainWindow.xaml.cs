using EASL.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EASL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDbContext _context;
        public MainWindow()
        {
            InitializeComponent();
            // centrer la fenetre
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = new MyDbContext();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Visibility = Visibility.Hidden;
            accueil.ShowDialog();
            this.Visibility = Visibility.Visible;
        }
    }
}
