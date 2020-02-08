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
    public partial class Form1 : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.personel where personel_kadi='" + textBox1.Text + "'and personel_pw='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Doldurun");
            }
            else if (dr.Read())
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
                form2.button1.Enabled = false;
                form2.button2.Enabled = false;
                form2.button3.Enabled = false;
                form2.button4.Enabled = false;
                form2.button1.Enabled = false;
                form2.personelarabtn.Enabled = false;
                form2.personeleklebtn.Enabled=false;
                form2.personelduzenlebtn.Enabled = false;
                form2.button7.Enabled=false;

            }
            else MessageBox.Show("Hatalı Giriş Yaptınız! Tekrar Deneyiniz");

            Globals.con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.administrator where admin_kadi='" + textBox3.Text + "'and admin_pw='" + textBox4.Text + "'";
            dr = cmd.ExecuteReader();
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Doldurun");
            }
            else if (dr.Read())
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else MessageBox.Show("Hatalı Giriş Yaptınız! Tekrar Deneyiniz");
            Globals.con.Close();
        }
    }
    }

