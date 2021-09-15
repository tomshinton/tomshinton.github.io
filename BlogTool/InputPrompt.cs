using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogTool
{
    public partial class NewBlogPostPrompt : Form
    {
        public delegate void OnAcceptDelegate(string InNewBlogName);
        public OnAcceptDelegate OnAccepted;
        public NewBlogPostPrompt()
        {
            InitializeComponent();
        }

        private void NewBlogPostPrompt_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            OnAccepted.Invoke(BlogName_TextBox.Text);
            this.Close();
        }
    }
}
