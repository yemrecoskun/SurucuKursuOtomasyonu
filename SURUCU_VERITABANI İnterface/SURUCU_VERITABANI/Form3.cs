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
    public partial class Form3 : Form
    {
        MySqlConnection con;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" && textBox6.Text != "" && radioButton1.Checked == true && radioButton5.Checked == true && comboBox2.Text != "Yok")
                {
                    DialogResult cikis = new DialogResult();
                    cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (cikis == DialogResult.Yes)
                    {
                        
                        Globals.con.Open();
                        MySqlCommand ekle = new MySqlCommand("insert into sql7292929.aday(aday_ad,aday_soyad,aday_ogrenim_durum,aday_TC,aday_tel,aday_saglikbelgesi,aday_adlibelge,aday_ehliyetsinif) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + textBox5.Text + "','" + textBox6.Text + "','var','var','" + comboBox1.SelectedItem.ToString() + "')",Globals.con);
                        object sonuc = null;
                        sonuc = ekle.ExecuteNonQuery();
                        if (sonuc != null)
                            MessageBox.Show("Ekleme yapildi");
                        else
                            MessageBox.Show("HATA");
                        Globals.con.Close();
                        this.Hide();
                    }
                }
                else if (textBox1.Text == "") MessageBox.Show("Aday Adı Boş Kalamaz");
                else if (textBox2.Text == "") MessageBox.Show("Aday Soyadı Boş Kalamaz");
                else if (textBox5.Text == "") MessageBox.Show("Aday T.C NO Boş Kalamaz");
                else if (textBox6.Text == "") MessageBox.Show("Aday TEL NO Boş Kalamaz");
                else if (radioButton1.Checked == false) MessageBox.Show("Aday Adli Belgesi Olmalıdır");
                else if (radioButton5.Checked == false) MessageBox.Show("Aday Sağlık Raporu Olmalıdır");
                else if (comboBox2.Text == "Yok") MessageBox.Show("Aday Öğrenim durumu en az İlköğretim Olmalıdır");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
