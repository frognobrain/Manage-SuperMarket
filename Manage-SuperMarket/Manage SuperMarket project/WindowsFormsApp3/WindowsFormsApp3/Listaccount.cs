using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Listaccount
    {
        private static Listaccount instance;
        public static Listaccount Instance 
        { 
            get => instance; 
            set => instance = value; 
        }

        List<Account> Listaccounts;

        

        public List<Account> Listaccounts1 
        { 
            get => Listaccounts; 
            set => Listaccounts = value; 
        }
        
        
        Listaccount ()
        {
            Listaccounts1 = new List<Account> ();
            Listaccounts1.Add(new Account ("Manager","1",true));
            Listaccounts1.Add(new Account("Sales", "2",false));
            Listaccounts1.Add(new Account("Warehouse", "3",false));
        }
    }
}
