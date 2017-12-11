namespace SearchTeklaModel
{
	partial class Search
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearchString = new System.Windows.Forms.TextBox();
			this.comboBoxPartType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxPartProperty = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SearchTeklaModel.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(43, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(197, 57);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(43, 288);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(197, 36);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearchString
			// 
			this.textBoxSearchString.Location = new System.Drawing.Point(43, 236);
			this.textBoxSearchString.Name = "textBoxSearchString";
			this.textBoxSearchString.Size = new System.Drawing.Size(197, 22);
			this.textBoxSearchString.TabIndex = 2;
			// 
			// comboBoxPartType
			// 
			this.comboBoxPartType.FormattingEnabled = true;
			this.comboBoxPartType.Location = new System.Drawing.Point(43, 109);
			this.comboBoxPartType.Name = "comboBoxPartType";
			this.comboBoxPartType.Size = new System.Drawing.Size(197, 24);
			this.comboBoxPartType.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Part Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Search String";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Part Property";
			// 
			// comboBoxPartProperty
			// 
			this.comboBoxPartProperty.FormattingEnabled = true;
			this.comboBoxPartProperty.Location = new System.Drawing.Point(43, 170);
			this.comboBoxPartProperty.Name = "comboBoxPartProperty";
			this.comboBoxPartProperty.Size = new System.Drawing.Size(197, 24);
			this.comboBoxPartProperty.TabIndex = 6;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 354);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxPartProperty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxPartType);
			this.Controls.Add(this.textBoxSearchString);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Search";
			this.Text = "Search";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearchString;
		private System.Windows.Forms.ComboBox comboBoxPartType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxPartProperty;
	}
}

