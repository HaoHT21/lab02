using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class userData
    {
        public string Id;
        public string Username;
        public int Level;
        

        public userData(string id,string username, int level)
        {
            Id = id;
            Username = username;
            Level = level;
        }
        public void GetInfor()
        {
            Console.WriteLine(":ID: " + Id + "|userName: " + Username + "|level: " + Level);

        }


        



    }
    
}
