namespace FirstPlugin
{
    partial class BfresLODMeshEditor
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
            this.meshListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.centXUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.label3 = new System.Windows.Forms.Label();
            this.centYUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.label4 = new System.Windows.Forms.Label();
            this.centZUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.extXUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.extYUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.extZUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.subMeshListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formatCB = new Toolbox.Library.Forms.STComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.faceTypeCB = new Toolbox.Library.Forms.STComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radiusUD = new Toolbox.Library.Forms.NumericUpDownFloat();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centZUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extZUD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUD)).BeginInit();
            this.SuspendLayout();
            // 
            // meshListView
            // 
            this.meshListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.meshListView.ForeColor = System.Drawing.Color.White;
            this.meshListView.HideSelection = false;
            this.meshListView.Location = new System.Drawing.Point(2, 2);
            this.meshListView.Name = "meshListView";
            this.meshListView.Size = new System.Drawing.Size(207, 282);
            this.meshListView.TabIndex = 0;
            this.meshListView.UseCompatibleStateImageBehavior = false;
            this.meshListView.View = System.Windows.Forms.View.List;
            this.meshListView.SelectedIndexChanged += new System.EventHandler(this.meshListView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "移除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(134, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.centXUD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.centYUD);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.centZUD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.extXUD);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.extYUD);
            this.panel2.Controls.Add(this.extZUD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(215, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 88);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 20);
            this.panel3.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = global::FirstPlugin.Properties.Resources.arrowMinimize_;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 20);
            this.button3.TabIndex = 1;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "边界";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "居中";
            // 
            // centXUD
            // 
            this.centXUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.centXUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.centXUD.DecimalPlaces = 5;
            this.centXUD.ForeColor = System.Drawing.Color.White;
            this.centXUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.centXUD.Location = new System.Drawing.Point(88, 38);
            this.centXUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.centXUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.centXUD.Name = "centXUD";
            this.centXUD.Size = new System.Drawing.Size(120, 17);
            this.centXUD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(69, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // centYUD
            // 
            this.centYUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.centYUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.centYUD.DecimalPlaces = 5;
            this.centYUD.ForeColor = System.Drawing.Color.White;
            this.centYUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.centYUD.Location = new System.Drawing.Point(234, 38);
            this.centYUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.centYUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.centYUD.Name = "centYUD";
            this.centYUD.Size = new System.Drawing.Size(120, 17);
            this.centYUD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(214, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // centZUD
            // 
            this.centZUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.centZUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.centZUD.DecimalPlaces = 5;
            this.centZUD.ForeColor = System.Drawing.Color.White;
            this.centZUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.centZUD.Location = new System.Drawing.Point(385, 38);
            this.centZUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.centZUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.centZUD.Name = "centZUD";
            this.centZUD.Size = new System.Drawing.Size(120, 17);
            this.centZUD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(365, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "范围";
            // 
            // extXUD
            // 
            this.extXUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.extXUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extXUD.DecimalPlaces = 5;
            this.extXUD.ForeColor = System.Drawing.Color.White;
            this.extXUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.extXUD.Location = new System.Drawing.Point(89, 60);
            this.extXUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.extXUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.extXUD.Name = "extXUD";
            this.extXUD.Size = new System.Drawing.Size(120, 17);
            this.extXUD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(69, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(366, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Z";
            // 
            // extYUD
            // 
            this.extYUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.extYUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extYUD.DecimalPlaces = 5;
            this.extYUD.ForeColor = System.Drawing.Color.White;
            this.extYUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.extYUD.Location = new System.Drawing.Point(235, 60);
            this.extYUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.extYUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.extYUD.Name = "extYUD";
            this.extYUD.Size = new System.Drawing.Size(120, 17);
            this.extYUD.TabIndex = 12;
            // 
            // extZUD
            // 
            this.extZUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.extZUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extZUD.DecimalPlaces = 5;
            this.extZUD.ForeColor = System.Drawing.Color.White;
            this.extZUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.extZUD.Location = new System.Drawing.Point(386, 60);
            this.extZUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.extZUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.extZUD.Name = "extZUD";
            this.extZUD.Size = new System.Drawing.Size(120, 17);
            this.extZUD.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(215, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.subMeshListView);
            this.panel1.Controls.Add(this.formatCB);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.faceTypeCB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.radiusUD);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(215, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 188);
            this.panel1.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "子网格";
            // 
            // subMeshListView
            // 
            this.subMeshListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.subMeshListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.subMeshListView.ForeColor = System.Drawing.Color.White;
            this.subMeshListView.HideSelection = false;
            this.subMeshListView.Location = new System.Drawing.Point(332, 26);
            this.subMeshListView.Name = "subMeshListView";
            this.subMeshListView.Size = new System.Drawing.Size(180, 179);
            this.subMeshListView.TabIndex = 29;
            this.subMeshListView.UseCompatibleStateImageBehavior = false;
            this.subMeshListView.View = System.Windows.Forms.View.Details;
            this.subMeshListView.SelectedIndexChanged += new System.EventHandler(this.subMeshListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "偏移";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "计数";
            this.columnHeader2.Width = 81;
            // 
            // formatCB
            // 
            this.formatCB.BorderColor = System.Drawing.Color.Empty;
            this.formatCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.formatCB.ButtonColor = System.Drawing.Color.Empty;
            this.formatCB.FormattingEnabled = true;
            this.formatCB.IsReadOnly = false;
            this.formatCB.Location = new System.Drawing.Point(74, 58);
            this.formatCB.Name = "formatCB";
            this.formatCB.Size = new System.Drawing.Size(121, 20);
            this.formatCB.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "格式";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "面数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "面类型";
            // 
            // faceTypeCB
            // 
            this.faceTypeCB.BorderColor = System.Drawing.Color.Empty;
            this.faceTypeCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.faceTypeCB.ButtonColor = System.Drawing.Color.Empty;
            this.faceTypeCB.FormattingEnabled = true;
            this.faceTypeCB.IsReadOnly = false;
            this.faceTypeCB.Location = new System.Drawing.Point(75, 85);
            this.faceTypeCB.Name = "faceTypeCB";
            this.faceTypeCB.Size = new System.Drawing.Size(121, 20);
            this.faceTypeCB.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 20);
            this.panel4.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Image = global::FirstPlugin.Properties.Resources.arrowMinimize_;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 20);
            this.button4.TabIndex = 1;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "细节层次网格";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "边界半径";
            // 
            // radiusUD
            // 
            this.radiusUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radiusUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.radiusUD.DecimalPlaces = 5;
            this.radiusUD.ForeColor = System.Drawing.Color.White;
            this.radiusUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.radiusUD.Location = new System.Drawing.Point(105, 123);
            this.radiusUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.radiusUD.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.radiusUD.Name = "radiusUD";
            this.radiusUD.Size = new System.Drawing.Size(120, 17);
            this.radiusUD.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(644, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 21);
            this.button5.TabIndex = 28;
            this.button5.Text = "好的";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BfresLODMeshEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(731, 315);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meshListView);
            this.Name = "BfresLODMeshEditor";
            this.Text = "细节层次网格";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centZUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extZUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView meshListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private Toolbox.Library.Forms.NumericUpDownFloat centXUD;
        private System.Windows.Forms.Label label3;
        private Toolbox.Library.Forms.NumericUpDownFloat centYUD;
        private System.Windows.Forms.Label label4;
        private Toolbox.Library.Forms.NumericUpDownFloat centZUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Toolbox.Library.Forms.NumericUpDownFloat extXUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Toolbox.Library.Forms.NumericUpDownFloat extYUD;
        private Toolbox.Library.Forms.NumericUpDownFloat extZUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView subMeshListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Toolbox.Library.Forms.STComboBox formatCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Toolbox.Library.Forms.STComboBox faceTypeCB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Toolbox.Library.Forms.NumericUpDownFloat radiusUD;
        private System.Windows.Forms.Button button5;
    }
}