using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms.Recipes
{
    public partial class DownloadWithRetriesAsync : Form
    {
        public DownloadWithRetriesAsync()
        {
            InitializeComponent();
            lblStatus.Text = "Idle";
        }


        // Download with retries
        // Uses Task.Delay for idle periods between tries

        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            contentRichTextBox.Text = await DownloadStringWithRetriesAsync("http://softsystem.pl", 10);
        }

        /// <summary>
        /// Asynchronously downloads a string from given url with retries, retry interval is fixed (3000ms)
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<string> DownloadStringWithRetriesAsync(string url, int retries)
        {
            for (int i = 0; i < retries; i++)
            {
                lblStatus.Text = $"Try no: {i + 1}";
                try
                {
                    string result =  await DownloadStringAsync(url, i < 2);
                    lblStatus.Text = $"Downloades successfully";
                    return result;
                }
                catch
                {

                }

                await Task.Delay(3000);
            }

            // Try one last time, allowing the error to propogate.
            return await DownloadStringAsync(url, false);
        }

        /// <summary>
        /// Asynchronously downloads a string from given url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="throwEx">Indicates whether an exception should be thrown instead of downloading String - only for retries feature demo purposes</param>
        /// <returns></returns>
        private async Task<string> DownloadStringAsync(string url, bool throwEx)
        {
            using (var client = new HttpClient())
            {
                if (throwEx)
                    throw new HttpRequestException();
                else
                    return await client.GetStringAsync(url);
            }
        }
    }
}
