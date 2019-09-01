namespace ConcurrencyTrainingWinForms.Recipes
{
    partial class DownloadAllAsync
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnDownloadContent = new System.Windows.Forms.Button();
            this.listBoxSources = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 363);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(24, 12);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(713, 317);
            this.contentRichTextBox.TabIndex = 16;
            this.contentRichTextBox.Text = "";
            // 
            // btnDownloadContent
            // 
            this.btnDownloadContent.Location = new System.Drawing.Point(24, 402);
            this.btnDownloadContent.Name = "btnDownloadContent";
            this.btnDownloadContent.Size = new System.Drawing.Size(164, 23);
            this.btnDownloadContent.TabIndex = 15;
            this.btnDownloadContent.Text = "Download Content";
            this.btnDownloadContent.UseVisualStyleBackColor = true;
            this.btnDownloadContent.Click += new System.EventHandler(this.BtnDownloadContent_Click);
            // 
            // listBoxSources
            // 
            this.listBoxSources.FormattingEnabled = true;
            this.listBoxSources.Items.AddRange(new object[] {
            "http://google.pl",
            "http://softsystem.pl",
            "http://github.com"});
            this.listBoxSources.Location = new System.Drawing.Point(770, 13);
            this.listBoxSources.Name = "listBoxSources";
            this.listBoxSources.Size = new System.Drawing.Size(251, 316);
            this.listBoxSources.TabIndex = 18;
            // 
            // DownloadAllAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 476);
            this.Controls.Add(this.listBoxSources);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.btnDownloadContent);
            this.Name = "DownloadAllAsync";
            this.Text = "DownloadAllAsync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button btnDownloadContent;
        private System.Windows.Forms.ListBox listBoxSources;
    }
}