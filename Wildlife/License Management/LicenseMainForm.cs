using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wildlife;
using Wildlife.License_Management;

namespace Wildlife
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Renew renew = new Renew();
            renew.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Specie specie = new Specie();
            specie.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            challan fine = new challan();
            fine.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Registration Reg = new Registration();
            Reg.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            shooting_Permit shoot = new shooting_Permit();
            shoot.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Verification verify = new Verification();
            verify.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            ViolationTypes violation = new ViolationTypes();
            violation.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            LicenseEntry lic = new LicenseEntry();
            lic.Show();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
