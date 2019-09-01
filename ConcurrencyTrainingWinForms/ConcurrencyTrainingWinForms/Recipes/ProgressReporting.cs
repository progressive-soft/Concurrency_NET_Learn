using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms.Recipes
{
    public partial class ProgressReporting : Form
    {
        public ProgressReporting()
        {
            InitializeComponent();
            lblStatus.Text = "Idle";
        }


        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Downloading...";

            var progress = new Progress<int>();
            progress.ProgressChanged += (s, ea) =>
            {
                progressBar1.Value = ea;
            };

            contentRichTextBox.Text = await DownloadStringAsync("http://softsystem.pl", progress, 5);
            lblStatus.Text = "Downloaded successfully...";
        }

        /// <summary>
        /// Asynchronously downloads a string from given url with delay
        /// </summary>
        /// <param name="url"></param>
        /// <param name="delayInSec">A delay in downloading - used for demo purposes</param>
        /// <returns></returns>
        private async Task<string> DownloadStringAsync(string url, IProgress<int> progress = null, int delayInSec = 0)
        {
            int percentComplete = 0;

            const int portionPercentageStep = 80 / 10;
            int delayPortionInMs = (delayInSec * 1000) / 10;

            // split given delay into 10 portions
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(delayPortionInMs);
                percentComplete += portionPercentageStep;
                progress?.Report(percentComplete);
            }

            using (var client = new HttpClient())
            {
                string result = await client.GetStringAsync(url).ConfigureAwait(false);
                percentComplete = 100;
                progress?.Report(percentComplete);
                return result;
            }
        }

    }


}
