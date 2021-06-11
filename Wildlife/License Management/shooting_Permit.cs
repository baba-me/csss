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
    public partial class shooting_Permit : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public shooting_Permit()
        {
            InitializeComponent();
        }

        private void shooting_Permit_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
            MySqlCommand cmd = new MySqlCommand("select * from license_reg where l_category='Shooting'", con);
            MySqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                cmblicno.Items.Add(r["l_no"].ToString());
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
            txttokenid.Clear();
            cmblicno.ResetText();
            txtname.Clear();
            txtfee.Clear();
            cmbhuntingdog.ResetText();
            cmbweapon.ResetText();
            expirydate.ResetText();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txttokenid.Text == "" || cmblicno.SelectedIndex<0  || txtname.Text == "" || txtfee.Text=="" || cmbhuntingdog.SelectedIndex<0 || cmbweapon.SelectedIndex<0)
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from shooting_permit where token_id='" + txttokenid.Text + "'", con);
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
                    MySqlCommand cmd1 = new MySqlCommand("insert into shooting_permit(token_id,l_no,name,permit_fee,hunting_dog,weapon,expiry_date)Values('" + txttokenid.Text + "','" + cmblicno.SelectedItem.ToString() + "','" + txtname.Text + "','"+txtfee.Text+"','"+cmbhuntingdog.SelectedItem.ToString()+"','"+cmbweapon.SelectedItem.ToString()+"','"+expirydate.Value.ToShortDateString()+"')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_save);
                    clr();
                    txtname.Focus();
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txttokenid.Text == "" || cmblicno.SelectedIndex < 0 || txtname.Text == "" || txtfee.Text == "" || cmbhuntingdog.SelectedIndex < 0 || cmbweapon.SelectedIndex < 0)
            {
                MessageBox.Show(obj.fill_all);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from shooting_permit where token_id='" + txttokenid.Text + "'", con);
                MySqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                    con.Close();
                    MySqlCommand cm1 = new MySqlCommand("update shooting_permit set name='"+txtname.Text+"',permit_fee='"+txtfee.Text+"',hunting_dog='"+cmbhuntingdog.SelectedItem.ToString()+"',weapon='"+cmbweapon.SelectedItem.ToString()+"',expiry_date='"+expirydate.Value.ToShortDateString()+"' where token_id='"+txttokenid.Text+"' ", con);
                    con.Open();
                    cm1.ExecuteNonQuery();
                    MessageBox.Show(obj.rec_updated);
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

        private void cmblicno_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from license_reg where l_no='"+cmblicno.SelectedItem.ToString()+"'",con);
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
    }
}
