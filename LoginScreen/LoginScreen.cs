using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : UserControl
    {
        HomePage hp = new HomePage();
        public static string username = "Bronson";
        public static string password = "abc123";

        public LoginScreen()
        {
            InitializeComponent();
        }
        //Button Click
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == username && passwordText.Text == password)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                HomePage hp = new HomePage();
                f.Controls.Add(hp);
                hp.Location = new Point((f.Width - hp.Width) / 2, (f.Height - hp.Height) / 2);
            }
            else 
            {
                label1.Text = "Login information incorrect";
            }

        }
    }
}
