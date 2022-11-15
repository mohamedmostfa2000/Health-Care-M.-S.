using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_M.S
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text=="" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }

            else if (UnameTb.Text=="Admin" && PasswordTb.Text == "Password")
            {
                Patients obj = new Patients();
                obj.Show();
                this.Hide();
            }

            else
            {
                UnameTb.Text = "";
                PasswordTb.Text = "";

            }
        }

        
    }
}
