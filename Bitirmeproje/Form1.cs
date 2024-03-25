using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;

namespace Bitirmeproje
{
    public partial class Form1 : Form
    {
         public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\Bitirme.db;Version=3;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
    
    

        /* string sqlitedb_constr = "Data source=C:\\Bitirme.db;Version=3;";
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
    }
}
