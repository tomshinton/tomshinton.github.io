using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogTool
{
    public partial class FileBrowser : UserControl
    {
        public string FileDesc
        {
            get
            {
                return (FileDescLabel.Text);
            }
            set
            {
                FileDescLabel.Text = value;
            }
        }

        public delegate void OnFileSelectedDelegate(string s);
        public OnFileSelectedDelegate OnFileSelected;
        public FileBrowser()
        {
            InitializeComponent();
        }

        public string GetDir()
        {
            return LocationString.Text;
        }
        private void LocationString_TextChanged(object sender, EventArgs e)
        {

        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult Result = folderDlg.ShowDialog();
            if(Result == DialogResult.OK)
            {
                LocationString.Text = folderDlg.SelectedPath;

                if(OnFileSelected != null)
                {
                    OnFileSelected.Invoke(folderDlg.SelectedPath);
                }
            }
        }
    }
}
