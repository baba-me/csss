using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Wildlife.License_Management
{
    public partial class LicenseEntry : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public LicenseEntry()
        {
            InitializeComponent();
        }
        
        private void Category_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
            MySqlCommand cmd = new MySqlCommand("Select * from license",con);
            MySqlDataReader r;
            con.Open();
            r=cmd.ExecuteReader();
            while(r.Read())
            {
                cmbsearch.Items.Add(r["l_category"].ToString());

            }
            r.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clr()
        {
            txtlicid.Clear();
            txtlicname.Clear();
            txtamt.Clear();
            txtlicname.Focus();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtlicid.Text == "" || txtamt.Text == "" || txtlicname.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from license where l_category='" + txtlicname.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_exist);
                }
                else
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand("insert into license(l_id,l_category,amount)Values('" + txtlicid.Text + "','" + txtlicname.Text + "','" + txtamt.Text + "')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_save);
                    clr();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtamt.Text == "" || txtlicid.Text == "" || txtlicname.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from license where l_category='" + txtlicname.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand("Update license set amount='" + txtamt.Text + "' where l_category='" + txtlicname.Text + "'", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_updated);
                    con.Close();
                    clr();
                    cmbsearch.Focus();

                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_dosexit);
                }
            }
        }

        private void btnsearach_Click(object sender, EventArgs e)
        {
            if (cmbsearch.SelectedIndex < 0)
            {
                MessageBox.Show("Select License Category!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from license where l_category='" + cmbsearch.SelectedItem.ToString() + "' ", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txtlicid.Text = r["l_id"].ToString();
                    txtlicname.Text = r["l_category"].ToString();
                    txtamt.Text = r["amount"].ToString();
                    r.Close();
                    con.Close();
                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.no_recfound);

                }
            }
        }

        private void btndelate_Click(object sender, EventArgs e)
        {
            if (txtamt.Text == "" || txtlicid.Text == "" || txtlicname.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from license where l_category='" + txtlicname.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    DialogResult dr = MessageBox.Show(obj.rec_confirm, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {

                        MySqlCommand cmd1 = new MySqlCommand("Delete from license where l_category='" + txtlicname.Text + "'", con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(obj.rec_delete);
                        clr();
                        cmbsearch.Focus();
                    }
                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_dosexit);

                }
            }
        }
    }
}
