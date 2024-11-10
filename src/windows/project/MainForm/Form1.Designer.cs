namespace 因材網學習大師
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLink1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLink2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.goForward = new System.Windows.Forms.ToolStripMenuItem();
            this.goBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLink1,
            this.menuLink2,
            this.checkUpdateButton,
            this.aboutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLink1
            // 
            this.menuLink1.Name = "menuLink1";
            this.menuLink1.Size = new System.Drawing.Size(243, 26);
            this.menuLink1.Text = "新北市政府教育局單一簽入(登入)";
            this.menuLink1.Click += new System.EventHandler(this.menuLink1_Click);
            // 
            // menuLink2
            // 
            this.menuLink2.Name = "menuLink2";
            this.menuLink2.Size = new System.Drawing.Size(198, 26);
            this.menuLink2.Text = "教育部因材網(需要先登入)";
            this.menuLink2.Click += new System.EventHandler(this.menuLink2_Click);
            // 
            // checkUpdateButton
            // 
            this.checkUpdateButton.Name = "checkUpdateButton";
            this.checkUpdateButton.Size = new System.Drawing.Size(83, 26);
            this.checkUpdateButton.Text = "檢查更新";
            this.checkUpdateButton.Click += new System.EventHandler(this.checkUpdateButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(53, 26);
            this.aboutButton.Text = "關於";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 30);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1090, 598);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh,
            this.goForward,
            this.goBack});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1090, 30);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // refresh
            // 
            this.refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(83, 26);
            this.refresh.Text = "重新整理";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // goForward
            // 
            this.goForward.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(68, 26);
            this.goForward.Text = "下一頁";
            this.goForward.Click += new System.EventHandler(this.goForward_click);
            // 
            // goBack
            // 
            this.goBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(68, 26);
            this.goBack.Text = "上一頁";
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 628);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLink1;
        private System.Windows.Forms.ToolStripMenuItem menuLink2;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        private System.Windows.Forms.ToolStripMenuItem goForward;
        private System.Windows.Forms.ToolStripMenuItem goBack;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateButton;
    }
}

