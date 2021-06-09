
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
            this.cbAdidas = new System.Windows.Forms.CheckBox();
            this.cbEnd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbAdidas
            // 
            this.cbAdidas.AutoSize = true;
            this.cbAdidas.Location = new System.Drawing.Point(16, 15);
            this.cbAdidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAdidas.Name = "cbAdidas";
            this.cbAdidas.Size = new System.Drawing.Size(73, 21);
            this.cbAdidas.TabIndex = 0;
            this.cbAdidas.Text = "Ádidas";
            this.cbAdidas.UseVisualStyleBackColor = true;
            this.cbAdidas.CheckedChanged += new System.EventHandler(this.cbAdidas_CheckedChanged);
            // 
            // cbEnd
            // 
            this.cbEnd.AutoSize = true;
            this.cbEnd.Location = new System.Drawing.Point(16, 43);
            this.cbEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(204, 21);
            this.cbEnd.TabIndex = 1;
            this.cbEnd.Text = "End (not working probably) ";
            this.cbEnd.UseVisualStyleBackColor = true;
            this.cbEnd.CheckedChanged += new System.EventHandler(this.cbEnd_CheckedChanged);
            // 
            // FmAutofill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 178);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.cbAdidas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmAutofill";
            this.Text = "FmAutofill";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbAdidas;
		private System.Windows.Forms.CheckBox cbEnd;
	}
}