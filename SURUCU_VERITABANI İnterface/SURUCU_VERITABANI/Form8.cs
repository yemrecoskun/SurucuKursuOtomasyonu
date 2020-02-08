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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void personeleklebtn_Click(object sender, EventArgs e)
        {
            {
                if ( peradtxt.Text != "" && persoyadtxt.Text != "" && perkaditxt.Text != "" && perpwtxt.Text != "")
                {
                    DialogResult cikis = new DialogResult();
                    object sonuc = null;
                    cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (cikis == DialogResult.Yes)
                    {
                        Globals.con.Open();
                        MySqlCommand ekle = new MySqlCommand("insert into 'personel' (`personel_ad`, `personel_soyad`, `personel_kadi`, `personel_pw`) values('" + peradtxt.Text + "','" + persoyadtxt.Text + "','" + perkaditxt.Text + "','" + perpwtxt.Text + "')", Globals.con);


                        sonuc = ekle.ExecuteNonQuery();
                        if (sonuc != null)
                            MessageBox.Show("Ekleme yapildi");
                        else
                            MessageBox.Show("HATA");
                        Globals.con.Close();
                        this.Hide();
                       
                    }
                }
                else if (peradtxt.Text == "") MessageBox.Show("Personel ad Boş Kalamaz");
                else if (persoyadtxt.Text == "") MessageBox.Show("Personel soyad  Boş Kalamaz");
                else if (perkaditxt.Text == "") MessageBox.Show("Kullanıcı Adı Boş Kalamaz");
                else if (perpwtxt.Text == "") MessageBox.Show("Şifre Boş Kalamaz");
            }
        }
    }
}
