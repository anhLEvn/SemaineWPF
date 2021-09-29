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

namespace TP01
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculTVA_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("pour calculer le TTC à partir du HT et de la TVA");

            // on a besoin de recuperer la HT saisie,
            // on a besoin de recupérer la TVA 
            // or ces 2 se trouvent dans des textBOX -- Alors  il faut nommer ces Text


          

            try
            {
                double ht = double.Parse(tbxHT.Text);
                double tva = double.Parse(tbxTVA.Text);
                double ttc = ht + ht * tva / 100;
                //   MessageBox.Show($"La valeur TTC est :{ttc}");

                lblTTC.Content = ttc;

            }
            catch (Exception ex)
            {

                lblTTC.Content = "Saisie incorrecte "+ex.Message;
            }
        }
    }
}
