namespace ConcurrencyTrainingWinForms.Recipes
{
    partial class DownloadWithTimeoutAsync
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
            this.lblTimeout = new System.Windows.Forms.Label();
            this.textBoxTimeoutInMs = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 351);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(948, 317);
            this.contentRichTextBox.TabIndex = 8;
            this.contentRichTextBox.Text = "";
            // 
            // btnDownloadContent
            // 
            this.btnDownloadContent.Location = new System.Drawing.Point(12, 436);
            this.btnDownloadContent.Name = "btnDownloadContent";
            this.btnDownloadContent.Size = new System.Drawing.Size(164, 23);
            this.btnDownloadContent.TabIndex = 7;
            this.btnDownloadContent.Text = "Download Content";
            this.btnDownloadContent.UseVisualStyleBackColor = true;
            this.btnDownloadContent.Click += new System.EventHandler(this.BtnDownloadContent_Click);
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(13, 407);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(67, 13);
            this.lblTimeout.TabIndex = 11;
            this.lblTimeout.Text = "Timeout [ms]";
            // 
            // textBoxTimeoutInMs
            // 
            this.textBoxTimeoutInMs.Location = new System.Drawing.Point(98, 404);
            this.textBoxTimeoutInMs.Name = "textBoxTimeoutInMs";
            this.textBoxTimeoutInMs.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeoutInMs.TabIndex = 12;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(98, 376);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrl.TabIndex = 14;
            this.textBoxUrl.Text = "http://github.com";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 379);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Url";
            // 
            // DownloadWithTimeoutAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 550);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.textBoxTimeoutInMs);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.btnDownloadContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DownloadWithTimeoutAsync";
            this.Text = "DownloadWithTimeoutAsync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button btnDownloadContent;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.TextBox textBoxTimeoutInMs;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label lblUrl;
    }
}