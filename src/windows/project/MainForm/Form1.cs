using Microsoft.Web.WebView2.Core;
using System;
using System.Net.Http;
using System.Reflection;
using System.Windows.Forms;

namespace 因材網學習大師
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            this.Text = "因材網學習大師";
        }

        private string scriptUrl = "https://raw.githubusercontent.com/SweetPotatoYee/YCW-Learning-Master/refs/heads/main/scripts/funtions.js";
        private string script;
        private string latestVersionUrl = "https://raw.githubusercontent.com/SweetPotatoYee/YCW-Learning-Master/refs/heads/main/src/version";
        private string lastestVersion;

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    script = await client.GetStringAsync(scriptUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法加載腳本: " + ex.Message);
                    return;
                }
            }

            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri("https://sso.ntpc.edu.tw");
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
        }

        private async void WebView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                await webView21.ExecuteScriptAsync(script);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void menuLink2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://pts.ntpc.edu.tw/private/service/goto/service/100/100");
        }

        private void menuLink1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://sso.ntpc.edu.tw");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        private void goForward_click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
            }
        }

        private async void checkUpdateButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                lastestVersion = await client.GetStringAsync(latestVersionUrl);
            }
            if (lastestVersion.ToString().Trim() != Assembly.GetExecutingAssembly().GetName().Version.ToString().Trim())
            {
                DialogResult result = MessageBox.Show("最新版本為" + lastestVersion + "您的版本為" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + Environment.NewLine + "是否要下載更新?", "更新提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (UpdateForm updateForm = new UpdateForm())
                    {
                        updateForm.ShowDialog();
                    }
                }
            } else
            {
                MessageBox.Show("已經是最新版本啦!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
