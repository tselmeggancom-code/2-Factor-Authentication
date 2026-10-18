using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_code_in_password
{
    class ChangePassword:details
    {
        private string username;
        private string passsword;
        private string email;

        public ChangePassword(string username, string passsword, string email):base(username,passsword,email)
        {
            this.username = username;
            this.passsword = passsword;
            this.email = email;
        }

        public void Reset_The_Details()
        {
            StreamWriter sw = new StreamWriter(filepath());
            sw.Write(" ");
            sw.Close();
        }
        
        
    }
}
