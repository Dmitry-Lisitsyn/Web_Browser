namespace browser
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.pContainer = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buRefresh = new System.Windows.Forms.ToolStripButton();
            this.textUrl = new System.Windows.Forms.ToolStripTextBox();
            this.buSearch = new System.Windows.Forms.ToolStripButton();
            this.buSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buProfile = new System.Windows.Forms.ToolStripButton();
            this.laUser = new System.Windows.Forms.ToolStripLabel();
            this.laVhod = new System.Windows.Forms.ToolStripLabel();
            this.buExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hist = new System.Windows.Forms.ToolStripButton();
            this.pContainer.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoSize = true;
            this.pContainer.Controls.Add(this.groupBox1);
            this.pContainer.Location = new System.Drawing.Point(0, 52);
            this.pContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(966, 416);
            this.pContainer.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buBack,
            this.buForward,
            this.buRefresh,
            this.textUrl,
            this.buSearch,
            this.buSettings,
            this.buProfile,
            this.laUser,
            this.laVhod,
            this.hist,
            this.buExit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(966, 50);
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
            this.buBack.Size = new System.Drawing.Size(24, 47);
            this.buBack.Text = "back";
            this.buBack.Click += new System.EventHandler(this.buBack_Click_1);
            // 
            // buForward
            // 
            this.buForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buForward.Image = ((System.Drawing.Image)(resources.GetObject("buForward.Image")));
            this.buForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(24, 47);
            this.buForward.Text = "Forward";
            this.buForward.Click += new System.EventHandler(this.buForward_Click_1);
            // 
            // buRefresh
            // 
            this.buRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buRefresh.Image")));
            this.buRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buRefresh.Name = "buRefresh";
            this.buRefresh.Size = new System.Drawing.Size(24, 47);
            this.buRefresh.Text = "Refresh";
            this.buRefresh.Click += new System.EventHandler(this.buRefresh_Click);
            // 
            // textUrl
            // 
            this.textUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textUrl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(600, 50);
            // 
            // buSearch
            // 
            this.buSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buSearch.Image = ((System.Drawing.Image)(resources.GetObject("buSearch.Image")));
            this.buSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(24, 47);
            this.buSearch.Text = "Search!";
            this.buSearch.Click += new System.EventHandler(this.buSearch_Click);
            // 
            // buSettings
            // 
            this.buSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem});
            this.buSettings.Image = ((System.Drawing.Image)(resources.GetObject("buSettings.Image")));
            this.buSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buSettings.Name = "buSettings";
            this.buSettings.Size = new System.Drawing.Size(33, 47);
            this.buSettings.Text = "Settings";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл...";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // buProfile
            // 
            this.buProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buProfile.Image = ((System.Drawing.Image)(resources.GetObject("buProfile.Image")));
            this.buProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buProfile.Name = "buProfile";
            this.buProfile.Size = new System.Drawing.Size(24, 47);
            this.buProfile.Text = "Authorization";
            this.buProfile.Click += new System.EventHandler(this.buProfile_Click_1);
            // 
            // laUser
            // 
            this.laUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(0, 47);
            // 
            // laVhod
            // 
            this.laVhod.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.laVhod.Name = "laVhod";
            this.laVhod.Size = new System.Drawing.Size(108, 47);
            this.laVhod.Text = "Вход не выполнен";
            this.laVhod.Click += new System.EventHandler(this.laVhod_Click);
            // 
            // buExit
            // 
            this.buExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buExit.Image = ((System.Drawing.Image)(resources.GetObject("buExit.Image")));
            this.buExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buExit.Name = "buExit";
            this.buExit.Size = new System.Drawing.Size(46, 19);
            this.buExit.Text = "Выйти";
            this.buExit.Visible = false;
            this.buExit.Click += new System.EventHandler(this.buExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(720, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "История";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 259);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hist
            // 
            this.hist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hist.Image = ((System.Drawing.Image)(resources.GetObject("hist.Image")));
            this.hist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(113, 19);
            this.hist.Text = "Показать историю";
            this.hist.ToolTipText = "Показать/скрыть историю";
            this.hist.Click += new System.EventHandler(this.hist_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 479);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.TopMost = true;
            this.pContainer.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton buProfile;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel laUser;
        private System.Windows.Forms.ToolStripLabel laVhod;
        private System.Windows.Forms.ToolStripButton buExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton hist;
    }
}

