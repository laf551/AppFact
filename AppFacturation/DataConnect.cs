using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Xml.Linq;

namespace AppFacturation
{

   public class DataConnect
    {
        private string ConnectData { get; set; }

        public DataConnect()
        {

            ConnectData = "server=localhost;Database=envoicedata;port=3306;user=root;password=;";

        }

        /* public void Insert(string nameUser, string mailUser, string passUser)
         {
             using (MySqlConnection conn = new MySqlConnection(ConnectData))
             {
                 try
                 {
                     conn.Open();
                     string Insertquery = "INSERT INTO `user`( `NameUser`, `EmailUser`, `PasswordUser`) " +
                         "VALUES (@name,@mail,@password)";
                     using (MySqlCommand cmd = new MySqlCommand(Insertquery, conn))
                     {
                         cmd.Parameters.AddWithValue("@name", nameUser);
                         cmd.Parameters.AddWithValue("@mail", mailUser);
                         cmd.Parameters.AddWithValue("@password", passUser);

                         cmd.ExecuteNonQuery();
                     }
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.ToString());
                 }


             }
         }
*/
        public List<User> Display()
        {
            List<User>? listuser = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(ConnectData))
            {
                //MessageBox.Show($"hello ! ");
                try
                {
                    conn.Open();
                    // List<User> listUser = new List<User>();
                    string selectQuery = "SELECT * FROM `user`";
					MessageBox.Show($"hello ! ");
					using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            //ObservableCollection<User> ligne = new ObservableCollection<User>();

                            while (reader.Read())
                            {

                                //all.Add(rowUser);
                                //User rowUser = new User($"{reader[1] }", $"{reader[2]}" ,$" {reader[3]}");
                                /*User rowUser = new User()
                                {
                                    Name = reader["NameUser"].ToString(),
                                    Email = reader["EmailUser"].ToString(),
									Password = reader["Password"].ToString()
								};*/

                                listuser.Add(new User {
									Name = reader[1].ToString(),
									Email = reader[2].ToString(),
									Password = reader[3].ToString()

								});

                            }
                            
                        }
                    }
                    
				    
				}
                catch (Exception ex)
                {
                    MessageBox.Show($"hello ! {ex} ");
                    return listuser;  
                }

            };
			return listuser;
		}
    }
}
        
            /*
        public void  display() {
            MessageBox.Show($" Deuxieme Bonjour ");
            using (MySqlConnection conn = new MySqlConnection(connectData))
            {
                MessageBox.Show($" Troisieme Bonjour ");
                try {
                    conn.Open();
                    string selectQuery = "SELECT * FROM `user`";
                    MessageBox.Show($" Quatrieme Bonjour ");
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                        
                    {
                        MessageBox.Show($" Cinquième Bonjour ");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show($" Sixième Bonjour ");
                            List<User> listUserData = new List<User>();
                           /* while (reader.Read()) {
                                User u = new User(reader["name"].ToString(), reader["mail"].ToString() , reader["pass"].ToString()); 
                                listUserData.Add(u);
                                //listUserDa
                                MessageBox.Show($" Septième Bonjour ");

                            }

                            foreach (User user in listUserData)
                            {
                                Console.WriteLine(user);
                                MessageBox.Show($"Bonjour huitième");
                                *//*foreach (User u in listUserData) {
                                secondList.Name = user.Email;
                                secondList.Name = user.Name;
                                secondList.Name = user.Password;
                                 }*//*
                            }
                          

                            // List<User> users = new List<User>();
                            ListView UserLV = new ListView();
                            UserLV.Items.Add(listUserData);
                            */
                            //usersListBox.ItemsSource = myfirstList;

                            

                            /* ListView secondList = new ListView();
                             */


                            /*List<User> myfirstList = new List<User> {
                                new User { Name = inputname , Email = inputmail , Password= inputpass },
                                    //new User { Name = "Bob", Email = "hiahio", Password="huhao" },
                                    //new User { Name = "Charlie",Email = "hiahio", Password="huhao"  }
                                };*/

                                //ListView secondList = new ListView();


                                /*foreach (User user in listUserData)
                                {

                                       *//* = user.Email;
                                        = user.Name;
                                        = user.Password;*//*

                                }*/

/*
                            };
                       
                    };
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
*/
                
        //    }  
            


//}


//}       
   
//}

