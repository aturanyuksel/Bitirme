using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;
using System.Data;

namespace Bitirmeproje
{
    public partial class Form1 : Form
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=C:\\Users\\Turann\\Desktop\\bitirmeproje1.db;Version=3;");

        
        void Listele()
        {
          
        }

        private void LoadData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM bitirmeproje111";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public Form1()
        {


            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        int veri = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            veri++;
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO bitirmeproje111 (d,koulA1,koulA2,koulB1,koulB2,koulC1,koulC2,KKARESONUC,KKARERAPOR,ANOVASONUC) VALUES (@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@P0", veri);
                    cmd.Parameters.AddWithValue("@P1", kadınA);
                    cmd.Parameters.AddWithValue("@P2", erkekA);
                    cmd.Parameters.AddWithValue("@P3", kadınB);
                    cmd.Parameters.AddWithValue("@P4", erkekB);
                    cmd.Parameters.AddWithValue("@P5", kadinC);
                    cmd.Parameters.AddWithValue("@P6", erkekC);
                    cmd.Parameters.AddWithValue("@P7", kikaretoplam);
                    cmd.Parameters.AddWithValue("@P8", lbl_anlamlilikdüzeyi.Text);
                    cmd.Parameters.AddWithValue("@P9", lbl_analiz.Text);
                    cmd.ExecuteNonQuery();
                  LoadData();
                    // Listele();
                }
                catch
                {
                    MessageBox.Show("veri yüklenemedi");
                }
            }
        }
        decimal kadınA, erkekA, kadınB, erkekB,kadinC,erkekC, hesaplakadınA, hesaplakadınB, hesaplaerkekA, hesaplaerkekB, kikarekadınA, kikarekadınB, kikareerkekA, kikarerekekB, kikaretoplam, serbestlikderecesi;
        

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            kadınA = Convert.ToDecimal(txt_kadin_a.Text);
            erkekA = Convert.ToDecimal(txt_erkek_a.Text);
            kadınB = Convert.ToDecimal(txt_kadin_a.Text);
            erkekB = Convert.ToDecimal(txt_erkek_b.Text);
            hesaplakadınA = (kadınA + kadınB) * (kadınA + erkekA) / (kadınA + kadınB + erkekA + erkekB);
            hesaplakadınB = (kadınA + kadınB) * (kadınB + erkekB) / (kadınA + kadınB + erkekA + erkekB);
            hesaplaerkekA = (erkekA + erkekB) * (kadınA + erkekA) / (kadınA + kadınB + erkekA + erkekB);
            hesaplaerkekB = (erkekA + erkekB) * (kadınB + erkekA) / (kadınA + kadınB + erkekA + erkekB);

            kikarekadınA = (kadınA - hesaplakadınA) * (kadınA - hesaplakadınA) / (hesaplakadınA);
            kikareerkekA = (erkekA - hesaplaerkekA) * (erkekA - hesaplaerkekA) / (hesaplaerkekA);
            kikarekadınB = (kadınB - hesaplakadınB) * (kadınB - hesaplakadınB) / (hesaplakadınB);
            kikarerekekB = (erkekB - hesaplaerkekB) * (erkekB - hesaplaerkekB) / (hesaplaerkekB);
            kikaretoplam = kikareerkekA + kikarekadınA + kikarekadınB + kikarerekekB;
            lbl_kikare.Text = Convert.ToString(kikaretoplam);
            serbestlikderecesi = (2 - 1) * (2 - 1);
            if (serbestlikderecesi == 1)
            {
                lbl_anlamlilikdüzeyi.Text = "null hipotezi reddedilir , iki değişken arasında anlamlı bir ilişki vardır";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        decimal anovatoplamA, anovatoplamB, anovatoplamC;
        private void btn_anova_Click(object sender, EventArgs e)
        {
            kadınA = Convert.ToDecimal(txt_kadin_a.Text);
            erkekA = Convert.ToDecimal(txt_erkek_a.Text);
            kadınB = Convert.ToDecimal(txt_kadin_a.Text);
            erkekB = Convert.ToDecimal(txt_erkek_b.Text);
            kadinC =Convert.ToDecimal(txt_kadın_c.Text);
            erkekC=Convert.ToDecimal(txt_erkek_c.Text);
            anovatoplamA = kadınA + erkekA / 2;
            anovatoplamB=kadınB+erkekB/2;
            anovatoplamC=kadinC+erkekC/2;
            if(anovatoplamA==anovatoplamB & anovatoplamA == anovatoplamC)
            {
                lbl_analiz.Text = "Üç farklı koşulunda teste etkisi yoktur .";
            }
            else if(anovatoplamA>anovatoplamB || anovatoplamA>anovatoplamC) {
                lbl_analiz.Text = "Koşul A test için farklılık oluşturmuştur ve ARTAN bir eğilim izlemiştir .";
            }
            else if (anovatoplamA < anovatoplamB || anovatoplamA < anovatoplamC)
            {
                lbl_analiz.Text = "Koşul A test için farklılık oluşturmuştur ve AZALAN bir eğilim izlemiştir .";
            }
            else if (anovatoplamB > anovatoplamA || anovatoplamB > anovatoplamC)
            {
                lbl_analiz.Text = "Koşul B test için farklılık oluşturmuştur ve ARTAN bir eğilim izlemiştir .";
            }
            else if (anovatoplamB < anovatoplamA || anovatoplamB < anovatoplamC)
            {
                lbl_analiz.Text = "Koşul B test için farklılık oluşturmuştur ve AZALAN bir eğilim izlemiştir .";
            }
            else if (anovatoplamC > anovatoplamB || anovatoplamC > anovatoplamA)
            {
                lbl_analiz.Text = "Koşul C test için farklılık oluşturmuştur ve ARTAN bir eğilim izlemiştir .";
            }
            else if (anovatoplamC < anovatoplamB || anovatoplamC < anovatoplamA)
            {
                lbl_analiz.Text = "Koşul C test için farklılık oluşturmuştur ve AZALAN bir eğilim izlemiştir .";
            }
            else { lbl_analiz.Text = "Test her koşul için farklılık göstermiştir . "; }
        }
    }

}
