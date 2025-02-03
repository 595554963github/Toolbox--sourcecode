namespace Toolbox.Library.Forms
{
    partial class STColorDialog
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
            this.stPanel1 = new Toolbox.Library.Forms.STPanel();
            this.hexTB = new Toolbox.Library.Forms.STTextBox();
            this.stLabel7 = new Toolbox.Library.Forms.STLabel();
            this.stLabel6 = new Toolbox.Library.Forms.STLabel();
            this.stLabel5 = new Toolbox.Library.Forms.STLabel();
            this.stLabel4 = new Toolbox.Library.Forms.STLabel();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.alphaUD = new Toolbox.Library.Forms.NumericUpDownUint();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.blueUD = new Toolbox.Library.Forms.NumericUpDownUint();
            this.greenUD = new Toolbox.Library.Forms.NumericUpDownUint();
            this.redUD = new Toolbox.Library.Forms.NumericUpDownUint();
            this.alphaPB = new System.Windows.Forms.PictureBox();
            this.colorPB = new System.Windows.Forms.PictureBox();
            this.colorSelector1 = new Toolbox.Library.Forms.ColorSelector();
            this.stPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // stPanel1
            // 
            this.stPanel1.Controls.Add(this.hexTB);
            this.stPanel1.Controls.Add(this.stLabel7);
            this.stPanel1.Controls.Add(this.stLabel6);
            this.stPanel1.Controls.Add(this.stLabel5);
            this.stPanel1.Controls.Add(this.stLabel4);
            this.stPanel1.Controls.Add(this.stLabel3);
            this.stPanel1.Controls.Add(this.stLabel2);
            this.stPanel1.Controls.Add(this.alphaUD);
            this.stPanel1.Controls.Add(this.stLabel1);
            this.stPanel1.Controls.Add(this.blueUD);
            this.stPanel1.Controls.Add(this.greenUD);
            this.stPanel1.Controls.Add(this.redUD);
            this.stPanel1.Controls.Add(this.alphaPB);
            this.stPanel1.Controls.Add(this.colorPB);
            this.stPanel1.Controls.Add(this.colorSelector1);
            this.stPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel1.Location = new System.Drawing.Point(0, 0);
            this.stPanel1.Name = "stPanel1";
            this.stPanel1.Size = new System.Drawing.Size(389, 258);
            this.stPanel1.TabIndex = 1;
            // 
            // hexTB
            // 
            this.hexTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexTB.Location = new System.Drawing.Point(286, 210);
            this.hexTB.Name = "hexTB";
            this.hexTB.Size = new System.Drawing.Size(100, 21);
            this.hexTB.TabIndex = 16;
            this.hexTB.TextChanged += new System.EventHandler(this.stTextBox1_TextChanged);
            // 
            // stLabel7
            // 
            this.stLabel7.AutoSize = true;
            this.stLabel7.Location = new System.Drawing.Point(281, 56);
            this.stLabel7.Name = "stLabel7";
            this.stLabel7.Size = new System.Drawing.Size(41, 12);
            this.stLabel7.TabIndex = 15;
            this.stLabel7.Text = "透明度";
            // 
            // stLabel6
            // 
            this.stLabel6.AutoSize = true;
            this.stLabel6.Location = new System.Drawing.Point(281, 18);
            this.stLabel6.Name = "stLabel6";
            this.stLabel6.Size = new System.Drawing.Size(29, 12);
            this.stLabel6.TabIndex = 14;
            this.stLabel6.Text = "颜色";
            // 
            // stLabel5
            // 
            this.stLabel5.AutoSize = true;
            this.stLabel5.Location = new System.Drawing.Point(291, 195);
            this.stLabel5.Name = "stLabel5";
            this.stLabel5.Size = new System.Drawing.Size(41, 12);
            this.stLabel5.TabIndex = 13;
            this.stLabel5.Text = "16进制";
            // 
            // stLabel4
            // 
            this.stLabel4.AutoSize = true;
            this.stLabel4.Location = new System.Drawing.Point(263, 173);
            this.stLabel4.Name = "stLabel4";
            this.stLabel4.Size = new System.Drawing.Size(11, 12);
            this.stLabel4.TabIndex = 11;
            this.stLabel4.Text = "A";
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(263, 149);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(11, 12);
            this.stLabel3.TabIndex = 10;
            this.stLabel3.Text = "B";
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(263, 125);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(11, 12);
            this.stLabel2.TabIndex = 9;
            this.stLabel2.Text = "G";
            // 
            // alphaUD
            // 
            this.alphaUD.Location = new System.Drawing.Point(284, 171);
            this.alphaUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaUD.Name = "alphaUD";
            this.alphaUD.Size = new System.Drawing.Size(93, 21);
            this.alphaUD.TabIndex = 8;
            this.alphaUD.ValueChanged += new System.EventHandler(this.UD_ValueChanged);
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(263, 101);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(11, 12);
            this.stLabel1.TabIndex = 7;
            this.stLabel1.Text = "R";
            // 
            // blueUD
            // 
            this.blueUD.Location = new System.Drawing.Point(284, 147);
            this.blueUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueUD.Name = "blueUD";
            this.blueUD.Size = new System.Drawing.Size(93, 21);
            this.blueUD.TabIndex = 6;
            this.blueUD.ValueChanged += new System.EventHandler(this.UD_ValueChanged);
            // 
            // greenUD
            // 
            this.greenUD.Location = new System.Drawing.Point(284, 123);
            this.greenUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenUD.Name = "greenUD";
            this.greenUD.Size = new System.Drawing.Size(93, 21);
            this.greenUD.TabIndex = 5;
            this.greenUD.ValueChanged += new System.EventHandler(this.UD_ValueChanged);
            // 
            // redUD
            // 
            this.redUD.Location = new System.Drawing.Point(284, 99);
            this.redUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redUD.Name = "redUD";
            this.redUD.Size = new System.Drawing.Size(93, 21);
            this.redUD.TabIndex = 4;
            this.redUD.ValueChanged += new System.EventHandler(this.UD_ValueChanged);
            // 
            // alphaPB
            // 
            this.alphaPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaPB.Location = new System.Drawing.Point(338, 44);
            this.alphaPB.Name = "alphaPB";
            this.alphaPB.Size = new System.Drawing.Size(39, 36);
            this.alphaPB.TabIndex = 2;
            this.alphaPB.TabStop = false;
            // 
            // colorPB
            // 
            this.colorPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPB.Location = new System.Drawing.Point(338, 3);
            this.colorPB.Name = "colorPB";
            this.colorPB.Size = new System.Drawing.Size(39, 36);
            this.colorPB.TabIndex = 1;
            this.colorPB.TabStop = false;
            // 
            // colorSelector1
            // 
            this.colorSelector1.Alpha = 0;
            this.colorSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSelector1.Color = System.Drawing.Color.Empty;
            this.colorSelector1.DisplayAlpha = true;
            this.colorSelector1.DisplayColor = true;
            this.colorSelector1.Location = new System.Drawing.Point(3, 3);
            this.colorSelector1.Name = "colorSelector1";
            this.colorSelector1.Size = new System.Drawing.Size(254, 255);
            this.colorSelector1.TabIndex = 0;
            this.colorSelector1.ColorChanged += new System.EventHandler(this.colorSelector1_ColorChanged);
            // 
            // STColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 258);
            this.Controls.Add(this.stPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "STColorDialog";
            this.Deactivate += new System.EventHandler(this.STColorDialog_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.STColorDialog_FormClosed);
            this.Load += new System.EventHandler(this.STColorDialog_Load);
            this.stPanel1.ResumeLayout(false);
            this.stPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ColorSelector colorSelector1;
        private STPanel stPanel1;
        private System.Windows.Forms.PictureBox colorPB;
        private System.Windows.Forms.PictureBox alphaPB;
        private NumericUpDownUint blueUD;
        private NumericUpDownUint greenUD;
        private NumericUpDownUint redUD;
        private STLabel stLabel4;
        private STLabel stLabel3;
        private STLabel stLabel2;
        private NumericUpDownUint alphaUD;
        private STLabel stLabel1;
        private STLabel stLabel7;
        private STLabel stLabel6;
        private STLabel stLabel5;
        private STTextBox hexTB;
    }
}
