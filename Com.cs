using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using HslCommunication.LogNet;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace XXuanSCADA
{
    public static class Com
    {
        public static string PlcState;
        public static string ServerState;
        public static string LoginUser;
        public static string LoginUserLe;
        public static ILogNet logNet = new LogNetDateTime(Application.StartupPath + "\\Logs", GenerateMode.ByEveryDay);//按每天


        public static DataRow dr = DB.GetData("select * from systeminfo").Rows[0];
        public static string PlcIp = dr["PlcIp"].ToString();
        public static int GetDataTime = Convert.ToInt32(dr["GetDataTime"].ToString());
        public static int SaveDataTime = Convert.ToInt32(dr["SaveDataTime"].ToString());
        public static bool IsSaveData = Convert.ToBoolean(dr["IsSaveData"].ToString());
        public static string Jinghao = dr["Jinghao"].ToString();
        public static string SystemNo = dr["SystemNo"].ToString();



        /// <summary>
        /// 数据采集时将int16转换成1位小数点字符100→10.0
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string IntToDubleString(int data)
        {
            decimal a = Convert.ToDecimal(data);
            decimal b = 0.1M;
            return (a * b).ToString("0.0");
        }

        /// <summary>
        /// 数据采集时将int16转换成1位小数点字符100→10.0
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string IntToDubleString2w(int data)
        {
            decimal a = Convert.ToDecimal(data);
            decimal b = 0.1M;
            return (a * b).ToString("0.00");
        }
        /// <summary>
        /// 数据采集时将int16转换成1位小数点字符 100→1.00
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string IntToDubleString2(int data)
        {
            decimal a = Convert.ToDecimal(data);
            decimal b = 0.01M;
            return (a * b).ToString("0.00");
        }

        /// <summary>
        /// 向PLC写数据时将字符转换成int16 10.0→100
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Int16 StringToInt(string data)
        {
            decimal a = Convert.ToDecimal(data) * 10M;
            return Convert.ToInt16(a);
        }
        /// <summary>
        /// 向PLC写数据时将字符转换成int16 1.00→100
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Int16 StringToInt2(string data)
        {
            decimal a = Convert.ToDecimal(data) * 100M;
            return Convert.ToInt16(a);

        }
        public static Int16 StringToInt3(string data)
        {
            decimal a = Convert.ToDecimal(data) * 1M;
            return Convert.ToInt16(a);

        }

        /// <summary>
        /// 导出数据到Excel
        /// </summary>
        /// <param name="gc">需要导出数据的grindcontrl</param>
        /// <param name="form">窗口</param>
        public static void Savexls(DevExpress.XtraGrid.GridControl gc, Form form, string Filename)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = Filename;
            fileDialog.Title = "导出Excel";
            fileDialog.Filter = "Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = fileDialog.ShowDialog(form);
            if (dialogResult == DialogResult.OK)
            {
                XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                options.TextExportMode = TextExportMode.Text;
                gc.ExportToXls(fileDialog.FileName, options);

                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void log(string Des)
        {
            DB.DoSql("insert into logs (des,op) values ('" + Des + "','" + Com.LoginUser + "')");
        }
        /// <summary>
        /// 编码格式转换
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public static string Utf8(string myString)
        {
            return HttpUtility.UrlEncode(myString, Encoding.UTF8);
        }
    }
}
