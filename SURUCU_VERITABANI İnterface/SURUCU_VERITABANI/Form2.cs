using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
namespace SURUCU_VERITABANI
{
    public partial class Form2 : Form
    {
        
        MySqlCommand cmd = new MySqlCommand();
        string ad0,ad1,ad2,ad3,ad4,ad5,ad6,ad7,ad8,not1,not2,not3,per1,per2,per3;

        private void noteklebtn_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.NotlarGridView";
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string aday_ad = rd.GetString(0);
                int aday_id = rd.GetInt32(1);
                int not_turu_id = rd.GetInt32(2);
                string notturu_ad = rd.GetString(3);
                int notu = rd.GetInt32(4);
                dataGridView2.Rows.Add(aday_ad, aday_id, not_turu_id, notturu_ad, notu);
            }
            rd.Close();
            Globals.con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            Globals.con.Open();
            cmd.CommandText = "Select * from sql7292929.personel";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int per_id = rd.GetInt32(0);
                string per_ad = rd.GetString(1);
                string per_soyad = rd.GetString(2);
                dataGridView3.Rows.Add(per_id, per_ad, per_soyad);

            }
            rd.Close();
            Globals.con.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            Globals.con.Open();
            cmd.CommandText = " select * from sql7292929.odemeGridView";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string aday_idd = rd.GetString(0);
                string aday_add = rd.GetString(1);
                string aday_durum = rd.GetString(2);
                string odeme_tutari = rd.GetString(3);
                dataGridView4.Rows.Add(aday_idd, aday_add, aday_durum, odeme_tutari);
            }
            rd.Close();
            Globals.con.Close();
        }


        private void ogrenciarabtn_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.adayidnottxt.Enabled = true;
            frm7.notturuidtxt.Enabled = true;
            frm7.button1.Visible = true;
            frm7.notduzenlebtn.Visible = false;
            frm7.nottxt.Enabled = false;
            frm7.ShowDialog();
        }

        private void personeleklebtn_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
          
                frm8.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kaldırmak İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Globals.con.Open();
                cmd.Connection = Globals.con;
                cmd.CommandText = "delete from sql7292929.personel where personel_id='" + per1 + "';";
                object rd = cmd.ExecuteNonQuery();
                Globals.con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            cmd.Connection = Globals.con;
            
            cmd.CommandText = "Select * from sql7292929.ehliyetview where aday_id = (select aday_id from sql7292929.aday where aday_TC='" + textBox1.Text + "')";
            var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                if (rd.GetString(5) == "odendi" && rd.GetInt32(2) == 1 && rd.GetInt32(4) >= 70 )
                {
                            Form10 frm10 = new Form10();
                            rd.Close();
                            cmd.CommandText = "select aday_ad,aday_soyad,aday_TC,aday_ehliyetsinif from sql7292929.aday where aday_TC='" + textBox1.Text + "' ";
                            var dr = cmd.ExecuteReader();
                            dr.Read();
                            frm10.ehliyetbelgeaditxt.Text = dr.GetString(0);
                            frm10.ehliyetbelgesisoyadtxt.Text = dr.GetString(1);
                            frm10.ehliyettctxt.Text = dr.GetString(2);
                            frm10.ehliyetsiniftxt.Text = dr.GetString(3);
                            frm10.ShowDialog();
                      
                    }
                    else MessageBox.Show("Ehliyet Belgesi Bulunamadı");
                
            }
            else MessageBox.Show("Ehliyet Belgesi Bulunamadı");
            Globals.con.Close();
            rd.Close();
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.ShowDialog();
        }
        
        private void personelduzenlebtn_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.personel where personel_id='" + per1 + "'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                frm9.peridtxt.Text = rd.GetString(0);
                frm9.peradtxt.Text = rd.GetString(1);
                frm9.persoyadtxt.Text = rd.GetString(2);
                frm9.perkaditxt.Text = rd.GetString(3);
                frm9.perpwtxt.Text = rd.GetString(4);
                frm9.personelarabtn.Visible = false;
            }
            Globals.con.Close();
            frm9.ShowDialog();
        }

        private void personelarabtn_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.personelarabtn.Visible = true;
            frm9.personelduzenlebtn.Visible = false;
            frm9.peridtxt.Enabled = true;
            frm9.peradtxt.Enabled = false;
            frm9.persoyadtxt.Enabled = false;
            frm9.perkaditxt.Enabled = false;
            frm9.perpwtxt.Enabled = false;
            frm9.ShowDialog();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.aday";
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd.GetString(0) != null)
                {
                    int id = rd.GetInt32(0);
                    string name = rd.GetString(1);
                    string surname = rd.GetString(2);
                    string ogrenimdurumu = rd.GetString(3);
                    string TC = rd.GetString(4);
                    string tel = rd.GetString(5);
                    string saglikbelgesi = rd.GetString(6);
                    string adlibelge = rd.GetString(7);
                    string ehliyetsinifi = rd.GetString(8);
                    dataGridView1.Rows.Add(id, name, surname, ogrenimdurumu, TC, tel, saglikbelgesi, adlibelge, ehliyetsinifi);
                }
            }
            Globals.con.Close();
        }

        

        public Form2()
        {
            InitializeComponent();
            Globals.con.Close();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from sql7292929.aday";
            var rd = cmd.ExecuteReader();
            
            while(rd.Read())
            {
                int id = rd.GetInt32(0);
                string name = rd.GetString(1);
                string surname = rd.GetString(2);
                string ogrenimdurumu = rd.GetString(3);
                string TC= rd.GetString(4);
                string tel = rd.GetString(5);
                string saglikbelgesi = rd.GetString(6);
                string adlibelge = rd.GetString(7);
                string ehliyetsinifi = rd.GetString(8);
                dataGridView1.Rows.Add(id, name, surname, ogrenimdurumu, TC, tel, saglikbelgesi,adlibelge,ehliyetsinifi);
            }
            rd.Close();
            cmd.CommandText = "Select * from sql7292929.NotlarGridView";
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string aday_ad = rd.GetString(0);
                int aday_id = rd.GetInt32(1);
                int not_turu_id = rd.GetInt32(2);
                string notturu_ad = rd.GetString(3);
                int notu = rd.GetInt32(4);  
                dataGridView2.Rows.Add(aday_ad,aday_id, not_turu_id,notturu_ad,notu);
            }
            rd.Close();
            cmd.CommandText = " select * from sql7292929.OdemeGridView";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string aday_idd = rd.GetString(0);
                string aday_add = rd.GetString(1);
                string aday_durum = rd.GetString(2);
                string odeme_tutari = rd.GetString(3);
                dataGridView4.Rows.Add(aday_idd, aday_add, aday_durum, odeme_tutari);
            }
            rd.Close();
            cmd.CommandText = "Select * from sql7292929.personel";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int per_id = rd.GetInt32(0);
                string per_ad = rd.GetString(1);
                string per_soyad = rd.GetString(2);
                dataGridView3.Rows.Add(per_id,per_ad,per_soyad);

            }
            rd.Close();
            Globals.con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.textBox1.Text = ad1;
            frm5.textBox2.Text = ad2;
            frm5.textBox5.Text = ad4;
            frm5.textBox6.Text = ad5;
            frm5.radioButton1.Checked = true;
            frm5.radioButton5.Checked = true;
            frm5.comboBox1.Text = ad8;
            frm5.comboBox2.Text = ad3;
            frm5.ShowDialog();
        }

        private void notduzenlebtn_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.nottxt.Text = not3;
            frm7.notturuidtxt.Text = not2;
            frm7.adayidnottxt.Text = not1;
            frm7.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            ad0 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ad1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ad2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ad3 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ad4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ad5 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ad6 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ad7 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            ad8 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;
            }
            not1 = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            not2 = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            not3 = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView3.Rows[e.RowIndex].Selected = true;
            }
            per1 = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            per2 = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            per3 = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e )
        {

            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kaldırmak İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Globals.con.Open();
                cmd.Connection = Globals.con;
                cmd.CommandText = "delete from sql7292929.aday where aday_id='" + ad0 + "';";
                object rd = cmd.ExecuteNonQuery();
                Globals.con.Close();
            }
        }
    }
}
