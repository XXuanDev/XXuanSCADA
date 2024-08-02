using CCWin;
using DevExpress.XtraEditors;
using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XXuanSCADA
{
    public partial class RealData : CCSkinMain
    {

        public SiemensS7Net S7 { get; set; }
        public OperateResult ConnectState;


        double[] arr = new double[27];//运行数据

        String sbrkyl;
        public RealData()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            timer_readdata.Interval = Com.GetDataTime * 1000;
            timer_savedate.Interval = Com.SaveDataTime * 1000;

            //双缓冲减少闪烁和提高重绘性能
            this.DoubleBuffered = true;

            //启用硬件加速来提升性能
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint, true);


        }

        //窗体的默认宽和高
        int normalWidth = 0;
        int normalHeight = 0;

        //需要记录的控件的位置以及宽和高（X,Y,Width，Height）
        Dictionary<string, Rect> normalControl = new Dictionary<string, Rect>();

        private void realData_Load(object sender, EventArgs e)
        {

            //记录相关对向及原始尺寸
            normalWidth = this.RealDataPanel.Width;
            normalHeight = this.RealDataPanel.Height;
            foreach (Control item in this.RealDataPanel.Controls)
            {
                normalControl.Add(item.Name, new Rect(item.Left, item.Top, item.Width, item.Height));
            }

            try
            {
                S7 = new SiemensS7Net(SiemensPLCS.S200Smart, Com.PlcIp)
                {
                    ConnectTimeOut = 3000
                };
                ConnectState = S7.ConnectServer();
                if (ConnectState.IsSuccess)
                {
                    this.timer_readdata.Enabled = true;
                    this.timer_savedate.Enabled = Com.IsSaveData;
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

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //根据原始比例进行新尺寸的计算
            int w = this.RealDataPanel.Width;
            int h = this.RealDataPanel.Height;

            //使用SuspendLayout和ResumeLayout方法可以暂时停止和恢复布局逻辑，减少控件的重绘次数。
            this.SuspendLayout();
            //通过延迟重绘来减少频繁的UI更新
            this.BeginInvoke(new MethodInvoker(delegate
            {
                // Your scaling logic here
                foreach (Control item in this.RealDataPanel.Controls)
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
                ScaleControls(this, this.Width / (float)this.ClientSize.Width, this.Height / (float)this.ClientSize.Height);
                this.Invalidate();  // Force a redraw after scaling
                this.ResumeLayout(true);
            }));
            
            //throw new NotImplementedException();
        }

        private void ScaleControls(Control parent, float scaleX, float scaleY)
        {
            foreach (Control control in parent.Controls)
            {
                control.Left = (int)(control.Left * scaleX);
                control.Top = (int)(control.Top * scaleY);
                control.Width = (int)(control.Width * scaleX);
                control.Height = (int)(control.Height * scaleY);
                if (control.Controls.Count > 0)
                {
                    ScaleControls(control, scaleX, scaleY);
                }
            }
        }

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

        private void ReadData()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate { this.systemState.Text = "正在读取数据…"; });
                this.Invoke((MethodInvoker)delegate
                {
                    
                    arr[0] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1000").Content));
                    sbrkyl = arr[0].ToString("0.0") + "Mpa";
                    设备入口压力.Text = sbrkyl;

                    arr[1] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1016").Content));
                    设备入口温度.Text = arr[1].ToString("0.0") + "℃";

                    arr[2] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1164").Content));
                    换热器入口压力.Text = arr[2].ToString("0.0") + "Mpa";

                    arr[3] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1208").Content));
                    换热器入口温度.Text = arr[3].ToString("0.0") + "℃";

                    arr[4] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1300").Content));
                    换热器出口压力.Text = arr[4].ToString("0.0") + "Mpa";

                    arr[5] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1310").Content));
                    换热器出口温度.Text = arr[5].ToString("0.0") + "℃";

                    arr[6] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1622").Content));
                    JT阀入口压力.Text = arr[6].ToString("0.0") + "Mpa";

                    arr[7] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1632").Content));
                    JT阀入口温度.Text = arr[7].ToString("0.0") + "℃";

                    arr[8] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1170").Content));
                    旋流分离器出口压力.Text = arr[8].ToString("0.0") + "Mpa";

                    arr[9] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1180").Content));
                    旋流分离器出口温度.Text = arr[9].ToString("0.0") + "℃";

                    arr[10] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1100").Content));
                    设备出口压力.Text = arr[10].ToString("0.0") + "Mpa";

                    arr[11] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1120").Content));
                    设备出口温度.Text = arr[11].ToString("0.0") + "℃";

                    arr[12] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1190").Content));
                    气控压力.Text = arr[12].ToString("0.0") + "Mpa";

                    arr[13] = Convert.ToDouble(S7.ReadInt16("V1050").Content);
                    高压分离器液位计.Value = S7.ReadInt16("V1050").Content;
                    高压分离器液位.Text = arr[13].ToString() + "mm";

                    arr[14] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1260").Content));
                    高压分离器浓度.Text = arr[14].ToString("0.0") + "LEL%";

                    arr[15] = Convert.ToDouble(S7.ReadInt16("V1088").Content);
                    旋流分离器液位计.Value = S7.ReadInt16("V1088").Content;
                    旋流分离器液位.Text = arr[15].ToString() + "mm";

                    arr[16] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1136").Content));
                    旋流分离器浓度.Text = arr[16].ToString("0.0") + "LEL%";

                    arr[17] = Convert.ToDouble(S7.ReadInt16("V1290").Content);
                    JT阀开度监测.Text = arr[17].ToString() + "%";

                    arr[18] = Convert.ToDouble(S7.ReadInt16("V1280").Content);
                    水套炉液位计.Value = S7.ReadInt16("V1280").Content;
                    水套炉液位.Text = arr[18].ToString() + "mm";

                    arr[19] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1320").Content));
                    水套炉进气温度.Text = arr[19].ToString("0.0") + "℃";

                    arr[20] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1228").Content));
                    水套炉水温.Text = arr[20].ToString("0.0") + "℃";

                    arr[21] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1490").Content));
                    水套炉点火浓度.Text = arr[21].ToString("0.0") + "LEL%";

                    arr[22] = Convert.ToDouble(Com.IntToDubleString(S7.ReadInt16("V1480").Content));
                    露点仪.Text = arr[22].ToString() + "℃";

                    arr[23] = Convert.ToDouble(S7.ReadFloat("V56").Content);
                    气体瞬时流量.Text = arr[23].ToString("0.0") + "Nm3/h";

                    arr[24] = Convert.ToDouble(S7.ReadFloat("V60").Content);
                    气体累计流量.Text = arr[24].ToString("0.00") + "Nm3";

                    arr[25] = Convert.ToDouble(S7.ReadFloat("V64").Content);
                    液体瞬时流量.Text = arr[25].ToString("0.00") + "Nm3/h";

                    arr[26] = Convert.ToDouble(S7.ReadFloat("V68").Content);
                    液体累计流量.Text = arr[26].ToString("0.00") + "Nm3";
                });

            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.systemState.Text = "PLC连接断开…";
                    Console.WriteLine("读取数据时发生异常: " + ex.Message);
                });
            }
        }

        private void timer_readdata_Tick(object sender, EventArgs e)
        {
            Task.Run(() => ReadData());
        }


        private void Alarm()
        {
            try
            {
                int alarm = Convert.ToInt32(S7.ReadBool("Q1.7").Content);
                Console.WriteLine("Alarm method read value: " + alarm);

                if (alarm == 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        报警器.State = false;
                    });
                    Console.WriteLine("Alarm state set to false");
                }
                if (alarm == 1)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        报警器.State = true;
                        new clsMCI
                        {
                            FileName = "alarm.mp3"
                        }.play();
                        timer_alarm.Interval = 3000;
                    });
                    Console.WriteLine("Alarm state set to true");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Alarm method: " + ex.Message);
            }
        }

        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            Task.Run(() => Alarm());
            Console.WriteLine("Task started at: " + DateTime.Now);
        }

        private void ReadState()
        {
            try
            {
                switch_JT阀.State = Convert.ToInt32(S7.ReadBool("M3.5").Content); //JT阀状态
                switch_进口阀.State = Convert.ToInt32(S7.ReadBool("Q0.0").Content); //进口阀状态
                switch_高压排污阀.State = Convert.ToInt32(S7.ReadBool("Q0.2").Content); //高压分离器排污阀状态
                switch_高压放空阀.State = Convert.ToInt32(S7.ReadBool("Q0.6").Content); //高压分离器放空阀状态
                switch_旋流排污阀.State = Convert.ToInt32(S7.ReadBool("Q1.0").Content); //旋流排污阀状态
                switch_出口阀.State = Convert.ToInt32(S7.ReadBool("Q1.2").Content); //旋流排污阀状态
                switch_燃料阀.State = Convert.ToInt32(S7.ReadBool("Q1.5").Content); //旋流排污阀状态
                switch_主路阀.State = Convert.ToInt32(S7.ReadBool("Q1.6").Content); //旋流排污阀状态
                Console.WriteLine("ReadState method completed at: " + DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadState method: " + ex.Message);
            }
        }



        private void timer_readstate_Tick(object sender, EventArgs e)
        {
            Task.Run(() => ReadState());
            Console.WriteLine("Task started at: " + DateTime.Now);
        }

        private void ShowForm<T>(string formName) where T : Form, new()
        {
            Form frmCheck = Application.OpenForms[formName];
            if (frmCheck == null || frmCheck.IsDisposed)
            {
                T form = new T();
                form.Show();
            }
            else
            {
                frmCheck.Activate();
            }
        }

        //历史数据
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

        //机组控制
        private void btnControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Com.LoginUserLe == "操作员")
            {
                XtraMessageBox.Show("你没有权限操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ConnectState.IsSuccess)
            {
                ShowForm<Controls>("Controls");
            }
            else
            {
                XtraMessageBox.Show("未连接PLC，无法设置该项", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //运行参数
        private void btnRunningConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Com.LoginUserLe == "操作员")
            {
                XtraMessageBox.Show("你没有权限操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ConnectState.IsSuccess)
            {
                ShowForm<RunningConfig>("RunningConfig");
            }
            else
            {
                XtraMessageBox.Show("未连接PLC，无法设置该项", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //系统设置
        private void btnSystemConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Com.LoginUserLe == "超级管理员")
            {
                ShowForm<SystemConfig>("SystemConfig");
            }
            else
            {
                XtraMessageBox.Show("你没有权限操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SaveData()
        {
            try
            {
                systemState.Text = "正在保存数据…";
                string sql = "insert into Datadetails (设备编号,设备入口压力,设备入口温度,换热器入口压力,换热器入口温度,换热器出口压力,换热器出口温度,JT阀入口压力,JT阀入口温度,旋流分离器出口压力,旋流分离器出口温度,设备出口压力,设备出口温度,气控压力,高压分离器液位,高压分离器浓度,旋流分离器液位,旋流分离器浓度,JT阀开度监测,水套炉液位,水套炉进气温度,水套炉水温,水套炉点火浓度,露点仪,气体瞬时流量,气体累计流量,液体瞬时流量,液体累计流量) values('" + Com.SystemNo + "'," + arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8] + "," + arr[9] + "," + arr[10] + "," + arr[11] + "," + arr[12] + "," + arr[13] + "," + arr[14] + "," + arr[15] + "," + arr[16] + "," + arr[17] + "," + arr[18] + "," + arr[19] + "," + arr[20] + "," + arr[21] + "," + arr[22] + "," + arr[23] + "," + arr[24] + "," + arr[25] + "," + arr[26] + ")";
                DB.DoSql(sql);
            }
            catch (Exception ex)
            {
                systemState.Text = "保存数据失败";
            }
        }

        private void timer_savedate_Tick(object sender, EventArgs e)
        {
            Task.Run(() => SaveData());
        }

        private void RealData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
