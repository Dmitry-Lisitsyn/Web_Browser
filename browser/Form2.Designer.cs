namespace browser
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.but_reg = new System.Windows.Forms.Button();
            this.box_log = new System.Windows.Forms.TextBox();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.but_vhod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.log_vhod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pass_vhod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // but_reg
            // 
            this.but_reg.Location = new System.Drawing.Point(67, 172);
            this.but_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_reg.Name = "but_reg";
            this.but_reg.Size = new System.Drawing.Size(203, 28);
            this.but_reg.TabIndex = 0;
            this.but_reg.Text = "Зарегистрироваться";
            this.but_reg.UseVisualStyleBackColor = true;
            this.but_reg.Click += new System.EventHandler(this.but_reg_Click);
            // 
            // box_log
            // 
            this.box_log.Location = new System.Drawing.Point(111, 30);
            this.box_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_log.Name = "box_log";
            this.box_log.Size = new System.Drawing.Size(132, 22);
            this.box_log.TabIndex = 1;
            // 
            // box_pass
            // 
            this.box_pass.Location = new System.Drawing.Point(111, 86);
            this.box_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(132, 22);
            this.box_pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 572);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.but_reg);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.box_log);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.box_pass);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(413, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.but_vhod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.log_vhod);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pass_vhod);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(413, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Войти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // but_vhod
            // 
            this.but_vhod.Location = new System.Drawing.Point(101, 252);
            this.but_vhod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_vhod.Name = "but_vhod";
            this.but_vhod.Size = new System.Drawing.Size(203, 28);
            this.but_vhod.TabIndex = 5;
            this.but_vhod.Text = "Войти";
            this.but_vhod.UseVisualStyleBackColor = true;
            this.but_vhod.Click += new System.EventHandler(this.but_vhod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // log_vhod
            // 
            this.log_vhod.Location = new System.Drawing.Point(171, 112);
            this.log_vhod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_vhod.Name = "log_vhod";
            this.log_vhod.Size = new System.Drawing.Size(132, 22);
            this.log_vhod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Логин";
            // 
            // pass_vhod
            // 
            this.pass_vhod.Location = new System.Drawing.Point(171, 169);
            this.pass_vhod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_vhod.Name = "pass_vhod";
            this.pass_vhod.Size = new System.Drawing.Size(132, 22);
            this.pass_vhod.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 572);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_pass;
        private System.Windows.Forms.TextBox box_log;
        private System.Windows.Forms.Button but_reg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button but_vhod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox log_vhod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass_vhod;
    }
}