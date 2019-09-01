using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms.Recipes
{
    public partial class DownloadAllAsyncWithProgress : Form
    {
        public DownloadAllAsyncWithProgress()
        {
            InitializeComponent();
            lblStatus.Text = "Idle";
        }

        static int _completedCount = 0;
        private static readonly object _syncRoot = new object();

        /// <summary>
        /// Asynchronously downloads a string from given url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="progress">IProgress instance</param>
        /// <returns></returns>
        private async Task<string> DownloadStringAsync(string url, int taskIndex, IProgress<int> progress)
        {
            using (var client = new HttpClient())
            {
                // slow down second task for demo purposes
                if (taskIndex == 1)
                {
                    await Task.Delay(5000);
                }
                
                string result = await client.GetStringAsync(url).ConfigureAwait(false);
                Interlocked.Increment(ref _completedCount);
                int progressVal = (int)((float)_completedCount / (float)listBoxSources.Items.Count * 100.0f);
                progress?.Report(progressVal);
                lock (_syncRoot)
                {
                    contentRichTextBox.AppendText(result);
                }
                return result;
            }
        }

        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            _completedCount = 0;
            var progress = new Progress<int>();
            progress.ProgressChanged += (s, ea) =>
            {
                progressBar1.Value = ea;
            };

            var downloadTasks = new List<Task<string>>();
            for (int i = 0; i < listBoxSources.Items.Count; i++)
            {
                downloadTasks.Add(DownloadStringAsync(listBoxSources.Items[i].ToString(), i, progress));
            }

            lblStatus.Text = "Downloading...";
            string[] result = await Task.WhenAll(downloadTasks);
            lblStatus.Text = "Completed";

            //contentRichTextBox.Text = string.Concat(result);
        }
    }
}
