using CCWin;
using DevExpress.XtraEditors;
using System;
using System.Data;

using System.Windows.Forms;

namespace XXuanSCADA
{
    public partial class SystemConfig : CCSkinMain
    {
        public SystemConfig()
        {
            InitializeComponent();
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = DB.GetData("select * from systeminfo").Rows[0];
                txtGetDatatime.Text = dr["GetDataTime"].ToString();
                txtSaveDatatime.Text = dr["SaveDataTime"].ToString();
                txtPlcIp.Text = dr["PlcIP"].ToString();
                txtSystemName.Text = dr["SystemName"].ToString();
                txtSystemNo.Text = dr["SystemNo"].ToString();
                txtJinghao.Text = dr["Jinghao"].ToString();
                checkSavedata.Checked = Convert.ToBoolean(dr["IsSaveData"].ToString());
            }
            catch (Exception err)
            {
                Com.logNet.WriteDebug(err.Message.ToString());
            }

        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                int getdatatime = Convert.ToInt32(txtGetDatatime.Text.ToString());
                int savedatatime = Convert.ToInt32(txtSaveDatatime.Text.ToString());
                string plcip = txtPlcIp.Text.ToString();
                string systemname = txtSystemName.Text.ToString();
                string systemno = txtSystemNo.Text.ToString();
                string jinghao = txtJinghao.Text.ToString();
                bool issavedata = checkSavedata.Checked;
                string sql = "update systeminfo set SystemNo='" + systemno + "',SystemName='" + systemname + "',PlcIP='" + plcip + "',IsSaveData=" + issavedata + ",GetDataTime=" + getdatatime + ",SaveDataTime=" + savedatatime + ",Jinghao='" + jinghao + "'";
                DB.DoSql(sql);
                XtraMessageBox.Show("系统配置参数已保存，请重新登录站控系统生效。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                XtraMessageBox.Show(err.Message.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
