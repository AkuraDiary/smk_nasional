using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studikasus_smk_nasional.model
{
    internal class UserModel
    {
        public UserModel(int id_user, string username, string password, string level)
        {
            this.id_user = id_user;
            this.username = username;
            this.password = password;
            this.level = level;
        }
        public int id_user { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string level { get; set; }
    }
   
}
