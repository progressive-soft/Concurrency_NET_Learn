using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms.Recipes
{
    public partial class DownloadAllAsync : Form
    {
        public DownloadAllAsync()
        {
            InitializeComponent();
            lblStatus.Text = "Idle";
        }

        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            var downloadTasks = new List<Task<string>>();
            foreach (var item in listBoxSources.Items)
            {
                downloadTasks.Add(DownloadStringAsync(item.ToString()));
            }

            try
            {
                string[] content = await Task.WhenAll(downloadTasks);
                lblStatus.Text = "Completed successfully";
                contentRichTextBox.Text = string.Concat(content);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error occured";
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Asynchronously downloads a string from given url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<string> DownloadStringAsync(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url).ConfigureAwait(false);
            }
        }
    }
}
