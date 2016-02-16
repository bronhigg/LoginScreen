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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome back Bronson.";
        }

        
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            HomePage hp = new HomePage();
            f.Controls.Add(ls);
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
