using CCWin;
using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Windows.Forms;

namespace XXuanSCADA
{
    public partial class RunningConfig : CCSkinMain
    {
        public SiemensS7Net S7 { get; set; }

        public RunningConfig()
        {
            InitializeComponent();
            S7 = new SiemensS7Net(SiemensPLCS.S200Smart, Com.PlcIp);
            S7.ConnectTimeOut = 3000;
            OperateResult connect = S7.ConnectServer();
            if (connect.IsSuccess)
            {
                LoadData();
            }
            else
            {
                Com.logNet.WriteDebug("连接PLC超时！");
                //XtraMessageBox.Show("连接PLC超时！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            double[] arr = new double[25];
            try
            {
                高压分离器压力高开放空.Text = Com.IntToDubleString(S7.ReadInt16("V1166").Content);
                高压分离器压力低关放空.Text = Com.IntToDubleString(S7.ReadInt16("V1162").Content);
                高压分离器液位高开排污.Text = S7.ReadInt16("V1414").Content.ToString();
                高压分离器液位低关排污.Text = S7.ReadInt16("V1412").Content.ToString();
                旋流分离器液位高开排污.Text = S7.ReadInt16("V1090").Content.ToString();
                旋流分离器液位低关排污.Text = S7.ReadInt16("V1086").Content.ToString();
                JT阀开度0对应值.Text = Com.IntToDubleString(S7.ReadInt16("V1292").Content);
                JT阀开度100对应值.Text = Com.IntToDubleString(S7.ReadInt16("V1296").Content);

            }
            catch (Exception err)
            {
                Com.logNet.WriteDebug(err.Message.ToString());
            }

        }

        private void RunningConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            S7.ConnectClose();
        }

        private  void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                S7.Write("V1166", Com.StringToInt(高压分离器压力高开放空.Text.ToString()));
                S7.Write("V1162", Com.StringToInt(高压分离器压力低关放空.Text.ToString()));
                S7.Write("V1414", Com.StringToInt3(高压分离器液位高开排污.Text.ToString()));
                S7.Write("V1412", Com.StringToInt3(高压分离器液位低关排污.Text.ToString()));
                S7.Write("V1090", Com.StringToInt3(旋流分离器液位高开排污.Text.ToString()));
                S7.Write("V1086", Com.StringToInt3(旋流分离器液位低关排污.Text.ToString()));
                S7.Write("V1292", Com.StringToInt(JT阀开度0对应值.Text.ToString()));
                S7.Write("V1296", Com.StringToInt(JT阀开度100对应值.Text.ToString()));
            }
            catch(Exception err)
            {
                Com.logNet.WriteDebug(err.Message.ToString());
            }
        }
    }
}
