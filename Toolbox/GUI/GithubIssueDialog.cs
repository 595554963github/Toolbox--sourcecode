using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox.Library.Forms;
using Octokit;

namespace Toolbox
{
    public partial class GithubIssueDialog : STForm
    {
        public GithubIssueDialog()
        {
            InitializeComponent();

            typeCB.Items.Add("Bug");
            typeCB.Items.Add("Feature");

            typeCB.SelectedIndex = 0;
        }

        public void CreateIssue()
        {
            if (titleTB.Text == String.Empty) {
                MessageBox.Show("标题不能为空!", "问题对话框", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (titleTB.Text.Length < 5)
            {
                MessageBox.Show("标题太短!至少有5个或更多字符!", "问题对话框", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var client = new GitHubClient(new ProductHeaderValue("Switch-Toolbox"));
            var createIssue = new NewIssue(titleTB.Text);
            createIssue.Body = infoTB.Text;

            if (typeCB.GetSelectedText() == "Bug")
                createIssue.Labels.Add("bug");
            else
                createIssue.Labels.Add("enhancement");

            CreateIssue(client, createIssue).Wait();
        }

        static async Task CreateIssue(GitHubClient client, NewIssue createIssue)
        {
            var issue = await client.Issue.Create("fake", "test", createIssue);
        }

        private void titleTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
