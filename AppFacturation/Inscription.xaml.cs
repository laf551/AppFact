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
        public void AddUser(object sender, RoutedEventArgs e)
        {
            string inputmail = obtenirMail.Text;
            string inputname = obtenirName.Text;
            string inputpass = obtenirPass.Text;

            //DataConnect myConnexion = new DataConnect();
            // myConnexion.Insert(inputname, inputmail, inputpass);





           



            /* using (MySqlConnection conn = new MySqlConnection(connectData))
             {
                 conn.Open();
                 string Insertquery = "INSERT INTO `user`( `NameUser`, `EmailUser`, `PasswordUser`) " +
                     "VALUES (@name,@mail,@password)";
                 using (MySqlCommand cmd = new MySqlCommand(Insertquery, conn))
                 {
                     cmd.Parameters.AddWithValue("@name", inputname);
                     cmd.Parameters.AddWithValue("@mail", inputmail);
                     cmd.Parameters.AddWithValue("@password", inputpass);

                     cmd.ExecuteNonQuery();
                 }

             }*/






           

            /*foreach (var user in myfirstList)
            {
               // afficher.ItemsSource = user.Name;
                Console.WriteLine(user);
            }*/



            /* foreach (User user in listUserData){
                                     = user.Email;
                                     = user.Name;
                                     = user.Password;

             }*/

            List<User> myfirstList = new List<User>
            {
               new User(inputname, inputmail, inputpass)
            };

           // MessageBox.Show($"Bonjour {myfirstList}");
            





            ListView UserLV = new ListView();
            UserLV.Items.Add(myfirstList);
            usersListBox.ItemsSource = myfirstList;

           

        }
        public void affciherTest(object sender, RoutedEventArgs e)
        {
            List<User> Contacts = new List<User>(); 
            
            Contacts.Add(new User("John", "Doe", "Contoso"));
            Contacts.Add(new User("Jane", "Doe", "Fabrikam"));
            Contacts.Add(new User("Santa", "Claus", "Alpine Ski House"));

            
            ListView ContactsLV = new ListView();
            ContactsLV.ItemsSource = Contacts;

           




        }
        //myfirstList

        /*var inputList = new List<User> { 
           new User{Name = obtenir.Text , 
           Email = obtenir.Text , 
           Id = obtenir.Text,
           Password = obtenir.Text
           }*/
            //}
            /*LbxUtilisateurs.ItemsSource = new List<Utilisateur> {
                new Utilisateur { Nom = "Max"}, new Utilisateur {Nom ="Marie" }*/
            //};

            // Afficher le texte dans le TextBlock
            //obtenir.Text = inputText;



            



        }
    }
