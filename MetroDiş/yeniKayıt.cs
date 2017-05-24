using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace MetroDiş
{
    public partial class yeniKayıt : MetroForm
    {
        string ConnectionString = "Data Source=" + "randevu.sqlite" + ";Version=3;";



        public yeniKayıt()
        {
            InitializeComponent();
        }

        private void yeniKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 form1 = new Form1();
            //form1.Show();
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "")
            {
                MessageBox.Show("Bos Alanlar Var");

            }
            else
            {

                if (metroTextBox3.Text.Length == 11)
                {


                    string isim = metroTextBox1.Text;
                    string soyisim = metroTextBox2.Text;
                    string tckimlik = metroTextBox3.Text;


                    using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                    {
                        c.Open();
                        string kullaniciEkleKomutu = "insert into kullanicilar (isim, soyisim,tckimlik,sifre) values ('" + metroTextBox1.Text + "', '" + metroTextBox2.Text + "'," + metroTextBox3.Text.ToString() + "," + metroTextBox4.Text.ToString() + ")";

                        using (SQLiteCommand cmd = new SQLiteCommand(kullaniciEkleKomutu, c))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }








                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Tc kimlik 11 haneli olmalii");
                }


            }
        }
    }
}
