using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms.Recipes
{
    public partial class DownloadWithTimeoutAsync : Form
    {
        public DownloadWithTimeoutAsync()
        {
            InitializeComponent();
            lblStatus.Text = "Idle";
            textBoxTimeoutInMs.Text = "5000";
        }

        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            string result = await DownloadStringWithTimeoutAsync("http://softsystem.pl", int.Parse(textBoxTimeoutInMs.Text));
            if (result != null)
            {
                contentRichTextBox.Text = result;
                lblStatus.Text = "Downloaded successfully";
            }
            else
            {
                lblStatus.Text = "Timeout occured";
                MessageBox.Show("Timeout occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> DownloadStringWithTimeoutAsync(string url, int timeoutInMs)
        {
            using (var client = new HttpClient())
            {
                lblStatus.Text = "Downloading...";
                if (timeoutInMs > 0)
                {
                    var timeoutTask = Task.Delay(timeoutInMs);
                    var downloadTask = DownloadStringAsync(url, 2);

                    var completedTask = await Task.WhenAny(timeoutTask, downloadTask);
                    if (completedTask == downloadTask)
                    {
                        return await downloadTask;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return await DownloadStringAsync(url);
                }
                
            }
        }


        /// <summary>
        /// Asynchronously downloads a string from given url with delay
        /// </summary>
        /// <param name="url"></param>
        /// <param name="delayInSec">A delay in downloading - used for demo purposes</param>
        /// <returns></returns>
        private async Task<string> DownloadStringAsync(string url, int delayInSec = 0)
        {
            using (var client = new HttpClient())
            {
                await Task.Delay(delayInSec * 1000);
                return await client.GetStringAsync(url);
            }
        }
    }
}
