using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace HTQLHSSV
{
    class Database
    {
        private SqlConnection connect;
        private SqlDataAdapter adt;
        private SqlCommandBuilder cmd;

        private static Database singleton = null;

        public static Database Singleton
        {
            get {
                if (singleton == null)
                {
                    singleton = new Database();
                }
                return singleton;
            }
        }

        private Database()
        {
            string stringConnect = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
            this.connect = new SqlConnection(stringConnect);
        }

        public DataTable LoadData(string sql)
        {
            DataTable table = new DataTable();
            adt = new SqlDataAdapter(sql,this.connect);
            adt.Fill(table);
            return table;
        }

    }
}
