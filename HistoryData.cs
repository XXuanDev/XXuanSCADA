using CCWin;
using System;
using System.Data.SqlClient;

namespace XXuanSCADA
{
    public partial class HistoryData : CCSkinMain
    {
        public HistoryData()
        {
            InitializeComponent();
        }

        private void HistoryData_Load(object sender, EventArgs e)
        {
            //加载数据到gridControl1
            gridControl1.DataSource = DB.GetData("select * from datadetails");

            //调整列宽以适应内容
            gridView1.BestFitColumns();
        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            string sql = "select * from datadetails where 采集时间 between #" + dateTimeBegin.Value.ToString("yyyy-MM-dd HH:mm:ss") + "# and  #" + dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "#";
            gridControl1.DataSource = DB.GetData(sql);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Com.Savexls(gridControl1, this, "(" + dateTimeBegin.Value.ToString("yyyy-MM-dd HH:mm:ss")+ ")" + "-" + "(" + dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + ")-" + "历史数据记录");
        }

        
    }
}
