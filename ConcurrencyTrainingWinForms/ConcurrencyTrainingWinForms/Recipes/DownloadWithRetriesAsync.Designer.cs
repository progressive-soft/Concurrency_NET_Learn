namespace ConcurrencyTrainingWinForms.Recipes
{
    partial class DownloadWithRetriesAsync
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
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnDownloadContent = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(948, 317);
            this.contentRichTextBox.TabIndex = 5;
            this.contentRichTextBox.Text = "";
            // 
            // btnDownloadContent
            // 
            this.btnDownloadContent.Location = new System.Drawing.Point(12, 387);
            this.btnDownloadContent.Name = "btnDownloadContent";
            this.btnDownloadContent.Size = new System.Drawing.Size(164, 23);
            this.btnDownloadContent.TabIndex = 4;
            this.btnDownloadContent.Text = "Download Content";
            this.btnDownloadContent.UseVisualStyleBackColor = true;
            this.btnDownloadContent.Click += new System.EventHandler(this.BtnDownloadContent_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 351);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 483);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.btnDownloadContent);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button btnDownloadContent;
        private System.Windows.Forms.Label lblStatus;
    }
}