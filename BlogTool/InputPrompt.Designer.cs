namespace BlogTool
{
    partial class NewBlogPostPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptBlogButton = new System.Windows.Forms.Button();
            this.CancelBlogButton = new System.Windows.Forms.Button();
            this.BlogName_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // AcceptBlogButton
            // 
            this.AcceptBlogButton.Location = new System.Drawing.Point(13, 43);
            this.AcceptBlogButton.Name = "AcceptBlogButton";
            this.AcceptBlogButton.Size = new System.Drawing.Size(262, 23);
            this.AcceptBlogButton.TabIndex = 0;
            this.AcceptBlogButton.Text = "Accept";
            this.AcceptBlogButton.UseVisualStyleBackColor = true;
            this.AcceptBlogButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelBlogButton
            // 
            this.CancelBlogButton.Location = new System.Drawing.Point(281, 43);
            this.CancelBlogButton.Name = "CancelBlogButton";
            this.CancelBlogButton.Size = new System.Drawing.Size(265, 23);
            this.CancelBlogButton.TabIndex = 1;
            this.CancelBlogButton.Text = "Cancel";
            this.CancelBlogButton.UseVisualStyleBackColor = true;
            this.CancelBlogButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BlogName_TextBox
            // 
            this.BlogName_TextBox.Location = new System.Drawing.Point(14, 14);
            this.BlogName_TextBox.Name = "BlogName_TextBox";
            this.BlogName_TextBox.Size = new System.Drawing.Size(532, 20);
            this.BlogName_TextBox.TabIndex = 2;
            // 
            // NewBlogPostPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 79);
            this.Controls.Add(this.BlogName_TextBox);
            this.Controls.Add(this.CancelBlogButton);
            this.Controls.Add(this.AcceptBlogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewBlogPostPrompt";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Enter name of new Blogpost";
            this.Load += new System.EventHandler(this.NewBlogPostPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptBlogButton;
        private System.Windows.Forms.Button CancelBlogButton;
        private System.Windows.Forms.TextBox BlogName_TextBox;
    }
}