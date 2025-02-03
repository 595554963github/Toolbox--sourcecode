namespace LayoutBXLYT
{
    partial class LytKeyVisibiltyPane
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
            this.alphaSelectorHorizontalPanel1 = new Toolbox.Library.Forms.AlphaSelectorHorizontalPanel();
            this.stLabel6 = new Toolbox.Library.Forms.STLabel();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.paneVisibleChkBox = new Toolbox.Library.Forms.STCheckBox();
            this.alphaUD = new BarSlider.BarSlider();
            this.SuspendLayout();
            // 
            // alphaSelectorHorizontalPanel1
            // 
            this.alphaSelectorHorizontalPanel1.Alpha = 0;
            this.alphaSelectorHorizontalPanel1.Location = new System.Drawing.Point(81, 66);
            this.alphaSelectorHorizontalPanel1.Name = "alphaSelectorHorizontalPanel1";
            this.alphaSelectorHorizontalPanel1.Size = new System.Drawing.Size(176, 31);
            this.alphaSelectorHorizontalPanel1.TabIndex = 45;
            // 
            // stLabel6
            // 
            this.stLabel6.AutoSize = true;
            this.stLabel6.Location = new System.Drawing.Point(24, 77);
            this.stLabel6.Name = "stLabel6";
            this.stLabel6.Size = new System.Drawing.Size(41, 12);
            this.stLabel6.TabIndex = 44;
            this.stLabel6.Text = "透明度";
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(12, 34);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(53, 12);
            this.stLabel2.TabIndex = 43;
            this.stLabel2.Text = "面板可见";
            // 
            // paneVisibleChkBox
            // 
            this.paneVisibleChkBox.AutoSize = true;
            this.paneVisibleChkBox.Location = new System.Drawing.Point(81, 34);
            this.paneVisibleChkBox.Name = "paneVisibleChkBox";
            this.paneVisibleChkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paneVisibleChkBox.Size = new System.Drawing.Size(15, 14);
            this.paneVisibleChkBox.TabIndex = 42;
            this.paneVisibleChkBox.UseVisualStyleBackColor = true;
            // 
            // alphaUD
            // 
            this.alphaUD.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.alphaUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.alphaUD.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.alphaUD.BarPenColorBottom = System.Drawing.Color.Empty;
            this.alphaUD.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.alphaUD.BarPenColorTop = System.Drawing.Color.Empty;
            this.alphaUD.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.alphaUD.DataType = null;
            this.alphaUD.DrawSemitransparentThumb = false;
            this.alphaUD.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alphaUD.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.alphaUD.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.alphaUD.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.alphaUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.alphaUD.IncrementAmount = 0.01F;
            this.alphaUD.InputName = "A";
            this.alphaUD.LargeChange = 5F;
            this.alphaUD.Location = new System.Drawing.Point(259, 66);
            this.alphaUD.Maximum = 300000F;
            this.alphaUD.Minimum = -300000F;
            this.alphaUD.Name = "alphaUD";
            this.alphaUD.Precision = 0.01F;
            this.alphaUD.ScaleDivisions = 1;
            this.alphaUD.ScaleSubDivisions = 2;
            this.alphaUD.ShowDivisionsText = false;
            this.alphaUD.ShowSmallScale = false;
            this.alphaUD.Size = new System.Drawing.Size(84, 23);
            this.alphaUD.SmallChange = 0.01F;
            this.alphaUD.TabIndex = 46;
            this.alphaUD.Text = "rotXUD";
            this.alphaUD.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alphaUD.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alphaUD.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.alphaUD.ThumbSize = new System.Drawing.Size(1, 1);
            this.alphaUD.TickAdd = 0F;
            this.alphaUD.TickColor = System.Drawing.Color.White;
            this.alphaUD.TickDivide = 0F;
            this.alphaUD.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaUD.UseInterlapsedBar = false;
            this.alphaUD.Value = 30F;
            // 
            // LytKeyVisibiltyPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alphaUD);
            this.Controls.Add(this.alphaSelectorHorizontalPanel1);
            this.Controls.Add(this.stLabel6);
            this.Controls.Add(this.stLabel2);
            this.Controls.Add(this.paneVisibleChkBox);
            this.Name = "LytKeyVisibiltyPane";
            this.Size = new System.Drawing.Size(346, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toolbox.Library.Forms.AlphaSelectorHorizontalPanel alphaSelectorHorizontalPanel1;
        private Toolbox.Library.Forms.STLabel stLabel6;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.STCheckBox paneVisibleChkBox;
        private BarSlider.BarSlider alphaUD;
    }
}
