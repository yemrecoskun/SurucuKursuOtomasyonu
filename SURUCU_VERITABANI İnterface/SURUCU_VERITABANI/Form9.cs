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

namespace SURUCU_VERITABANI
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void personelduzenlebtn_Click(object sender, EventArgs e)
        {
            if (persoyadtxt.Text != "" && perpwtxt.Text != "" && peradtxt.Text != "" && perkaditxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("update sql7292929.personel set personel_ad='" + peradtxt.Text + "',personel_soyad='" + persoyadtxt.Text + "',personel_kadi='" + perkaditxt.Text + "',personel_pw='" + perpwtxt.Text + "' where personel_id='" + peridtxt.Text + "'", Globals.con);
                    object sonuc = null;
                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Değişiklik Yapıldı");
                    else
                        MessageBox.Show("HATA");
                    Globals.con.Close();
                    this.Hide();
                }
            }
            else if (peradtxt.Text == "") MessageBox.Show("Personel Adı Boş Kalamaz");
            else if (persoyadtxt.Text == "") MessageBox.Show("Personel Soyad Boş Kalamaz");
            else if (perkaditxt.Text == "") MessageBox.Show("Kullanıcı Adı Boş Kalamaz");
            else if (perpwtxt.Text == "") MessageBox.Show("Şifre Boş Kalamaz");
        }

        private void personelarabtn_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand  cmd = new MySqlCommand ("Select * from sql7292929.Personel where personel_id='" + peridtxt.Text + "'",Globals.con);
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                peridtxt.Text = rd.GetString(0);
                peradtxt.Text = rd.GetString(1);
                persoyadtxt.Text = rd.GetString(2);
                perkaditxt.Text = rd.GetString(3);
                perpwtxt.Text = rd.GetString(4);
                personelarabtn.Visible = false;
                personelduzenlebtn.Visible = true;
                peridtxt.Enabled = false;
                peradtxt.Enabled = true;
                persoyadtxt.Enabled = true;
                perkaditxt.Enabled = true;
                perpwtxt.Enabled = true;
            }
            Globals.con.Close();
        }
    }
}
