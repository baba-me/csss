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
    public partial class ViolationTypes : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public ViolationTypes()
        {
            InitializeComponent();
        }
        private void clr ()
        {
            txtid.Clear();
            cmbsrch.ResetText();
            txtvtype.Clear();
            txtvamount.Clear();
        }
        private void showvoli()
        {
            MySqlCommand cmd = new MySqlCommand("select * from violation",con);
            MySqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                cmbsrch.Items.Add(r["violation_type"].ToString());
            }
            r.Close();
            con.Close();
        }
        private void ViolationTypes_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
            showvoli();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtvtype.Text == "" || txtvamount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from violation where violation_type='" + txtvtype.Text + "'", con);
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
                    MySqlCommand cmd1 = new MySqlCommand("insert into violation(violation_id,violation_type,fine_amount)Values('" + txtid.Text + "','" + txtvtype.Text + "','" + txtvamount.Text + "')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_save);
                    con.Close();
                    showvoli();
                    clr();
                    txtvtype.Focus();

                    
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtvtype.Text == "" || txtvamount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from violation where violation_type='" + txtvtype.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand("Update violation set   fine_amount='" +txtvamount.Text + "'where violation_type = '"+txtvtype.Text+"'", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_updated);
                    con.Close();
                    
                   

                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_dosexit);
                }
                clr();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbsrch.SelectedIndex < 0)
            {
                MessageBox.Show("Select Violation Type!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select * from violation where violation_type='" + cmbsrch.SelectedItem.ToString() + "'", con);
                con.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txtid.Text = r["violation_id"].ToString();
                    txtvtype.Text = r["violation_type"].ToString();
                    txtvamount.Text = r["fine_amount"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtvtype.Text == "" || txtvamount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from violation where violation_type='" + txtvtype.Text + "'", con);
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

                        MySqlCommand cmd1 = new MySqlCommand("Delete from violation where violation_type='" + txtvtype.Text + "'", con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(obj.rec_delete);
                        clr();
                        cmbsrch.Focus();
                        showvoli();
                        con.Close();
                       
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
