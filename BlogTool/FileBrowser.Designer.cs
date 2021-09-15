namespace BlogTool
{
    partial class FileBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationString = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileDescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LocationString
            // 
            this.LocationString.Location = new System.Drawing.Point(97, 4);
            this.LocationString.Name = "LocationString";
            this.LocationString.Size = new System.Drawing.Size(249, 20);
            this.LocationString.TabIndex = 1;
            this.LocationString.TextChanged += new System.EventHandler(this.LocationString_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(352, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 21);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileDescLabel
            // 
            this.FileDescLabel.AutoSize = true;
            this.FileDescLabel.Location = new System.Drawing.Point(3, 7);
            this.FileDescLabel.Name = "FileDescLabel";
            this.FileDescLabel.Size = new System.Drawing.Size(48, 13);
            this.FileDescLabel.TabIndex = 0;
            this.FileDescLabel.Text = "FileDesc";
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.LocationString);
            this.Controls.Add(this.FileDescLabel);
            this.Name = "FileBrowser";
            this.Size = new System.Drawing.Size(443, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationString;
        private System.Windows.Forms.Button BrowseButton;


        private System.Windows.Forms.Label FileDescLabel;
    }
}
