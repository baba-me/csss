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
    public partial class Renew : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public Renew()
        {
            InitializeComponent();
        }

        private void Renew_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
            MySqlCommand cmd = new MySqlCommand("select * from license_reg", con);
            MySqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmblicno.Items.Add(r["l_no"].ToString());
                cmbsearch.Items.Add(r["l_no"].ToString());
            }
            r.Close();
            con.Close();
        }

        private void clr()
        {
            txtreid.Clear();
            cmblicno.ResetText();
            renedate.ResetText();
            expdate.ResetText();
            txtrenfee.Clear();
            txtname.Clear();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmblicno.SelectedIndex < 0 || txtrenfee.Text == "" || txtname.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from renew where renewal_id='" + txtreid.Text + "'", con);
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
                    MySqlCommand cmd1 = new MySqlCommand("insert into renew(renewal_id,l_no,renewal_date,expiry_date,amount)Values('" + txtreid.Text + "','" + cmblicno.SelectedItem.ToString() + "','" + renedate.Value.ToShortDateString() + "','" + expdate.Value.ToShortDateString() + "','" + txtrenfee.Text + "')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_save);
                    con.Close();
                    MySqlCommand cmd3 = new MySqlCommand("update license_reg set expiry_date='" + expdate.Value.ToShortDateString() + "' where l_no='" + cmblicno.SelectedItem.ToString() + "'", con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    clr();
                    cmblicno.Focus();
                }
            }
        }

        private void cmblicno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand("select * from license_reg where l_no='"+cmblicno.SelectedItem.ToString()+"'", con);
            MySqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            if(r.Read())
            {
                txtname.Text = r["name"].ToString();
                r.Close();
                con.Close();
            }
            else
            {
                r.Close();
                con.Close();
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmblicno.SelectedIndex < 0 || txtrenfee.Text == "" )
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from renew where renewal_id='" + txtreid.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand("Update renew set renewal_date='" + renedate.Value.ToShortDateString() + "',expiry_date='" + expdate.Value.ToShortDateString() + "',amount='" + txtrenfee.Text + "' where renewal_id='" + txtreid.Text + "'", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_updated);
                    con.Close();
                    clr();

                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_dosexit);
                }
            }
        }

        private void btndelate_Click(object sender, EventArgs e)
        {
            if (cmblicno.SelectedIndex < 0 || txtrenfee.Text == "" )
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from renew where renewal_id='" + txtreid.Text + "'", con);
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

                        MySqlCommand cmd1 = new MySqlCommand("Delete from renew where renewal_id='" + txtreid.Text + "'", con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(obj.rec_delete);
                        clr();
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
        private void serch()
        {
            if (cmbsearch.SelectedIndex<0)
            {
                MessageBox.Show("Please Select License No!");
            }
            else
            {
               MySqlDataAdapter ad = new MySqlDataAdapter("select * from  renew where l_no='"+cmbsearch.SelectedItem.ToString()+"'", con);
               DataSet ds = new DataSet();
               ad.Fill(ds, 0, 0, "renew");
               dataGridView1.DataSource = ds.Tables["renew"];
            }
            int n = dataGridView1.RowCount;
            if (n == 0)
            {
                MessageBox.Show(obj.no_recfound);
            }
            
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            serch();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtreid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmblicno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            renedate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            expdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtrenfee.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clr();
        }
    }
}