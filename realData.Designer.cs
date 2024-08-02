namespace XXuanSCADA
{
    partial class RealData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::XXuanSCADA.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealData));
            this.RealDataPanel = new CCWin.SkinControl.SkinPanel();
            this.switch_进口阀 = new XLControl.Switch();
            this.switch_高压排污阀 = new XLControl.Switch();
            this.switch_高压放空阀 = new XLControl.Switch();
            this.switch_主路阀 = new XLControl.Switch();
            this.switch_燃料阀 = new XLControl.Switch();
            this.switch_出口阀 = new XLControl.Switch();
            this.switch_旋流排污阀 = new XLControl.Switch();
            this.switch_JT阀 = new XLControl.Switch();
            this.报警器 = new XLControl.Alarm();
            this.水套炉液位计 = new XLControl.LevelGauge();
            this.旋流分离器液位计 = new XLControl.LevelGauge();
            this.高压分离器液位计 = new XLControl.LevelGauge();
            this.液位 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.水温 = new CCWin.SkinControl.SkinLabel();
            this.气体累计流量 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.液体累计流量 = new CCWin.SkinControl.SkinTextBox();
            this.气体瞬时流量 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.液体瞬时流量 = new CCWin.SkinControl.SkinTextBox();
            this.systemState = new CCWin.SkinControl.SkinLabel();
            this.旋流分离器浓度 = new CCWin.SkinControl.SkinTextBox();
            this.高压分离器浓度 = new CCWin.SkinControl.SkinTextBox();
            this.水套炉点火浓度 = new CCWin.SkinControl.SkinTextBox();
            this.水套炉液位 = new CCWin.SkinControl.SkinTextBox();
            this.旋流分离器出口压力 = new CCWin.SkinControl.SkinTextBox();
            this.旋流分离器液位 = new CCWin.SkinControl.SkinTextBox();
            this.JT阀开度监测 = new CCWin.SkinControl.SkinTextBox();
            this.水套炉进气温度 = new CCWin.SkinControl.SkinTextBox();
            this.设备出口压力 = new CCWin.SkinControl.SkinTextBox();
            this.JT阀入口压力 = new CCWin.SkinControl.SkinTextBox();
            this.换热器出口压力 = new CCWin.SkinControl.SkinTextBox();
            this.换热器入口压力 = new CCWin.SkinControl.SkinTextBox();
            this.设备入口压力 = new CCWin.SkinControl.SkinTextBox();
            this.高压分离器液位 = new CCWin.SkinControl.SkinTextBox();
            this.水套炉水温 = new CCWin.SkinControl.SkinTextBox();
            this.旋流分离器出口温度 = new CCWin.SkinControl.SkinTextBox();
            this.露点仪 = new CCWin.SkinControl.SkinTextBox();
            this.气控压力 = new CCWin.SkinControl.SkinTextBox();
            this.设备出口温度 = new CCWin.SkinControl.SkinTextBox();
            this.JT阀入口温度 = new CCWin.SkinControl.SkinTextBox();
            this.换热器出口温度 = new CCWin.SkinControl.SkinTextBox();
            this.换热器入口温度 = new CCWin.SkinControl.SkinTextBox();
            this.设备入口温度 = new CCWin.SkinControl.SkinTextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnRunningConfig = new DevExpress.XtraBars.BarButtonItem();
            this.btnControl = new DevExpress.XtraBars.BarButtonItem();
            this.btnHistory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSystemConfig = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.timer_readdata = new System.Windows.Forms.Timer(this.components);
            this.timer_savedate = new System.Windows.Forms.Timer(this.components);
            this.timer_senddata = new System.Windows.Forms.Timer(this.components);
            this.timer_alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_readstate = new System.Windows.Forms.Timer(this.components);
            this.RealDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // RealDataPanel
            // 
            this.RealDataPanel.BackColor = System.Drawing.Color.White;
            this.RealDataPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RealDataPanel.BackgroundImage")));
            this.RealDataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RealDataPanel.Controls.Add(this.switch_进口阀);
            this.RealDataPanel.Controls.Add(this.switch_高压排污阀);
            this.RealDataPanel.Controls.Add(this.switch_高压放空阀);
            this.RealDataPanel.Controls.Add(this.switch_主路阀);
            this.RealDataPanel.Controls.Add(this.switch_燃料阀);
            this.RealDataPanel.Controls.Add(this.switch_出口阀);
            this.RealDataPanel.Controls.Add(this.switch_旋流排污阀);
            this.RealDataPanel.Controls.Add(this.switch_JT阀);
            this.RealDataPanel.Controls.Add(this.报警器);
            this.RealDataPanel.Controls.Add(this.水套炉液位计);
            this.RealDataPanel.Controls.Add(this.旋流分离器液位计);
            this.RealDataPanel.Controls.Add(this.高压分离器液位计);
            this.RealDataPanel.Controls.Add(this.液位);
            this.RealDataPanel.Controls.Add(this.skinLabel7);
            this.RealDataPanel.Controls.Add(this.skinLabel5);
            this.RealDataPanel.Controls.Add(this.skinLabel6);
            this.RealDataPanel.Controls.Add(this.skinLabel4);
            this.RealDataPanel.Controls.Add(this.skinLabel3);
            this.RealDataPanel.Controls.Add(this.水温);
            this.RealDataPanel.Controls.Add(this.气体累计流量);
            this.RealDataPanel.Controls.Add(this.skinLabel2);
            this.RealDataPanel.Controls.Add(this.液体累计流量);
            this.RealDataPanel.Controls.Add(this.气体瞬时流量);
            this.RealDataPanel.Controls.Add(this.skinLabel1);
            this.RealDataPanel.Controls.Add(this.液体瞬时流量);
            this.RealDataPanel.Controls.Add(this.systemState);
            this.RealDataPanel.Controls.Add(this.旋流分离器浓度);
            this.RealDataPanel.Controls.Add(this.高压分离器浓度);
            this.RealDataPanel.Controls.Add(this.水套炉点火浓度);
            this.RealDataPanel.Controls.Add(this.水套炉液位);
            this.RealDataPanel.Controls.Add(this.旋流分离器出口压力);
            this.RealDataPanel.Controls.Add(this.旋流分离器液位);
            this.RealDataPanel.Controls.Add(this.JT阀开度监测);
            this.RealDataPanel.Controls.Add(this.水套炉进气温度);
            this.RealDataPanel.Controls.Add(this.设备出口压力);
            this.RealDataPanel.Controls.Add(this.JT阀入口压力);
            this.RealDataPanel.Controls.Add(this.换热器出口压力);
            this.RealDataPanel.Controls.Add(this.换热器入口压力);
            this.RealDataPanel.Controls.Add(this.设备入口压力);
            this.RealDataPanel.Controls.Add(this.高压分离器液位);
            this.RealDataPanel.Controls.Add(this.水套炉水温);
            this.RealDataPanel.Controls.Add(this.旋流分离器出口温度);
            this.RealDataPanel.Controls.Add(this.露点仪);
            this.RealDataPanel.Controls.Add(this.气控压力);
            this.RealDataPanel.Controls.Add(this.设备出口温度);
            this.RealDataPanel.Controls.Add(this.JT阀入口温度);
            this.RealDataPanel.Controls.Add(this.换热器出口温度);
            this.RealDataPanel.Controls.Add(this.换热器入口温度);
            this.RealDataPanel.Controls.Add(this.设备入口温度);
            this.RealDataPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RealDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealDataPanel.DownBack = null;
            this.RealDataPanel.Location = new System.Drawing.Point(4, 28);
            this.RealDataPanel.MouseBack = null;
            this.RealDataPanel.Name = "RealDataPanel";
            this.RealDataPanel.NormlBack = null;
            this.RealDataPanel.Size = new System.Drawing.Size(1912, 1007);
            this.RealDataPanel.TabIndex = 0;
            // 
            // switch_进口阀
            // 
            this.switch_进口阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_进口阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_进口阀.BackgroundImage")));
            this.switch_进口阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_进口阀.Location = new System.Drawing.Point(297, 579);
            this.switch_进口阀.Name = "switch_进口阀";
            this.switch_进口阀.Size = new System.Drawing.Size(30, 30);
            this.switch_进口阀.State = 0;
            this.switch_进口阀.TabIndex = 5;
            // 
            // switch_高压排污阀
            // 
            this.switch_高压排污阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_高压排污阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_高压排污阀.BackgroundImage")));
            this.switch_高压排污阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_高压排污阀.Location = new System.Drawing.Point(554, 615);
            this.switch_高压排污阀.Name = "switch_高压排污阀";
            this.switch_高压排污阀.Size = new System.Drawing.Size(30, 30);
            this.switch_高压排污阀.State = 0;
            this.switch_高压排污阀.TabIndex = 5;
            // 
            // switch_高压放空阀
            // 
            this.switch_高压放空阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_高压放空阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_高压放空阀.BackgroundImage")));
            this.switch_高压放空阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_高压放空阀.Location = new System.Drawing.Point(506, 291);
            this.switch_高压放空阀.Name = "switch_高压放空阀";
            this.switch_高压放空阀.Size = new System.Drawing.Size(30, 30);
            this.switch_高压放空阀.State = 0;
            this.switch_高压放空阀.TabIndex = 5;
            // 
            // switch_主路阀
            // 
            this.switch_主路阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_主路阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_主路阀.BackgroundImage")));
            this.switch_主路阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_主路阀.Location = new System.Drawing.Point(1168, 712);
            this.switch_主路阀.Name = "switch_主路阀";
            this.switch_主路阀.Size = new System.Drawing.Size(30, 30);
            this.switch_主路阀.State = 0;
            this.switch_主路阀.TabIndex = 5;
            // 
            // switch_燃料阀
            // 
            this.switch_燃料阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_燃料阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_燃料阀.BackgroundImage")));
            this.switch_燃料阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_燃料阀.Location = new System.Drawing.Point(1168, 616);
            this.switch_燃料阀.Name = "switch_燃料阀";
            this.switch_燃料阀.Size = new System.Drawing.Size(30, 30);
            this.switch_燃料阀.State = 0;
            this.switch_燃料阀.TabIndex = 5;
            // 
            // switch_出口阀
            // 
            this.switch_出口阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_出口阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_出口阀.BackgroundImage")));
            this.switch_出口阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_出口阀.Location = new System.Drawing.Point(1410, 820);
            this.switch_出口阀.Name = "switch_出口阀";
            this.switch_出口阀.Size = new System.Drawing.Size(30, 30);
            this.switch_出口阀.State = 0;
            this.switch_出口阀.TabIndex = 5;
            // 
            // switch_旋流排污阀
            // 
            this.switch_旋流排污阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_旋流排污阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_旋流排污阀.BackgroundImage")));
            this.switch_旋流排污阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_旋流排污阀.Location = new System.Drawing.Point(1554, 756);
            this.switch_旋流排污阀.Name = "switch_旋流排污阀";
            this.switch_旋流排污阀.Size = new System.Drawing.Size(30, 30);
            this.switch_旋流排污阀.State = 0;
            this.switch_旋流排污阀.TabIndex = 5;
            // 
            // switch_JT阀
            // 
            this.switch_JT阀.BackColor = System.Drawing.Color.Transparent;
            this.switch_JT阀.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_JT阀.BackgroundImage")));
            this.switch_JT阀.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_JT阀.Location = new System.Drawing.Point(1470, 425);
            this.switch_JT阀.Name = "switch_JT阀";
            this.switch_JT阀.Size = new System.Drawing.Size(30, 30);
            this.switch_JT阀.State = 0;
            this.switch_JT阀.TabIndex = 5;
            // 
            // 报警器
            // 
            this.报警器.BackColor = System.Drawing.Color.Transparent;
            this.报警器.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("报警器.BackgroundImage")));
            this.报警器.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.报警器.Interval = 100;
            this.报警器.Location = new System.Drawing.Point(38, 225);
            this.报警器.Name = "报警器";
            this.报警器.Size = new System.Drawing.Size(69, 80);
            this.报警器.State = false;
            this.报警器.TabIndex = 4;
            // 
            // 水套炉液位计
            // 
            this.水套炉液位计.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.水套炉液位计.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.水套炉液位计.Location = new System.Drawing.Point(1179, 353);
            this.水套炉液位计.Name = "水套炉液位计";
            this.水套炉液位计.Size = new System.Drawing.Size(10, 158);
            this.水套炉液位计.TabIndex = 3;
            // 
            // 旋流分离器液位计
            // 
            this.旋流分离器液位计.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.旋流分离器液位计.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.旋流分离器液位计.Location = new System.Drawing.Point(1625, 454);
            this.旋流分离器液位计.Name = "旋流分离器液位计";
            this.旋流分离器液位计.Size = new System.Drawing.Size(10, 124);
            this.旋流分离器液位计.TabIndex = 3;
            // 
            // 高压分离器液位计
            // 
            this.高压分离器液位计.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.高压分离器液位计.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.高压分离器液位计.Location = new System.Drawing.Point(663, 405);
            this.高压分离器液位计.Name = "高压分离器液位计";
            this.高压分离器液位计.Size = new System.Drawing.Size(10, 72);
            this.高压分离器液位计.TabIndex = 2;
            // 
            // 液位
            // 
            this.液位.AutoSize = true;
            this.液位.BackColor = System.Drawing.Color.Transparent;
            this.液位.BorderColor = System.Drawing.Color.White;
            this.液位.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.液位.Location = new System.Drawing.Point(939, 462);
            this.液位.Name = "液位";
            this.液位.Size = new System.Drawing.Size(42, 21);
            this.液位.TabIndex = 1;
            this.液位.Text = "液位";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(1348, 969);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(106, 21);
            this.skinLabel7.TabIndex = 1;
            this.skinLabel7.Text = "气体累计流量";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(567, 969);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(106, 21);
            this.skinLabel5.TabIndex = 1;
            this.skinLabel5.Text = "液体累计流量";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(1006, 969);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(106, 21);
            this.skinLabel6.TabIndex = 1;
            this.skinLabel6.Text = "气体瞬时流量";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(143, 969);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(106, 21);
            this.skinLabel4.TabIndex = 1;
            this.skinLabel4.Text = "液体瞬时流量";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(88, 764);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(51, 21);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "浓度2";
            // 
            // 水温
            // 
            this.水温.AutoSize = true;
            this.水温.BackColor = System.Drawing.Color.Transparent;
            this.水温.BorderColor = System.Drawing.Color.White;
            this.水温.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水温.Location = new System.Drawing.Point(939, 410);
            this.水温.Name = "水温";
            this.水温.Size = new System.Drawing.Size(42, 21);
            this.水温.TabIndex = 1;
            this.水温.Text = "水温";
            // 
            // 气体累计流量
            // 
            this.气体累计流量.BackColor = System.Drawing.Color.Transparent;
            this.气体累计流量.DownBack = null;
            this.气体累计流量.Icon = null;
            this.气体累计流量.IconIsButton = false;
            this.气体累计流量.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.气体累计流量.IsPasswordChat = '\0';
            this.气体累计流量.IsSystemPasswordChar = false;
            this.气体累计流量.Lines = new string[0];
            this.气体累计流量.Location = new System.Drawing.Point(1500, 964);
            this.气体累计流量.Margin = new System.Windows.Forms.Padding(0);
            this.气体累计流量.MaxLength = 32767;
            this.气体累计流量.MinimumSize = new System.Drawing.Size(28, 28);
            this.气体累计流量.MouseBack = null;
            this.气体累计流量.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.气体累计流量.Multiline = true;
            this.气体累计流量.Name = "气体累计流量";
            this.气体累计流量.NormlBack = null;
            this.气体累计流量.Padding = new System.Windows.Forms.Padding(5);
            this.气体累计流量.ReadOnly = false;
            this.气体累计流量.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.气体累计流量.Size = new System.Drawing.Size(160, 30);
            // 
            // 
            // 
            this.气体累计流量.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.气体累计流量.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.气体累计流量.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.气体累计流量.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.气体累计流量.SkinTxt.Multiline = true;
            this.气体累计流量.SkinTxt.Name = "BaseText";
            this.气体累计流量.SkinTxt.Size = new System.Drawing.Size(150, 20);
            this.气体累计流量.SkinTxt.TabIndex = 0;
            this.气体累计流量.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气体累计流量.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气体累计流量.SkinTxt.WaterText = "";
            this.气体累计流量.TabIndex = 0;
            this.气体累计流量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气体累计流量.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气体累计流量.WaterText = "";
            this.气体累计流量.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(88, 731);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(51, 21);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "浓度1";
            // 
            // 液体累计流量
            // 
            this.液体累计流量.BackColor = System.Drawing.Color.Transparent;
            this.液体累计流量.DownBack = null;
            this.液体累计流量.Icon = null;
            this.液体累计流量.IconIsButton = false;
            this.液体累计流量.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.液体累计流量.IsPasswordChat = '\0';
            this.液体累计流量.IsSystemPasswordChar = false;
            this.液体累计流量.Lines = new string[0];
            this.液体累计流量.Location = new System.Drawing.Point(720, 964);
            this.液体累计流量.Margin = new System.Windows.Forms.Padding(0);
            this.液体累计流量.MaxLength = 32767;
            this.液体累计流量.MinimumSize = new System.Drawing.Size(28, 28);
            this.液体累计流量.MouseBack = null;
            this.液体累计流量.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.液体累计流量.Multiline = true;
            this.液体累计流量.Name = "液体累计流量";
            this.液体累计流量.NormlBack = null;
            this.液体累计流量.Padding = new System.Windows.Forms.Padding(5);
            this.液体累计流量.ReadOnly = false;
            this.液体累计流量.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.液体累计流量.Size = new System.Drawing.Size(160, 30);
            // 
            // 
            // 
            this.液体累计流量.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.液体累计流量.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.液体累计流量.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.液体累计流量.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.液体累计流量.SkinTxt.Multiline = true;
            this.液体累计流量.SkinTxt.Name = "BaseText";
            this.液体累计流量.SkinTxt.Size = new System.Drawing.Size(150, 20);
            this.液体累计流量.SkinTxt.TabIndex = 0;
            this.液体累计流量.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.液体累计流量.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.液体累计流量.SkinTxt.WaterText = "";
            this.液体累计流量.TabIndex = 0;
            this.液体累计流量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.液体累计流量.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.液体累计流量.WaterText = "";
            this.液体累计流量.WordWrap = true;
            // 
            // 气体瞬时流量
            // 
            this.气体瞬时流量.BackColor = System.Drawing.Color.Transparent;
            this.气体瞬时流量.DownBack = null;
            this.气体瞬时流量.Icon = null;
            this.气体瞬时流量.IconIsButton = false;
            this.气体瞬时流量.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.气体瞬时流量.IsPasswordChat = '\0';
            this.气体瞬时流量.IsSystemPasswordChar = false;
            this.气体瞬时流量.Lines = new string[0];
            this.气体瞬时流量.Location = new System.Drawing.Point(1159, 964);
            this.气体瞬时流量.Margin = new System.Windows.Forms.Padding(0);
            this.气体瞬时流量.MaxLength = 32767;
            this.气体瞬时流量.MinimumSize = new System.Drawing.Size(28, 28);
            this.气体瞬时流量.MouseBack = null;
            this.气体瞬时流量.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.气体瞬时流量.Multiline = true;
            this.气体瞬时流量.Name = "气体瞬时流量";
            this.气体瞬时流量.NormlBack = null;
            this.气体瞬时流量.Padding = new System.Windows.Forms.Padding(5);
            this.气体瞬时流量.ReadOnly = false;
            this.气体瞬时流量.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.气体瞬时流量.Size = new System.Drawing.Size(160, 30);
            // 
            // 
            // 
            this.气体瞬时流量.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.气体瞬时流量.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.气体瞬时流量.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.气体瞬时流量.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.气体瞬时流量.SkinTxt.Multiline = true;
            this.气体瞬时流量.SkinTxt.Name = "BaseText";
            this.气体瞬时流量.SkinTxt.Size = new System.Drawing.Size(150, 20);
            this.气体瞬时流量.SkinTxt.TabIndex = 0;
            this.气体瞬时流量.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气体瞬时流量.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气体瞬时流量.SkinTxt.WaterText = "";
            this.气体瞬时流量.TabIndex = 0;
            this.气体瞬时流量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气体瞬时流量.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气体瞬时流量.WaterText = "";
            this.气体瞬时流量.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(88, 698);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(52, 21);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "点  火";
            // 
            // 液体瞬时流量
            // 
            this.液体瞬时流量.BackColor = System.Drawing.Color.Transparent;
            this.液体瞬时流量.DownBack = null;
            this.液体瞬时流量.Icon = null;
            this.液体瞬时流量.IconIsButton = false;
            this.液体瞬时流量.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.液体瞬时流量.IsPasswordChat = '\0';
            this.液体瞬时流量.IsSystemPasswordChar = false;
            this.液体瞬时流量.Lines = new string[0];
            this.液体瞬时流量.Location = new System.Drawing.Point(295, 964);
            this.液体瞬时流量.Margin = new System.Windows.Forms.Padding(0);
            this.液体瞬时流量.MaxLength = 32767;
            this.液体瞬时流量.MinimumSize = new System.Drawing.Size(28, 28);
            this.液体瞬时流量.MouseBack = null;
            this.液体瞬时流量.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.液体瞬时流量.Multiline = true;
            this.液体瞬时流量.Name = "液体瞬时流量";
            this.液体瞬时流量.NormlBack = null;
            this.液体瞬时流量.Padding = new System.Windows.Forms.Padding(5);
            this.液体瞬时流量.ReadOnly = false;
            this.液体瞬时流量.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.液体瞬时流量.Size = new System.Drawing.Size(160, 30);
            // 
            // 
            // 
            this.液体瞬时流量.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.液体瞬时流量.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.液体瞬时流量.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.液体瞬时流量.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.液体瞬时流量.SkinTxt.Multiline = true;
            this.液体瞬时流量.SkinTxt.Name = "BaseText";
            this.液体瞬时流量.SkinTxt.Size = new System.Drawing.Size(150, 20);
            this.液体瞬时流量.SkinTxt.TabIndex = 0;
            this.液体瞬时流量.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.液体瞬时流量.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.液体瞬时流量.SkinTxt.WaterText = "";
            this.液体瞬时流量.TabIndex = 0;
            this.液体瞬时流量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.液体瞬时流量.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.液体瞬时流量.WaterText = "";
            this.液体瞬时流量.WordWrap = true;
            // 
            // systemState
            // 
            this.systemState.AutoSize = true;
            this.systemState.BackColor = System.Drawing.Color.Transparent;
            this.systemState.BorderColor = System.Drawing.Color.White;
            this.systemState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.systemState.ForeColor = System.Drawing.Color.Red;
            this.systemState.Location = new System.Drawing.Point(24, 320);
            this.systemState.Name = "systemState";
            this.systemState.Size = new System.Drawing.Size(154, 21);
            this.systemState.TabIndex = 1;
            this.systemState.Text = "等待连接设备。。。";
            // 
            // 旋流分离器浓度
            // 
            this.旋流分离器浓度.BackColor = System.Drawing.Color.Transparent;
            this.旋流分离器浓度.DownBack = null;
            this.旋流分离器浓度.Icon = null;
            this.旋流分离器浓度.IconIsButton = false;
            this.旋流分离器浓度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器浓度.IsPasswordChat = '\0';
            this.旋流分离器浓度.IsSystemPasswordChar = false;
            this.旋流分离器浓度.Lines = new string[0];
            this.旋流分离器浓度.Location = new System.Drawing.Point(176, 760);
            this.旋流分离器浓度.Margin = new System.Windows.Forms.Padding(0);
            this.旋流分离器浓度.MaxLength = 32767;
            this.旋流分离器浓度.MinimumSize = new System.Drawing.Size(28, 28);
            this.旋流分离器浓度.MouseBack = null;
            this.旋流分离器浓度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器浓度.Multiline = true;
            this.旋流分离器浓度.Name = "旋流分离器浓度";
            this.旋流分离器浓度.NormlBack = null;
            this.旋流分离器浓度.Padding = new System.Windows.Forms.Padding(5);
            this.旋流分离器浓度.ReadOnly = false;
            this.旋流分离器浓度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.旋流分离器浓度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.旋流分离器浓度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.旋流分离器浓度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.旋流分离器浓度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.旋流分离器浓度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.旋流分离器浓度.SkinTxt.Multiline = true;
            this.旋流分离器浓度.SkinTxt.Name = "BaseText";
            this.旋流分离器浓度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.旋流分离器浓度.SkinTxt.TabIndex = 0;
            this.旋流分离器浓度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器浓度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器浓度.SkinTxt.WaterText = "";
            this.旋流分离器浓度.TabIndex = 0;
            this.旋流分离器浓度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器浓度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器浓度.WaterText = "";
            this.旋流分离器浓度.WordWrap = true;
            // 
            // 高压分离器浓度
            // 
            this.高压分离器浓度.BackColor = System.Drawing.Color.Transparent;
            this.高压分离器浓度.DownBack = null;
            this.高压分离器浓度.Icon = null;
            this.高压分离器浓度.IconIsButton = false;
            this.高压分离器浓度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.高压分离器浓度.IsPasswordChat = '\0';
            this.高压分离器浓度.IsSystemPasswordChar = false;
            this.高压分离器浓度.Lines = new string[0];
            this.高压分离器浓度.Location = new System.Drawing.Point(176, 727);
            this.高压分离器浓度.Margin = new System.Windows.Forms.Padding(0);
            this.高压分离器浓度.MaxLength = 32767;
            this.高压分离器浓度.MinimumSize = new System.Drawing.Size(28, 28);
            this.高压分离器浓度.MouseBack = null;
            this.高压分离器浓度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.高压分离器浓度.Multiline = true;
            this.高压分离器浓度.Name = "高压分离器浓度";
            this.高压分离器浓度.NormlBack = null;
            this.高压分离器浓度.Padding = new System.Windows.Forms.Padding(5);
            this.高压分离器浓度.ReadOnly = false;
            this.高压分离器浓度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.高压分离器浓度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.高压分离器浓度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.高压分离器浓度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.高压分离器浓度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.高压分离器浓度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.高压分离器浓度.SkinTxt.Multiline = true;
            this.高压分离器浓度.SkinTxt.Name = "BaseText";
            this.高压分离器浓度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.高压分离器浓度.SkinTxt.TabIndex = 0;
            this.高压分离器浓度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.高压分离器浓度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.高压分离器浓度.SkinTxt.WaterText = "";
            this.高压分离器浓度.TabIndex = 0;
            this.高压分离器浓度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.高压分离器浓度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.高压分离器浓度.WaterText = "";
            this.高压分离器浓度.WordWrap = true;
            // 
            // 水套炉点火浓度
            // 
            this.水套炉点火浓度.BackColor = System.Drawing.Color.Transparent;
            this.水套炉点火浓度.DownBack = null;
            this.水套炉点火浓度.Icon = null;
            this.水套炉点火浓度.IconIsButton = false;
            this.水套炉点火浓度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉点火浓度.IsPasswordChat = '\0';
            this.水套炉点火浓度.IsSystemPasswordChar = false;
            this.水套炉点火浓度.Lines = new string[0];
            this.水套炉点火浓度.Location = new System.Drawing.Point(176, 694);
            this.水套炉点火浓度.Margin = new System.Windows.Forms.Padding(0);
            this.水套炉点火浓度.MaxLength = 32767;
            this.水套炉点火浓度.MinimumSize = new System.Drawing.Size(28, 28);
            this.水套炉点火浓度.MouseBack = null;
            this.水套炉点火浓度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉点火浓度.Multiline = true;
            this.水套炉点火浓度.Name = "水套炉点火浓度";
            this.水套炉点火浓度.NormlBack = null;
            this.水套炉点火浓度.Padding = new System.Windows.Forms.Padding(5);
            this.水套炉点火浓度.ReadOnly = false;
            this.水套炉点火浓度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.水套炉点火浓度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.水套炉点火浓度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.水套炉点火浓度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.水套炉点火浓度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水套炉点火浓度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.水套炉点火浓度.SkinTxt.Multiline = true;
            this.水套炉点火浓度.SkinTxt.Name = "BaseText";
            this.水套炉点火浓度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.水套炉点火浓度.SkinTxt.TabIndex = 0;
            this.水套炉点火浓度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉点火浓度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉点火浓度.SkinTxt.WaterText = "";
            this.水套炉点火浓度.TabIndex = 0;
            this.水套炉点火浓度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉点火浓度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉点火浓度.WaterText = "";
            this.水套炉点火浓度.WordWrap = true;
            // 
            // 水套炉液位
            // 
            this.水套炉液位.BackColor = System.Drawing.Color.Transparent;
            this.水套炉液位.DownBack = null;
            this.水套炉液位.Icon = null;
            this.水套炉液位.IconIsButton = false;
            this.水套炉液位.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉液位.IsPasswordChat = '\0';
            this.水套炉液位.IsSystemPasswordChar = false;
            this.水套炉液位.Lines = new string[0];
            this.水套炉液位.Location = new System.Drawing.Point(1022, 458);
            this.水套炉液位.Margin = new System.Windows.Forms.Padding(0);
            this.水套炉液位.MaxLength = 32767;
            this.水套炉液位.MinimumSize = new System.Drawing.Size(28, 28);
            this.水套炉液位.MouseBack = null;
            this.水套炉液位.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉液位.Multiline = true;
            this.水套炉液位.Name = "水套炉液位";
            this.水套炉液位.NormlBack = null;
            this.水套炉液位.Padding = new System.Windows.Forms.Padding(5);
            this.水套炉液位.ReadOnly = false;
            this.水套炉液位.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.水套炉液位.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.水套炉液位.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.水套炉液位.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.水套炉液位.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水套炉液位.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.水套炉液位.SkinTxt.Multiline = true;
            this.水套炉液位.SkinTxt.Name = "BaseText";
            this.水套炉液位.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.水套炉液位.SkinTxt.TabIndex = 0;
            this.水套炉液位.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉液位.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉液位.SkinTxt.WaterText = "";
            this.水套炉液位.TabIndex = 0;
            this.水套炉液位.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉液位.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉液位.WaterText = "";
            this.水套炉液位.WordWrap = true;
            // 
            // 旋流分离器出口压力
            // 
            this.旋流分离器出口压力.BackColor = System.Drawing.Color.Transparent;
            this.旋流分离器出口压力.DownBack = null;
            this.旋流分离器出口压力.Icon = null;
            this.旋流分离器出口压力.IconIsButton = false;
            this.旋流分离器出口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器出口压力.IsPasswordChat = '\0';
            this.旋流分离器出口压力.IsSystemPasswordChar = false;
            this.旋流分离器出口压力.Lines = new string[0];
            this.旋流分离器出口压力.Location = new System.Drawing.Point(1588, 335);
            this.旋流分离器出口压力.Margin = new System.Windows.Forms.Padding(0);
            this.旋流分离器出口压力.MaxLength = 32767;
            this.旋流分离器出口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.旋流分离器出口压力.MouseBack = null;
            this.旋流分离器出口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器出口压力.Multiline = true;
            this.旋流分离器出口压力.Name = "旋流分离器出口压力";
            this.旋流分离器出口压力.NormlBack = null;
            this.旋流分离器出口压力.Padding = new System.Windows.Forms.Padding(5);
            this.旋流分离器出口压力.ReadOnly = false;
            this.旋流分离器出口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.旋流分离器出口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.旋流分离器出口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.旋流分离器出口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.旋流分离器出口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.旋流分离器出口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.旋流分离器出口压力.SkinTxt.Multiline = true;
            this.旋流分离器出口压力.SkinTxt.Name = "BaseText";
            this.旋流分离器出口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.旋流分离器出口压力.SkinTxt.TabIndex = 0;
            this.旋流分离器出口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器出口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器出口压力.SkinTxt.WaterText = "";
            this.旋流分离器出口压力.TabIndex = 0;
            this.旋流分离器出口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器出口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器出口压力.WaterText = "";
            this.旋流分离器出口压力.WordWrap = true;
            // 
            // 旋流分离器液位
            // 
            this.旋流分离器液位.BackColor = System.Drawing.Color.Transparent;
            this.旋流分离器液位.DownBack = null;
            this.旋流分离器液位.Icon = null;
            this.旋流分离器液位.IconIsButton = false;
            this.旋流分离器液位.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器液位.IsPasswordChat = '\0';
            this.旋流分离器液位.IsSystemPasswordChar = false;
            this.旋流分离器液位.Lines = new string[0];
            this.旋流分离器液位.Location = new System.Drawing.Point(1640, 453);
            this.旋流分离器液位.Margin = new System.Windows.Forms.Padding(0);
            this.旋流分离器液位.MaxLength = 32767;
            this.旋流分离器液位.MinimumSize = new System.Drawing.Size(28, 28);
            this.旋流分离器液位.MouseBack = null;
            this.旋流分离器液位.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器液位.Multiline = true;
            this.旋流分离器液位.Name = "旋流分离器液位";
            this.旋流分离器液位.NormlBack = null;
            this.旋流分离器液位.Padding = new System.Windows.Forms.Padding(5);
            this.旋流分离器液位.ReadOnly = false;
            this.旋流分离器液位.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.旋流分离器液位.Size = new System.Drawing.Size(64, 30);
            // 
            // 
            // 
            this.旋流分离器液位.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.旋流分离器液位.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.旋流分离器液位.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.旋流分离器液位.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.旋流分离器液位.SkinTxt.Multiline = true;
            this.旋流分离器液位.SkinTxt.Name = "BaseText";
            this.旋流分离器液位.SkinTxt.Size = new System.Drawing.Size(54, 20);
            this.旋流分离器液位.SkinTxt.TabIndex = 0;
            this.旋流分离器液位.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器液位.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器液位.SkinTxt.WaterText = "";
            this.旋流分离器液位.TabIndex = 0;
            this.旋流分离器液位.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器液位.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器液位.WaterText = "";
            this.旋流分离器液位.WordWrap = true;
            // 
            // JT阀开度监测
            // 
            this.JT阀开度监测.BackColor = System.Drawing.Color.Transparent;
            this.JT阀开度监测.DownBack = null;
            this.JT阀开度监测.Icon = null;
            this.JT阀开度监测.IconIsButton = false;
            this.JT阀开度监测.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀开度监测.IsPasswordChat = '\0';
            this.JT阀开度监测.IsSystemPasswordChar = false;
            this.JT阀开度监测.Lines = new string[0];
            this.JT阀开度监测.Location = new System.Drawing.Point(1428, 392);
            this.JT阀开度监测.Margin = new System.Windows.Forms.Padding(0);
            this.JT阀开度监测.MaxLength = 32767;
            this.JT阀开度监测.MinimumSize = new System.Drawing.Size(28, 28);
            this.JT阀开度监测.MouseBack = null;
            this.JT阀开度监测.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀开度监测.Multiline = true;
            this.JT阀开度监测.Name = "JT阀开度监测";
            this.JT阀开度监测.NormlBack = null;
            this.JT阀开度监测.Padding = new System.Windows.Forms.Padding(5);
            this.JT阀开度监测.ReadOnly = false;
            this.JT阀开度监测.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JT阀开度监测.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.JT阀开度监测.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JT阀开度监测.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JT阀开度监测.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JT阀开度监测.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.JT阀开度监测.SkinTxt.Multiline = true;
            this.JT阀开度监测.SkinTxt.Name = "BaseText";
            this.JT阀开度监测.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.JT阀开度监测.SkinTxt.TabIndex = 0;
            this.JT阀开度监测.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀开度监测.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀开度监测.SkinTxt.WaterText = "";
            this.JT阀开度监测.TabIndex = 0;
            this.JT阀开度监测.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀开度监测.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀开度监测.WaterText = "";
            this.JT阀开度监测.WordWrap = true;
            // 
            // 水套炉进气温度
            // 
            this.水套炉进气温度.BackColor = System.Drawing.Color.Transparent;
            this.水套炉进气温度.DownBack = null;
            this.水套炉进气温度.Icon = null;
            this.水套炉进气温度.IconIsButton = false;
            this.水套炉进气温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉进气温度.IsPasswordChat = '\0';
            this.水套炉进气温度.IsSystemPasswordChar = false;
            this.水套炉进气温度.Lines = new string[0];
            this.水套炉进气温度.Location = new System.Drawing.Point(1352, 705);
            this.水套炉进气温度.Margin = new System.Windows.Forms.Padding(0);
            this.水套炉进气温度.MaxLength = 32767;
            this.水套炉进气温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.水套炉进气温度.MouseBack = null;
            this.水套炉进气温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉进气温度.Multiline = true;
            this.水套炉进气温度.Name = "水套炉进气温度";
            this.水套炉进气温度.NormlBack = null;
            this.水套炉进气温度.Padding = new System.Windows.Forms.Padding(5);
            this.水套炉进气温度.ReadOnly = false;
            this.水套炉进气温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.水套炉进气温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.水套炉进气温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.水套炉进气温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.水套炉进气温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水套炉进气温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.水套炉进气温度.SkinTxt.Multiline = true;
            this.水套炉进气温度.SkinTxt.Name = "BaseText";
            this.水套炉进气温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.水套炉进气温度.SkinTxt.TabIndex = 0;
            this.水套炉进气温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉进气温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉进气温度.SkinTxt.WaterText = "";
            this.水套炉进气温度.TabIndex = 0;
            this.水套炉进气温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉进气温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉进气温度.WaterText = "";
            this.水套炉进气温度.WordWrap = true;
            // 
            // 设备出口压力
            // 
            this.设备出口压力.BackColor = System.Drawing.Color.Transparent;
            this.设备出口压力.DownBack = null;
            this.设备出口压力.Icon = null;
            this.设备出口压力.IconIsButton = false;
            this.设备出口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备出口压力.IsPasswordChat = '\0';
            this.设备出口压力.IsSystemPasswordChar = false;
            this.设备出口压力.Lines = new string[0];
            this.设备出口压力.Location = new System.Drawing.Point(1453, 822);
            this.设备出口压力.Margin = new System.Windows.Forms.Padding(0);
            this.设备出口压力.MaxLength = 32767;
            this.设备出口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.设备出口压力.MouseBack = null;
            this.设备出口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备出口压力.Multiline = true;
            this.设备出口压力.Name = "设备出口压力";
            this.设备出口压力.NormlBack = null;
            this.设备出口压力.Padding = new System.Windows.Forms.Padding(5);
            this.设备出口压力.ReadOnly = false;
            this.设备出口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.设备出口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.设备出口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.设备出口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.设备出口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备出口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.设备出口压力.SkinTxt.Multiline = true;
            this.设备出口压力.SkinTxt.Name = "BaseText";
            this.设备出口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.设备出口压力.SkinTxt.TabIndex = 0;
            this.设备出口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备出口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备出口压力.SkinTxt.WaterText = "";
            this.设备出口压力.TabIndex = 0;
            this.设备出口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备出口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备出口压力.WaterText = "";
            this.设备出口压力.WordWrap = true;
            // 
            // JT阀入口压力
            // 
            this.JT阀入口压力.BackColor = System.Drawing.Color.Transparent;
            this.JT阀入口压力.DownBack = null;
            this.JT阀入口压力.Icon = null;
            this.JT阀入口压力.IconIsButton = false;
            this.JT阀入口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀入口压力.IsPasswordChat = '\0';
            this.JT阀入口压力.IsSystemPasswordChar = false;
            this.JT阀入口压力.Lines = new string[0];
            this.JT阀入口压力.Location = new System.Drawing.Point(1352, 518);
            this.JT阀入口压力.Margin = new System.Windows.Forms.Padding(0);
            this.JT阀入口压力.MaxLength = 32767;
            this.JT阀入口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.JT阀入口压力.MouseBack = null;
            this.JT阀入口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀入口压力.Multiline = true;
            this.JT阀入口压力.Name = "JT阀入口压力";
            this.JT阀入口压力.NormlBack = null;
            this.JT阀入口压力.Padding = new System.Windows.Forms.Padding(5);
            this.JT阀入口压力.ReadOnly = false;
            this.JT阀入口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JT阀入口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.JT阀入口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JT阀入口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JT阀入口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JT阀入口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.JT阀入口压力.SkinTxt.Multiline = true;
            this.JT阀入口压力.SkinTxt.Name = "BaseText";
            this.JT阀入口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.JT阀入口压力.SkinTxt.TabIndex = 0;
            this.JT阀入口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀入口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀入口压力.SkinTxt.WaterText = "";
            this.JT阀入口压力.TabIndex = 0;
            this.JT阀入口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀入口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀入口压力.WaterText = "";
            this.JT阀入口压力.WordWrap = true;
            // 
            // 换热器出口压力
            // 
            this.换热器出口压力.BackColor = System.Drawing.Color.Transparent;
            this.换热器出口压力.DownBack = null;
            this.换热器出口压力.Icon = null;
            this.换热器出口压力.IconIsButton = false;
            this.换热器出口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器出口压力.IsPasswordChat = '\0';
            this.换热器出口压力.IsSystemPasswordChar = false;
            this.换热器出口压力.Lines = new string[0];
            this.换热器出口压力.Location = new System.Drawing.Point(1351, 288);
            this.换热器出口压力.Margin = new System.Windows.Forms.Padding(0);
            this.换热器出口压力.MaxLength = 32767;
            this.换热器出口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.换热器出口压力.MouseBack = null;
            this.换热器出口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器出口压力.Multiline = true;
            this.换热器出口压力.Name = "换热器出口压力";
            this.换热器出口压力.NormlBack = null;
            this.换热器出口压力.Padding = new System.Windows.Forms.Padding(5);
            this.换热器出口压力.ReadOnly = false;
            this.换热器出口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.换热器出口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.换热器出口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.换热器出口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.换热器出口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.换热器出口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.换热器出口压力.SkinTxt.Multiline = true;
            this.换热器出口压力.SkinTxt.Name = "BaseText";
            this.换热器出口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.换热器出口压力.SkinTxt.TabIndex = 0;
            this.换热器出口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器出口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器出口压力.SkinTxt.WaterText = "";
            this.换热器出口压力.TabIndex = 0;
            this.换热器出口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器出口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器出口压力.WaterText = "";
            this.换热器出口压力.WordWrap = true;
            // 
            // 换热器入口压力
            // 
            this.换热器入口压力.BackColor = System.Drawing.Color.Transparent;
            this.换热器入口压力.DownBack = null;
            this.换热器入口压力.Icon = null;
            this.换热器入口压力.IconIsButton = false;
            this.换热器入口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器入口压力.IsPasswordChat = '\0';
            this.换热器入口压力.IsSystemPasswordChar = false;
            this.换热器入口压力.Lines = new string[0];
            this.换热器入口压力.Location = new System.Drawing.Point(621, 209);
            this.换热器入口压力.Margin = new System.Windows.Forms.Padding(0);
            this.换热器入口压力.MaxLength = 32767;
            this.换热器入口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.换热器入口压力.MouseBack = null;
            this.换热器入口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器入口压力.Multiline = true;
            this.换热器入口压力.Name = "换热器入口压力";
            this.换热器入口压力.NormlBack = null;
            this.换热器入口压力.Padding = new System.Windows.Forms.Padding(5);
            this.换热器入口压力.ReadOnly = false;
            this.换热器入口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.换热器入口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.换热器入口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.换热器入口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.换热器入口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.换热器入口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.换热器入口压力.SkinTxt.Multiline = true;
            this.换热器入口压力.SkinTxt.Name = "BaseText";
            this.换热器入口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.换热器入口压力.SkinTxt.TabIndex = 0;
            this.换热器入口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器入口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器入口压力.SkinTxt.WaterText = "";
            this.换热器入口压力.TabIndex = 0;
            this.换热器入口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器入口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器入口压力.WaterText = "";
            this.换热器入口压力.WordWrap = true;
            // 
            // 设备入口压力
            // 
            this.设备入口压力.BackColor = System.Drawing.Color.Transparent;
            this.设备入口压力.DownBack = null;
            this.设备入口压力.Icon = null;
            this.设备入口压力.IconIsButton = false;
            this.设备入口压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备入口压力.IsPasswordChat = '\0';
            this.设备入口压力.IsSystemPasswordChar = false;
            this.设备入口压力.Lines = new string[0];
            this.设备入口压力.Location = new System.Drawing.Point(176, 579);
            this.设备入口压力.Margin = new System.Windows.Forms.Padding(0);
            this.设备入口压力.MaxLength = 32767;
            this.设备入口压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.设备入口压力.MouseBack = null;
            this.设备入口压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备入口压力.Multiline = true;
            this.设备入口压力.Name = "设备入口压力";
            this.设备入口压力.NormlBack = null;
            this.设备入口压力.Padding = new System.Windows.Forms.Padding(5);
            this.设备入口压力.ReadOnly = false;
            this.设备入口压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.设备入口压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.设备入口压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.设备入口压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.设备入口压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备入口压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.设备入口压力.SkinTxt.Multiline = true;
            this.设备入口压力.SkinTxt.Name = "BaseText";
            this.设备入口压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.设备入口压力.SkinTxt.TabIndex = 0;
            this.设备入口压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备入口压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备入口压力.SkinTxt.WaterText = "";
            this.设备入口压力.TabIndex = 0;
            this.设备入口压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备入口压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备入口压力.WaterText = "";
            this.设备入口压力.WordWrap = true;
            // 
            // 高压分离器液位
            // 
            this.高压分离器液位.BackColor = System.Drawing.Color.Transparent;
            this.高压分离器液位.DownBack = null;
            this.高压分离器液位.Icon = null;
            this.高压分离器液位.IconIsButton = false;
            this.高压分离器液位.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.高压分离器液位.IsPasswordChat = '\0';
            this.高压分离器液位.IsSystemPasswordChar = false;
            this.高压分离器液位.Lines = new string[0];
            this.高压分离器液位.Location = new System.Drawing.Point(551, 432);
            this.高压分离器液位.Margin = new System.Windows.Forms.Padding(0);
            this.高压分离器液位.MaxLength = 32767;
            this.高压分离器液位.MinimumSize = new System.Drawing.Size(28, 28);
            this.高压分离器液位.MouseBack = null;
            this.高压分离器液位.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.高压分离器液位.Multiline = true;
            this.高压分离器液位.Name = "高压分离器液位";
            this.高压分离器液位.NormlBack = null;
            this.高压分离器液位.Padding = new System.Windows.Forms.Padding(5);
            this.高压分离器液位.ReadOnly = false;
            this.高压分离器液位.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.高压分离器液位.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.高压分离器液位.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.高压分离器液位.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.高压分离器液位.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.高压分离器液位.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.高压分离器液位.SkinTxt.Multiline = true;
            this.高压分离器液位.SkinTxt.Name = "BaseText";
            this.高压分离器液位.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.高压分离器液位.SkinTxt.TabIndex = 0;
            this.高压分离器液位.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.高压分离器液位.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.高压分离器液位.SkinTxt.WaterText = "";
            this.高压分离器液位.TabIndex = 0;
            this.高压分离器液位.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.高压分离器液位.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.高压分离器液位.WaterText = "";
            this.高压分离器液位.WordWrap = true;
            // 
            // 水套炉水温
            // 
            this.水套炉水温.BackColor = System.Drawing.Color.Transparent;
            this.水套炉水温.DownBack = null;
            this.水套炉水温.Icon = null;
            this.水套炉水温.IconIsButton = false;
            this.水套炉水温.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉水温.IsPasswordChat = '\0';
            this.水套炉水温.IsSystemPasswordChar = false;
            this.水套炉水温.Lines = new string[0];
            this.水套炉水温.Location = new System.Drawing.Point(1022, 405);
            this.水套炉水温.Margin = new System.Windows.Forms.Padding(0);
            this.水套炉水温.MaxLength = 32767;
            this.水套炉水温.MinimumSize = new System.Drawing.Size(28, 28);
            this.水套炉水温.MouseBack = null;
            this.水套炉水温.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.水套炉水温.Multiline = true;
            this.水套炉水温.Name = "水套炉水温";
            this.水套炉水温.NormlBack = null;
            this.水套炉水温.Padding = new System.Windows.Forms.Padding(5);
            this.水套炉水温.ReadOnly = false;
            this.水套炉水温.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.水套炉水温.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.水套炉水温.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.水套炉水温.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.水套炉水温.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水套炉水温.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.水套炉水温.SkinTxt.Multiline = true;
            this.水套炉水温.SkinTxt.Name = "BaseText";
            this.水套炉水温.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.水套炉水温.SkinTxt.TabIndex = 0;
            this.水套炉水温.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉水温.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉水温.SkinTxt.WaterText = "";
            this.水套炉水温.TabIndex = 0;
            this.水套炉水温.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.水套炉水温.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.水套炉水温.WaterText = "";
            this.水套炉水温.WordWrap = true;
            // 
            // 旋流分离器出口温度
            // 
            this.旋流分离器出口温度.BackColor = System.Drawing.Color.Transparent;
            this.旋流分离器出口温度.DownBack = null;
            this.旋流分离器出口温度.Icon = null;
            this.旋流分离器出口温度.IconIsButton = false;
            this.旋流分离器出口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器出口温度.IsPasswordChat = '\0';
            this.旋流分离器出口温度.IsSystemPasswordChar = false;
            this.旋流分离器出口温度.Lines = new string[0];
            this.旋流分离器出口温度.Location = new System.Drawing.Point(1588, 304);
            this.旋流分离器出口温度.Margin = new System.Windows.Forms.Padding(0);
            this.旋流分离器出口温度.MaxLength = 32767;
            this.旋流分离器出口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.旋流分离器出口温度.MouseBack = null;
            this.旋流分离器出口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.旋流分离器出口温度.Multiline = true;
            this.旋流分离器出口温度.Name = "旋流分离器出口温度";
            this.旋流分离器出口温度.NormlBack = null;
            this.旋流分离器出口温度.Padding = new System.Windows.Forms.Padding(5);
            this.旋流分离器出口温度.ReadOnly = false;
            this.旋流分离器出口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.旋流分离器出口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.旋流分离器出口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.旋流分离器出口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.旋流分离器出口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.旋流分离器出口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.旋流分离器出口温度.SkinTxt.Multiline = true;
            this.旋流分离器出口温度.SkinTxt.Name = "BaseText";
            this.旋流分离器出口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.旋流分离器出口温度.SkinTxt.TabIndex = 0;
            this.旋流分离器出口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器出口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器出口温度.SkinTxt.WaterText = "";
            this.旋流分离器出口温度.TabIndex = 0;
            this.旋流分离器出口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.旋流分离器出口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.旋流分离器出口温度.WaterText = "";
            this.旋流分离器出口温度.WordWrap = true;
            // 
            // 露点仪
            // 
            this.露点仪.BackColor = System.Drawing.Color.Transparent;
            this.露点仪.DownBack = null;
            this.露点仪.Icon = null;
            this.露点仪.IconIsButton = false;
            this.露点仪.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.露点仪.IsPasswordChat = '\0';
            this.露点仪.IsSystemPasswordChar = false;
            this.露点仪.Lines = new string[0];
            this.露点仪.Location = new System.Drawing.Point(1643, 803);
            this.露点仪.Margin = new System.Windows.Forms.Padding(0);
            this.露点仪.MaxLength = 32767;
            this.露点仪.MinimumSize = new System.Drawing.Size(28, 28);
            this.露点仪.MouseBack = null;
            this.露点仪.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.露点仪.Multiline = true;
            this.露点仪.Name = "露点仪";
            this.露点仪.NormlBack = null;
            this.露点仪.Padding = new System.Windows.Forms.Padding(5);
            this.露点仪.ReadOnly = false;
            this.露点仪.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.露点仪.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.露点仪.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.露点仪.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.露点仪.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.露点仪.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.露点仪.SkinTxt.Multiline = true;
            this.露点仪.SkinTxt.Name = "BaseText";
            this.露点仪.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.露点仪.SkinTxt.TabIndex = 0;
            this.露点仪.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.露点仪.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.露点仪.SkinTxt.WaterText = "";
            this.露点仪.TabIndex = 0;
            this.露点仪.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.露点仪.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.露点仪.WaterText = "";
            this.露点仪.WordWrap = true;
            // 
            // 气控压力
            // 
            this.气控压力.BackColor = System.Drawing.Color.Transparent;
            this.气控压力.DownBack = null;
            this.气控压力.Icon = null;
            this.气控压力.IconIsButton = false;
            this.气控压力.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.气控压力.IsPasswordChat = '\0';
            this.气控压力.IsSystemPasswordChar = false;
            this.气控压力.Lines = new string[0];
            this.气控压力.Location = new System.Drawing.Point(1158, 878);
            this.气控压力.Margin = new System.Windows.Forms.Padding(0);
            this.气控压力.MaxLength = 32767;
            this.气控压力.MinimumSize = new System.Drawing.Size(28, 28);
            this.气控压力.MouseBack = null;
            this.气控压力.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.气控压力.Multiline = true;
            this.气控压力.Name = "气控压力";
            this.气控压力.NormlBack = null;
            this.气控压力.Padding = new System.Windows.Forms.Padding(5);
            this.气控压力.ReadOnly = false;
            this.气控压力.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.气控压力.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.气控压力.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.气控压力.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.气控压力.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.气控压力.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.气控压力.SkinTxt.Multiline = true;
            this.气控压力.SkinTxt.Name = "BaseText";
            this.气控压力.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.气控压力.SkinTxt.TabIndex = 0;
            this.气控压力.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气控压力.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气控压力.SkinTxt.WaterText = "";
            this.气控压力.TabIndex = 0;
            this.气控压力.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.气控压力.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.气控压力.WaterText = "";
            this.气控压力.WordWrap = true;
            // 
            // 设备出口温度
            // 
            this.设备出口温度.BackColor = System.Drawing.Color.Transparent;
            this.设备出口温度.DownBack = null;
            this.设备出口温度.Icon = null;
            this.设备出口温度.IconIsButton = false;
            this.设备出口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备出口温度.IsPasswordChat = '\0';
            this.设备出口温度.IsSystemPasswordChar = false;
            this.设备出口温度.Lines = new string[0];
            this.设备出口温度.Location = new System.Drawing.Point(1453, 794);
            this.设备出口温度.Margin = new System.Windows.Forms.Padding(0);
            this.设备出口温度.MaxLength = 32767;
            this.设备出口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.设备出口温度.MouseBack = null;
            this.设备出口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备出口温度.Multiline = true;
            this.设备出口温度.Name = "设备出口温度";
            this.设备出口温度.NormlBack = null;
            this.设备出口温度.Padding = new System.Windows.Forms.Padding(5);
            this.设备出口温度.ReadOnly = false;
            this.设备出口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.设备出口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.设备出口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.设备出口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.设备出口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备出口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.设备出口温度.SkinTxt.Multiline = true;
            this.设备出口温度.SkinTxt.Name = "BaseText";
            this.设备出口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.设备出口温度.SkinTxt.TabIndex = 0;
            this.设备出口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备出口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备出口温度.SkinTxt.WaterText = "";
            this.设备出口温度.TabIndex = 0;
            this.设备出口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备出口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备出口温度.WaterText = "";
            this.设备出口温度.WordWrap = true;
            // 
            // JT阀入口温度
            // 
            this.JT阀入口温度.BackColor = System.Drawing.Color.Transparent;
            this.JT阀入口温度.DownBack = null;
            this.JT阀入口温度.Icon = null;
            this.JT阀入口温度.IconIsButton = false;
            this.JT阀入口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀入口温度.IsPasswordChat = '\0';
            this.JT阀入口温度.IsSystemPasswordChar = false;
            this.JT阀入口温度.Lines = new string[0];
            this.JT阀入口温度.Location = new System.Drawing.Point(1352, 487);
            this.JT阀入口温度.Margin = new System.Windows.Forms.Padding(0);
            this.JT阀入口温度.MaxLength = 32767;
            this.JT阀入口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.JT阀入口温度.MouseBack = null;
            this.JT阀入口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.JT阀入口温度.Multiline = true;
            this.JT阀入口温度.Name = "JT阀入口温度";
            this.JT阀入口温度.NormlBack = null;
            this.JT阀入口温度.Padding = new System.Windows.Forms.Padding(5);
            this.JT阀入口温度.ReadOnly = false;
            this.JT阀入口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JT阀入口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.JT阀入口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JT阀入口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JT阀入口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JT阀入口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.JT阀入口温度.SkinTxt.Multiline = true;
            this.JT阀入口温度.SkinTxt.Name = "BaseText";
            this.JT阀入口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.JT阀入口温度.SkinTxt.TabIndex = 0;
            this.JT阀入口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀入口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀入口温度.SkinTxt.WaterText = "";
            this.JT阀入口温度.TabIndex = 0;
            this.JT阀入口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JT阀入口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.JT阀入口温度.WaterText = "";
            this.JT阀入口温度.WordWrap = true;
            // 
            // 换热器出口温度
            // 
            this.换热器出口温度.BackColor = System.Drawing.Color.Transparent;
            this.换热器出口温度.DownBack = null;
            this.换热器出口温度.Icon = null;
            this.换热器出口温度.IconIsButton = false;
            this.换热器出口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器出口温度.IsPasswordChat = '\0';
            this.换热器出口温度.IsSystemPasswordChar = false;
            this.换热器出口温度.Lines = new string[0];
            this.换热器出口温度.Location = new System.Drawing.Point(1351, 257);
            this.换热器出口温度.Margin = new System.Windows.Forms.Padding(0);
            this.换热器出口温度.MaxLength = 32767;
            this.换热器出口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.换热器出口温度.MouseBack = null;
            this.换热器出口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器出口温度.Multiline = true;
            this.换热器出口温度.Name = "换热器出口温度";
            this.换热器出口温度.NormlBack = null;
            this.换热器出口温度.Padding = new System.Windows.Forms.Padding(5);
            this.换热器出口温度.ReadOnly = false;
            this.换热器出口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.换热器出口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.换热器出口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.换热器出口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.换热器出口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.换热器出口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.换热器出口温度.SkinTxt.Multiline = true;
            this.换热器出口温度.SkinTxt.Name = "BaseText";
            this.换热器出口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.换热器出口温度.SkinTxt.TabIndex = 0;
            this.换热器出口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器出口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器出口温度.SkinTxt.WaterText = "";
            this.换热器出口温度.TabIndex = 0;
            this.换热器出口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器出口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器出口温度.WaterText = "";
            this.换热器出口温度.WordWrap = true;
            // 
            // 换热器入口温度
            // 
            this.换热器入口温度.BackColor = System.Drawing.Color.Transparent;
            this.换热器入口温度.DownBack = null;
            this.换热器入口温度.Icon = null;
            this.换热器入口温度.IconIsButton = false;
            this.换热器入口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器入口温度.IsPasswordChat = '\0';
            this.换热器入口温度.IsSystemPasswordChar = false;
            this.换热器入口温度.Lines = new string[0];
            this.换热器入口温度.Location = new System.Drawing.Point(621, 178);
            this.换热器入口温度.Margin = new System.Windows.Forms.Padding(0);
            this.换热器入口温度.MaxLength = 32767;
            this.换热器入口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.换热器入口温度.MouseBack = null;
            this.换热器入口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.换热器入口温度.Multiline = true;
            this.换热器入口温度.Name = "换热器入口温度";
            this.换热器入口温度.NormlBack = null;
            this.换热器入口温度.Padding = new System.Windows.Forms.Padding(5);
            this.换热器入口温度.ReadOnly = false;
            this.换热器入口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.换热器入口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.换热器入口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.换热器入口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.换热器入口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.换热器入口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.换热器入口温度.SkinTxt.Multiline = true;
            this.换热器入口温度.SkinTxt.Name = "BaseText";
            this.换热器入口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.换热器入口温度.SkinTxt.TabIndex = 0;
            this.换热器入口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器入口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器入口温度.SkinTxt.WaterText = "";
            this.换热器入口温度.TabIndex = 0;
            this.换热器入口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.换热器入口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.换热器入口温度.WaterText = "";
            this.换热器入口温度.WordWrap = true;
            // 
            // 设备入口温度
            // 
            this.设备入口温度.BackColor = System.Drawing.Color.Transparent;
            this.设备入口温度.DownBack = null;
            this.设备入口温度.Icon = null;
            this.设备入口温度.IconIsButton = false;
            this.设备入口温度.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备入口温度.IsPasswordChat = '\0';
            this.设备入口温度.IsSystemPasswordChar = false;
            this.设备入口温度.Lines = new string[0];
            this.设备入口温度.Location = new System.Drawing.Point(176, 548);
            this.设备入口温度.Margin = new System.Windows.Forms.Padding(0);
            this.设备入口温度.MaxLength = 32767;
            this.设备入口温度.MinimumSize = new System.Drawing.Size(28, 28);
            this.设备入口温度.MouseBack = null;
            this.设备入口温度.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.设备入口温度.Multiline = true;
            this.设备入口温度.Name = "设备入口温度";
            this.设备入口温度.NormlBack = null;
            this.设备入口温度.Padding = new System.Windows.Forms.Padding(5);
            this.设备入口温度.ReadOnly = false;
            this.设备入口温度.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.设备入口温度.Size = new System.Drawing.Size(100, 30);
            // 
            // 
            // 
            this.设备入口温度.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.设备入口温度.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.设备入口温度.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备入口温度.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.设备入口温度.SkinTxt.Multiline = true;
            this.设备入口温度.SkinTxt.Name = "BaseText";
            this.设备入口温度.SkinTxt.Size = new System.Drawing.Size(90, 20);
            this.设备入口温度.SkinTxt.TabIndex = 0;
            this.设备入口温度.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备入口温度.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备入口温度.SkinTxt.WaterText = "";
            this.设备入口温度.TabIndex = 0;
            this.设备入口温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.设备入口温度.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.设备入口温度.WaterText = "";
            this.设备入口温度.WordWrap = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.ribbonGalleryBarItem1,
            this.barButtonGroup1,
            this.btnRunningConfig,
            this.btnControl,
            this.btnHistory,
            this.barButtonItem6,
            this.btnSystemConfig});
            this.ribbonControl1.Location = new System.Drawing.Point(4, 28);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1912, 128);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "实时数据";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 3;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 4;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnRunningConfig
            // 
            this.btnRunningConfig.Caption = "运行参数设置";
            this.btnRunningConfig.Id = 7;
            this.btnRunningConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRunningConfig.ImageOptions.Image")));
            this.btnRunningConfig.Name = "btnRunningConfig";
            this.btnRunningConfig.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRunningConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRunningConfig_ItemClick);
            // 
            // btnControl
            // 
            this.btnControl.Caption = "机组控制";
            this.btnControl.Id = 8;
            this.btnControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnControl.ImageOptions.Image")));
            this.btnControl.Name = "btnControl";
            this.btnControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnControl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnControl_ItemClick);
            // 
            // btnHistory
            // 
            this.btnHistory.Caption = "历史数据";
            this.btnHistory.Id = 9;
            this.btnHistory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.ImageOptions.Image")));
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHistory_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnSystemConfig
            // 
            this.btnSystemConfig.Caption = "系统设置";
            this.btnSystemConfig.Id = 13;
            this.btnSystemConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemConfig.ImageOptions.Image")));
            this.btnSystemConfig.Name = "btnSystemConfig";
            this.btnSystemConfig.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSystemConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSystemConfig_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "YS50-25B型井口一体化天然气回收撬";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHistory);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "机组数据";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnControl);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRunningConfig);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "机组控制";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSystemConfig);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "系统设置";
            // 
            // timer_readdata
            // 
            this.timer_readdata.Enabled = true;
            this.timer_readdata.Interval = 1000;
            this.timer_readdata.Tick += new System.EventHandler(this.timer_readdata_Tick);
            // 
            // timer_savedate
            // 
            this.timer_savedate.Enabled = true;
            this.timer_savedate.Interval = 1000;
            this.timer_savedate.Tick += new System.EventHandler(this.timer_savedate_Tick);
            // 
            // timer_alarm
            // 
            this.timer_alarm.Enabled = true;
            this.timer_alarm.Interval = 3000;
            this.timer_alarm.Tick += new System.EventHandler(this.timer_alarm_Tick);
            // 
            // timer_readstate
            // 
            this.timer_readstate.Enabled = true;
            this.timer_readstate.Interval = 3000;
            this.timer_readstate.Tick += new System.EventHandler(this.timer_readstate_Tick);
            // 
            // RealData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1039);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.RealDataPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "RealData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XXuanSCADA物联网平台";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RealData_FormClosed);
            this.Load += new System.EventHandler(this.realData_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.RealDataPanel.ResumeLayout(false);
            this.RealDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel RealDataPanel;
        private CCWin.SkinControl.SkinTextBox 设备入口温度;
        private System.Windows.Forms.Timer timer_readdata;
        private System.Windows.Forms.Timer timer_savedate;
        private System.Windows.Forms.Timer timer_senddata;
        private CCWin.SkinControl.SkinLabel systemState;
        private CCWin.SkinControl.SkinTextBox 设备入口压力;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox 旋流分离器浓度;
        private CCWin.SkinControl.SkinTextBox 高压分离器浓度;
        private CCWin.SkinControl.SkinTextBox 水套炉点火浓度;
        private CCWin.SkinControl.SkinTextBox 高压分离器液位;
        private XLControl.LevelGauge 高压分离器液位计;
        private CCWin.SkinControl.SkinTextBox 换热器入口压力;
        private CCWin.SkinControl.SkinTextBox 换热器入口温度;
        private CCWin.SkinControl.SkinLabel 液位;
        private CCWin.SkinControl.SkinLabel 水温;
        private CCWin.SkinControl.SkinTextBox 水套炉液位;
        private CCWin.SkinControl.SkinTextBox 水套炉水温;
        private CCWin.SkinControl.SkinTextBox 换热器出口压力;
        private CCWin.SkinControl.SkinTextBox 换热器出口温度;
        private CCWin.SkinControl.SkinTextBox 旋流分离器出口压力;
        private CCWin.SkinControl.SkinTextBox 旋流分离器出口温度;
        private CCWin.SkinControl.SkinTextBox JT阀开度监测;
        private CCWin.SkinControl.SkinTextBox JT阀入口压力;
        private CCWin.SkinControl.SkinTextBox JT阀入口温度;
        private CCWin.SkinControl.SkinTextBox 旋流分离器液位;
        private XLControl.LevelGauge 旋流分离器液位计;
        private XLControl.LevelGauge 水套炉液位计;
        private CCWin.SkinControl.SkinTextBox 水套炉进气温度;
        private CCWin.SkinControl.SkinTextBox 设备出口压力;
        private CCWin.SkinControl.SkinTextBox 设备出口温度;
        private CCWin.SkinControl.SkinTextBox 露点仪;
        private CCWin.SkinControl.SkinTextBox 气控压力;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox 液体瞬时流量;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox 液体累计流量;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinTextBox 气体累计流量;
        private CCWin.SkinControl.SkinTextBox 气体瞬时流量;
        private XLControl.Alarm 报警器;
        private System.Windows.Forms.Timer timer_alarm;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRunningConfig;
        private DevExpress.XtraBars.BarButtonItem btnControl;
        private DevExpress.XtraBars.BarButtonItem btnHistory;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnSystemConfig;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XLControl.Switch switch_JT阀;
        private XLControl.Switch switch_进口阀;
        private XLControl.Switch switch_高压排污阀;
        private XLControl.Switch switch_高压放空阀;
        private XLControl.Switch switch_主路阀;
        private XLControl.Switch switch_燃料阀;
        private XLControl.Switch switch_出口阀;
        private XLControl.Switch switch_旋流排污阀;
        private System.Windows.Forms.Timer timer_readstate;
    }
}