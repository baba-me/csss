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
    public partial class Specie : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public Specie()
        {
            InitializeComponent();
        }
        private void clr()
        {
            txtsp_id.Clear();
            txtsp_name.Clear();
            txtsrch.Clear();
            txtsp_amount.Clear();
        }
        private void Specie_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txtsp_id.Text == "" || txtsp_name.Text == "" || txtsp_amount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd1 = new MySqlCommand("select * from specie where specie_name='" + txtsp_name.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd1.ExecuteReader();
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
                    MySqlCommand cmd = new MySqlCommand("insert into specie(specie_id,specie_name,amount)values('" + txtsp_id.Text + "','" + txtsp_name.Text + "','" + txtsp_amount.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_save);
                    con.Close();
                    clr();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txtsp_id.Text == "" || txtsp_name.Text == "" || txtsp_amount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select * from specie where specie_name='" + txtsp_name.Text + "'", con);
                con.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand("update specie set amount='" + txtsp_amount.Text + "'where specie_name='" + txtsp_name.Text + "'", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(obj.rec_updated);

                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.no_recfound);

                }
                clr();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtsrch.Text == "")
            {
                MessageBox.Show("Enter Specie Name!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select * from specie where specie_name='" + txtsrch.Text + "'", con);
                con.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txtsp_id.Text = r["specie_id"].ToString();
                    txtsp_name.Text = r["Specie_name"].ToString();
                    txtsp_amount.Text = r["amount"].ToString();
                    r.Close();
                    con.Close();

                }
                else
                {
                    r.Close();
                    con.Close();
                    MessageBox.Show(obj.rec_dosexit);
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtsp_id.Text == "" || txtsp_name.Text == "" || txtsp_amount.Text == "")
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select * from specie where specie_name='" + txtsp_name.Text + "'", con);
                con.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    DialogResult dr = MessageBox.Show(obj.rec_confirm, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        MySqlCommand cmd1 = new MySqlCommand("delete from specie where specie_name='" + txtsp_name.Text + "'", con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(obj.rec_delete);
                    }
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
    }
}
