using System;
using System.IO;
using System.Windows.Forms;
using AltoHttp;

namespace 因材網學習大師
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Continuous;
            installButton.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}

        private string tempFilePath;
        private bool funcCancel = true;
        private bool startPause = true;
        private bool pauseResume = true;
        HttpDownloader httpDownloader;

        // 開始下載更新
        public void StartDownloadUpdate(string downloadUrl)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (funcCancel) {
                if (startPause)
                {
                    MessageBox.Show("安裝將自動關閉以進行更新" + Environment.NewLine + "如遭到防毒軟體攔截(閃退)，請暫停防毒軟體或加入白名單並重試下載。");
                    btnStart.Enabled = false;
                    btnStart.Text = "暫停";
                    string downloadUrl = "https://github.com/SweetPotatoYee/YCW-Learning-Master/raw/refs/heads/main/src/windows/YCWLM-windows-updater.exe";
                    tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetFileName(downloadUrl));
                    httpDownloader = new HttpDownloader(downloadUrl, tempFilePath);
                    httpDownloader.DownloadCompleted += downloadCompleted;
                    httpDownloader.ProgressChanged += progressChanged;
                    httpDownloader.Start();
                    startPause = false;
                    pauseResume = true;
                    btnStart.Enabled = true;
                } else
                {
                    if (pauseResume)
                    {
                        if (httpDownloader != null)
                        {
                            btnStart.Enabled = false;
                            btnStart.Text = "繼續";
                            httpDownloader.Pause();
                            btnStart.Enabled = true;
                            pauseResume = false;
                        }
                    } else
                    {
                        if (httpDownloader != null)
                        {
                            btnStart.Enabled = false;
                            btnStart.Text = "暫停";
                            httpDownloader.Resume();
                            pauseResume = true;
                            btnStart.Enabled = true;
                        }
                    }
                
                }
            } else
            {
                this.Close();
            }

        }

        private void downloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                funcCancel = false;
                btnStart.Text = "取消";
                statusLabel.Text = "完成 !";
                lblPercent.Text = "100%";
                installButton.Enabled = true;
            });
        }


        private void progressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lblPercent.Text = $"{e.Progress.ToString("0.00")} %";
            statusLabel.Text = "下載中";
            lblSpeed.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lblDownloaded.Text = string.Format("{0} MB/s", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        }

        // 當安裝按鈕被點擊時
        private void installButton_Click(object sender, EventArgs e)
        {
            installButton.Enabled = false;
            // 檢查檔案是否存在
            if (!File.Exists(tempFilePath))
            {
                MessageBox.Show("安裝檔案不存在，請重試下載並暫停防毒軟體或加入白名單。");
                return;
            }

            try
            {
                // 啟動下載的更新程序
                System.Diagnostics.Process.Start(tempFilePath);

                // 關閉當前應用程式
                Application.Exit();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("垃圾"))
                {
                    MessageBox.Show("啟動安裝程式失敗: " + ex.Message);
                    this.Close();
                } else
                {
                    MessageBox.Show("啟動安裝程式失敗: " + "遭到防毒軟體攔截，請暫停防毒軟體或加入白名單並重試下載。");
                    this.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
