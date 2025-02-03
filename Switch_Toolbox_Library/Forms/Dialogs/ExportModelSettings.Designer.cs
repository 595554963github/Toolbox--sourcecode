namespace Toolbox.Library.Forms
{
    partial class ExportModelSettings
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
            this.exportTexturesChkBox = new Toolbox.Library.Forms.STCheckBox();
            this.stButton1 = new Toolbox.Library.Forms.STButton();
            this.stButton2 = new Toolbox.Library.Forms.STButton();
            this.chkFlipUvsVertical = new Toolbox.Library.Forms.STCheckBox();
            this.chkOldExporter = new Toolbox.Library.Forms.STCheckBox();
            this.chkVertexColors = new Toolbox.Library.Forms.STCheckBox();
            this.chkExportRiggedBonesOnly = new Toolbox.Library.Forms.STCheckBox();
            this.chkApplyUVTransforms = new Toolbox.Library.Forms.STCheckBox();
            this.chkTextureChannelComps = new Toolbox.Library.Forms.STCheckBox();
            this.contentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.Controls.Add(this.chkTextureChannelComps);
            this.contentContainer.Controls.Add(this.chkApplyUVTransforms);
            this.contentContainer.Controls.Add(this.chkExportRiggedBonesOnly);
            this.contentContainer.Controls.Add(this.chkVertexColors);
            this.contentContainer.Controls.Add(this.chkOldExporter);
            this.contentContainer.Controls.Add(this.chkFlipUvsVertical);
            this.contentContainer.Controls.Add(this.stButton2);
            this.contentContainer.Controls.Add(this.stButton1);
            this.contentContainer.Controls.Add(this.exportTexturesChkBox);
            this.contentContainer.Size = new System.Drawing.Size(338, 246);
            this.contentContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.contentContainer_Paint);
            this.contentContainer.Controls.SetChildIndex(this.exportTexturesChkBox, 0);
            this.contentContainer.Controls.SetChildIndex(this.stButton1, 0);
            this.contentContainer.Controls.SetChildIndex(this.stButton2, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkFlipUvsVertical, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkOldExporter, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkVertexColors, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkExportRiggedBonesOnly, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkApplyUVTransforms, 0);
            this.contentContainer.Controls.SetChildIndex(this.chkTextureChannelComps, 0);
            // 
            // exportTexturesChkBox
            // 
            this.exportTexturesChkBox.AutoSize = true;
            this.exportTexturesChkBox.Checked = true;
            this.exportTexturesChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportTexturesChkBox.Location = new System.Drawing.Point(23, 43);
            this.exportTexturesChkBox.Name = "exportTexturesChkBox";
            this.exportTexturesChkBox.Size = new System.Drawing.Size(72, 16);
            this.exportTexturesChkBox.TabIndex = 11;
            this.exportTexturesChkBox.Text = "导出纹理";
            this.exportTexturesChkBox.UseVisualStyleBackColor = true;
            this.exportTexturesChkBox.CheckedChanged += new System.EventHandler(this.exportTexturesChkBox_CheckedChanged);
            // 
            // stButton1
            // 
            this.stButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton1.Location = new System.Drawing.Point(254, 217);
            this.stButton1.Name = "stButton1";
            this.stButton1.Size = new System.Drawing.Size(75, 21);
            this.stButton1.TabIndex = 12;
            this.stButton1.Text = "取消";
            this.stButton1.UseVisualStyleBackColor = false;
            // 
            // stButton2
            // 
            this.stButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.stButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton2.Location = new System.Drawing.Point(173, 217);
            this.stButton2.Name = "stButton2";
            this.stButton2.Size = new System.Drawing.Size(75, 21);
            this.stButton2.TabIndex = 13;
            this.stButton2.Text = "好的";
            this.stButton2.UseVisualStyleBackColor = false;
            // 
            // chkFlipUvsVertical
            // 
            this.chkFlipUvsVertical.AutoSize = true;
            this.chkFlipUvsVertical.Location = new System.Drawing.Point(23, 135);
            this.chkFlipUvsVertical.Name = "chkFlipUvsVertical";
            this.chkFlipUvsVertical.Size = new System.Drawing.Size(90, 16);
            this.chkFlipUvsVertical.TabIndex = 14;
            this.chkFlipUvsVertical.Text = "Flp UVs垂直";
            this.chkFlipUvsVertical.UseVisualStyleBackColor = true;
            this.chkFlipUvsVertical.CheckedChanged += new System.EventHandler(this.chkFlipUvsVertical_CheckedChanged);
            // 
            // chkOldExporter
            // 
            this.chkOldExporter.AutoSize = true;
            this.chkOldExporter.Location = new System.Drawing.Point(23, 157);
            this.chkOldExporter.Name = "chkOldExporter";
            this.chkOldExporter.Size = new System.Drawing.Size(216, 16);
            this.chkOldExporter.TabIndex = 15;
            this.chkOldExporter.Text = "使用旧导出器（如果新导出器坏了）";
            this.chkOldExporter.UseVisualStyleBackColor = true;
            this.chkOldExporter.CheckedChanged += new System.EventHandler(this.stCheckBox1_CheckedChanged);
            // 
            // chkVertexColors
            // 
            this.chkVertexColors.AutoSize = true;
            this.chkVertexColors.Checked = true;
            this.chkVertexColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVertexColors.Location = new System.Drawing.Point(23, 65);
            this.chkVertexColors.Name = "chkVertexColors";
            this.chkVertexColors.Size = new System.Drawing.Size(96, 16);
            this.chkVertexColors.TabIndex = 16;
            this.chkVertexColors.Text = "导出顶点颜色";
            this.chkVertexColors.UseVisualStyleBackColor = true;
            this.chkVertexColors.CheckedChanged += new System.EventHandler(this.chkVertexColors_CheckedChanged);
            // 
            // chkExportRiggedBonesOnly
            // 
            this.chkExportRiggedBonesOnly.AutoSize = true;
            this.chkExportRiggedBonesOnly.Enabled = false;
            this.chkExportRiggedBonesOnly.Location = new System.Drawing.Point(23, 86);
            this.chkExportRiggedBonesOnly.Name = "chkExportRiggedBonesOnly";
            this.chkExportRiggedBonesOnly.Size = new System.Drawing.Size(120, 16);
            this.chkExportRiggedBonesOnly.TabIndex = 17;
            this.chkExportRiggedBonesOnly.Text = "仅导出绑定的骨骼";
            this.chkExportRiggedBonesOnly.UseVisualStyleBackColor = true;
            this.chkExportRiggedBonesOnly.CheckedChanged += new System.EventHandler(this.chkExportRiggedBonesOnly_CheckedChanged);
            // 
            // chkApplyUVTransforms
            // 
            this.chkApplyUVTransforms.AutoSize = true;
            this.chkApplyUVTransforms.Location = new System.Drawing.Point(23, 107);
            this.chkApplyUVTransforms.Name = "chkApplyUVTransforms";
            this.chkApplyUVTransforms.Size = new System.Drawing.Size(156, 16);
            this.chkApplyUVTransforms.TabIndex = 18;
            this.chkApplyUVTransforms.Text = "仅针对漫反射应用UV变换";
            this.chkApplyUVTransforms.UseVisualStyleBackColor = true;
            this.chkApplyUVTransforms.CheckedChanged += new System.EventHandler(this.chkApplyUVTransforms_CheckedChanged);
            // 
            // chkTextureChannelComps
            // 
            this.chkTextureChannelComps.AutoSize = true;
            this.chkTextureChannelComps.Checked = true;
            this.chkTextureChannelComps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTextureChannelComps.Location = new System.Drawing.Point(153, 43);
            this.chkTextureChannelComps.Name = "chkTextureChannelComps";
            this.chkTextureChannelComps.Size = new System.Drawing.Size(120, 16);
            this.chkTextureChannelComps.TabIndex = 19;
            this.chkTextureChannelComps.Text = "使用纹理通道交换";
            this.chkTextureChannelComps.UseVisualStyleBackColor = true;
            this.chkTextureChannelComps.CheckedChanged += new System.EventHandler(this.chkTextureChannelComps_CheckedChanged);
            // 
            // ExportModelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 251);
            this.Name = "ExportModelSettings";
            this.Text = "导出设置";
            this.contentContainer.ResumeLayout(false);
            this.contentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private STCheckBox exportTexturesChkBox;
        private STButton stButton2;
        private STButton stButton1;
        private STCheckBox chkFlipUvsVertical;
        protected STCheckBox chkOldExporter;
        private STCheckBox chkVertexColors;
        private STCheckBox chkExportRiggedBonesOnly;
        private STCheckBox chkApplyUVTransforms;
        private STCheckBox chkTextureChannelComps;
    }
}