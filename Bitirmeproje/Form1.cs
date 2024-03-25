using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;

namespace Bitirmeproje
{
    public partial class Form1 : Form
    {
        
        void Listele()
        {
            string sql = "Select * from Bitirme";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }
       // string program_yolu = Application.StartupPath;


        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            /* string sqlitedb_constr = "Data source=C:\\Bitirme.db;Version=3;";  //sql baðlantý testi kod satýrý .
             using(var  AC = new SQLiteConnection(connection))
             {
                 try
                 {
                     AC.Open();
                     MessageBox.Show("Veri tabanýna baglantý basarýyla gerceklestirildi.");
                 }
                 catch (Exception hata)
                 {
                     MessageBox.Show("veri tabanýna gaglantý saglanamadý!","Hata Mesajý"+hata.Message);
                     throw;
                 }


             }


            /* string yol = Application.StartupPath;

             string databaseyolu = @"Data Source =" + C:\\Users\Turann\Desktop + "\\VeritabaninizinAdi.db3; */     //veri tabanýnýn yolunu her yerde tanýmlamamýzý saðlar .


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();  //baglantý yapmamýzý  ve verileri listelememizi saðladým . 

            /* string sqlitedb_constr = $"Data source=C:\\apoo.db;Version=3;";   

              using (var baglan = new SQLiteConnection(sqlitedb_constr))
              {
                  using (var cmd = new SQLiteCommand("SELECT * FROM users", baglan))
                  {
                      cmd.Connection.Open();
                      SQLiteDataReader dtr = cmd.ExecuteReader();
                      if (dtr.Read())
                      {
                          listBox1.Items.Add(dtr[1] + "" + dtr[2]);
                          // dataGridView1.DataSource= dtr["ad"].ToString();
                      }

                  }


               } */
        }
    }
}
