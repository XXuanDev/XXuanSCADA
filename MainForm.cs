using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HslCommunication.Profinet.Siemens;
using HslCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Collections;
using DevExpress.Charts.Native;
using System.Threading;

namespace XXuanSCADA
{
    public partial class MainForm : CCSkinMain
    {

        public SiemensS7Net S7 { get; set; }
        public OperateResult ConectState;

        double[] arr = new double[25];//运行数据




        public MainForm()
        {
            InitializeComponent();

            //this.Load += MainForm_Load;
            //this.SizeChanged += MainForm_SizeChanged;
        }

        //窗体的默认宽和高
        int normalWidth = 0;
        int normalHeight = 0;

        //需要记录的控件的位置以及宽和高（X,Y,Width，Height）
        Dictionary<string, Rect> normalControl = new Dictionary<string, Rect>();

        private void MainForm_Load(object sender, EventArgs e)
        {

            //记录相关对向及原始尺寸
            normalWidth = this.imgPanel.Width;
            normalHeight = this.imgPanel.Height;
            foreach (Control item in this.imgPanel.Controls)
            {
                normalControl.Add(item.Name, new Rect(item.Left, item.Top, item.Width, item.Height));
            }

            try
            {
                S7 = new SiemensS7Net(SiemensPLCS.S200Smart, Com.PlcIp)
                {
                    ConnectTimeOut = 3000
                };
                ConectState = S7.ConnectServer();
                if (ConectState.IsSuccess)
                {
                    this.timer_readdata.Enabled = true;

                    if (Com.IsSaveData)
                    {
                        this.timer_savedate.Enabled = true;
                    }
                    else
                    {
                        this.timer_savedate.Enabled = false;
                    }
                }
                else
                {
                    this.timer_readdata.Enabled = false;
                    this.systemState.Text = "PLC连接断开…";
                    XtraMessageBox.Show("连接PLC超时！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

        }

        private void ReadData()
        {
            try
            {
                this.systemState.Text = "正在读取数据…";
                arr[0] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1000").Content));
                设备入口压力.Text = arr[0].ToString("0.0") + "Mpa";

                arr[1] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1016").Content));
                设备入口温度.Text = arr[1].ToString("0.0") + "℃";

                arr[2] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1100").Content));
                设备出口压力.Text = arr[2].ToString("0.0") + "Mpa";

                arr[3] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1120").Content));
                设备出口温度.Text = arr[3].ToString("0.0") + "℃";

                arr[4] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1190").Content));
                气控压力.Text = arr[4].ToString("0.0") + "Mpa";

                arr[5] = Convert.ToDouble(S7.ReadInt16("V1050").Content);
                高压分离器液位计.Value = S7.ReadInt16("V1050").Content;
                高压分离器液位.Text = arr[5].ToString() + "mm";

                arr[6] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1260").Content));
                高压分离器浓度.Text = arr[6].ToString("0.0") + "LEL%";

                arr[7] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1136").Content));
                旋流分离器浓度.Text = arr[7].ToString("0.0") + "LEL%";

                arr[8] = Convert.ToDouble(S7.ReadInt16("V1088").Content);
                旋流分离器液位计.Value = S7.ReadInt16("V1088").Content;
                旋流分离器液位.Text = arr[8].ToString() + "mm";

                arr[9] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1170").Content));
                旋流分离器出口压力.Text = arr[9].ToString("0.0") + "Mpa";

                arr[10] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1180").Content));
                旋流分离器出口温度.Text = arr[10].ToString("0.0") + "℃";

                arr[11] = Convert.ToDouble(S7.ReadInt16("V1290").Content);
                JT阀开度监测.Text = arr[11].ToString() + "%";

                arr[12] = Convert.ToDouble(S7.ReadInt16("V1280").Content);
                水套炉液位计.Value = S7.ReadInt16("V1280").Content;
                水套炉液位.Text = arr[12].ToString() + "mm";

                arr[13] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1320").Content));
                水套炉进气温度.Text = arr[13].ToString("0.0") + "℃";

                arr[14] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1228").Content));
                水套炉水温.Text = arr[14].ToString("0.0") + "℃";

                arr[15] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1164").Content));
                换热器入口压力.Text = arr[15].ToString("0.0") + "Mpa";

                arr[16] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1208").Content));
                换热器入口温度.Text = arr[16].ToString("0.0") + "℃";

                arr[17] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1300").Content));
                换热器出口压力.Text = arr[17].ToString("0.0") + "Mpa";

                arr[18] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1310").Content));
                换热器出口温度.Text = arr[18].ToString("0.0") + "℃";

                arr[19] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1490").Content));
                水套炉点火浓度.Text = arr[19].ToString("0.0") + "LEL%";

                arr[20] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1480").Content));
                //arr[20] = Convert.ToDouble(S7.ReadInt16("V1480").Content)/10;
                露点仪.Text = arr[20].ToString() + "℃";

                arr[21] = Convert.ToDouble(S7.ReadFloat("V56").Content.ToString("0.0"));
                气体瞬时流量.Text = S7.ReadFloat("V56").Content.ToString("0.0") + "Nm3/d";

                arr[22] = Convert.ToDouble(S7.ReadFloat("V60").Content.ToString("0.00"));
                气体累计流量.Text = S7.ReadFloat("V60").Content.ToString("0.00") + "Nm3";

                arr[23] = Convert.ToDouble(S7.ReadFloat("V64").Content.ToString("0.00"));
                液体瞬时流量.Text = S7.ReadFloat("V64").Content.ToString("0.00") + "Nm3/d";

                arr[24] = Convert.ToDouble(S7.ReadFloat("V68").Content.ToString("0.00"));
                液体累计流量.Text = S7.ReadFloat("V68").Content.ToString("0.00") + "Nm3";

                //
                switch_JT阀.State = Convert.ToInt32(S7.ReadBool("M3.5").Content); //JT阀状态
                switch_进口阀.State = Convert.ToInt32(S7.ReadBool("Q0.0").Content); //进口阀状态
                switch_高压排污阀.State = Convert.ToInt32(S7.ReadBool("Q0.2").Content); //高压分离器排污阀状态
                switch_高压放空阀.State = Convert.ToInt32(S7.ReadBool("Q0.6").Content); //高压分离器放空阀状态
                switch_旋流排污阀.State = Convert.ToInt32(S7.ReadBool("Q1.0").Content); //旋流排污阀状态
                switch_出口阀.State = Convert.ToInt32(S7.ReadBool("Q1.2").Content); //旋流排污阀状态
                switch_燃料阀.State = Convert.ToInt32(S7.ReadBool("Q1.5").Content); //旋流排污阀状态
                switch_主路阀.State = Convert.ToInt32(S7.ReadBool("Q1.6").Content); //旋流排污阀状态
                //switch_水套炉火焰.State = Convert.ToInt32(S7.ReadBool("I1.4").Content);

                //

            }
            catch (Exception err)
            {
                this.systemState.Text = "PLC连接断开…";
            }
        }

        private void Alarm()
        {
            int alarm = Convert.ToInt32(S7.ReadBool("Q1.7").Content);


            if (alarm == 0)
            {
                报警器.State = false;
                //MessageBox.Show("0");
            }
            if (alarm == 1)
            {
                报警器.State = true;
                timer_alarm.Interval = 3000;
                //MessageBox.Show("1");
                new clsMCI
                {
                    FileName = "alarm2.mp3"
                }.play();
            }
        }

        /*
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //根据原始比例进行新尺寸的计算
            int w = this.imgPanel.Width;
            int h = this.imgPanel.Height;
            foreach (Control item in this.imgPanel.Controls)
            {
                if (normalControl.ContainsKey(item.Name))
                {
                    var controlInfo = normalControl[item.Name];
                    int newX = (int)(w * 1.0 / normalWidth * controlInfo.X);
                    int newY = (int)(h * 1.0 / normalHeight * controlInfo.Y);
                    int newW = (int)(w * 1.0 / normalWidth * controlInfo.Width);
                    int newH = (int)(h * 1.0 / normalHeight * controlInfo.Height);

                    item.Left = newX;
                    item.Top = newY;
                    item.Width = newW;
                    item.Height = newH;

                }
                else
                {
                    Console.WriteLine($"控件{item.Name}不存在于normalControl中");
                }
            }
            //throw new NotImplementedException();
        }
        */
        public class Rect
        {
            public Rect(int x, int y, int width, int height)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        private bool HaveOpened(string FormName)
        {
            bool bOpened = false;

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == FormName)
                {
                    this.MdiChildren[i].Show();
                    this.MdiChildren[i].BringToFront();
                    bOpened = true;
                    break;
                }
            }
            return bOpened;
        }




        //机组控制
        private void btnControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Com.LoginUserLe == "操作员")
            {
                XtraMessageBox.Show("你没有权限操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ConectState.IsSuccess)
                {
                    Form frmcheck = Application.OpenForms["Controls"];
                    if (frmcheck == null || frmcheck.IsDisposed)
                    {
                        Controls form = new Controls();
                        form.Show();
                    }
                    else
                    {
                        frmcheck.Activate();
                    }
                }
                else
                {
                    XtraMessageBox.Show("未连接PLC，无法设置该项", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                Form frmcheck = Application.OpenForms["HistoryData"];
                if (frmcheck == null || frmcheck.IsDisposed)
                {
                    HistoryData form = new HistoryData();
                    form.Show();
                }
                else
                {
                    frmcheck.Activate();
                }
            }
        }

        private void timer_readdata_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(ReadData);
            t.Start();
            ReadData();
            //Alarm();
        }

        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            Alarm();
        }

        private void btnRunningConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Com.LoginUserLe == "操作员")
            {
                XtraMessageBox.Show("你没有权限操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ConectState.IsSuccess)
                {
                    Form frmcheck = Application.OpenForms["RunningConfig"];
                    if (frmcheck == null || frmcheck.IsDisposed)
                    {
                        RunningConfig form = new RunningConfig();
                        form.Show();
                    }
                    else
                    {
                        frmcheck.Activate();
                    }
                }
                else
                {
                    XtraMessageBox.Show("未连接PLC，无法设置该项", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
