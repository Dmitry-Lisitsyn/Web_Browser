namespace browser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pContainer = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buRefresh = new System.Windows.Forms.ToolStripButton();
            this.textUrl = new System.Windows.Forms.ToolStripTextBox();
            this.buSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.buSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoSize = true;
            this.pContainer.Location = new System.Drawing.Point(0, 52);
            this.pContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(843, 329);
            this.pContainer.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buBack,
            this.buForward,
            this.buRefresh,
            this.textUrl,
            this.buSearch,
            this.buSettings,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(843, 50);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // buBack
            // 
            this.buBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buBack.Image = ((System.Drawing.Image)(resources.GetObject("buBack.Image")));
            this.buBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(23, 47);
            this.buBack.Text = "back";
            // 
            // buForward
            // 
            this.buForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buForward.Image = ((System.Drawing.Image)(resources.GetObject("buForward.Image")));
            this.buForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(23, 47);
            this.buForward.Text = "Forward";
            // 
            // buRefresh
            // 
            this.buRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buRefresh.Image")));
            this.buRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buRefresh.Name = "buRefresh";
            this.buRefresh.Size = new System.Drawing.Size(23, 47);
            this.buRefresh.Text = "Refresh";
            // 
            // textUrl
            // 
            this.textUrl.AutoSize = false;
            this.textUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textUrl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(1500, 20);
            // 
            // buSearch
            // 
            this.buSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buSearch.Image = ((System.Drawing.Image)(resources.GetObject("buSearch.Image")));
            this.buSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(23, 47);
            this.buSearch.Text = "Search!";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton2.Text = "Authorization";
            // 
            // buSettings
            // 
            this.buSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buSettings.Image = ((System.Drawing.Image)(resources.GetObject("buSettings.Image")));
            this.buSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buSettings.Name = "buSettings";
            this.buSettings.Size = new System.Drawing.Size(29, 47);
            this.buSettings.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 392);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.ToolStripButton buForward;
        private System.Windows.Forms.ToolStripButton buRefresh;
        private System.Windows.Forms.ToolStripTextBox textUrl;
        private System.Windows.Forms.ToolStripButton buSearch;
        private System.Windows.Forms.ToolStripDropDownButton buSettings;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

