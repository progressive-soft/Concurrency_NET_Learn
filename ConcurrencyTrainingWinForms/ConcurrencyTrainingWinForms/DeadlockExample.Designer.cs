namespace ConcurrencyTrainingWinForms
{
    partial class DeadlockExample
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
            this.btnDownloadContent = new System.Windows.Forms.Button();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDownloadContent
            // 
            this.btnDownloadContent.Location = new System.Drawing.Point(12, 362);
            this.btnDownloadContent.Name = "btnDownloadContent";
            this.btnDownloadContent.Size = new System.Drawing.Size(164, 23);
            this.btnDownloadContent.TabIndex = 0;
            this.btnDownloadContent.Text = "Download Content";
            this.btnDownloadContent.UseVisualStyleBackColor = true;
            this.btnDownloadContent.Click += new System.EventHandler(this.BtnDownloadContent_Click);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(948, 317);
            this.contentRichTextBox.TabIndex = 1;
            this.contentRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 522);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.btnDownloadContent);
            this.Name = "Form1";
            this.Text = "Concurrency training";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadContent;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
    }
}

