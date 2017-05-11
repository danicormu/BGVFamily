using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSFamilyProject.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            ControlPanel.Hide();
        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseSessionBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            PositionLabel.Text = "Clientes";
            TabPanel.Show();
            ControlPanel.Show();
        }

        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show(); 
        }

        private void ClientAdmiBtn_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label2.Show();  
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            TabPanel.Hide();
            ControlPanel.Hide();
            PositionLabel.Text = "Dashboard";
        }

        // metodos de control de controles XD




    }
}
