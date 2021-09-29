using Microsoft.Win32;
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
using TP02_GARAGE.Model.ORM;

namespace TP02_GARAGE
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

        private void ImporterImage_Click(object sender, RoutedEventArgs e)
        {
            // Ouvir le fenetre pour selectionner un fichier
            // OpenFileIDialogue -- est la classe qui nous permet d'ouvre la boite qui permet de selectionner un fichier
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {

                //  MessageBox.Show("Vous avez selectionner le fichier "+ofd.FileName);
                  //imgVoiture.Source = ofd.FileName;
                string cheminFic = ofd.FileName;
                // pour récupérer une imageSource il faut
                // 1- convertir le Chemin en 
                // en ressource Unique Ressource  Idenfier --

                var r = new Uri(cheminFic);
                imgVoiture.Source = new BitmapImage(r);

            }
        }

        private void EnregistrerBase_Click(object sender, RoutedEventArgs e)
        {
            // Pour enregistrer une voiture
            // Approche 1 
            //
            Voiture v = new Voiture();
            v.Matricule = tbxMatricule.Text;
            v.MotifPanne = tbxDesc.Text;
            if (chkbSociete.IsChecked == true)
                v.EstVoitureDeSociete = "O";
            else
                v.EstVoitureDeSociete = "N";
            // Pour récupérer la source de l'image :
            //1- On fait un cast en BitmapImage
            //2- A partir de l'image on récipère la ressource et enfin le chemin de la ressouce
            v.ImageVoiture = ((BitmapImage)imgVoiture.Source).UriSource.AbsoluteUri;

            // Enregistrer en base
            // Pour celà on utilise le conteneur d'entités
            VoitureDBEntities db = new VoitureDBEntities();
            db.Voitures.Add(v); // ajouter la voiture à la liste

            // on dot sauvegarder (commit)
         int i=  db.SaveChanges(); // qui retourne un entier
                                   // si l'entier est SUP a 0 =OK sinon nOK

            if (i > 0)
            {
                MessageBox.Show("Sauvegardé en base");
            }
            else
                MessageBox.Show("Echec de l'enregistrement");



        }
    }
}
