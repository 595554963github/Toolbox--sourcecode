﻿namespace FirstPlugin.Forms
{
    partial class SamplerEditor2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplerEditor2));
            this.stLabel17 = new Toolbox.Library.Forms.STLabel();
            this.stPanel3 = new Toolbox.Library.Forms.STPanel();
            this.wrapUCB = new Toolbox.Library.Forms.STComboBox();
            this.wrapUCBLabel = new Toolbox.Library.Forms.STLabel();
            this.wrapVCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel5 = new Toolbox.Library.Forms.STLabel();
            this.wrapWCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel6 = new Toolbox.Library.Forms.STLabel();
            this.stLabel16 = new Toolbox.Library.Forms.STLabel();
            this.stPanel2 = new Toolbox.Library.Forms.STPanel();
            this.stLabel11 = new Toolbox.Library.Forms.STLabel();
            this.lodMinUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.lodMaxUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.stLabel12 = new Toolbox.Library.Forms.STLabel();
            this.stLabel13 = new Toolbox.Library.Forms.STLabel();
            this.biasUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.stLabel15 = new Toolbox.Library.Forms.STLabel();
            this.stPanel1 = new Toolbox.Library.Forms.STPanel();
            this.filterZCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel22 = new Toolbox.Library.Forms.STLabel();
            this.filterBorderCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel18 = new Toolbox.Library.Forms.STLabel();
            this.stLabel9 = new Toolbox.Library.Forms.STLabel();
            this.filterExpandCB = new Toolbox.Library.Forms.STComboBox();
            this.filterShrinkCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel8 = new Toolbox.Library.Forms.STLabel();
            this.filterMipmapCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel7 = new Toolbox.Library.Forms.STLabel();
            this.filterAntitropicCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel10 = new Toolbox.Library.Forms.STLabel();
            this.stLabel14 = new Toolbox.Library.Forms.STLabel();
            this.textureNameTB = new Toolbox.Library.Forms.STTextBox();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.samplerHintTB = new Toolbox.Library.Forms.STTextBox();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.samplerCB = new Toolbox.Library.Forms.STComboBox();
            this.textureRefListView = new Toolbox.Library.Forms.ListViewCustom();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textureBP = new Toolbox.Library.Forms.PictureBoxCustom();
            this.stLabel19 = new Toolbox.Library.Forms.STLabel();
            this.stPanel4 = new Toolbox.Library.Forms.STPanel();
            this.deptComparechkBox = new Toolbox.Library.Forms.STCheckBox();
            this.stLabel20 = new Toolbox.Library.Forms.STLabel();
            this.depthFuncCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel21 = new Toolbox.Library.Forms.STLabel();
            this.btnAdd = new Toolbox.Library.Forms.STButton();
            this.btnRemove = new Toolbox.Library.Forms.STButton();
            this.btnSamplerEdit = new Toolbox.Library.Forms.STButton();
            this.btnEdit = new Toolbox.Library.Forms.STButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.stPanel5 = new Toolbox.Library.Forms.STPanel();
            this.stPanel3.SuspendLayout();
            this.stPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lodMinUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodMaxUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biasUD)).BeginInit();
            this.stPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureBP)).BeginInit();
            this.stPanel4.SuspendLayout();
            this.stPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // stLabel17
            // 
            this.stLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stLabel17.AutoSize = true;
            this.stLabel17.Location = new System.Drawing.Point(313, 6);
            this.stLabel17.Name = "stLabel17";
            this.stLabel17.Size = new System.Drawing.Size(53, 12);
            this.stLabel17.TabIndex = 43;
            this.stLabel17.Text = "环绕模式";
            // 
            // stPanel3
            // 
            this.stPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stPanel3.Controls.Add(this.wrapUCB);
            this.stPanel3.Controls.Add(this.wrapUCBLabel);
            this.stPanel3.Controls.Add(this.wrapVCB);
            this.stPanel3.Controls.Add(this.stLabel5);
            this.stPanel3.Controls.Add(this.wrapWCB);
            this.stPanel3.Controls.Add(this.stLabel6);
            this.stPanel3.Location = new System.Drawing.Point(302, 24);
            this.stPanel3.Name = "stPanel3";
            this.stPanel3.Size = new System.Drawing.Size(205, 84);
            this.stPanel3.TabIndex = 49;
            // 
            // wrapUCB
            // 
            this.wrapUCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapUCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapUCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapUCB.FormattingEnabled = true;
            this.wrapUCB.IsReadOnly = false;
            this.wrapUCB.Location = new System.Drawing.Point(77, 8);
            this.wrapUCB.Name = "wrapUCB";
            this.wrapUCB.Size = new System.Drawing.Size(121, 20);
            this.wrapUCB.TabIndex = 10;
            this.wrapUCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // wrapUCBLabel
            // 
            this.wrapUCBLabel.AutoSize = true;
            this.wrapUCBLabel.Location = new System.Drawing.Point(5, 11);
            this.wrapUCBLabel.Name = "wrapUCBLabel";
            this.wrapUCBLabel.Size = new System.Drawing.Size(59, 12);
            this.wrapUCBLabel.TabIndex = 11;
            this.wrapUCBLabel.Text = "U方向环绕";
            // 
            // wrapVCB
            // 
            this.wrapVCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapVCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapVCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapVCB.FormattingEnabled = true;
            this.wrapVCB.IsReadOnly = false;
            this.wrapVCB.Location = new System.Drawing.Point(77, 33);
            this.wrapVCB.Name = "wrapVCB";
            this.wrapVCB.Size = new System.Drawing.Size(121, 20);
            this.wrapVCB.TabIndex = 12;
            this.wrapVCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel5
            // 
            this.stLabel5.AutoSize = true;
            this.stLabel5.Location = new System.Drawing.Point(5, 36);
            this.stLabel5.Name = "stLabel5";
            this.stLabel5.Size = new System.Drawing.Size(59, 12);
            this.stLabel5.TabIndex = 13;
            this.stLabel5.Text = "V方向环绕";
            // 
            // wrapWCB
            // 
            this.wrapWCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapWCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapWCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapWCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapWCB.FormattingEnabled = true;
            this.wrapWCB.IsReadOnly = false;
            this.wrapWCB.Location = new System.Drawing.Point(77, 56);
            this.wrapWCB.Name = "wrapWCB";
            this.wrapWCB.Size = new System.Drawing.Size(121, 20);
            this.wrapWCB.TabIndex = 14;
            this.wrapWCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel6
            // 
            this.stLabel6.AutoSize = true;
            this.stLabel6.Location = new System.Drawing.Point(5, 59);
            this.stLabel6.Name = "stLabel6";
            this.stLabel6.Size = new System.Drawing.Size(59, 12);
            this.stLabel6.TabIndex = 15;
            this.stLabel6.Text = "W方向环绕";
            // 
            // stLabel16
            // 
            this.stLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stLabel16.AutoSize = true;
            this.stLabel16.Location = new System.Drawing.Point(310, 365);
            this.stLabel16.Name = "stLabel16";
            this.stLabel16.Size = new System.Drawing.Size(53, 12);
            this.stLabel16.TabIndex = 48;
            this.stLabel16.Text = "细节层次";
            // 
            // stPanel2
            // 
            this.stPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stPanel2.Controls.Add(this.stLabel11);
            this.stPanel2.Controls.Add(this.lodMinUD);
            this.stPanel2.Controls.Add(this.lodMaxUD);
            this.stPanel2.Controls.Add(this.stLabel12);
            this.stPanel2.Controls.Add(this.stLabel13);
            this.stPanel2.Controls.Add(this.biasUD);
            this.stPanel2.Location = new System.Drawing.Point(301, 379);
            this.stPanel2.Name = "stPanel2";
            this.stPanel2.Size = new System.Drawing.Size(202, 92);
            this.stPanel2.TabIndex = 47;
            // 
            // stLabel11
            // 
            this.stLabel11.AutoSize = true;
            this.stLabel11.Location = new System.Drawing.Point(17, 18);
            this.stLabel11.Name = "stLabel11";
            this.stLabel11.Size = new System.Drawing.Size(41, 12);
            this.stLabel11.TabIndex = 25;
            this.stLabel11.Text = "最小值";
            // 
            // lodMinUD
            // 
            this.lodMinUD.DecimalPlaces = 5;
            this.lodMinUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.lodMinUD.Location = new System.Drawing.Point(77, 16);
            this.lodMinUD.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.lodMinUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.lodMinUD.Name = "lodMinUD";
            this.lodMinUD.Size = new System.Drawing.Size(120, 21);
            this.lodMinUD.TabIndex = 24;
            this.lodMinUD.ValueChanged += new System.EventHandler(this.lodMinUD_ValueChanged);
            // 
            // lodMaxUD
            // 
            this.lodMaxUD.DecimalPlaces = 5;
            this.lodMaxUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.lodMaxUD.Location = new System.Drawing.Point(77, 40);
            this.lodMaxUD.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.lodMaxUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.lodMaxUD.Name = "lodMaxUD";
            this.lodMaxUD.Size = new System.Drawing.Size(120, 21);
            this.lodMaxUD.TabIndex = 26;
            this.lodMaxUD.ValueChanged += new System.EventHandler(this.lodMaxUD_ValueChanged);
            // 
            // stLabel12
            // 
            this.stLabel12.AutoSize = true;
            this.stLabel12.Location = new System.Drawing.Point(17, 42);
            this.stLabel12.Name = "stLabel12";
            this.stLabel12.Size = new System.Drawing.Size(41, 12);
            this.stLabel12.TabIndex = 27;
            this.stLabel12.Text = "最大值";
            // 
            // stLabel13
            // 
            this.stLabel13.AutoSize = true;
            this.stLabel13.Location = new System.Drawing.Point(16, 66);
            this.stLabel13.Name = "stLabel13";
            this.stLabel13.Size = new System.Drawing.Size(29, 12);
            this.stLabel13.TabIndex = 29;
            this.stLabel13.Text = "偏差";
            // 
            // biasUD
            // 
            this.biasUD.DecimalPlaces = 5;
            this.biasUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.biasUD.Location = new System.Drawing.Point(76, 64);
            this.biasUD.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.biasUD.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            -2147483648});
            this.biasUD.Name = "biasUD";
            this.biasUD.Size = new System.Drawing.Size(120, 21);
            this.biasUD.TabIndex = 28;
            this.biasUD.ValueChanged += new System.EventHandler(this.biasUD_ValueChanged);
            // 
            // stLabel15
            // 
            this.stLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stLabel15.AutoSize = true;
            this.stLabel15.Location = new System.Drawing.Point(316, 195);
            this.stLabel15.Name = "stLabel15";
            this.stLabel15.Size = new System.Drawing.Size(41, 12);
            this.stLabel15.TabIndex = 44;
            this.stLabel15.Text = "过滤器";
            // 
            // stPanel1
            // 
            this.stPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stPanel1.Controls.Add(this.filterZCB);
            this.stPanel1.Controls.Add(this.stLabel22);
            this.stPanel1.Controls.Add(this.filterBorderCB);
            this.stPanel1.Controls.Add(this.stLabel18);
            this.stPanel1.Controls.Add(this.stLabel9);
            this.stPanel1.Controls.Add(this.filterExpandCB);
            this.stPanel1.Controls.Add(this.filterShrinkCB);
            this.stPanel1.Controls.Add(this.stLabel8);
            this.stPanel1.Controls.Add(this.filterMipmapCB);
            this.stPanel1.Controls.Add(this.stLabel7);
            this.stPanel1.Controls.Add(this.filterAntitropicCB);
            this.stPanel1.Controls.Add(this.stLabel10);
            this.stPanel1.Location = new System.Drawing.Point(300, 210);
            this.stPanel1.Name = "stPanel1";
            this.stPanel1.Size = new System.Drawing.Size(206, 152);
            this.stPanel1.TabIndex = 46;
            // 
            // filterZCB
            // 
            this.filterZCB.BorderColor = System.Drawing.Color.Empty;
            this.filterZCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterZCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterZCB.FormattingEnabled = true;
            this.filterZCB.IsReadOnly = false;
            this.filterZCB.Location = new System.Drawing.Point(75, 128);
            this.filterZCB.Name = "filterZCB";
            this.filterZCB.Size = new System.Drawing.Size(121, 20);
            this.filterZCB.TabIndex = 26;
            this.filterZCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel22
            // 
            this.stLabel22.AutoSize = true;
            this.stLabel22.Location = new System.Drawing.Point(10, 138);
            this.stLabel22.Name = "stLabel22";
            this.stLabel22.Size = new System.Drawing.Size(35, 12);
            this.stLabel22.TabIndex = 27;
            this.stLabel22.Text = "Z过滤";
            // 
            // filterBorderCB
            // 
            this.filterBorderCB.BorderColor = System.Drawing.Color.Empty;
            this.filterBorderCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterBorderCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterBorderCB.FormattingEnabled = true;
            this.filterBorderCB.IsReadOnly = false;
            this.filterBorderCB.Location = new System.Drawing.Point(76, 103);
            this.filterBorderCB.Name = "filterBorderCB";
            this.filterBorderCB.Size = new System.Drawing.Size(121, 20);
            this.filterBorderCB.TabIndex = 24;
            this.filterBorderCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel18
            // 
            this.stLabel18.AutoSize = true;
            this.stLabel18.Location = new System.Drawing.Point(11, 114);
            this.stLabel18.Name = "stLabel18";
            this.stLabel18.Size = new System.Drawing.Size(29, 12);
            this.stLabel18.TabIndex = 25;
            this.stLabel18.Text = "边界";
            // 
            // stLabel9
            // 
            this.stLabel9.AutoSize = true;
            this.stLabel9.Location = new System.Drawing.Point(9, 13);
            this.stLabel9.Name = "stLabel9";
            this.stLabel9.Size = new System.Drawing.Size(29, 12);
            this.stLabel9.TabIndex = 17;
            this.stLabel9.Text = "放大";
            // 
            // filterExpandCB
            // 
            this.filterExpandCB.BorderColor = System.Drawing.Color.Empty;
            this.filterExpandCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterExpandCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterExpandCB.FormattingEnabled = true;
            this.filterExpandCB.IsReadOnly = false;
            this.filterExpandCB.Location = new System.Drawing.Point(77, 6);
            this.filterExpandCB.Name = "filterExpandCB";
            this.filterExpandCB.Size = new System.Drawing.Size(121, 20);
            this.filterExpandCB.TabIndex = 16;
            this.filterExpandCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // filterShrinkCB
            // 
            this.filterShrinkCB.BorderColor = System.Drawing.Color.Empty;
            this.filterShrinkCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterShrinkCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterShrinkCB.FormattingEnabled = true;
            this.filterShrinkCB.IsReadOnly = false;
            this.filterShrinkCB.Location = new System.Drawing.Point(77, 30);
            this.filterShrinkCB.Name = "filterShrinkCB";
            this.filterShrinkCB.Size = new System.Drawing.Size(121, 20);
            this.filterShrinkCB.TabIndex = 18;
            this.filterShrinkCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel8
            // 
            this.stLabel8.AutoSize = true;
            this.stLabel8.Location = new System.Drawing.Point(9, 38);
            this.stLabel8.Name = "stLabel8";
            this.stLabel8.Size = new System.Drawing.Size(29, 12);
            this.stLabel8.TabIndex = 19;
            this.stLabel8.Text = "缩小";
            // 
            // filterMipmapCB
            // 
            this.filterMipmapCB.BorderColor = System.Drawing.Color.Empty;
            this.filterMipmapCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterMipmapCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterMipmapCB.FormattingEnabled = true;
            this.filterMipmapCB.IsReadOnly = false;
            this.filterMipmapCB.Location = new System.Drawing.Point(77, 54);
            this.filterMipmapCB.Name = "filterMipmapCB";
            this.filterMipmapCB.Size = new System.Drawing.Size(121, 20);
            this.filterMipmapCB.TabIndex = 20;
            this.filterMipmapCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel7
            // 
            this.stLabel7.AutoSize = true;
            this.stLabel7.Location = new System.Drawing.Point(0, 63);
            this.stLabel7.Name = "stLabel7";
            this.stLabel7.Size = new System.Drawing.Size(77, 12);
            this.stLabel7.TabIndex = 21;
            this.stLabel7.Text = "多级渐远纹理";
            // 
            // filterAntitropicCB
            // 
            this.filterAntitropicCB.BorderColor = System.Drawing.Color.Empty;
            this.filterAntitropicCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.filterAntitropicCB.ButtonColor = System.Drawing.Color.Empty;
            this.filterAntitropicCB.FormattingEnabled = true;
            this.filterAntitropicCB.IsReadOnly = false;
            this.filterAntitropicCB.Location = new System.Drawing.Point(77, 78);
            this.filterAntitropicCB.Name = "filterAntitropicCB";
            this.filterAntitropicCB.Size = new System.Drawing.Size(121, 20);
            this.filterAntitropicCB.TabIndex = 22;
            this.filterAntitropicCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel10
            // 
            this.stLabel10.AutoSize = true;
            this.stLabel10.Location = new System.Drawing.Point(10, 86);
            this.stLabel10.Name = "stLabel10";
            this.stLabel10.Size = new System.Drawing.Size(53, 12);
            this.stLabel10.TabIndex = 23;
            this.stLabel10.Text = "各向异性";
            // 
            // stLabel14
            // 
            this.stLabel14.AutoSize = true;
            this.stLabel14.Location = new System.Drawing.Point(104, 120);
            this.stLabel14.Name = "stLabel14";
            this.stLabel14.Size = new System.Drawing.Size(29, 12);
            this.stLabel14.TabIndex = 45;
            this.stLabel14.Text = "图像";
            // 
            // textureNameTB
            // 
            this.textureNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textureNameTB.Location = new System.Drawing.Point(75, 39);
            this.textureNameTB.Name = "textureNameTB";
            this.textureNameTB.ReadOnly = true;
            this.textureNameTB.Size = new System.Drawing.Size(219, 21);
            this.textureNameTB.TabIndex = 42;
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(20, 42);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(29, 12);
            this.stLabel3.TabIndex = 41;
            this.stLabel3.Text = "名称";
            // 
            // samplerHintTB
            // 
            this.samplerHintTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.samplerHintTB.HideSelection = false;
            this.samplerHintTB.Location = new System.Drawing.Point(75, 89);
            this.samplerHintTB.Name = "samplerHintTB";
            this.samplerHintTB.ReadOnly = true;
            this.samplerHintTB.Size = new System.Drawing.Size(219, 21);
            this.samplerHintTB.TabIndex = 40;
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(20, 91);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(29, 12);
            this.stLabel2.TabIndex = 39;
            this.stLabel2.Text = "提示";
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(20, 66);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(41, 12);
            this.stLabel1.TabIndex = 38;
            this.stLabel1.Text = "采样器";
            // 
            // samplerCB
            // 
            this.samplerCB.BorderColor = System.Drawing.Color.Empty;
            this.samplerCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.samplerCB.ButtonColor = System.Drawing.Color.Empty;
            this.samplerCB.FormattingEnabled = true;
            this.samplerCB.IsReadOnly = false;
            this.samplerCB.Location = new System.Drawing.Point(75, 64);
            this.samplerCB.Name = "samplerCB";
            this.samplerCB.Size = new System.Drawing.Size(176, 20);
            this.samplerCB.TabIndex = 37;
            this.samplerCB.SelectedIndexChanged += new System.EventHandler(this.samplerCB_SelectedIndexChanged);
            // 
            // textureRefListView
            // 
            this.textureRefListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textureRefListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.textureRefListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.textureRefListView.HideSelection = false;
            this.textureRefListView.Location = new System.Drawing.Point(0, 0);
            this.textureRefListView.Name = "textureRefListView";
            this.textureRefListView.OwnerDraw = true;
            this.textureRefListView.Size = new System.Drawing.Size(510, 139);
            this.textureRefListView.TabIndex = 35;
            this.textureRefListView.UseCompatibleStateImageBehavior = false;
            this.textureRefListView.View = System.Windows.Forms.View.Details;
            this.textureRefListView.SelectedIndexChanged += new System.EventHandler(this.textureRefListView_SelectedIndexChanged);
            this.textureRefListView.DoubleClick += new System.EventHandler(this.textureRefListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "纹理";
            this.columnHeader1.Width = 254;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "采样器";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "片段采样器";
            this.columnHeader3.Width = 179;
            // 
            // textureBP
            // 
            this.textureBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textureBP.BackColor = System.Drawing.Color.Transparent;
            this.textureBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textureBP.BackgroundImage")));
            this.textureBP.Location = new System.Drawing.Point(14, 135);
            this.textureBP.MinimumSize = new System.Drawing.Size(280, 337);
            this.textureBP.Name = "textureBP";
            this.textureBP.Size = new System.Drawing.Size(280, 337);
            this.textureBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textureBP.TabIndex = 36;
            this.textureBP.TabStop = false;
            this.textureBP.DoubleClick += new System.EventHandler(this.textureRefListView_DoubleClick);
            // 
            // stLabel19
            // 
            this.stLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stLabel19.AutoSize = true;
            this.stLabel19.Location = new System.Drawing.Point(313, 120);
            this.stLabel19.Name = "stLabel19";
            this.stLabel19.Size = new System.Drawing.Size(29, 12);
            this.stLabel19.TabIndex = 50;
            this.stLabel19.Text = "深度";
            // 
            // stPanel4
            // 
            this.stPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stPanel4.Controls.Add(this.deptComparechkBox);
            this.stPanel4.Controls.Add(this.stLabel20);
            this.stPanel4.Controls.Add(this.depthFuncCB);
            this.stPanel4.Controls.Add(this.stLabel21);
            this.stPanel4.Location = new System.Drawing.Point(305, 135);
            this.stPanel4.Name = "stPanel4";
            this.stPanel4.Size = new System.Drawing.Size(205, 57);
            this.stPanel4.TabIndex = 51;
            // 
            // deptComparechkBox
            // 
            this.deptComparechkBox.AutoSize = true;
            this.deptComparechkBox.Location = new System.Drawing.Point(95, 10);
            this.deptComparechkBox.Name = "deptComparechkBox";
            this.deptComparechkBox.Size = new System.Drawing.Size(15, 14);
            this.deptComparechkBox.TabIndex = 14;
            this.deptComparechkBox.UseVisualStyleBackColor = true;
            this.deptComparechkBox.CheckedChanged += new System.EventHandler(this.deptComparechkBox_CheckedChanged);
            // 
            // stLabel20
            // 
            this.stLabel20.AutoSize = true;
            this.stLabel20.Location = new System.Drawing.Point(5, 11);
            this.stLabel20.Name = "stLabel20";
            this.stLabel20.Size = new System.Drawing.Size(53, 12);
            this.stLabel20.TabIndex = 11;
            this.stLabel20.Text = "深度比较";
            // 
            // depthFuncCB
            // 
            this.depthFuncCB.BorderColor = System.Drawing.Color.Empty;
            this.depthFuncCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.depthFuncCB.ButtonColor = System.Drawing.Color.Empty;
            this.depthFuncCB.FormattingEnabled = true;
            this.depthFuncCB.IsReadOnly = false;
            this.depthFuncCB.Location = new System.Drawing.Point(77, 33);
            this.depthFuncCB.Name = "depthFuncCB";
            this.depthFuncCB.Size = new System.Drawing.Size(121, 20);
            this.depthFuncCB.TabIndex = 12;
            this.depthFuncCB.SelectedIndexChanged += new System.EventHandler(this.SamplerEditor_SelectedIndexChanged);
            // 
            // stLabel21
            // 
            this.stLabel21.AutoSize = true;
            this.stLabel21.Location = new System.Drawing.Point(5, 36);
            this.stLabel21.Name = "stLabel21";
            this.stLabel21.Size = new System.Drawing.Size(29, 12);
            this.stLabel21.TabIndex = 13;
            this.stLabel21.Text = "函数";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(14, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 21);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(95, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 21);
            this.btnRemove.TabIndex = 53;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSamplerEdit
            // 
            this.btnSamplerEdit.Enabled = false;
            this.btnSamplerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSamplerEdit.Location = new System.Drawing.Point(248, 63);
            this.btnSamplerEdit.Name = "btnSamplerEdit";
            this.btnSamplerEdit.Size = new System.Drawing.Size(46, 21);
            this.btnSamplerEdit.TabIndex = 54;
            this.btnSamplerEdit.Text = "编辑";
            this.btnSamplerEdit.UseVisualStyleBackColor = false;
            this.btnSamplerEdit.Click += new System.EventHandler(this.btnSamplerEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(176, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 21);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.textureRefListView_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 139);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(510, 3);
            this.splitter1.TabIndex = 56;
            this.splitter1.TabStop = false;
            // 
            // stPanel5
            // 
            this.stPanel5.AutoScroll = true;
            this.stPanel5.Controls.Add(this.stPanel3);
            this.stPanel5.Controls.Add(this.stPanel1);
            this.stPanel5.Controls.Add(this.btnEdit);
            this.stPanel5.Controls.Add(this.stLabel15);
            this.stPanel5.Controls.Add(this.btnSamplerEdit);
            this.stPanel5.Controls.Add(this.stPanel2);
            this.stPanel5.Controls.Add(this.btnRemove);
            this.stPanel5.Controls.Add(this.stLabel16);
            this.stPanel5.Controls.Add(this.btnAdd);
            this.stPanel5.Controls.Add(this.stLabel14);
            this.stPanel5.Controls.Add(this.stLabel17);
            this.stPanel5.Controls.Add(this.textureNameTB);
            this.stPanel5.Controls.Add(this.stLabel19);
            this.stPanel5.Controls.Add(this.stLabel3);
            this.stPanel5.Controls.Add(this.stPanel4);
            this.stPanel5.Controls.Add(this.samplerHintTB);
            this.stPanel5.Controls.Add(this.textureBP);
            this.stPanel5.Controls.Add(this.stLabel2);
            this.stPanel5.Controls.Add(this.samplerCB);
            this.stPanel5.Controls.Add(this.stLabel1);
            this.stPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel5.Location = new System.Drawing.Point(0, 142);
            this.stPanel5.Name = "stPanel5";
            this.stPanel5.Size = new System.Drawing.Size(510, 481);
            this.stPanel5.TabIndex = 57;
            // 
            // SamplerEditor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stPanel5);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textureRefListView);
            this.Name = "SamplerEditor2";
            this.Size = new System.Drawing.Size(510, 623);
            this.stPanel3.ResumeLayout(false);
            this.stPanel3.PerformLayout();
            this.stPanel2.ResumeLayout(false);
            this.stPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lodMinUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodMaxUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biasUD)).EndInit();
            this.stPanel1.ResumeLayout(false);
            this.stPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureBP)).EndInit();
            this.stPanel4.ResumeLayout(false);
            this.stPanel4.PerformLayout();
            this.stPanel5.ResumeLayout(false);
            this.stPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbox.Library.Forms.STLabel stLabel17;
        private Toolbox.Library.Forms.STPanel stPanel3;
        private Toolbox.Library.Forms.STComboBox wrapUCB;
        private Toolbox.Library.Forms.STLabel wrapUCBLabel;
        private Toolbox.Library.Forms.STComboBox wrapVCB;
        private Toolbox.Library.Forms.STLabel stLabel5;
        private Toolbox.Library.Forms.STLabel stLabel6;
        private Toolbox.Library.Forms.STLabel stLabel16;
        private Toolbox.Library.Forms.STPanel stPanel2;
        private Toolbox.Library.Forms.STLabel stLabel11;
        private Toolbox.Library.Forms.NumericUpDownFloat lodMinUD;
        private Toolbox.Library.Forms.NumericUpDownFloat lodMaxUD;
        private Toolbox.Library.Forms.STLabel stLabel12;
        private Toolbox.Library.Forms.STLabel stLabel13;
        private Toolbox.Library.Forms.NumericUpDownFloat biasUD;
        private Toolbox.Library.Forms.STLabel stLabel15;
        private Toolbox.Library.Forms.STPanel stPanel1;
        private Toolbox.Library.Forms.STLabel stLabel9;
        private Toolbox.Library.Forms.STComboBox filterExpandCB;
        private Toolbox.Library.Forms.STComboBox filterShrinkCB;
        private Toolbox.Library.Forms.STLabel stLabel8;
        private Toolbox.Library.Forms.STComboBox filterMipmapCB;
        private Toolbox.Library.Forms.STLabel stLabel7;
        private Toolbox.Library.Forms.STComboBox filterAntitropicCB;
        private Toolbox.Library.Forms.STLabel stLabel10;
        private Toolbox.Library.Forms.STLabel stLabel14;
        private Toolbox.Library.Forms.STTextBox textureNameTB;
        private Toolbox.Library.Forms.STLabel stLabel3;
        private Toolbox.Library.Forms.STTextBox samplerHintTB;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.STLabel stLabel1;
        private Toolbox.Library.Forms.STComboBox samplerCB;
        private Toolbox.Library.Forms.PictureBoxCustom textureBP;
        private Toolbox.Library.Forms.ListViewCustom textureRefListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Toolbox.Library.Forms.STComboBox wrapWCB;
        private Toolbox.Library.Forms.STComboBox filterBorderCB;
        private Toolbox.Library.Forms.STLabel stLabel18;
        private Toolbox.Library.Forms.STLabel stLabel19;
        private Toolbox.Library.Forms.STPanel stPanel4;
        private Toolbox.Library.Forms.STCheckBox deptComparechkBox;
        private Toolbox.Library.Forms.STLabel stLabel20;
        private Toolbox.Library.Forms.STComboBox depthFuncCB;
        private Toolbox.Library.Forms.STLabel stLabel21;
        private Toolbox.Library.Forms.STComboBox filterZCB;
        private Toolbox.Library.Forms.STLabel stLabel22;
        private Toolbox.Library.Forms.STButton btnAdd;
        private Toolbox.Library.Forms.STButton btnRemove;
        private Toolbox.Library.Forms.STButton btnSamplerEdit;
        private Toolbox.Library.Forms.STButton btnEdit;
        private System.Windows.Forms.Splitter splitter1;
        private Toolbox.Library.Forms.STPanel stPanel5;
    }
}
