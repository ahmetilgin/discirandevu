using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MetroFramework;
using MetroFramework.Forms;

namespace MetroDiş
{

    public partial class Form2 : MetroForm 
    {
        string ConnectionString = "Data Source=" + "randevu.sqlite" + ";Version=3;;Count Changes=off;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off";
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            string sorgu = "insert into doktorlar(isim,soyisim,tckimlik,p_isim,sifre) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sorgu, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
   
    
           
          
            this.DialogResult = DialogResult.OK;


        }
    }
}
