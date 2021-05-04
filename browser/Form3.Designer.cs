
namespace browser
{
    partial class Form3
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
            this.log_voss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_voss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.questi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.questi_answer = new System.Windows.Forms.TextBox();
            this.butt_voss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_voss
            // 
            this.log_voss.Location = new System.Drawing.Point(136, 62);
            this.log_voss.Name = "log_voss";
            this.log_voss.Size = new System.Drawing.Size(100, 20);
            this.log_voss.TabIndex = 0;
            this.log_voss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_log_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ваш логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите новый пароль";
            // 
            // pass_voss
            // 
            this.pass_voss.Location = new System.Drawing.Point(136, 143);
            this.pass_voss.Name = "pass_voss";
            this.pass_voss.PasswordChar = '*';
            this.pass_voss.Size = new System.Drawing.Size(100, 20);
            this.pass_voss.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Выберите контрольный вопрос:";
            // 
            // questi
            // 
            this.questi.FormattingEnabled = true;
            this.questi.Items.AddRange(new object[] {
            "Ваше первое домашнее животное?",
            "В каком месяце у вас день рождения?"});
            this.questi.Location = new System.Drawing.Point(26, 216);
            this.questi.Name = "questi";
            this.questi.Size = new System.Drawing.Size(226, 21);
            this.questi.TabIndex = 9;
            this.questi.SelectedIndexChanged += new System.EventHandler(this.questi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ответ:";
            // 
            // questi_answer
            // 
            this.questi_answer.Location = new System.Drawing.Point(75, 265);
            this.questi_answer.Name = "questi_answer";
            this.questi_answer.Size = new System.Drawing.Size(100, 20);
            this.questi_answer.TabIndex = 11;
            // 
            // butt_voss
            // 
            this.butt_voss.Location = new System.Drawing.Point(63, 330);
            this.butt_voss.Name = "butt_voss";
            this.butt_voss.Size = new System.Drawing.Size(141, 23);
            this.butt_voss.TabIndex = 13;
            this.butt_voss.Text = "Восстановить пароль";
            this.butt_voss.UseVisualStyleBackColor = true;
            this.butt_voss.Click += new System.EventHandler(this.butt_voss_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.butt_voss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.questi_answer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.questi);
            this.Controls.Add(this.pass_voss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_voss);
            this.Name = "Form3";
            this.Text = "Восстановление пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_voss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_voss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox questi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox questi_answer;
        private System.Windows.Forms.Button butt_voss;
    }
}