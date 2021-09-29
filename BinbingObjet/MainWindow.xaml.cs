using BinbingObjet.Model;
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

namespace BinbingObjet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Client client = new Client();
        public MainWindow()
        {
            InitializeComponent();
            // pour faire la lian*ison avec un objet
            // 1- on définit le context de binding DataConntext

            DataContext = client; // la liaison se fait avec le client
            client.Id = 40;
            // définir le binding 
        }

        private void GenererClient_Click(object sender, RoutedEventArgs e)
        {
            // générer automatique des noms de client
            int auHazard = new Random().Next(1, 1000);
            client.Id = auHazard;
            client.Nom = "Nom " + auHazard;
            client.Prenom = "Prenom" + auHazard;
            client.Mail = "nom.prenom" + auHazard + "@gmail.com";

            // Sans le binding

                    //tbxNum.Text = client.Id.ToString();
                    //tbxNom.Text = client.Nom;
                    //tbxPrenom.Text = client.Prenom;
                    //tbxMail.Text = client.Mail;

            // En utilisant le binding
        }
    }
}
