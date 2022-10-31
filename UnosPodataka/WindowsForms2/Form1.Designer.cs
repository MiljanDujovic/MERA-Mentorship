namespace WindowsForms2 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lsvContacts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvContacts);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(560, 382);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contacts";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.txtZip);
			this.groupBox2.Controls.Add(this.txtState);
			this.groupBox2.Controls.Add(this.txtCity);
			this.groupBox2.Controls.Add(this.txtStreet);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.lblName);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox2.Location = new System.Drawing.Point(588, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(191, 208);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Enter Contact Details";
			// 
			// btnSave
			// 
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(97, 171);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "Savo";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(72, 131);
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(100, 20);
			this.txtZip.TabIndex = 20;
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(72, 105);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(100, 20);
			this.txtState.TabIndex = 19;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(72, 79);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 18;
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(72, 53);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(100, 20);
			this.txtStreet.TabIndex = 17;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(72, 27);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(31, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "ZIP";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(31, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "State";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(31, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "City";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(31, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Street";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblName.Location = new System.Drawing.Point(31, 30);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Name";
			// 
			// lsvContacts
			// 
			this.lsvContacts.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lsvContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lsvContacts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lsvContacts.FullRowSelect = true;
			this.lsvContacts.HideSelection = false;
			this.lsvContacts.Location = new System.Drawing.Point(6, 19);
			this.lsvContacts.Name = "lsvContacts";
			this.lsvContacts.Size = new System.Drawing.Size(548, 357);
			this.lsvContacts.TabIndex = 0;
			this.lsvContacts.UseCompatibleStateImageBehavior = false;
			this.lsvContacts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Street";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "City";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "State";
			this.columnHeader5.Width = 64;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Zip";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ListView lsvContacts;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

