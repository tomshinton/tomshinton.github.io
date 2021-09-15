namespace BlogTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolMainStrip = new System.Windows.Forms.ToolStrip();
            this.Main_ToolLab = new System.Windows.Forms.ToolStripLabel();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.Workspace = new System.Windows.Forms.TabControl();
            this.DesignerTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.StartDesigningButton = new System.Windows.Forms.Button();
            this.StylesheetDir = new BlogTool.FileBrowser();
            this.ScriptsDir = new BlogTool.FileBrowser();
            this.ToolMainStrip.SuspendLayout();
            this.Workspace.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolMainStrip
            // 
            this.ToolMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolLab,
            this.SaveButton});
            this.ToolMainStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolMainStrip.Name = "ToolMainStrip";
            this.ToolMainStrip.Size = new System.Drawing.Size(1209, 25);
            this.ToolMainStrip.TabIndex = 0;
            this.ToolMainStrip.Text = "toolStrip1";
            // 
            // Main_ToolLab
            // 
            this.Main_ToolLab.Name = "Main_ToolLab";
            this.Main_ToolLab.Size = new System.Drawing.Size(61, 22);
            this.Main_ToolLab.Text = "New Entry";
            this.Main_ToolLab.Click += new System.EventHandler(this.Main_ToolLab_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "SaveBlog";
            // 
            // Workspace
            // 
            this.Workspace.Controls.Add(this.DesignerTab);
            this.Workspace.Controls.Add(this.SettingsTab);
            this.Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workspace.Enabled = false;
            this.Workspace.Location = new System.Drawing.Point(0, 25);
            this.Workspace.Name = "Workspace";
            this.Workspace.SelectedIndex = 0;
            this.Workspace.Size = new System.Drawing.Size(1209, 523);
            this.Workspace.TabIndex = 1;
            // 
            // DesignerTab
            // 
            this.DesignerTab.Location = new System.Drawing.Point(4, 22);
            this.DesignerTab.Name = "DesignerTab";
            this.DesignerTab.Padding = new System.Windows.Forms.Padding(3);
            this.DesignerTab.Size = new System.Drawing.Size(1201, 497);
            this.DesignerTab.TabIndex = 0;
            this.DesignerTab.Text = "Designer";
            this.DesignerTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.SettingsPanel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(1201, 497);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.ScriptsDir);
            this.SettingsPanel.Controls.Add(this.StylesheetDir);
            this.SettingsPanel.Controls.Add(this.StartDesigningButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1195, 491);
            this.SettingsPanel.TabIndex = 1;
            // 
            // StartDesigningButton
            // 
            this.StartDesigningButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartDesigningButton.Location = new System.Drawing.Point(0, 446);
            this.StartDesigningButton.Name = "StartDesigningButton";
            this.StartDesigningButton.Size = new System.Drawing.Size(1195, 45);
            this.StartDesigningButton.TabIndex = 1;
            this.StartDesigningButton.Text = "Start Editing";
            this.StartDesigningButton.UseVisualStyleBackColor = true;
            this.StartDesigningButton.Click += new System.EventHandler(this.StartDesigningButton_Click);
            // 
            // StylesheetDir
            // 
            this.StylesheetDir.AutoSize = true;
            this.StylesheetDir.FileDesc = "Stylesheets";
            this.StylesheetDir.Location = new System.Drawing.Point(0, 0);
            this.StylesheetDir.Name = "StylesheetDir";
            this.StylesheetDir.Size = new System.Drawing.Size(430, 27);
            this.StylesheetDir.TabIndex = 0;
            // 
            // ScriptsDir
            // 
            this.ScriptsDir.AutoSize = true;
            this.ScriptsDir.FileDesc = "Scripts";
            this.ScriptsDir.Location = new System.Drawing.Point(0, 33);
            this.ScriptsDir.Name = "ScriptsDir";
            this.ScriptsDir.Size = new System.Drawing.Size(430, 27);
            this.ScriptsDir.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 548);
            this.Controls.Add(this.Workspace);
            this.Controls.Add(this.ToolMainStrip);
            this.Name = "MainForm";
            this.Text = "Blog Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ToolMainStrip.ResumeLayout(false);
            this.ToolMainStrip.PerformLayout();
            this.Workspace.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolMainStrip;
        private System.Windows.Forms.ToolStripLabel Main_ToolLab;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.TabControl Workspace;
        private System.Windows.Forms.TabPage DesignerTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button StartDesigningButton;
        private FileBrowser StylesheetDir;
        private FileBrowser ScriptsDir;
    }
}

