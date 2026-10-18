using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Printing;//This is what you have to import inorder to get the things

namespace Hashing_code_in_password
{
    class details
    {
        private string UserEmail;
        private string password;
        private string username;
        public string passcheck
        {
            get { return password; }
            set
            {
                if (value.Length > 8)
                {
                    int number = 0;
                    foreach (char letter in value)
                    {  

                        if (int.TryParse(letter.ToString(), out number) == true)
                        {
                            password = value;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password must be bigger than 8 letters","Error");
                    password = "Wrong123";
                }
            }
        }

        public details( string username, string passcheck,string useremail )
        {
            this.username = username;
            this.passcheck = passcheck;
            this.UserEmail = useremail;
        }

        public string filepath()
        {
            string filepath = Directory.GetCurrentDirectory();
            return filepath = filepath + $"\\Logins.txt";
        }
        public string[] Contents()
        {
            string[] contents = File.ReadAllLines(filepath());
            return contents;
        }

        public bool CheckUsername()
        {
            if (Contents().Length != 0)
            {
                foreach (string username1 in Contents())
                {
                    string checkuser = username1.Split(',')[0];
                    if (checkuser == username)
                    {
                        MessageBox.Show("Username already used","Error");
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public bool hashPassword()
        {
            if (password != "Wrong123")
            {
                var HashingAlgorithim = SHA256.Create();
                var BytesArray = Encoding.Default.GetBytes(passcheck);
                var hashpassword = HashingAlgorithim.ComputeHash(BytesArray);
                string newpassword = Convert.ToBase64String(hashpassword);
                password = newpassword;
                
                return true;
            }
            return false;
        }

        public void CreateLogin()
        {
            if (password != "Wrong123")
            {
                using (StreamWriter writetofile = new StreamWriter(filepath(), append: true))//this is to efficiently to enter details
                {
                    writetofile.WriteLine(username +","+ UserEmail+"," + password);
                }
            }
        }
        public bool checkEmail()
        {
            if (UserEmail.Contains("@") == true && UserEmail.EndsWith(".com") || UserEmail.EndsWith(".co.uk"))
            {
                string[] contents = Contents();
                if (contents.Length > 3)//this is because the csv file counts the " " as a item in the array therefore i have inplemeneted the 3 instead
                {
                    foreach (string users in contents)
                    {
                        if (UserEmail == users.Split(',')[1])
                        {
                            MessageBox.Show("Email already used", "Error");
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }
            else
            {
                MessageBox.Show("Write a correct email");
                return true;
            }
        }
    }
}
