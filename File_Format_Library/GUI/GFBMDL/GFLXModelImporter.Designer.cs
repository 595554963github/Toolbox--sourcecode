namespace FirstPlugin.Forms
{
    partial class GFLXModelImporter
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
            this.presetCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.chkUseNormals = new Toolbox.Library.Forms.STCheckBox();
            this.chkHasUv1 = new Toolbox.Library.Forms.STCheckBox();
            this.chkUseBoneIndex = new Toolbox.Library.Forms.STCheckBox();
            this.chkUseColor1 = new Toolbox.Library.Forms.STCheckBox();
            this.normalFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.uv0FormatCB = new Toolbox.Library.Forms.STComboBox();
            this.boneFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.color0FormatCB = new Toolbox.Library.Forms.STComboBox();
            this.uv1FormatCB = new Toolbox.Library.Forms.STComboBox();
            this.chkHasUv2 = new Toolbox.Library.Forms.STCheckBox();
            this.color1FormatCB = new Toolbox.Library.Forms.STComboBox();
            this.chkUseColor2 = new Toolbox.Library.Forms.STCheckBox();
            this.positionFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.stCheckBox8 = new Toolbox.Library.Forms.STCheckBox();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.materiialPresetCB = new Toolbox.Library.Forms.STComboBox();
            this.stButton1 = new Toolbox.Library.Forms.STButton();
            this.listViewCustom1 = new Toolbox.Library.Forms.ListViewCustom();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.stPanel1 = new Toolbox.Library.Forms.STPanel();
            this.chkSetNormalsToColorChannel = new Toolbox.Library.Forms.STCheckBox();
            this.tangentFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.chkTangents = new Toolbox.Library.Forms.STCheckBox();
            this.chkUseBoneWeights = new Toolbox.Library.Forms.STCheckBox();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.bitangentFormatCB = new Toolbox.Library.Forms.STComboBox();
            this.chkBitangents = new Toolbox.Library.Forms.STCheckBox();
            this.stLabel4 = new Toolbox.Library.Forms.STLabel();
            this.rotateModel90YUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.stLabel5 = new Toolbox.Library.Forms.STLabel();
            this.stPanel2 = new Toolbox.Library.Forms.STPanel();
            this.chkResetTexTransforms = new Toolbox.Library.Forms.STCheckBox();
            this.chkMatchAttributes = new Toolbox.Library.Forms.STCheckBox();
            this.chkUseOriginalBones = new Toolbox.Library.Forms.STCheckBox();
            this.chkFlipUVsVertical = new Toolbox.Library.Forms.STCheckBox();
            this.stButton2 = new Toolbox.Library.Forms.STButton();
            this.contentContainer.SuspendLayout();
            this.stPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateModel90YUD)).BeginInit();
            this.stPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.Controls.Add(this.stButton2);
            this.contentContainer.Controls.Add(this.stPanel2);
            this.contentContainer.Controls.Add(this.stPanel1);
            this.contentContainer.Controls.Add(this.listViewCustom1);
            this.contentContainer.Size = new System.Drawing.Size(605, 572);
            this.contentContainer.Controls.SetChildIndex(this.listViewCustom1, 0);
            this.contentContainer.Controls.SetChildIndex(this.stPanel1, 0);
            this.contentContainer.Controls.SetChildIndex(this.stPanel2, 0);
            this.contentContainer.Controls.SetChildIndex(this.stButton2, 0);
            // 
            // presetCB
            // 
            this.presetCB.BorderColor = System.Drawing.Color.Empty;
            this.presetCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.presetCB.ButtonColor = System.Drawing.Color.Empty;
            this.presetCB.FormattingEnabled = true;
            this.presetCB.IsReadOnly = false;
            this.presetCB.Location = new System.Drawing.Point(153, 39);
            this.presetCB.Name = "presetCB";
            this.presetCB.Size = new System.Drawing.Size(120, 20);
            this.presetCB.TabIndex = 11;
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(13, 42);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(29, 12);
            this.stLabel1.TabIndex = 12;
            this.stLabel1.Text = "预设";
            // 
            // chkUseNormals
            // 
            this.chkUseNormals.AutoSize = true;
            this.chkUseNormals.Location = new System.Drawing.Point(12, 96);
            this.chkUseNormals.Name = "chkUseNormals";
            this.chkUseNormals.Size = new System.Drawing.Size(72, 16);
            this.chkUseNormals.TabIndex = 14;
            this.chkUseNormals.Text = "使用法线";
            this.chkUseNormals.UseVisualStyleBackColor = true;
            this.chkUseNormals.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkHasUv1
            // 
            this.chkHasUv1.AutoSize = true;
            this.chkHasUv1.Location = new System.Drawing.Point(11, 182);
            this.chkHasUv1.Name = "chkHasUv1";
            this.chkHasUv1.Size = new System.Drawing.Size(90, 16);
            this.chkHasUv1.TabIndex = 15;
            this.chkHasUv1.Text = "使用UV通道1";
            this.chkHasUv1.UseVisualStyleBackColor = true;
            this.chkHasUv1.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkUseBoneIndex
            // 
            this.chkUseBoneIndex.AutoSize = true;
            this.chkUseBoneIndex.Location = new System.Drawing.Point(11, 311);
            this.chkUseBoneIndex.Name = "chkUseBoneIndex";
            this.chkUseBoneIndex.Size = new System.Drawing.Size(96, 16);
            this.chkUseBoneIndex.TabIndex = 16;
            this.chkUseBoneIndex.Text = "使用骨骼索引";
            this.chkUseBoneIndex.UseVisualStyleBackColor = true;
            this.chkUseBoneIndex.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkUseColor1
            // 
            this.chkUseColor1.AutoSize = true;
            this.chkUseColor1.Location = new System.Drawing.Point(11, 234);
            this.chkUseColor1.Name = "chkUseColor1";
            this.chkUseColor1.Size = new System.Drawing.Size(102, 16);
            this.chkUseColor1.TabIndex = 17;
            this.chkUseColor1.Text = "使用颜色通道1";
            this.chkUseColor1.UseVisualStyleBackColor = true;
            this.chkUseColor1.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // normalFormatCB
            // 
            this.normalFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.normalFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.normalFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.normalFormatCB.FormattingEnabled = true;
            this.normalFormatCB.IsReadOnly = false;
            this.normalFormatCB.Location = new System.Drawing.Point(142, 96);
            this.normalFormatCB.Name = "normalFormatCB";
            this.normalFormatCB.Size = new System.Drawing.Size(131, 20);
            this.normalFormatCB.TabIndex = 18;
            this.normalFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // uv0FormatCB
            // 
            this.uv0FormatCB.BorderColor = System.Drawing.Color.Empty;
            this.uv0FormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.uv0FormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.uv0FormatCB.FormattingEnabled = true;
            this.uv0FormatCB.IsReadOnly = false;
            this.uv0FormatCB.Location = new System.Drawing.Point(142, 177);
            this.uv0FormatCB.Name = "uv0FormatCB";
            this.uv0FormatCB.Size = new System.Drawing.Size(131, 20);
            this.uv0FormatCB.TabIndex = 19;
            this.uv0FormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // boneFormatCB
            // 
            this.boneFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.boneFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.boneFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.boneFormatCB.FormattingEnabled = true;
            this.boneFormatCB.IsReadOnly = false;
            this.boneFormatCB.Location = new System.Drawing.Point(142, 307);
            this.boneFormatCB.Name = "boneFormatCB";
            this.boneFormatCB.Size = new System.Drawing.Size(133, 20);
            this.boneFormatCB.TabIndex = 21;
            this.boneFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // color0FormatCB
            // 
            this.color0FormatCB.BorderColor = System.Drawing.Color.Empty;
            this.color0FormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.color0FormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.color0FormatCB.FormattingEnabled = true;
            this.color0FormatCB.IsReadOnly = false;
            this.color0FormatCB.Location = new System.Drawing.Point(142, 232);
            this.color0FormatCB.Name = "color0FormatCB";
            this.color0FormatCB.Size = new System.Drawing.Size(131, 20);
            this.color0FormatCB.TabIndex = 20;
            this.color0FormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // uv1FormatCB
            // 
            this.uv1FormatCB.BorderColor = System.Drawing.Color.Empty;
            this.uv1FormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.uv1FormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.uv1FormatCB.FormattingEnabled = true;
            this.uv1FormatCB.IsReadOnly = false;
            this.uv1FormatCB.Location = new System.Drawing.Point(142, 203);
            this.uv1FormatCB.Name = "uv1FormatCB";
            this.uv1FormatCB.Size = new System.Drawing.Size(131, 20);
            this.uv1FormatCB.TabIndex = 23;
            this.uv1FormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkHasUv2
            // 
            this.chkHasUv2.AutoSize = true;
            this.chkHasUv2.Location = new System.Drawing.Point(11, 207);
            this.chkHasUv2.Name = "chkHasUv2";
            this.chkHasUv2.Size = new System.Drawing.Size(90, 16);
            this.chkHasUv2.TabIndex = 22;
            this.chkHasUv2.Text = "使用UV通道2";
            this.chkHasUv2.UseVisualStyleBackColor = true;
            this.chkHasUv2.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // color1FormatCB
            // 
            this.color1FormatCB.BorderColor = System.Drawing.Color.Empty;
            this.color1FormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.color1FormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.color1FormatCB.FormattingEnabled = true;
            this.color1FormatCB.IsReadOnly = false;
            this.color1FormatCB.Location = new System.Drawing.Point(142, 256);
            this.color1FormatCB.Name = "color1FormatCB";
            this.color1FormatCB.Size = new System.Drawing.Size(131, 20);
            this.color1FormatCB.TabIndex = 25;
            this.color1FormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkUseColor2
            // 
            this.chkUseColor2.AutoSize = true;
            this.chkUseColor2.Location = new System.Drawing.Point(11, 258);
            this.chkUseColor2.Name = "chkUseColor2";
            this.chkUseColor2.Size = new System.Drawing.Size(102, 16);
            this.chkUseColor2.TabIndex = 24;
            this.chkUseColor2.Text = "使用颜色通道2";
            this.chkUseColor2.UseVisualStyleBackColor = true;
            this.chkUseColor2.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // positionFormatCB
            // 
            this.positionFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.positionFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.positionFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.positionFormatCB.FormattingEnabled = true;
            this.positionFormatCB.IsReadOnly = false;
            this.positionFormatCB.Location = new System.Drawing.Point(142, 69);
            this.positionFormatCB.Name = "positionFormatCB";
            this.positionFormatCB.Size = new System.Drawing.Size(131, 20);
            this.positionFormatCB.TabIndex = 29;
            this.positionFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stCheckBox8
            // 
            this.stCheckBox8.AutoSize = true;
            this.stCheckBox8.Checked = true;
            this.stCheckBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stCheckBox8.Enabled = false;
            this.stCheckBox8.Location = new System.Drawing.Point(12, 71);
            this.stCheckBox8.Name = "stCheckBox8";
            this.stCheckBox8.Size = new System.Drawing.Size(48, 16);
            this.stCheckBox8.TabIndex = 28;
            this.stCheckBox8.Text = "位置";
            this.stCheckBox8.UseVisualStyleBackColor = true;
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(9, 36);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(29, 12);
            this.stLabel2.TabIndex = 31;
            this.stLabel2.Text = "材质";
            // 
            // materiialPresetCB
            // 
            this.materiialPresetCB.BorderColor = System.Drawing.Color.Empty;
            this.materiialPresetCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.materiialPresetCB.ButtonColor = System.Drawing.Color.Empty;
            this.materiialPresetCB.FormattingEnabled = true;
            this.materiialPresetCB.IsReadOnly = false;
            this.materiialPresetCB.Location = new System.Drawing.Point(142, 33);
            this.materiialPresetCB.Name = "materiialPresetCB";
            this.materiialPresetCB.Size = new System.Drawing.Size(131, 20);
            this.materiialPresetCB.TabIndex = 32;
            this.materiialPresetCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stButton1
            // 
            this.stButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton1.Location = new System.Drawing.Point(282, 31);
            this.stButton1.Name = "stButton1";
            this.stButton1.Size = new System.Drawing.Size(31, 21);
            this.stButton1.TabIndex = 33;
            this.stButton1.Text = "+";
            this.stButton1.UseVisualStyleBackColor = false;
            this.stButton1.Click += new System.EventHandler(this.stButton1_Click);
            // 
            // listViewCustom1
            // 
            this.listViewCustom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCustom1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCustom1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewCustom1.HideSelection = false;
            this.listViewCustom1.Location = new System.Drawing.Point(5, 29);
            this.listViewCustom1.Name = "listViewCustom1";
            this.listViewCustom1.OwnerDraw = true;
            this.listViewCustom1.Size = new System.Drawing.Size(208, 461);
            this.listViewCustom1.TabIndex = 34;
            this.listViewCustom1.UseCompatibleStateImageBehavior = false;
            this.listViewCustom1.View = System.Windows.Forms.View.Details;
            this.listViewCustom1.SelectedIndexChanged += new System.EventHandler(this.listViewCustom1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 202;
            // 
            // weightFormatCB
            // 
            this.weightFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.weightFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.weightFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.weightFormatCB.FormattingEnabled = true;
            this.weightFormatCB.IsReadOnly = false;
            this.weightFormatCB.Location = new System.Drawing.Point(142, 330);
            this.weightFormatCB.Name = "weightFormatCB";
            this.weightFormatCB.Size = new System.Drawing.Size(135, 20);
            this.weightFormatCB.TabIndex = 35;
            this.weightFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stPanel1
            // 
            this.stPanel1.Controls.Add(this.chkSetNormalsToColorChannel);
            this.stPanel1.Controls.Add(this.tangentFormatCB);
            this.stPanel1.Controls.Add(this.chkTangents);
            this.stPanel1.Controls.Add(this.chkUseBoneWeights);
            this.stPanel1.Controls.Add(this.stLabel2);
            this.stPanel1.Controls.Add(this.stLabel3);
            this.stPanel1.Controls.Add(this.weightFormatCB);
            this.stPanel1.Controls.Add(this.chkUseNormals);
            this.stPanel1.Controls.Add(this.chkHasUv1);
            this.stPanel1.Controls.Add(this.stButton1);
            this.stPanel1.Controls.Add(this.chkUseBoneIndex);
            this.stPanel1.Controls.Add(this.materiialPresetCB);
            this.stPanel1.Controls.Add(this.chkUseColor1);
            this.stPanel1.Controls.Add(this.normalFormatCB);
            this.stPanel1.Controls.Add(this.positionFormatCB);
            this.stPanel1.Controls.Add(this.uv0FormatCB);
            this.stPanel1.Controls.Add(this.stCheckBox8);
            this.stPanel1.Controls.Add(this.color0FormatCB);
            this.stPanel1.Controls.Add(this.bitangentFormatCB);
            this.stPanel1.Controls.Add(this.boneFormatCB);
            this.stPanel1.Controls.Add(this.chkBitangents);
            this.stPanel1.Controls.Add(this.chkHasUv2);
            this.stPanel1.Controls.Add(this.color1FormatCB);
            this.stPanel1.Controls.Add(this.uv1FormatCB);
            this.stPanel1.Controls.Add(this.chkUseColor2);
            this.stPanel1.Location = new System.Drawing.Point(219, 190);
            this.stPanel1.Name = "stPanel1";
            this.stPanel1.Size = new System.Drawing.Size(378, 352);
            this.stPanel1.TabIndex = 36;
            // 
            // chkSetNormalsToColorChannel
            // 
            this.chkSetNormalsToColorChannel.AutoSize = true;
            this.chkSetNormalsToColorChannel.Location = new System.Drawing.Point(11, 282);
            this.chkSetNormalsToColorChannel.Name = "chkSetNormalsToColorChannel";
            this.chkSetNormalsToColorChannel.Size = new System.Drawing.Size(150, 16);
            this.chkSetNormalsToColorChannel.TabIndex = 41;
            this.chkSetNormalsToColorChannel.Text = "将法线设置为颜色通道2";
            this.chkSetNormalsToColorChannel.UseVisualStyleBackColor = true;
            this.chkSetNormalsToColorChannel.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // tangentFormatCB
            // 
            this.tangentFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.tangentFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.tangentFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.tangentFormatCB.FormattingEnabled = true;
            this.tangentFormatCB.IsReadOnly = false;
            this.tangentFormatCB.Location = new System.Drawing.Point(142, 121);
            this.tangentFormatCB.Name = "tangentFormatCB";
            this.tangentFormatCB.Size = new System.Drawing.Size(131, 20);
            this.tangentFormatCB.TabIndex = 40;
            this.tangentFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkTangents
            // 
            this.chkTangents.AutoSize = true;
            this.chkTangents.Location = new System.Drawing.Point(12, 123);
            this.chkTangents.Name = "chkTangents";
            this.chkTangents.Size = new System.Drawing.Size(72, 16);
            this.chkTangents.TabIndex = 39;
            this.chkTangents.Text = "使用切线";
            this.chkTangents.UseVisualStyleBackColor = true;
            this.chkTangents.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkUseBoneWeights
            // 
            this.chkUseBoneWeights.AutoSize = true;
            this.chkUseBoneWeights.Location = new System.Drawing.Point(11, 336);
            this.chkUseBoneWeights.Name = "chkUseBoneWeights";
            this.chkUseBoneWeights.Size = new System.Drawing.Size(96, 16);
            this.chkUseBoneWeights.TabIndex = 38;
            this.chkUseBoneWeights.Text = "使用骨骼权重";
            this.chkUseBoneWeights.UseVisualStyleBackColor = true;
            this.chkUseBoneWeights.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(140, 9);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(53, 12);
            this.stLabel3.TabIndex = 37;
            this.stLabel3.Text = "网格设置";
            // 
            // bitangentFormatCB
            // 
            this.bitangentFormatCB.BorderColor = System.Drawing.Color.Empty;
            this.bitangentFormatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.bitangentFormatCB.ButtonColor = System.Drawing.Color.Empty;
            this.bitangentFormatCB.FormattingEnabled = true;
            this.bitangentFormatCB.IsReadOnly = false;
            this.bitangentFormatCB.Location = new System.Drawing.Point(142, 152);
            this.bitangentFormatCB.Name = "bitangentFormatCB";
            this.bitangentFormatCB.Size = new System.Drawing.Size(131, 20);
            this.bitangentFormatCB.TabIndex = 27;
            this.bitangentFormatCB.SelectedIndexChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkBitangents
            // 
            this.chkBitangents.AutoSize = true;
            this.chkBitangents.Location = new System.Drawing.Point(12, 151);
            this.chkBitangents.Name = "chkBitangents";
            this.chkBitangents.Size = new System.Drawing.Size(84, 16);
            this.chkBitangents.TabIndex = 26;
            this.chkBitangents.Text = "使用副切线";
            this.chkBitangents.UseVisualStyleBackColor = true;
            this.chkBitangents.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stLabel4
            // 
            this.stLabel4.AutoSize = true;
            this.stLabel4.Location = new System.Drawing.Point(137, 10);
            this.stLabel4.Name = "stLabel4";
            this.stLabel4.Size = new System.Drawing.Size(53, 12);
            this.stLabel4.TabIndex = 38;
            this.stLabel4.Text = "全局设置";
            // 
            // rotateModel90YUD
            // 
            this.rotateModel90YUD.DecimalPlaces = 5;
            this.rotateModel90YUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.rotateModel90YUD.Location = new System.Drawing.Point(153, 69);
            this.rotateModel90YUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.rotateModel90YUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.rotateModel90YUD.Name = "rotateModel90YUD";
            this.rotateModel90YUD.Size = new System.Drawing.Size(120, 21);
            this.rotateModel90YUD.TabIndex = 39;
            this.rotateModel90YUD.ValueChanged += new System.EventHandler(this.numericUpDownFloat1_ValueChanged);
            // 
            // stLabel5
            // 
            this.stLabel5.AutoSize = true;
            this.stLabel5.Location = new System.Drawing.Point(13, 71);
            this.stLabel5.Name = "stLabel5";
            this.stLabel5.Size = new System.Drawing.Size(47, 12);
            this.stLabel5.TabIndex = 40;
            this.stLabel5.Text = "Y轴旋转";
            // 
            // stPanel2
            // 
            this.stPanel2.Controls.Add(this.chkResetTexTransforms);
            this.stPanel2.Controls.Add(this.chkMatchAttributes);
            this.stPanel2.Controls.Add(this.chkUseOriginalBones);
            this.stPanel2.Controls.Add(this.chkFlipUVsVertical);
            this.stPanel2.Controls.Add(this.stLabel1);
            this.stPanel2.Controls.Add(this.presetCB);
            this.stPanel2.Controls.Add(this.stLabel5);
            this.stPanel2.Controls.Add(this.stLabel4);
            this.stPanel2.Controls.Add(this.rotateModel90YUD);
            this.stPanel2.Location = new System.Drawing.Point(222, 29);
            this.stPanel2.Name = "stPanel2";
            this.stPanel2.Size = new System.Drawing.Size(375, 156);
            this.stPanel2.TabIndex = 41;
            // 
            // chkResetTexTransforms
            // 
            this.chkResetTexTransforms.AutoSize = true;
            this.chkResetTexTransforms.Location = new System.Drawing.Point(153, 124);
            this.chkResetTexTransforms.Name = "chkResetTexTransforms";
            this.chkResetTexTransforms.Size = new System.Drawing.Size(108, 16);
            this.chkResetTexTransforms.TabIndex = 45;
            this.chkResetTexTransforms.Text = "重置材质UV变换";
            this.chkResetTexTransforms.UseVisualStyleBackColor = true;
            this.chkResetTexTransforms.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // chkMatchAttributes
            // 
            this.chkMatchAttributes.AutoSize = true;
            this.chkMatchAttributes.Location = new System.Drawing.Point(9, 102);
            this.chkMatchAttributes.Name = "chkMatchAttributes";
            this.chkMatchAttributes.Size = new System.Drawing.Size(96, 16);
            this.chkMatchAttributes.TabIndex = 44;
            this.chkMatchAttributes.Text = "匹配原始属性";
            this.chkMatchAttributes.UseVisualStyleBackColor = true;
            this.chkMatchAttributes.CheckedChanged += new System.EventHandler(this.chkMatchAttributes_CheckedChanged);
            // 
            // chkUseOriginalBones
            // 
            this.chkUseOriginalBones.AutoSize = true;
            this.chkUseOriginalBones.Checked = true;
            this.chkUseOriginalBones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseOriginalBones.Location = new System.Drawing.Point(9, 124);
            this.chkUseOriginalBones.Name = "chkUseOriginalBones";
            this.chkUseOriginalBones.Size = new System.Drawing.Size(96, 16);
            this.chkUseOriginalBones.TabIndex = 43;
            this.chkUseOriginalBones.Text = "使用原始骨骼";
            this.chkUseOriginalBones.UseVisualStyleBackColor = true;
            // 
            // chkFlipUVsVertical
            // 
            this.chkFlipUVsVertical.AutoSize = true;
            this.chkFlipUVsVertical.Location = new System.Drawing.Point(157, 102);
            this.chkFlipUVsVertical.Name = "chkFlipUVsVertical";
            this.chkFlipUVsVertical.Size = new System.Drawing.Size(84, 16);
            this.chkFlipUVsVertical.TabIndex = 41;
            this.chkFlipUVsVertical.Text = "垂直翻转UV";
            this.chkFlipUVsVertical.UseVisualStyleBackColor = true;
            this.chkFlipUVsVertical.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // stButton2
            // 
            this.stButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.stButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton2.Location = new System.Drawing.Point(522, 548);
            this.stButton2.Name = "stButton2";
            this.stButton2.Size = new System.Drawing.Size(75, 21);
            this.stButton2.TabIndex = 42;
            this.stButton2.Text = "确定";
            this.stButton2.UseVisualStyleBackColor = false;
            // 
            // GFLXModelImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 576);
            this.Name = "GFLXModelImporter";
            this.Text = "GFBMDL导入器";
            this.contentContainer.ResumeLayout(false);
            this.stPanel1.ResumeLayout(false);
            this.stPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateModel90YUD)).EndInit();
            this.stPanel2.ResumeLayout(false);
            this.stPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbox.Library.Forms.STComboBox presetCB;
        private Toolbox.Library.Forms.STLabel stLabel1;
        private Toolbox.Library.Forms.STComboBox boneFormatCB;
        private Toolbox.Library.Forms.STComboBox color0FormatCB;
        private Toolbox.Library.Forms.STComboBox uv0FormatCB;
        private Toolbox.Library.Forms.STComboBox normalFormatCB;
        private Toolbox.Library.Forms.STCheckBox chkUseColor1;
        private Toolbox.Library.Forms.STCheckBox chkUseBoneIndex;
        private Toolbox.Library.Forms.STCheckBox chkHasUv1;
        private Toolbox.Library.Forms.STCheckBox chkUseNormals;
        private Toolbox.Library.Forms.STComboBox color1FormatCB;
        private Toolbox.Library.Forms.STCheckBox chkUseColor2;
        private Toolbox.Library.Forms.STComboBox uv1FormatCB;
        private Toolbox.Library.Forms.STCheckBox chkHasUv2;
        private Toolbox.Library.Forms.STComboBox positionFormatCB;
        private Toolbox.Library.Forms.STCheckBox stCheckBox8;
        private Toolbox.Library.Forms.STButton stButton1;
        private Toolbox.Library.Forms.STComboBox materiialPresetCB;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.ListViewCustom listViewCustom1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Toolbox.Library.Forms.STComboBox weightFormatCB;
        private Toolbox.Library.Forms.STLabel stLabel4;
        private Toolbox.Library.Forms.STPanel stPanel1;
        private Toolbox.Library.Forms.STLabel stLabel3;
        private Toolbox.Library.Forms.STLabel stLabel5;
        private Toolbox.Library.Forms.NumericUpDownFloat rotateModel90YUD;
        private Toolbox.Library.Forms.STCheckBox chkUseBoneWeights;
        private Toolbox.Library.Forms.STPanel stPanel2;
        private Toolbox.Library.Forms.STCheckBox chkFlipUVsVertical;
        private Toolbox.Library.Forms.STCheckBox chkUseOriginalBones;
        private Toolbox.Library.Forms.STButton stButton2;
        private Toolbox.Library.Forms.STComboBox tangentFormatCB;
        private Toolbox.Library.Forms.STCheckBox chkTangents;
        private Toolbox.Library.Forms.STCheckBox chkMatchAttributes;
        private Toolbox.Library.Forms.STCheckBox chkSetNormalsToColorChannel;
        private Toolbox.Library.Forms.STComboBox bitangentFormatCB;
        private Toolbox.Library.Forms.STCheckBox chkBitangents;
        private Toolbox.Library.Forms.STCheckBox chkResetTexTransforms;
    }
}