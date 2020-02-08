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

namespace SURUCU_VERITABANI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void notduzenlebtn_Click(object sender, EventArgs e)
        {
                if (nottxt.Text != "" && notturuidtxt.Text != "" && adayidnottxt.Text != "" )
                {
                    DialogResult cikis = new DialogResult();
                    cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (cikis == DialogResult.Yes)
                    {
                        Globals.con.Open();
                        MySqlCommand ekle = new MySqlCommand("update sql7292929.notlar set notu='" + nottxt.Text + "',notturu_id='" + notturuidtxt.Text + "',aday_id='"+adayidnottxt.Text+"' where aday_id='" + adayidnottxt.Text + "'", Globals.con);
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
                else if (nottxt.Text == "") MessageBox.Show("Notu Boş Kalamaz");
                else if (notturuidtxt.Text == "") MessageBox.Show("Not Turu Boş Kalamaz");
                else if (adayidnottxt.Text == "") MessageBox.Show("Aday ID Boş Kalamaz");
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from sql7292929.NotlarGridView where aday_id='" + adayidnottxt.Text+"' and notturu_id='"+notturuidtxt.Text+"'",Globals.con);
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                notturuidtxt.Text = rd.GetString(2);
                nottxt.Text = rd.GetString(4);
                adayidnottxt.Text = rd.GetString(1);
            }
            notduzenlebtn.Enabled = true;
            nottxt.Enabled = true;
            notturuidtxt.Enabled = false;
            adayidnottxt.Enabled = false;
            button1.Visible = false;
            notduzenlebtn.Visible = true;
            Globals.con.Close();
        }
        
    }
    
}
