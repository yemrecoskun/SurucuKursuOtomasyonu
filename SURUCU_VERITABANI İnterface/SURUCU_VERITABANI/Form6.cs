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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void noteklebtn_Click(object sender, EventArgs e)
        {
            

                {
                    if (adayidnottxt.Text != "" && notturuidtxt.Text != "" && nottxt.Text != "" )
                    {
                        DialogResult cikis = new DialogResult();
                        object sonuc = null;
                         cikis = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                        if (cikis == DialogResult.Yes)
                        {
                            Globals.con.Open();
                            MySqlCommand ekle = new MySqlCommand("insert into sql7292929.notlar(notu,notturu_id,aday_id)values('" + nottxt.Text + "','" +notturuidtxt.Text + "','" + adayidnottxt.Text + "')", Globals.con);
                       
                       
                            sonuc = ekle.ExecuteNonQuery();
                            if (sonuc != null)
                                MessageBox.Show("Ekleme yapildi");
                            else
                                MessageBox.Show("HATA");
                            Globals.con.Close();
                            this.Hide();
                            Form2 frm2 = new Form2();
                            frm2.Show();
                    }
                    }
                    else if (adayidnottxt.Text == "") MessageBox.Show("Aday ID Boş Kalamaz");
                    else if (notturuidtxt.Text == "") MessageBox.Show("Not Turu ID  Boş Kalamaz");
                    else if (nottxt.Text == "") MessageBox.Show("Not Boş Kalamaz");
                }
            
        }
    }
}
