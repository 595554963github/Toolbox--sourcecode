using GL_EditorFramework.EditorDrawables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox.Library;
using Toolbox.Library.IO;

namespace FirstPlugin
{
    internal class TexToGoFolder : STTextureFolder
    {
        private MeshCodec MeshCodec;

        public TexToGoFolder(MeshCodec codec) : base("TexToGo")
        {
            MeshCodec = codec;
            foreach (var tex in MeshCodec.TextureList)
                Nodes.Add(tex);
        }

        public override ToolStripItem[] GetContextMenuItems()
        {
            List<ToolStripItem> Items = new List<ToolStripItem>();
            Items.Add(new ToolStripMenuItem("保存编辑过的纹理", null, (o, e) => SaveEdited(), Keys.Control | Keys.E));
            Items.Add(new ToolStripSeparator());
            Items.AddRange(base.GetContextMenuItems());
            Items.Add(new ToolStripSeparator());
            Items.Add(new ToolStripMenuItem("导入TXTG", null, (o, e) => AddTexture(), Keys.Control | Keys.E));

            return Items.ToArray();
        }

        public void SaveEdited()
        {
            if (MeshCodec.TextureList.Count == 0)
                return;

            var folder = System.IO.Path.GetDirectoryName(MeshCodec.TextureList[0].FilePath);
            FolderSelectDialog dlg = new FolderSelectDialog(folder);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (var tex in MeshCodec.TextureList)
                    if (tex.IsEdited)
                        STFileSaver.SaveFileFormat(tex, System.IO.Path.Combine(dlg.SelectedPath, $"{tex.Text}.txtg"), false);
            }
        }

        private void AddTexture()
        {
            Dictionary<string, string> extensions = new Dictionary<string, string>();
            extensions.Add(".txtg", "Tex To Go");

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = FileFilters.GetCompleteFilter(extensions);

            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddTexture(ofd.FileName);
            }
        }

        private void AddTexture(string filePath)
        {
            TXTG txtg = STFileLoader.OpenFileFormat(filePath) as TXTG;
            if (txtg == null) 
            {
                MessageBox.Show($"文件{filePath}不是一个有效的TXTG文件!");
                return;
            }
            this.MeshCodec.TextureList.Add(txtg);
            Nodes.Add(txtg);
        }
    }
}
