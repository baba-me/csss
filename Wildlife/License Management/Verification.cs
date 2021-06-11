using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wildlife.License_Management
{
    public partial class Verification : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public Verification()
        {
            InitializeComponent();
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cmbsrch.SelectedIndex < 0 || txtsearch.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                if (cmbsrch.SelectedIndex == 0)
                {

                    MySqlDataAdapter ad = new MySqlDataAdapter("select * from  license_reg where l_no='" + txtsearch.Text + "'", con);
                    DataSet ds = new DataSet();
                    ad.Fill(ds, 0, 0, "license_reg");
                    dataGridView1.DataSource = ds.Tables["license_reg"];
                }
                else if (cmbsrch.SelectedIndex == 1)
                {

                    MySqlDataAdapter ad = new MySqlDataAdapter("select * from  license_reg where name='" + txtsearch.Text + "'", con);
                    DataSet ds = new DataSet();
                    ad.Fill(ds, 0, 0, "license_reg");
                    dataGridView1.DataSource = ds.Tables["license_reg"];

                }
                else if (cmbsrch.SelectedIndex == 2)
                {

                    MySqlDataAdapter ad = new MySqlDataAdapter("select * from  license_reg where cnic='" + txtsearch.Text + "'", con);
                    DataSet ds = new DataSet();
                    ad.Fill(ds, 0, 0, "license_reg");
                    dataGridView1.DataSource = ds.Tables["license_reg"];


                }
                int n = dataGridView1.RowCount;
                if (n == 0)
                {
                    MessageBox.Show(obj.no_recfound);
                }
            }
        }
    }
}
