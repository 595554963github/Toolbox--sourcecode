using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox.Library;

namespace Toolbox
{
    public partial class Startup_Window : Form
    {
        public Startup_Window()
        {
            InitializeComponent();

            CreateTipList();
            richTextBox1.Text = GetRandomTip();
        }
        List<string> Tips = new List<string>();
        private void CreateTipList()
        {
            Tips.Add("您可以通过右键单击树中的每个模型和纹理并单击“预览”来查看.bea文件中的每个模型和纹理.");
            Tips.Add("右键单击时,Bfres材料有一个复制选项,使用它可以轻松传输新材料!");
            Tips.Add("bfres中的大多数部分都可以导出和替换!");
            Tips.Add("对于MMSD和Splat oon,在材质编辑器中,如果在渲染信息中的 g sys_pass 设置为将一个对象密封在另一个对象之上，则可以防止冲突!");
        }
        private string GetRandomTip()
        {
            var shuffledTips = Tips.OrderBy(a => Guid.NewGuid()).ToList();
            return shuffledTips[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Runtime.OpenStartupWindow = !checkBox1.Checked;
            Config.Save();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string fileName = listView1.SelectedItems[0].Text;
                Close();
            }
        }
    }
}
