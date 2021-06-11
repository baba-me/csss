using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wildlife.Properties;

namespace Wildlife
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile3.TileImage = Resources.license;
        }
        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            metroTile3.TileImage = Resources.bg;
        }

        private void metroTile4_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile4.TileImage = Resources.location;
        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            metroTile4.TileImage = Resources.bg;
        }

        private void metroTile6_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile6.TileImage = Resources.peoplecases;
        }

        private void metroTile6_MouseLeave(object sender, EventArgs e)
        {
            metroTile6.TileImage = Resources.bg;
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile1.TileImage = Resources.attendance;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.TileImage = Resources.bg;
        }

        private void metroTile2_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile2.TileImage = Resources.eventt;
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            metroTile2.TileImage = Resources.bg;
        }

        private void metroTile5_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile5.TileImage = Resources.money;
        }

        private void metroTile5_MouseLeave(object sender, EventArgs e)
        {
            metroTile5.TileImage = Resources.bg;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
