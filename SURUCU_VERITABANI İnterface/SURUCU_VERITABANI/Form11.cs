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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Globals.con;

            cmd.CommandText = "Select * from sql7292929.OdemeGridView where aday_id='" + textBox1.Text + "'";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form12 frm12 = new Form12();
                frm12.adayaditxt.Text = dr.GetString(1);
                frm12.odemedurumutxt.Text = dr.GetString(2);
                frm12.tutartxt.Text = dr.GetString(3);
                frm12.ShowDialog();
            }
            Globals.con.Close();
        }
    }
}
