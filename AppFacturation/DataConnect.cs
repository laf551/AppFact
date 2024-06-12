using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppFacturation
{

    class DataConnect
    {
        private string connectData { get; set;}
    
        public DataConnect() { 

           connectData="server=localhost;Database=envoicedata;port=3306;user=root;password=;";
            
        }

        public void Insert(string nameUser, string mailUser , string passUser)
        {
            using (MySqlConnection conn = new MySqlConnection(connectData))
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
                catch (Exception ex) { 
                }
                

            }
        }
        public void display() {
            using (MySqlConnection conn = new MySqlConnection(connectData))
            {
                try {
                    conn.Open();
                    string selectQuery = "SELECT * FROM `user`";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<User> listUserData = new List<User>();
                            while (reader.Read()) {
                                User u = new User(reader["name"].ToString(), reader["mail"].ToString() , reader["pass"].ToString()); 
                                listUserData.Add(u);
                                //listUserDa

                                
                            }
                           // List<User> users = new List<User>();

                            


                            ListView secondList = new ListView();
                            foreach (User user in listUserData)
                            {
                                secondList.Name  = user.Email;
                                secondList.Name = user.Name;
                                secondList.Name  = user.Password;
                            }


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


                        };
                       
                    };
                }
                catch (Exception e) { 
                
                }

                
            } return; 
            


        }


}       
   
}

