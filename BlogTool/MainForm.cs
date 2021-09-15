using System;
using System.Windows.Forms;

namespace BlogTool
{
    public partial class MainForm : Form
    {
        Blog CurrentBlog;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Main_ToolLab_Click(object sender, EventArgs e)
        {
            NewBlogPostPrompt NewPostPrompt = new NewBlogPostPrompt();
            NewPostPrompt.OnAccepted = OnNewBlog;

            NewPostPrompt.Show();
        }

        private void OnNewBlog(string InNewBlogName)
        {
            CurrentBlog = new Blog(InNewBlogName);
            Workspace.Enabled = true;

            Workspace.SelectedTab = SettingsTab;
        }
        private void StartDesigningButton_Click(object sender, EventArgs e)
        {
            CurrentBlog.OnTempBlogCreated = OnBlogCreated;

            CurrentBlog.StylesheetDir = StylesheetDir.GetDir();
            CurrentBlog.ScriptDir = ScriptsDir.GetDir();

            CurrentBlog.StartDesigning();
        }

        private void OnBlogCreated(string BlogFileLoc)
        {
            PreviewWindow Preview = new PreviewWindow();
            Preview.FileToPreview = BlogFileLoc;

            Preview.Show();
        }
    }
}
