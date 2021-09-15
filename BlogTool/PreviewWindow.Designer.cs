namespace BlogTool
{
    partial class PreviewWindow
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
            this.PreviewBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewBrowser
            // 
            this.PreviewBrowser.CreationProperties = null;
            this.PreviewBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.PreviewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewBrowser.Location = new System.Drawing.Point(0, 0);
            this.PreviewBrowser.Name = "PreviewBrowser";
            this.PreviewBrowser.Size = new System.Drawing.Size(916, 479);
            this.PreviewBrowser.TabIndex = 0;
            this.PreviewBrowser.ZoomFactor = 1D;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PreviewBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Refresh_Button);
            this.splitContainer1.Size = new System.Drawing.Size(916, 508);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 1;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Refresh_Button.Location = new System.Drawing.Point(0, 0);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(916, 25);
            this.Refresh_Button.TabIndex = 0;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // PreviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 508);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PreviewWindow";
            this.Text = "Blog Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PreviewWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBrowser)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 PreviewBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Refresh_Button;
    }
}