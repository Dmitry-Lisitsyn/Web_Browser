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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butt_forgot = new System.Windows.Forms.Button();
            this.but_vhod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.log_vhod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pass_vhod = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.questi_answer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.questi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass_accept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // but_reg
            // 
            this.but_reg.Location = new System.Drawing.Point(79, 374);
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
            this.box_log.Location = new System.Drawing.Point(164, 54);
            this.box_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_log.Name = "box_log";
            this.box_log.Size = new System.Drawing.Size(132, 22);
            this.box_log.TabIndex = 1;
            this.box_log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
            // 
            // box_pass
            // 
            this.box_pass.Location = new System.Drawing.Point(164, 86);
            this.box_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_pass.Name = "box_pass";
            this.box_pass.PasswordChar = '*';
            this.box_pass.Size = new System.Drawing.Size(132, 22);
            this.box_pass.TabIndex = 2;
            this.box_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 572);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butt_forgot);
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
            // butt_forgot
            // 
            this.butt_forgot.Location = new System.Drawing.Point(152, 482);
            this.butt_forgot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butt_forgot.Name = "butt_forgot";
            this.butt_forgot.Size = new System.Drawing.Size(100, 58);
            this.butt_forgot.TabIndex = 10;
            this.butt_forgot.Text = "Забыли пароль?";
            this.butt_forgot.UseVisualStyleBackColor = true;
            this.butt_forgot.Click += new System.EventHandler(this.butt_forgot_Click);
            // 
            // but_vhod
            // 
            this.but_vhod.Location = new System.Drawing.Point(171, 226);
            this.but_vhod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_vhod.Name = "but_vhod";
            this.but_vhod.Size = new System.Drawing.Size(132, 28);
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
            this.log_vhod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
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
            this.pass_vhod.PasswordChar = '*';
            this.pass_vhod.Size = new System.Drawing.Size(132, 22);
            this.pass_vhod.TabIndex = 7;
            this.pass_vhod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.questi_answer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.questi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pass_accept);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ответ:";
            this.label7.Visible = false;
            // 
            // questi_answer
            // 
            this.questi_answer.Location = new System.Drawing.Point(79, 257);
            this.questi_answer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questi_answer.Name = "questi_answer";
            this.questi_answer.Size = new System.Drawing.Size(132, 22);
            this.questi_answer.TabIndex = 9;
            this.questi_answer.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выберите контрольный вопрос:";
            // 
            // questi
            // 
            this.questi.FormattingEnabled = true;
            this.questi.Items.AddRange(new object[] {
            "Ваше первое домашнее животное?",
            "В каком месяце у вас день рождения?"});
            this.questi.Location = new System.Drawing.Point(52, 213);
            this.questi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questi.Name = "questi";
            this.questi.Size = new System.Drawing.Size(300, 24);
            this.questi.TabIndex = 7;
            this.questi.SelectedIndexChanged += new System.EventHandler(this.questi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Подтвердите пароль";
            // 
            // pass_accept
            // 
            this.pass_accept.Location = new System.Drawing.Point(164, 118);
            this.pass_accept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_accept.Name = "pass_accept";
            this.pass_accept.PasswordChar = '*';
            this.pass_accept.Size = new System.Drawing.Size(132, 22);
            this.pass_accept.TabIndex = 5;
            this.pass_accept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass_accept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butt_forgot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox questi_answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox questi;
        public System.Windows.Forms.Button but_vhod;
        public System.Windows.Forms.TextBox log_vhod;
        public System.Windows.Forms.TextBox pass_vhod;
    }
}