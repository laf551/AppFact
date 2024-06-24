using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
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
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient; 


namespace AppFacturation
{

    public partial class Inscription : Page
    {
        public DataConnect dt ; 
       

		public Inscription()
        {

            InitializeComponent();
            
        }
		
		private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // password202000"
            if (textBox.Text == "Enter your email")
            {
                textBox.Text = "";
            }
            // test 2024
            else if (textBox.Text == "Enter your password")
            {
                textBox.Text = "";
            } else if (textBox.Text == "Enter your name")
            {
                textBox.Text = "";
            }

        }
        private void Button_signIn(object sender, RoutedEventArgs e)
        {
            //ouvre la page d'inscription
            MainWindow firstpage = new MainWindow();

            firstpage.Show();

        }
        private void AddUser(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("hey"); 
        }
        private void Button_display(object sender, RoutedEventArgs e)
        {
			dt = new DataConnect();
            List<User> collectUser =  dt.Display();

		    usersListBox.ItemsSource = collectUser;
			




		}
        

    }
}  