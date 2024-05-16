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


            /* string sqlitedb_constr = "Data source=C:\\Bitirme.db;Version=3;";  //sql ba�lant� testi kod sat�r� .
             using(var  AC = new SQLiteConnection(connection))
             {
                 try
                 {
                     AC.Open();
                     MessageBox.Show("Veri taban�na baglant� basar�yla gerceklestirildi.");
                 }
                 catch (Exception hata)
                 {
                     MessageBox.Show("veri taban�na gaglant� saglanamad�!","Hata Mesaj�"+hata.Message);
                     throw;
                 }


             }


            /* string yol = Application.StartupPath;

             string databaseyolu = @"Data Source =" + C:\\Users\Turann\Desktop + "\\VeritabaninizinAdi.db3; */     //veri taban�n�n yolunu her yerde tan�mlamam�z� sa�lar .


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();  //baglant� yapmam�z�  ve verileri listelememizi sa�lad�m . 

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
        decimal kad�nA, erkekA, kad�nB, erkekB,hesaplakad�nA,hesaplakad�nB,hesaplaerkekA,hesaplaerkekB,kikarekad�nA,kikarekad�nB,kikareerkekA,kikarerekekB,kikaretoplam,serbestlikderecesi;
       

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
             kad�nA=Convert.ToDecimal(txt_kadin_a.Text);
             erkekA = Convert.ToDecimal(txt_erkek_a.Text);
             kad�nB = Convert.ToDecimal(txt_kadin_a.Text);
             erkekB = Convert.ToDecimal(txt_erkek_b.Text);
            hesaplakad�nA=(kad�nA+kad�nB)*(kad�nA+erkekA)/(kad�nA+kad�nB+erkekA+erkekB);
            hesaplakad�nB = (kad�nA + kad�nB) * (kad�nB + erkekB) / (kad�nA + kad�nB + erkekA + erkekB);
            hesaplaerkekA= (erkekA + erkekB) * (kad�nA + erkekA) / (kad�nA + kad�nB + erkekA + erkekB);
            hesaplaerkekB = (erkekA + erkekB) * (kad�nB + erkekA) / (kad�nA + kad�nB + erkekA + erkekB);

            kikarekad�nA= (kad�nA-hesaplakad�nA ) *( kad�nA - hesaplakad�nA )/ (hesaplakad�nA);
            kikareerkekA= (erkekA-hesaplaerkekA )*( erkekA - hesaplaerkekA) / (hesaplaerkekA);
            kikarekad�nB= (kad�nB-hesaplakad�nB )* (kad�nB - hesaplakad�nB )/ (hesaplakad�nB);
            kikarerekekB= (erkekB-hesaplaerkekB )* (erkekB - hesaplaerkekB) / (hesaplaerkekB);
            kikaretoplam=kikareerkekA+kikarekad�nA+kikarekad�nB+kikarerekekB;
            lbl_kikare.Text = Convert.ToString(kikaretoplam);
            serbestlikderecesi=(2-1)*(2-1);
            if (serbestlikderecesi==1)
            {
                lbl_anlamlilikd�zeyi.Text = "null hipotezi reddedilir , iki de�i�ken aras�nda anlaml� bir ili�ki vard�r";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
