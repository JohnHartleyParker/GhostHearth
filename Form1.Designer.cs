namespace GhostHearth
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.AlphaSlider = new System.Windows.Forms.TrackBar();
			this.UnfloatButton = new System.Windows.Forms.Button();
			this.FloatButton = new System.Windows.Forms.Button();
			this.StatusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AlphaSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// AlphaSlider
			// 
			this.AlphaSlider.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AlphaSlider.Location = new System.Drawing.Point(0, 0);
			this.AlphaSlider.Name = "AlphaSlider";
			this.AlphaSlider.Size = new System.Drawing.Size(244, 92);
			this.AlphaSlider.TabIndex = 0;
			this.AlphaSlider.Scroll += new System.EventHandler(this.AlphaSlider_Scroll);
			// 
			// UnfloatButton
			// 
			this.UnfloatButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.UnfloatButton.Location = new System.Drawing.Point(0, 72);
			this.UnfloatButton.Name = "UnfloatButton";
			this.UnfloatButton.Size = new System.Drawing.Size(244, 20);
			this.UnfloatButton.TabIndex = 1;
			this.UnfloatButton.Text = "Unfloat Window";
			this.UnfloatButton.UseVisualStyleBackColor = true;
			this.UnfloatButton.Click += new System.EventHandler(this.UnfloatButton_Click);
			// 
			// FloatButton
			// 
			this.FloatButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FloatButton.Location = new System.Drawing.Point(0, 52);
			this.FloatButton.Name = "FloatButton";
			this.FloatButton.Size = new System.Drawing.Size(244, 20);
			this.FloatButton.TabIndex = 2;
			this.FloatButton.Text = "Float Window";
			this.FloatButton.UseVisualStyleBackColor = true;
			this.FloatButton.Click += new System.EventHandler(this.FloatButton_Click);
			// 
			// StatusLabel
			// 
			this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(12, 36);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(38, 13);
			this.StatusLabel.TabIndex = 3;
			this.StatusLabel.Text = "-status";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 92);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.FloatButton);
			this.Controls.Add(this.UnfloatButton);
			this.Controls.Add(this.AlphaSlider);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "GhostHearth";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.AlphaSlider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar AlphaSlider;
		private System.Windows.Forms.Button UnfloatButton;
		private System.Windows.Forms.Button FloatButton;
		private System.Windows.Forms.Label StatusLabel;
	}
}

