using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Web.WebView2.Core;

namespace BlogTool
{
    public partial class PreviewWindow : Form
    {
        public string FileToPreview;
        public PreviewWindow()
        {
            InitializeComponent();
        }
        async public void InitWebView()
        {
            await PreviewBrowser.EnsureCoreWebView2Async(null);
            if (PreviewBrowser.CoreWebView2 != null)
            {
                PreviewBrowser.CoreWebView2.Navigate(FileToPreview);
            }
            else
            {
                MessageBox.Show("Could not navigate to page");
            }
        }
        private void PreviewWindow_Load(object sender, EventArgs e)
        {
            InitWebView();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            if (PreviewBrowser.CoreWebView2 != null)
            {
                PreviewBrowser.CoreWebView2.Reload();
            }
        }
    }
}
