using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace XXuanSCADA
{
    public static class DB
    {
        //连接数据库
        public static OleDbConnection CreateConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + Application.StartupPath + "\\config.mdb;Jet OLEDB:Database Password=!yw3hj8yxjb933hc2#;";
            return conn;
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sqlstr">查询语句</param>
        /// <returns></returns>
        public static DataTable GetData(string sqlstr)//读取数据到datatable
        {
            OleDbConnection conn = CreateConnection();
            OleDbDataAdapter sda = new OleDbDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "getdata");
            conn.Close();
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sqlstr">sql语句</param>
        public static void DoSql(string sqlstr)//执行SQL语句
        {
            OleDbConnection conn = CreateConnection();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DoSql(string sqlstr, OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = CreateConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sqlstr, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
