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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Ödeme İşlemine Onay Veriyormusunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Globals.con.Close();
                Globals.con.Open();
                MySqlCommand ekle = new MySqlCommand("update sql7292929.odemegridview set odeme_durum='ödendi' where aday_ad='" + adayaditxt.Text+"'", Globals.con);
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
                if (sonuc != null)
                    MessageBox.Show("ÖDEME YAPILDI");
                else
                    MessageBox.Show("HATA!");
                Globals.con.Close();
                this.Hide();
                Globals.con.Close();

            }
        }
    }
}
