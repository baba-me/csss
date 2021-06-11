using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wildlife.License_Management
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        constring obj = new constring();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(obj.contring);
            MySqlCommand cmd = new MySqlCommand("select * from specie", con);
            MySqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                cmbspeciename.Items.Add(r["specie_name"].ToString());
            }
            r.Close();
            con.Close();
            MySqlCommand cmd1 = new MySqlCommand("select * from license", con);
            MySqlDataReader r2;
            con.Open();
            r2 = cmd1.ExecuteReader();
            while (r2.Read())
            {
                cmb_cat.Items.Add(r2["l_category"].ToString());
            }
            r2.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_cat.Text == "Posession")
            {
                MySqlCommand cmd = new MySqlCommand("insert into license_reg(reg_no,l_category,l_no,specie_name,amount,name,fname,district,cnic,address,contact,picture,issue_date,expiry_date)values('" + txtregno.Text + "','" + cmb_cat.Text + "','" + txtl_no.Text + "','" + cmbspeciename.Text + "','" + txtamount.Text + "','" + txtname.Text + "','" + txtfname.Text + "','"+cmbdistrict.Text+"','" + txtcnic.Text + "','" + txtadres.Text + "','" + txtcntct.Text + "','" + pictureBox1.Image + "','" + dateTimePicker1.Value.ToLongDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(obj.rec_save);
                con.Close();
            }
            else
            {
                string spcname = cmbspeciename.Text = "NUll";
                MySqlCommand cmd1 = new MySqlCommand("insert into license_reg(reg_no,l_category,l_no,specie_name,amount,name,fname,district,cnic,address,contact,picture,issue_date,expiry_date)values('" + txtregno.Text + "','" + cmb_cat.Text + "','" + txtl_no.Text + "','" + spcname + "','" + txtamount.Text + "','" + txtname.Text + "','" + txtfname.Text + "','" + cmbdistrict.Text + "','" + txtcnic.Text + "','" + txtadres.Text + "','" + txtcntct.Text + "','" + pictureBox1.Image + "','" + dateTimePicker1.Value.ToLongDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "')", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show(obj.rec_save);
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strFn = "";
                OpenFileDialog opd = new OpenFileDialog();
                opd.Filter = "(*.BMP; *.JPG; *.GIF; *.PNG;)| *.BMP; *.JPG; *.GIF; *.PNG;";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                opd.CheckFileExists = true;
                opd.CheckPathExists = true;
                opd.FilterIndex = 0;
                opd.Title = "Select an Image";
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    strFn = opd.FileName;
                    var fileSize = new FileInfo(opd.FileName);

                    var validFileSize = fileSize.Length <= 1024 * 200;
                    if (!validFileSize)
                    {
                        MessageBox.Show("Error ! File Size Must be less than 100 Kb");
                    }
                    else
                    {
                        if (opd.FileName != null)
                        {
                            pictureBox1.Image = Image.FromFile(strFn);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_cat.Text =="Posession")
            {
                cmbspeciename.Visible = true;
                lblspc.Visible = true;
                txtamount.Text = "0";

            }
            else
            {
               cmbspeciename.Visible = false;
               lblspc.Visible = false;
                MySqlCommand cmd = new MySqlCommand("select * from license where l_category='"+cmb_cat.SelectedItem.ToString()+"'",con);
                con.Open();
                MySqlDataReader r;
                r=cmd.ExecuteReader();
                if(r.Read())
                {
                    txtamount.Text = r["amount"].ToString();
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

        private void cmbspeciename_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from specie where specie_name='" + cmbspeciename.SelectedItem.ToString() + "'", con);
            con.Open();
            MySqlDataReader r;
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtamount.Text = r["amount"].ToString();
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
