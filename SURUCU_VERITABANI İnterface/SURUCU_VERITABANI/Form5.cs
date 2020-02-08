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
using MySql.Data;
namespace SURUCU_VERITABANI
{
    public partial class Form5 : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        
        public Form5()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" && textBox6.Text != "" && radioButton1.Checked == true && radioButton5.Checked == true && comboBox2.Text != "Yok")
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("update sql7292929.aday set aday_ad='" + textBox1.Text+"',aday_soyad='"+textBox2.Text+"',aday_ogrenim_durum='"+comboBox2.SelectedItem.ToString()+"',aday_TC='"+textBox5.Text+"',aday_tel='"+textBox6.Text+"',aday_saglikbelgesi='"+radioButton5.Text+"',aday_adlibelge='"+radioButton1.Text+"',aday_ehliyetsinif='"+comboBox1.SelectedItem.ToString()+"' where aday_TC='"+textBox5.Text +"'", Globals.con);
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
            else if (textBox1.Text == "") MessageBox.Show("Aday Adı Boş Kalamaz");
            else if (textBox2.Text == "") MessageBox.Show("Aday Soyadı Boş Kalamaz");
            else if (textBox5.Text == "") MessageBox.Show("Aday T.C NO Boş Kalamaz");
            else if (textBox6.Text == "") MessageBox.Show("Aday TEL NO Boş Kalamaz");
            else if (radioButton1.Checked == false) MessageBox.Show("Aday Adli Belgesi Olmalıdır");
            else if (radioButton5.Checked == false) MessageBox.Show("Aday Sağlık Raporu Olmalıdır");
            else if (comboBox2.Text == "Yok") MessageBox.Show("Aday Öğrenim durumu en az İlköğretim Olmalıdır");
        
    }
    }
}
