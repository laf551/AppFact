﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppFacturation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
           /*
            LbxUtilisateurs.ItemsSource = new List<Utilisateur> {
                new Utilisateur { Nom = "Max"}, new Utilisateur {Nom ="Marie" }
            };*/
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ouvre la page d'inscription
            Inscription secondPage = new Inscription();
            this.Content = secondPage;
        }
    }
}