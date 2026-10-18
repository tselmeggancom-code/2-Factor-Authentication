using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hashing_code_in_password
{
    public partial class Forget_Password : Form
    {
        TextBox T;
        Button B;
        Button PasswordB;
        string code;
        public string username;
        public string email;
        public Forget_Password()
        {
            InitializeComponent();
        }

        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            username = Forgetten_username.Text;
            string email = EmailF();
            if (email == "no username found")
            {
                EmailDisplay.Text = email;          
            }
            else
            {
                this.Controls.Clear();
                Random randgen = new Random();
                code = string.Empty;
                for (int i = 0; i < 6; i++)
                {
                    int num = randgen.Next(1, 10);
                    code = num.ToString() + code;
                }
                SendEmail(email, code);
                T= LabelAdd("We have sent a code to the email, please enter it below");
                B= ButtonAdd("Confirm");
                B.Click += Button_Click;
            }
        }



        public void Button_Click(object sender, EventArgs e)
        {
            if(T.Text == code)
            {
                MessageBox.Show("It has worked");
                code = "CodehasBeenCompleted";
                this.Controls.Clear();
                T = LabelAdd("Enter the new password please");
                PasswordB = ButtonAdd("Confirm");
                PasswordB.Click += PasswordChange;
                
            }
            else if (T.Text != code)
            {
                MessageBox.Show("The code is wrong");
            }
        }

        private void PasswordChange(object sender, EventArgs e)
        {
            string password = T.Text;
            ChangePassword newpassworduser = new ChangePassword(username, password, email);            
            newpassworduser.hashPassword();
            newpassworduser.Reset_The_Details();
            newpassworduser.CreateLogin();
            this.Close();
        }

        private TextBox LabelAdd(string text)//do this first
        {
            System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
            TextBox T = new TextBox();
            T.Size = new Size(215, 22);
            T.Location = new Point(200, 176);
            lb.Size = new Size(300, 16);
            lb.Location = new Point(200, 146);
            lb.Text = text;
            this.Controls.Add(lb);this.Controls.Add(T);
            return T;
        }
        private Button ButtonAdd(string text)//add button
        {
            Button newbut = new Button();
            newbut.Size = new Size(70, 28);
            newbut.Location = new Point(280, 220);
            newbut.Text = text;
            this.Controls.Add(newbut);
            return newbut;
        }
        private void SendEmail(string email,string code)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 25,
                Credentials = new NetworkCredential("superdragonman654@gmail.com", "vpjw bdch hqxz mddc"),
                EnableSsl = true,
            };

            smtpClient.Send("superdragonman654@gmail.com", email, "2 factor Authenication", "Code:" + code);
        }
    
        public string EmailF()
        {
            string[] contents = File.ReadAllLines(Directory.GetCurrentDirectory() + $"\\Logins.txt" );
            foreach(string line in contents)
            {
               if (line.Split(',')[0] == Forgetten_username.Text)
                {
                    email = line.Split(',')[1];
                    return email;
                }
            }
            return "no username found";
        }
    }
}
