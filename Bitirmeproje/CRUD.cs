using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitirmeproje
{
    public class CRUD
    {
        static DataTable dt;
        public static DataTable Listele(string sql)
        {
            dt =new DataTable();
            SQLiteDataAdapter adt=new SQLiteDataAdapter(sql,baglan.connection);
            adt.Fill(dt);
            return dt;
        }
    }
}
