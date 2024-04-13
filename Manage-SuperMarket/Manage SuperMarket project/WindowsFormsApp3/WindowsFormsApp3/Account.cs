using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Account
    {
        private string Username;

        public string Username1
        { 
            get => Username; 
            set => Username = value; 
        }
        

        private string Password;
        public string Password1 
        { 
            get => Password; 
            set => Password = value; 
        }


        private bool loaiaccount;
        public bool Loaiaccount 
        { 
            get => loaiaccount; 
            set => loaiaccount = value; 
        }
        public Account (string username, string password, bool Loaiaccount)
        {
            this.Username = username;
            this.Password = password;
            this.Loaiaccount = Loaiaccount;
        }
    }
}
