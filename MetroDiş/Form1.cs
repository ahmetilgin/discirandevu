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
    public partial class Form1 : MetroForm 
    {
        string randevu = "randevu.sqlite";
        string ConnectionString = "Data Source=" + "randevu.sqlite" + ";Version=3;;Count Changes=off;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

 
            SQLiteConnection.CreateFile(randevu);
          using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
        {
        c.Open();
      string sql = "create table kullanicilar (id INTEGER  PRIMARY KEY,isim varchar(50),soyisim varchar(50), tckimlik varchar(50),sifre varchar(50))";
    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
    {
              cmd.ExecuteNonQuery();
    }
}

          using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
          {
              c.Open();
              string sql = "create table doktorlar (id INTEGER  PRIMARY KEY,isim varchar(50),soyisim varchar(50),doktortckimlik varchar(50),p_isim varchar (50),sifre varchar(50))";
              using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
              {
                cmd.ExecuteNonQuery();
              }
          }
          //using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
          //{
          //    c.Open();
          //    string sql = "create table hastalar (doktortc varchar(50),saat varchar(50),tarih varchar(50),hastaTc)";
          //    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
          //    {
          //        cmd.ExecuteNonQuery();
          //    }
          //}


          using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
          {
              c.Open();
              string sql = "create table doktorRandevulari (id integer,doktortckimlik varchar(50),tarih varchar(50), saat varchar(50),kullaniciTc varchar(50),sikayet varchar(50))";
              using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
              {
                  cmd.ExecuteNonQuery();
              }
          }
          using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
          {
              c.Open();
              string sql = "insert into doktorlar(isim,soyisim,doktortckimlik,p_isim,sifre) values('Ahmet','ilgin','1537','POLİKLİNİK 1','1537')";
              using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
              {
                  cmd.ExecuteNonQuery();
              }
          }


          using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
          {
              c.Open();
              string sql = "insert into doktorlar(isim,soyisim,doktortckimlik,p_isim,sifre)values('Mücahit','yılmaz','123','POLİKLİNİK 2','1537')";

              using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
              {
                  cmd.ExecuteNonQuery();
              }
          }
         
            

        
          

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            if (metroTextBox1.Text == "admin" && metroTextBox2.Text == "admin")
            {
              
                Form2 kayit = new Form2();
                kayit.ShowDialog();
               
            }
            else
            {
             string sql = "select * from kullanicilar where tckimlik = " + metroTextBox1.Text ;
             using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
             {
                 c.Open();
                 using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                 {
                     using (SQLiteDataReader reader = cmd.ExecuteReader())
                     {
                         if (reader.Read())
                         {
                             giris gir = new giris(metroTextBox1.Text, metroTextBox1.Text);
                             c.Close();
                             gir.ShowDialog();
                         }
                     }
                }
           }   

             
               
              
            }
         
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            yeniKayıt kayit = new yeniKayıt();
            kayit.ShowDialog();
            this.Show();

   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
            string tcDoktor = "select * from doktorlar where doktortckimlik = " + metroTextBox1.Text;
            string doktorSifre = "select * from doktorlar where sifre = " + metroTextBox2.Text;

using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
{
    c.Open();
    using (SQLiteCommand cmd = new SQLiteCommand(tcDoktor, c))
    {
        using (SQLiteDataReader reader = cmd.ExecuteReader())
        {
            if (reader.Read())
            {
                doktorEkrani gir = new doktorEkrani(metroTextBox1.Text);
                c.Close();
                gir.ShowDialog();
            }
        }
    }
}
          
            
           
        }
    }
}
