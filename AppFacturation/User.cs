using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppFacturation
{
    class User
    {
       
       
       public string? Name { get; set; }
       public string? Email {  get; set; }
       public string? Password { get; set; }

        public User(string name, string mail , string pass ) { 
            Name= name;
            Email= mail;
            Password= pass; 
        }
        /*public string Affichage()
        {
            return $"{Name}, {Email} ,{Password}";
        }*/

    }
}
