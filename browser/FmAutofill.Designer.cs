﻿
namespace browser
{
	partial class FmAutofill
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
			this.button1 = new System.Windows.Forms.Button();
			this.cbAdidas = new System.Windows.Forms.CheckBox();
			this.cbEnd = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(115, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbAdidas
			// 
			this.cbAdidas.AutoSize = true;
			this.cbAdidas.Location = new System.Drawing.Point(12, 12);
			this.cbAdidas.Name = "cbAdidas";
			this.cbAdidas.Size = new System.Drawing.Size(57, 17);
			this.cbAdidas.TabIndex = 1;
			this.cbAdidas.Text = "adidas";
			this.cbAdidas.UseVisualStyleBackColor = true;
			this.cbAdidas.CheckedChanged += new System.EventHandler(this.cbAdidas_CheckedChanged);
			// 
			// cbEnd
			// 
			this.cbEnd.AutoSize = true;
			this.cbEnd.Location = new System.Drawing.Point(13, 36);
			this.cbEnd.Name = "cbEnd";
			this.cbEnd.Size = new System.Drawing.Size(52, 17);
			this.cbEnd.TabIndex = 2;
			this.cbEnd.Text = "END.";
			this.cbEnd.UseVisualStyleBackColor = true;
			this.cbEnd.CheckedChanged += new System.EventHandler(this.cbEnd_CheckedChanged);
			// 
			// FmAutofill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 217);
			this.Controls.Add(this.cbEnd);
			this.Controls.Add(this.cbAdidas);
			this.Controls.Add(this.button1);
			this.Name = "FmAutofill";
			this.Text = "FmAutofill";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox cbAdidas;
		private System.Windows.Forms.CheckBox cbEnd;
	}
}