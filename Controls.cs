using System;
using System.Threading;
using System.Windows.Forms;
using CCWin;
using DevExpress.XtraEditors;
using HslCommunication;
using HslCommunication.Profinet.Siemens;

namespace XXuanSCADA
{
    public partial class Controls : CCSkinMain
    {
        public SiemensS7Net S7 { get; set; }
        public OperateResult ConectState;

        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            try
            {
                S7 = new SiemensS7Net(SiemensPLCS.S200Smart, Com.PlcIp)
                {
                    ConnectTimeOut = 3000
                };
                ConectState = S7.ConnectServer();
                if (ConectState.IsSuccess)
                {
                    Read();
                }
                else
                {
                    Com.logNet.WriteDebug("PLC连接断开…");
                    Com.PlcState = "PLC连接断开…";
                    XtraMessageBox.Show("PLC连接断开…", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception err)
            {
                XtraMessageBox.Show(err.Message.ToString());
            }
        }

        private void Read()
        {
            this.textEdit1.Text = S7.ReadInt16("V1298").Content.ToString();
            bool atuo = S7.ReadBool("M5.0").Content;
            bool jinkou = S7.ReadBool("M8.0").Content;
            bool gaoyapaiwu = S7.ReadBool("M5.1").Content;
            bool gaoyafangkong = S7.ReadBool("M5.5").Content;
            bool xunliupaiwu = S7.ReadBool("M5.3").Content;
            bool chukou = S7.ReadBool("M8.2").Content;
            if (atuo)
            {
                btnAtuo.Text = "手动";
                this.btnJinkou.Enabled = true;
                this.btnGaoyaPaiwu.Enabled = true;
                this.btnGaoyaFangkong.Enabled = true;
                this.btnXuanliuPaiwu.Enabled = true;
                this.btnChukou.Enabled = true;
                this.btnJt.Enabled = true;


            }
            else
            {
                btnAtuo.Text = "自动";
                this.btnJinkou.Enabled = false;
                this.btnGaoyaPaiwu.Enabled = false;
                this.btnGaoyaFangkong.Enabled = false;
                this.btnXuanliuPaiwu.Enabled = false;
                this.btnChukou.Enabled = false;
                this.btnJt.Enabled = false;
            }
            if (jinkou)
            {
                this.switch1.State = 1;
            }
            else
            {
                this.switch1.State = 0;
            }
            if (gaoyapaiwu)
            {
                this.switch2.State = 1;
            }
            else
            {
                this.switch2.State = 0;
            }
            if (gaoyafangkong)
            {
                this.switch3.State = 1;
            }
            else
            {
                this.switch3.State = 0;
            }
            if (xunliupaiwu)
            {
                this.switch4.State = 1;
            }
            else
            {
                this.switch4.State = 0;
            }
            if (chukou)
            {
                this.switch5.State = 1;
            }
            else
            {
                this.switch5.State = 0;
            }

        }

        private void btnAtuo_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M5.0").Content)
            {
                S7.Write("M5.0", false);
            }
            else
            {
                S7.Write("M5.0", true);
            }
            Read();
        }

        private void btnFuwei_Click(object sender, EventArgs e)
        {
            S7.Write("M1.3", true);
            Thread.Sleep(2000);
            S7.Write("M1.3", false);
        }

        private void btnJt_Click(object sender, EventArgs e)
        {
            S7.Write("V1298", Convert.ToInt16(this.textEdit1.Text.ToString()));
            S7.Write("M5.7", true);
        }

        private void btnJinkou_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M8.0").Content)
            {
                S7.Write("M8.0", false);
                S7.Write("M8.1", true);

            }
            else
            {
                S7.Write("M8.0", true);
                S7.Write("M8.1", false);
            }
            Read();
        }

        private void btnGaoyaPaiwu_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M5.1").Content)
            {
                S7.Write("M5.1", false);
                S7.Write("M5.2", true);
            }
            else
            {
                S7.Write("M5.1", true);
                S7.Write("M5.2", false);
            }
            Read();
        }

        private void btnGaoyaFangkong_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M5.5").Content)
            {
                S7.Write("M5.5", false);
                S7.Write("M5.6", true);

            }
            else
            {
                S7.Write("M5.5", true);
                S7.Write("M5.6", false);
            }
            Read();
        }

        private void btnXuanliuPaiwu_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M5.3").Content)
            {
                S7.Write("M5.3", false);
                S7.Write("M5.4", true);
            }
            else
            {
                S7.Write("M5.3", true);
                S7.Write("M5.4", false);
            }
            Read();
        }

        private void btnChukou_Click(object sender, EventArgs e)
        {
            if (S7.ReadBool("M8.2").Content)
            {
                S7.Write("M8.2", false);
                S7.Write("M8.3", true);
            }
            else
            {
                S7.Write("M8.2", true);
                S7.Write("M8.3", false);
            }
            Read();
        }


    }
}
