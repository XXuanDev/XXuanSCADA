namespace XXuanSCADA
{
    partial class HistoryData
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.采集时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.设备入口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.设备入口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.换热器入口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.换热器入口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.换热器出口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.换热器出口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JT阀入口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JT阀入口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.旋流分离器出口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.旋流分离器出口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.设备出口压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.设备出口温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.气控压力 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.高压分离器液位 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.高压分离器浓度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.旋流分离器液位 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JT阀开度监测 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.水套炉液位 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.水套炉进气温度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.水套炉水温 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.水套炉点火浓度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.露点仪 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.气体瞬时流量 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.气体累计流量 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.液体瞬时流量 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.液体累计流量 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnExport = new CCWin.SkinControl.SkinButton();
            this.bntSelect = new CCWin.SkinControl.SkinButton();
            this.skinPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dateTimeEnd);
            this.skinPanel1.Controls.Add(this.dateTimeBegin);
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.btnExport);
            this.skinPanel1.Controls.Add(this.bntSelect);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1912, 1007);
            this.skinPanel1.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeEnd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(266, 22);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(161, 23);
            this.dateTimeEnd.TabIndex = 2;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CalendarFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeBegin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.Location = new System.Drawing.Point(50, 22);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(161, 23);
            this.dateTimeBegin.TabIndex = 2;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.gridControl1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 63);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(1912, 944);
            this.skinPanel2.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1912, 944);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.采集时间,
            this.设备入口压力,
            this.设备入口温度,
            this.换热器入口压力,
            this.换热器入口温度,
            this.换热器出口压力,
            this.换热器出口温度,
            this.JT阀入口压力,
            this.JT阀入口温度,
            this.旋流分离器出口压力,
            this.旋流分离器出口温度,
            this.设备出口压力,
            this.设备出口温度,
            this.气控压力,
            this.高压分离器液位,
            this.高压分离器浓度,
            this.旋流分离器液位,
            this.JT阀开度监测,
            this.水套炉液位,
            this.水套炉进气温度,
            this.水套炉水温,
            this.水套炉点火浓度,
            this.露点仪,
            this.气体瞬时流量,
            this.气体累计流量,
            this.液体瞬时流量,
            this.液体累计流量});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // 采集时间
            // 
            this.采集时间.Caption = "采集时间";
            this.采集时间.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.采集时间.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.采集时间.FieldName = "采集时间";
            this.采集时间.Name = "采集时间";
            this.采集时间.Visible = true;
            this.采集时间.VisibleIndex = 0;
            this.采集时间.Width = 130;
            // 
            // 设备入口压力
            // 
            this.设备入口压力.Caption = "设备入口压力";
            this.设备入口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.设备入口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.设备入口压力.FieldName = "设备入口压力";
            this.设备入口压力.Name = "设备入口压力";
            this.设备入口压力.Visible = true;
            this.设备入口压力.VisibleIndex = 1;
            this.设备入口压力.Width = 65;
            // 
            // 设备入口温度
            // 
            this.设备入口温度.Caption = "设备入口温度";
            this.设备入口温度.DisplayFormat.FormatString = "{0}℃";
            this.设备入口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.设备入口温度.FieldName = "设备入口温度";
            this.设备入口温度.Name = "设备入口温度";
            this.设备入口温度.Visible = true;
            this.设备入口温度.VisibleIndex = 2;
            this.设备入口温度.Width = 65;
            // 
            // 换热器入口压力
            // 
            this.换热器入口压力.Caption = "换热器入口压力";
            this.换热器入口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.换热器入口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.换热器入口压力.FieldName = "换热器入口压力";
            this.换热器入口压力.Name = "换热器入口压力";
            this.换热器入口压力.Visible = true;
            this.换热器入口压力.VisibleIndex = 3;
            this.换热器入口压力.Width = 65;
            // 
            // 换热器入口温度
            // 
            this.换热器入口温度.Caption = "换热器入口温度";
            this.换热器入口温度.DisplayFormat.FormatString = "{0}℃";
            this.换热器入口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.换热器入口温度.FieldName = "换热器入口温度";
            this.换热器入口温度.Name = "换热器入口温度";
            this.换热器入口温度.Visible = true;
            this.换热器入口温度.VisibleIndex = 4;
            this.换热器入口温度.Width = 65;
            // 
            // 换热器出口压力
            // 
            this.换热器出口压力.Caption = "换热器出口压力";
            this.换热器出口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.换热器出口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.换热器出口压力.FieldName = "换热器出口压力";
            this.换热器出口压力.Name = "换热器出口压力";
            this.换热器出口压力.Visible = true;
            this.换热器出口压力.VisibleIndex = 5;
            this.换热器出口压力.Width = 65;
            // 
            // 换热器出口温度
            // 
            this.换热器出口温度.Caption = "换热器出口温度";
            this.换热器出口温度.DisplayFormat.FormatString = "{0}℃";
            this.换热器出口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.换热器出口温度.FieldName = "换热器出口温度";
            this.换热器出口温度.Name = "换热器出口温度";
            this.换热器出口温度.Visible = true;
            this.换热器出口温度.VisibleIndex = 6;
            this.换热器出口温度.Width = 65;
            // 
            // JT阀入口压力
            // 
            this.JT阀入口压力.Caption = "JT阀入口压力";
            this.JT阀入口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.JT阀入口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.JT阀入口压力.FieldName = "JT阀入口压力";
            this.JT阀入口压力.Name = "JT阀入口压力";
            this.JT阀入口压力.Visible = true;
            this.JT阀入口压力.VisibleIndex = 7;
            this.JT阀入口压力.Width = 65;
            // 
            // JT阀入口温度
            // 
            this.JT阀入口温度.Caption = "JT阀入口温度";
            this.JT阀入口温度.DisplayFormat.FormatString = "{0}℃";
            this.JT阀入口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.JT阀入口温度.FieldName = "JT阀入口温度";
            this.JT阀入口温度.Name = "JT阀入口温度";
            this.JT阀入口温度.Visible = true;
            this.JT阀入口温度.VisibleIndex = 8;
            this.JT阀入口温度.Width = 65;
            // 
            // 旋流分离器出口压力
            // 
            this.旋流分离器出口压力.Caption = "旋流分离器出口压力";
            this.旋流分离器出口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.旋流分离器出口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.旋流分离器出口压力.FieldName = "旋流分离器出口压力";
            this.旋流分离器出口压力.Name = "旋流分离器出口压力";
            this.旋流分离器出口压力.Visible = true;
            this.旋流分离器出口压力.VisibleIndex = 9;
            this.旋流分离器出口压力.Width = 65;
            // 
            // 旋流分离器出口温度
            // 
            this.旋流分离器出口温度.Caption = "旋流分离器出口温度";
            this.旋流分离器出口温度.DisplayFormat.FormatString = "{0}℃";
            this.旋流分离器出口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.旋流分离器出口温度.FieldName = "旋流分离器出口温度";
            this.旋流分离器出口温度.Name = "旋流分离器出口温度";
            this.旋流分离器出口温度.Visible = true;
            this.旋流分离器出口温度.VisibleIndex = 10;
            this.旋流分离器出口温度.Width = 65;
            // 
            // 设备出口压力
            // 
            this.设备出口压力.Caption = "设备出口压力";
            this.设备出口压力.DisplayFormat.FormatString = "{0}Mpa";
            this.设备出口压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.设备出口压力.FieldName = "设备出口压力";
            this.设备出口压力.Name = "设备出口压力";
            this.设备出口压力.Visible = true;
            this.设备出口压力.VisibleIndex = 11;
            this.设备出口压力.Width = 65;
            // 
            // 设备出口温度
            // 
            this.设备出口温度.Caption = "设备出口温度";
            this.设备出口温度.DisplayFormat.FormatString = "{0}℃";
            this.设备出口温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.设备出口温度.FieldName = "设备出口温度";
            this.设备出口温度.Name = "设备出口温度";
            this.设备出口温度.Visible = true;
            this.设备出口温度.VisibleIndex = 12;
            this.设备出口温度.Width = 65;
            // 
            // 气控压力
            // 
            this.气控压力.Caption = "气控压力";
            this.气控压力.DisplayFormat.FormatString = "{0}Mpa";
            this.气控压力.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.气控压力.FieldName = "气控压力";
            this.气控压力.Name = "气控压力";
            this.气控压力.Visible = true;
            this.气控压力.VisibleIndex = 13;
            this.气控压力.Width = 65;
            // 
            // 高压分离器液位
            // 
            this.高压分离器液位.Caption = "高压分离器液位";
            this.高压分离器液位.DisplayFormat.FormatString = "{0}mm";
            this.高压分离器液位.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.高压分离器液位.FieldName = "高压分离器液位";
            this.高压分离器液位.Name = "高压分离器液位";
            this.高压分离器液位.Visible = true;
            this.高压分离器液位.VisibleIndex = 14;
            this.高压分离器液位.Width = 65;
            // 
            // 高压分离器浓度
            // 
            this.高压分离器浓度.Caption = "高压分离器浓度";
            this.高压分离器浓度.CustomizationCaption = "{0}LEL%";
            this.高压分离器浓度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.高压分离器浓度.FieldName = "高压分离器浓度";
            this.高压分离器浓度.Name = "高压分离器浓度";
            this.高压分离器浓度.Visible = true;
            this.高压分离器浓度.VisibleIndex = 15;
            this.高压分离器浓度.Width = 65;
            // 
            // 旋流分离器液位
            // 
            this.旋流分离器液位.Caption = "旋流分离器液位";
            this.旋流分离器液位.DisplayFormat.FormatString = "{0}mm";
            this.旋流分离器液位.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.旋流分离器液位.FieldName = "旋流分离器液位";
            this.旋流分离器液位.Name = "旋流分离器液位";
            this.旋流分离器液位.Visible = true;
            this.旋流分离器液位.VisibleIndex = 16;
            this.旋流分离器液位.Width = 65;
            // 
            // JT阀开度监测
            // 
            this.JT阀开度监测.Caption = "JT阀开度监测";
            this.JT阀开度监测.DisplayFormat.FormatString = "{0}%";
            this.JT阀开度监测.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.JT阀开度监测.FieldName = "JT阀开度监测";
            this.JT阀开度监测.Name = "JT阀开度监测";
            this.JT阀开度监测.Visible = true;
            this.JT阀开度监测.VisibleIndex = 17;
            this.JT阀开度监测.Width = 65;
            // 
            // 水套炉液位
            // 
            this.水套炉液位.Caption = "水套炉液位";
            this.水套炉液位.DisplayFormat.FormatString = "{0}mm";
            this.水套炉液位.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.水套炉液位.FieldName = "水套炉液位";
            this.水套炉液位.Name = "水套炉液位";
            this.水套炉液位.Visible = true;
            this.水套炉液位.VisibleIndex = 18;
            this.水套炉液位.Width = 65;
            // 
            // 水套炉进气温度
            // 
            this.水套炉进气温度.Caption = "水套炉进气温度";
            this.水套炉进气温度.DisplayFormat.FormatString = "{0}℃";
            this.水套炉进气温度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.水套炉进气温度.FieldName = "水套炉进气温度";
            this.水套炉进气温度.Name = "水套炉进气温度";
            this.水套炉进气温度.Visible = true;
            this.水套炉进气温度.VisibleIndex = 19;
            this.水套炉进气温度.Width = 65;
            // 
            // 水套炉水温
            // 
            this.水套炉水温.Caption = "水套炉水温";
            this.水套炉水温.DisplayFormat.FormatString = "{0}℃";
            this.水套炉水温.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.水套炉水温.FieldName = "水套炉水温";
            this.水套炉水温.Name = "水套炉水温";
            this.水套炉水温.Visible = true;
            this.水套炉水温.VisibleIndex = 20;
            this.水套炉水温.Width = 65;
            // 
            // 水套炉点火浓度
            // 
            this.水套炉点火浓度.Caption = "水套炉点火浓度";
            this.水套炉点火浓度.CustomizationCaption = "{0}LEL%";
            this.水套炉点火浓度.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.水套炉点火浓度.FieldName = "水套炉点火浓度";
            this.水套炉点火浓度.Name = "水套炉点火浓度";
            this.水套炉点火浓度.Visible = true;
            this.水套炉点火浓度.VisibleIndex = 21;
            this.水套炉点火浓度.Width = 65;
            // 
            // 露点仪
            // 
            this.露点仪.Caption = "露点仪";
            this.露点仪.DisplayFormat.FormatString = "{0}℃";
            this.露点仪.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.露点仪.FieldName = "露点仪";
            this.露点仪.Name = "露点仪";
            this.露点仪.Visible = true;
            this.露点仪.VisibleIndex = 22;
            this.露点仪.Width = 65;
            // 
            // 气体瞬时流量
            // 
            this.气体瞬时流量.Caption = "气体瞬时流量";
            this.气体瞬时流量.DisplayFormat.FormatString = "{0}Nm3/h";
            this.气体瞬时流量.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.气体瞬时流量.FieldName = "气体瞬时流量";
            this.气体瞬时流量.Name = "气体瞬时流量";
            this.气体瞬时流量.Visible = true;
            this.气体瞬时流量.VisibleIndex = 23;
            this.气体瞬时流量.Width = 65;
            // 
            // 气体累计流量
            // 
            this.气体累计流量.Caption = "气体累计流量";
            this.气体累计流量.DisplayFormat.FormatString = "{0}Nm3";
            this.气体累计流量.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.气体累计流量.FieldName = "气体累计流量";
            this.气体累计流量.Name = "气体累计流量";
            this.气体累计流量.Visible = true;
            this.气体累计流量.VisibleIndex = 24;
            this.气体累计流量.Width = 65;
            // 
            // 液体瞬时流量
            // 
            this.液体瞬时流量.Caption = "液体瞬时流量";
            this.液体瞬时流量.DisplayFormat.FormatString = "{0}Nm3/h";
            this.液体瞬时流量.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.液体瞬时流量.FieldName = "液体瞬时流量";
            this.液体瞬时流量.Name = "液体瞬时流量";
            this.液体瞬时流量.Visible = true;
            this.液体瞬时流量.VisibleIndex = 25;
            this.液体瞬时流量.Width = 91;
            // 
            // 液体累计流量
            // 
            this.液体累计流量.Caption = "液体累计流量";
            this.液体累计流量.DisplayFormat.FormatString = "{0}Nm3";
            this.液体累计流量.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.液体累计流量.FieldName = "液体累计流量";
            this.液体累计流量.Name = "液体累计流量";
            this.液体累计流量.Visible = true;
            this.液体累计流量.VisibleIndex = 26;
            this.液体累计流量.Width = 106;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(228, 23);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(26, 21);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "至";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(18, 23);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(26, 21);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "从";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExport.DownBack = null;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(559, 19);
            this.btnExport.MouseBack = null;
            this.btnExport.Name = "btnExport";
            this.btnExport.NormlBack = null;
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bntSelect
            // 
            this.bntSelect.BackColor = System.Drawing.Color.Transparent;
            this.bntSelect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bntSelect.DownBack = null;
            this.bntSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bntSelect.Location = new System.Drawing.Point(453, 19);
            this.bntSelect.MouseBack = null;
            this.bntSelect.Name = "bntSelect";
            this.bntSelect.NormlBack = null;
            this.bntSelect.Size = new System.Drawing.Size(100, 30);
            this.bntSelect.TabIndex = 1;
            this.bntSelect.Text = "查询";
            this.bntSelect.UseVisualStyleBackColor = false;
            this.bntSelect.Click += new System.EventHandler(this.bntSelect_Click);
            // 
            // HistoryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1039);
            this.Controls.Add(this.skinPanel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1039);
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "HistoryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史数据";
            this.Load += new System.EventHandler(this.HistoryData_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton bntSelect;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinButton btnExport;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 采集时间;
        private DevExpress.XtraGrid.Columns.GridColumn 设备入口压力;
        private DevExpress.XtraGrid.Columns.GridColumn 设备入口温度;
        private DevExpress.XtraGrid.Columns.GridColumn 换热器入口压力;
        private DevExpress.XtraGrid.Columns.GridColumn 换热器入口温度;
        private DevExpress.XtraGrid.Columns.GridColumn 换热器出口压力;
        private DevExpress.XtraGrid.Columns.GridColumn 换热器出口温度;
        private DevExpress.XtraGrid.Columns.GridColumn JT阀入口压力;
        private DevExpress.XtraGrid.Columns.GridColumn JT阀入口温度;
        private DevExpress.XtraGrid.Columns.GridColumn 旋流分离器出口压力;
        private DevExpress.XtraGrid.Columns.GridColumn 旋流分离器出口温度;
        private DevExpress.XtraGrid.Columns.GridColumn 设备出口压力;
        private DevExpress.XtraGrid.Columns.GridColumn 设备出口温度;
        private DevExpress.XtraGrid.Columns.GridColumn 气控压力;
        private DevExpress.XtraGrid.Columns.GridColumn 高压分离器液位;
        private DevExpress.XtraGrid.Columns.GridColumn 高压分离器浓度;
        private DevExpress.XtraGrid.Columns.GridColumn 旋流分离器液位;
        private DevExpress.XtraGrid.Columns.GridColumn JT阀开度监测;
        private DevExpress.XtraGrid.Columns.GridColumn 水套炉液位;
        private DevExpress.XtraGrid.Columns.GridColumn 水套炉进气温度;
        private DevExpress.XtraGrid.Columns.GridColumn 水套炉水温;
        private DevExpress.XtraGrid.Columns.GridColumn 水套炉点火浓度;
        private DevExpress.XtraGrid.Columns.GridColumn 露点仪;
        private DevExpress.XtraGrid.Columns.GridColumn 气体瞬时流量;
        private DevExpress.XtraGrid.Columns.GridColumn 气体累计流量;
        private DevExpress.XtraGrid.Columns.GridColumn 液体瞬时流量;
        private DevExpress.XtraGrid.Columns.GridColumn 液体累计流量;
    }
}