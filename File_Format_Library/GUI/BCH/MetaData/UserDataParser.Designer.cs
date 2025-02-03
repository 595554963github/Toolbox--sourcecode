namespace FirstPlugin.CtrLibrary.Forms
{
    partial class BCHUserDataParser
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
            this.nameTB = new Toolbox.Library.Forms.STTextBox();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.typeCB = new Toolbox.Library.Forms.STComboBox();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.valueTB = new System.Windows.Forms.RichTextBox();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.btnCancel = new Toolbox.Library.Forms.STButton();
            this.btnOk = new Toolbox.Library.Forms.STButton();
            this.contentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.Controls.Add(this.btnOk);
            this.contentContainer.Controls.Add(this.btnCancel);
            this.contentContainer.Controls.Add(this.stLabel3);
            this.contentContainer.Controls.Add(this.valueTB);
            this.contentContainer.Controls.Add(this.stLabel2);
            this.contentContainer.Controls.Add(this.typeCB);
            this.contentContainer.Controls.Add(this.stLabel1);
            this.contentContainer.Controls.Add(this.nameTB);
            this.contentContainer.Size = new System.Drawing.Size(314, 379);
            this.contentContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.contentContainer_Paint);
            this.contentContainer.Controls.SetChildIndex(this.nameTB, 0);
            this.contentContainer.Controls.SetChildIndex(this.stLabel1, 0);
            this.contentContainer.Controls.SetChildIndex(this.typeCB, 0);
            this.contentContainer.Controls.SetChildIndex(this.stLabel2, 0);
            this.contentContainer.Controls.SetChildIndex(this.valueTB, 0);
            this.contentContainer.Controls.SetChildIndex(this.stLabel3, 0);
            this.contentContainer.Controls.SetChildIndex(this.btnCancel, 0);
            this.contentContainer.Controls.SetChildIndex(this.btnOk, 0);
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTB.Location = new System.Drawing.Point(62, 33);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(243, 21);
            this.nameTB.TabIndex = 11;
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(9, 36);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(35, 12);
            this.stLabel1.TabIndex = 12;
            this.stLabel1.Text = "名称:";
            // 
            // typeCB
            // 
            this.typeCB.BorderColor = System.Drawing.Color.Empty;
            this.typeCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.typeCB.ButtonColor = System.Drawing.Color.Empty;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.IsReadOnly = false;
            this.typeCB.Location = new System.Drawing.Point(62, 72);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(136, 20);
            this.typeCB.TabIndex = 13;
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(9, 75);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(35, 12);
            this.stLabel2.TabIndex = 14;
            this.stLabel2.Text = "类型:";
            // 
            // valueTB
            // 
            this.valueTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTB.BackColor = System.Drawing.Color.White;
            this.valueTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTB.Location = new System.Drawing.Point(12, 109);
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(293, 236);
            this.valueTB.TabIndex = 15;
            this.valueTB.Text = "";
            this.valueTB.TextChanged += new System.EventHandler(this.valueTB_TextChanged);
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(9, 94);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(107, 12);
            this.stLabel3.TabIndex = 16;
            this.stLabel3.Text = "值:(每行输入一个)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(229, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(148, 350);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 21);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // BCHUserDataParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 384);
            this.Name = "BCHUserDataParser";
            this.Text = "用户数据";
            this.contentContainer.ResumeLayout(false);
            this.contentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbox.Library.Forms.STTextBox nameTB;
        private Toolbox.Library.Forms.STLabel stLabel3;
        private System.Windows.Forms.RichTextBox valueTB;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.STComboBox typeCB;
        private Toolbox.Library.Forms.STLabel stLabel1;
        private Toolbox.Library.Forms.STButton btnOk;
        private Toolbox.Library.Forms.STButton btnCancel;
    }
}