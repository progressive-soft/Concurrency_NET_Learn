using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms
{
    public partial class CallingAsyncMethodsFromSyncCode : Form
    {
        public CallingAsyncMethodsFromSyncCode()
        {
            InitializeComponent();
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
                return await client.GetStringAsync(url);
            }
        }


        // Bad, NOT SAFE version - causes a deadlock instantly
        //private void BtnDownloadContent_Click(object sender, EventArgs e)
        //{
        //    contentRichTextBox.Text = DownloadStringAsync("http://softsystem.pl").Result;
        //}



        // Really really BAD version - does horrible things - causes a deadlock - no matter what context you are calling from
        // Must be run in parallel enough times, might be not noticable when load on ThreadPool is not high enough
        //private void BtnDownloadContent_Click(object sender, EventArgs e)
        //{
        //    string result = Task.Run(() => {
        //        return DownloadStringAsync("http://softsystem.pl").Result;
        //    }).Result;

        //    contentRichTextBox.Text = result;
        //}



        // Good version - will NOT cause a deadlock when called from UI thread
        private void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            string result = Task.Run(async () =>
            {
                return await DownloadStringAsync("http://softsystem.pl");
            }).Result;

        contentRichTextBox.Text = result;
        }
}
}
