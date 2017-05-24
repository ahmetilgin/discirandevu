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
    public partial class doktorEkrani : MetroForm
    {
        string ConnectionString = "Data Source=" + "randevu.sqlite" + ";Version=3;;Count Changes=off;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off";
        string doktorKimligi;
        public doktorEkrani(string idi)
        {
            doktorKimligi = idi;
            InitializeComponent();
        }

        private void doktorEkrani_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {



            string kayit = "select tarih,saat,kullanicitc,sikayet from doktorRandevulari where doktortckimlik = "+ doktorKimligi;
    
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(kayit, c))
                {
                      DataSet ds = new DataSet();
                       var da = new SQLiteDataAdapter(kayit, c);
                       da.Fill(ds);
                       dataGridView1.DataSource = ds.Tables[0].DefaultView;

                     DataTable dt = new DataTable();
                }
            }

         

           
        }
    }
}
