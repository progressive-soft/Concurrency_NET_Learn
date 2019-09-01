using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms
{
    public partial class DeadlockExample : Form
    {
        public DeadlockExample()
        {
            InitializeComponent();
        }


        // Blocking version - continue on context captured on main UI thread
        // waiting for Task completion via .Result will cause a deadlock
        //private void BtnDownloadContent_Click(object sender, EventArgs e)
        //{
        //    contentRichTextBox.Text = DownloadContentAsync().Result;
        //}

        //private async Task<string> DownloadContentAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        return await client.GetStringAsync("http://softsystem.pl");
        //    }
        //}




        // Blocking version - continue on context captured on main UI thread
        // waiting for Task completion via Wait - the same effect as in above example  - will cause a deadlock
        //private void BtnDownloadContent_Click(object sender, EventArgs e)
        //{
        //    Task<string> t = DownloadContentAsync();
        //    t.Wait();
        //    contentRichTextBox.Text = t.Result;
        //}

        //private async Task<string> DownloadContentAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        return await client.GetStringAsync("http://softsystem.pl");
        //    }
        //}




        // Better solution: Non-Blocking version - continue on context captured on thread-pool
        // waiting for Task completion via .Result should not cause a deadlock
        //private void BtnDownloadContent_Click(object sender, EventArgs e)
        //{
        //    contentRichTextBox.Text = DownloadContentAsync().Result;
        //}

        //private async Task<string> DownloadContentAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        return await client.GetStringAsync("http://softsystem.pl").ConfigureAwait(false);
        //    }
        //}




        // Recommended solution: Non-Blocking version - make all methods 'async' in a chain 
        // waiting for Task completion via await
        private async void BtnDownloadContent_Click(object sender, EventArgs e)
        {
            contentRichTextBox.Text = await DownloadContentAsync();
        }

        private async Task<string> DownloadContentAsync()
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync("http://softsystem.pl");
            }
        }
    }
}
