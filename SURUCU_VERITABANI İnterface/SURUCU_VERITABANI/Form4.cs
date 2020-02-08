using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SURUCU_VERITABANI
{
    public partial class Form4 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public Form4()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            cmd.Connection = Globals.con;
            if (radioButton1.Checked == true)
            {
                cmd.CommandText = "Select * from sql7292929.aday where aday_id='" + textBox1.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form5 frm5 = new Form5();
                    frm5.textBox1.Text = dr.GetString(1).ToString();
                    frm5.textBox2.Text = dr.GetString(2).ToString();
                    frm5.textBox5.Text = dr.GetString(4).ToString();
                    frm5.textBox6.Text = dr.GetString(5).ToString();
                    frm5.radioButton1.Checked = true;
                    frm5.radioButton5.Checked = true;
                    frm5.comboBox1.Text = dr.GetString(8).ToString();
                    frm5.comboBox2.Text = dr.GetString(3).ToString();
                    frm5.Show();
                    this.Hide();
                }
            }
            else if(radioButton2.Checked == true)
            {
                cmd.CommandText = "select * from sql7292929.aday where aday_TC= '" + textBox1.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form5 frm5 = new Form5();
                    frm5.textBox1.Text = dr.GetString(1).ToString();
                    frm5.textBox2.Text = dr.GetString(2).ToString();
                    frm5.textBox5.Text = dr.GetString(4).ToString();
                    frm5.textBox6.Text = dr.GetString(5).ToString();
                    frm5.radioButton1.Checked = true;
                    frm5.radioButton5.Checked = true;
                    frm5.comboBox1.Text = dr.GetString(8).ToString();
                    frm5.comboBox2.Text = dr.GetString(3).ToString();
                    frm5.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Lütfen birini seçiniz!");

            Globals.con.Close();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
