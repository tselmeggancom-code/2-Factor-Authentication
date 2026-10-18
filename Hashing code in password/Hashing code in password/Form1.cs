using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashing_code_in_password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string user = User.Text;
            string password = Password.Text;
            string email = Email.Text;
            details NewUser = new details(user, password,email);
            bool checker = NewUser.CheckUsername();
            bool emailcheck = NewUser.checkEmail();
            if (checker == false)
            {
                if (emailcheck == false)
                {
                    Display.Text = string.Empty;
                    Display.ForeColor = Color.Black;
                    bool hashablepass = NewUser.hashPassword();
                    NewUser.CreateLogin();
                    Display.Text = "Account Registered";
                    Display.ForeColor = Color.Green;
                }
            }
            else if (checker == true)
            {
                Display.Text = "Did not Register";
                Display.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forget_Password window = new Forget_Password();
            window.ShowDialog();
        }

    }
}
