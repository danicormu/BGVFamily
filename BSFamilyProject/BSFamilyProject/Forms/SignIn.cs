using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSFamilyProject.Forms;

namespace BSFamilyProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }else
            {
                lbl_message.Text = "Credenciales Incorrectas*";
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
