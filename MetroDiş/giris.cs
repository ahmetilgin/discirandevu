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
    public partial class giris : MetroForm
    {
        string secilenDoktorId;
        string sikayet;
        string secilenTarih;
        string secilenDoktorKimligi;
        string kullanicininTcsi;
        string doktorId;
        string secilenSaat;
        string secilenDoktor;
        string[] doktorSaatleri;
        //string tarih, saat,d_kimligi;

        string[] saatler =  { "08:00", "09:00", "10:00","11:00","13:00","14:00","15:00","16:00","17:00"};
        string ConnectionString = "Data Source=" + "randevu.sqlite" + ";Version=3;;Count Changes=off;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off";
    
        public giris(string kullaniciAdi,string tckimlikNosuKullanicinin)
        {
            InitializeComponent();
            isim.Text = "Sayin "+kullaniciAdi+" Hoşgeldiniz.";
            kullanicininTcsi = tckimlikNosuKullanicinin;
        }

        private void giris_Load(object sender, EventArgs e)
        {
                
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void isim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        
        

       
        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        
        }

   
        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            //listBox2.Items.Clear();
         
            if (comboBox1.Text == "")
            {
                    MessageBox.Show("Poliklinik Seçiniz");
            }
            else
            {
  
                string doktorIsim;
             
                
                string sorgu = "Select id,isim,soyisim from doktorlar where p_isim='" + comboBox1.Text + "'";
              
              
             
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                 c.Open();
                 using (  SQLiteCommand cmd = new SQLiteCommand(sorgu, c))
                {
                 using (SQLiteDataReader reader = cmd.ExecuteReader())
                 {
                     while (reader.Read())
                     {
                         doktorId = reader["id"].ToString();
                         doktorIsim = doktorId + "  :" + "Diş Doktoru: " + " " + reader["isim"].ToString() + " " + reader["soyisim"].ToString();
                         listBox1.Items.Add(doktorIsim);
                     }
                 }
                }
                }
              
                
            }
           
            
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            
               // string randevular = "Select id,isim,soyisim from doktorRandevulari where p_isim='" + comboBox1.Text + "'";
                secilenDoktor = listBox1.GetItemText(listBox1.SelectedItem).ToString();
                secilenSaat =  listBox2.GetItemText(listBox2.SelectedItem).ToString();
                sikayet = listBox3.GetItemText(listBox3.SelectedItem).ToString();
                if (secilenDoktor.Equals("")|| secilenTarih.Equals(""))
                {
                    MessageBox.Show("Saat Veya Doktor Secmediniz");
                }
                else { 

               
                    secilenDoktorId = secilenDoktor.Substring(0, 1);
                    secilenTarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                 
                    string komut1 = "select doktortckimlik from doktorlar where id =" + secilenDoktorId;
                    

                    using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                    {
                        c.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(komut1, c))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        using (SQLiteCommand command2 = new SQLiteCommand(komut1, c))
                        {
                            using (SQLiteDataReader reader1 = command2.ExecuteReader())
                            {
                                while (reader1.Read())
                                {
                                    secilenDoktorKimligi = reader1["doktortckimlik"].ToString();
                                }

                            }
                        }
                       
                        

                      
                    }
                    using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                    {
                        //doktortc varchar(50),saat varchar(50),tarih varchar(50),hastaTc
                        komut1 = "insert into doktorRandevulari(id,doktortckimlik,tarih,saat,kullaniciTc,sikayet) values('" + secilenDoktorId + "','" + secilenDoktorKimligi + "','" + secilenTarih + "','" + secilenSaat.ToString() + "','" + kullanicininTcsi + "','"+sikayet+"')";
                        c.Open();
                        using (SQLiteCommand cmd2 = new SQLiteCommand(komut1, c))
                        {
                            cmd2.ExecuteNonQuery();
                        }

                    }        
            //   sql = "create table doktorRandevulari (id INTEGER  PRIMARY KEY,doktortckimlik varchar(50),tarih varchar(50), saat varchar(50),kullaniciTc varchar(50))";
                    //at = "Insert into doktorlar(isim,soyisim,tckimlik,p_isim) values('" + "ali" + "','" + "osman" + "','" + "123456789" + "','" + "POLİKLİNİK 2" + "')";
                    //doktortckimlik varchar(50),tarih varchar(50), saat varchar(50),kullaniciTc varchar(50),hastaligi varchar(50)
                  //komut1 = "";

                 
               
                   //cmd.ExecuteNonQuery();
                   //connect.Close();
                 //using(var connect = new SQLiteConnection("Data Source=" + "randevu.sqlite" + ";Version=3;"))
                 //{
                 //    connect.Open();
                 //    using (var cmd = new SQLiteCommand(connect))
                 //    {
                 //        cmd.CommandText = "insert into doktorRandevulari(id) values(@id)";
                 //        cmd.Parameters.AddWithValue("@id", secilenDoktorId);
                 //        //cmd.Parameters.AddWithValue("@b", secilenDoktorKimligi);
                 //        //cmd.Parameters.AddWithValue("@c", secilenTarih);
                 //        //cmd.Parameters.AddWithValue("@d", secilenSaat);
                 //        //cmd.Parameters.AddWithValue("@e", kullanicininTcsi);
                 //        //cmd.Parameters.AddWithValue("@f", sikayet);
                 //        cmd.ExecuteNonQuery();

                 //    }
                 //    connect.Close();
                 //}
             
                    if (listBox2.SelectedItems.Count != 0)
                    {
                        while (listBox2.SelectedIndex != -1)
                        {
                            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                            MessageBox.Show("Kayıt Başarılı Randevu Saati: " + secilenSaat + "\n" + "Randevu Tarihi: " + secilenTarih);
                        }
                    }
                }
        }

       

      
        

        private void metroButton1_Click_2(object sender, EventArgs e)
        {
            //        string[] saatler =  { "08:00", "09:00", "10:00","11:00","13:00","14:00","15:00","16:00","17:00"};
            doktorSaatleri = saatler;
            listBox2.Items.Clear();
            
            secilenSaat = listBox2.GetItemText(listBox2.SelectedItem).ToString();
            secilenDoktor = listBox1.GetItemText(listBox1.SelectedItem).ToString();
            secilenTarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            secilenDoktorId =  secilenDoktor.Substring(0,1);
            string doktorRandevuSorgu = "select * from doktorRandevulari where id = "+ secilenDoktorId;
      
   
           string secilmisSaat;
           string secilmisTarih;
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
               c.Open();
               using (SQLiteCommand cmd = new SQLiteCommand(doktorRandevuSorgu, c))
               {
                 using (SQLiteDataReader reader = cmd.ExecuteReader())
                 {
                     while (reader.Read())
                     {
                         secilmisTarih = reader["tarih"].ToString();
                         secilmisSaat = reader["saat"].ToString();
                         if (secilenTarih.Equals(secilmisTarih))
                         {
                             var list = new List<string>(doktorSaatleri);
                             list.Remove(secilmisSaat);
                             doktorSaatleri = list.ToArray();
                         }

                     }
                 }
               }
            }
            
       

            foreach (var a in doktorSaatleri){
                listBox2.Items.Add(a);
            }
            
        }
     
        
}
        
       
       


   
            
        }
            
        
    


        
       

       

        

      
    

