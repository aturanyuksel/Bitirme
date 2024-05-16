using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;

namespace Bitirmeproje
{
    public partial class Form1 : Form
    {
       

        void Listele()
        {
            string sql = "Select * from bitirmeproje";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }
        // string program_yolu = Application.StartupPath;


        public Form1()
        {
            InitializeComponent();
            Listele();
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
        decimal kadýnA, erkekA, kadýnB, erkekB,hesaplakadýnA,hesaplakadýnB,hesaplaerkekA,hesaplaerkekB,kikarekadýnA,kikarekadýnB,kikareerkekA,kikarerekekB,kikaretoplam,serbestlikderecesi;
       

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
             kadýnA=Convert.ToDecimal(txt_kadin_a.Text);
             erkekA = Convert.ToDecimal(txt_erkek_a.Text);
             kadýnB = Convert.ToDecimal(txt_kadin_a.Text);
             erkekB = Convert.ToDecimal(txt_erkek_b.Text);
            hesaplakadýnA=(kadýnA+kadýnB)*(kadýnA+erkekA)/(kadýnA+kadýnB+erkekA+erkekB);
            hesaplakadýnB = (kadýnA + kadýnB) * (kadýnB + erkekB) / (kadýnA + kadýnB + erkekA + erkekB);
            hesaplaerkekA= (erkekA + erkekB) * (kadýnA + erkekA) / (kadýnA + kadýnB + erkekA + erkekB);
            hesaplaerkekB = (erkekA + erkekB) * (kadýnB + erkekA) / (kadýnA + kadýnB + erkekA + erkekB);

            kikarekadýnA= (kadýnA-hesaplakadýnA ) *( kadýnA - hesaplakadýnA )/ (hesaplakadýnA);
            kikareerkekA= (erkekA-hesaplaerkekA )*( erkekA - hesaplaerkekA) / (hesaplaerkekA);
            kikarekadýnB= (kadýnB-hesaplakadýnB )* (kadýnB - hesaplakadýnB )/ (hesaplakadýnB);
            kikarerekekB= (erkekB-hesaplaerkekB )* (erkekB - hesaplaerkekB) / (hesaplaerkekB);
            kikaretoplam=kikareerkekA+kikarekadýnA+kikarekadýnB+kikarerekekB;
            lbl_kikare.Text = Convert.ToString(kikaretoplam);
            serbestlikderecesi=(2-1)*(2-1);
            if (serbestlikderecesi==1)
            {
                lbl_anlamlilikdüzeyi.Text = "null hipotezi reddedilir , iki deðiþken arasýnda anlamlý bir iliþki vardýr";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
