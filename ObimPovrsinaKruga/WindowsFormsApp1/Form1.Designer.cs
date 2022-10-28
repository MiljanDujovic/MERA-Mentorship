namespace WindowsFormsApp1 {
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
			this.btnZbir = new System.Windows.Forms.Button();
			this.lblPrviSabirak = new System.Windows.Forms.Label();
			this.txtPrviSabirak = new System.Windows.Forms.TextBox();
			this.lblDrugiSabirak = new System.Windows.Forms.Label();
			this.txtDrugiSabirak = new System.Windows.Forms.TextBox();
			this.lblObicanTekst = new System.Windows.Forms.Label();
			this.lblPrikazZbira = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPoluprecnik = new System.Windows.Forms.TextBox();
			this.btnIzracunajPovrsinuKruga = new System.Windows.Forms.Button();
			this.btnIzracunajObimKruga = new System.Windows.Forms.Button();
			this.lblPrikazPovrsineKruga = new System.Windows.Forms.Label();
			this.lblPrikazObimaKruga = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnZbir
			// 
			this.btnZbir.Location = new System.Drawing.Point(280, 84);
			this.btnZbir.Name = "btnZbir";
			this.btnZbir.Size = new System.Drawing.Size(100, 23);
			this.btnZbir.TabIndex = 0;
			this.btnZbir.Text = "Izracunaj zbir";
			this.btnZbir.UseVisualStyleBackColor = true;
			this.btnZbir.Click += new System.EventHandler(this.btnZbir_Click);
			// 
			// lblPrviSabirak
			// 
			this.lblPrviSabirak.AutoSize = true;
			this.lblPrviSabirak.Location = new System.Drawing.Point(212, 35);
			this.lblPrviSabirak.Name = "lblPrviSabirak";
			this.lblPrviSabirak.Size = new System.Drawing.Size(62, 13);
			this.lblPrviSabirak.TabIndex = 1;
			this.lblPrviSabirak.Text = "Prvi sabirak";
			// 
			// txtPrviSabirak
			// 
			this.txtPrviSabirak.Location = new System.Drawing.Point(280, 32);
			this.txtPrviSabirak.Name = "txtPrviSabirak";
			this.txtPrviSabirak.Size = new System.Drawing.Size(100, 20);
			this.txtPrviSabirak.TabIndex = 2;
			// 
			// lblDrugiSabirak
			// 
			this.lblDrugiSabirak.AutoSize = true;
			this.lblDrugiSabirak.Location = new System.Drawing.Point(205, 61);
			this.lblDrugiSabirak.Name = "lblDrugiSabirak";
			this.lblDrugiSabirak.Size = new System.Drawing.Size(69, 13);
			this.lblDrugiSabirak.TabIndex = 3;
			this.lblDrugiSabirak.Text = "Drugi sabirak";
			// 
			// txtDrugiSabirak
			// 
			this.txtDrugiSabirak.Location = new System.Drawing.Point(280, 58);
			this.txtDrugiSabirak.Name = "txtDrugiSabirak";
			this.txtDrugiSabirak.Size = new System.Drawing.Size(100, 20);
			this.txtDrugiSabirak.TabIndex = 4;
			// 
			// lblObicanTekst
			// 
			this.lblObicanTekst.AutoSize = true;
			this.lblObicanTekst.Location = new System.Drawing.Point(386, 61);
			this.lblObicanTekst.Name = "lblObicanTekst";
			this.lblObicanTekst.Size = new System.Drawing.Size(42, 13);
			this.lblObicanTekst.TabIndex = 5;
			this.lblObicanTekst.Text = "Zbir je: ";
			// 
			// lblPrikazZbira
			// 
			this.lblPrikazZbira.AutoSize = true;
			this.lblPrikazZbira.Location = new System.Drawing.Point(425, 61);
			this.lblPrikazZbira.Name = "lblPrikazZbira";
			this.lblPrikazZbira.Size = new System.Drawing.Size(13, 13);
			this.lblPrikazZbira.TabIndex = 6;
			this.lblPrikazZbira.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Unesi poluprecnik";
			// 
			// txtPoluprecnik
			// 
			this.txtPoluprecnik.Location = new System.Drawing.Point(280, 179);
			this.txtPoluprecnik.Name = "txtPoluprecnik";
			this.txtPoluprecnik.Size = new System.Drawing.Size(100, 20);
			this.txtPoluprecnik.TabIndex = 8;
			// 
			// btnIzracunajPovrsinuKruga
			// 
			this.btnIzracunajPovrsinuKruga.Location = new System.Drawing.Point(280, 205);
			this.btnIzracunajPovrsinuKruga.Name = "btnIzracunajPovrsinuKruga";
			this.btnIzracunajPovrsinuKruga.Size = new System.Drawing.Size(138, 23);
			this.btnIzracunajPovrsinuKruga.TabIndex = 9;
			this.btnIzracunajPovrsinuKruga.Text = "Izracunaj Povrsinu Kruga";
			this.btnIzracunajPovrsinuKruga.UseVisualStyleBackColor = true;
			this.btnIzracunajPovrsinuKruga.Click += new System.EventHandler(this.btnIzracunajPovrsinuKruga_Click);
			// 
			// btnIzracunajObimKruga
			// 
			this.btnIzracunajObimKruga.Location = new System.Drawing.Point(280, 234);
			this.btnIzracunajObimKruga.Name = "btnIzracunajObimKruga";
			this.btnIzracunajObimKruga.Size = new System.Drawing.Size(138, 23);
			this.btnIzracunajObimKruga.TabIndex = 10;
			this.btnIzracunajObimKruga.Text = "Izracunaj Obim Kruga";
			this.btnIzracunajObimKruga.UseVisualStyleBackColor = true;
			this.btnIzracunajObimKruga.Click += new System.EventHandler(this.btnIzracunajObimKruga_Click);
			// 
			// lblPrikazPovrsineKruga
			// 
			this.lblPrikazPovrsineKruga.AutoSize = true;
			this.lblPrikazPovrsineKruga.Location = new System.Drawing.Point(425, 210);
			this.lblPrikazPovrsineKruga.Name = "lblPrikazPovrsineKruga";
			this.lblPrikazPovrsineKruga.Size = new System.Drawing.Size(13, 13);
			this.lblPrikazPovrsineKruga.TabIndex = 11;
			this.lblPrikazPovrsineKruga.Text = "0";
			// 
			// lblPrikazObimaKruga
			// 
			this.lblPrikazObimaKruga.AutoSize = true;
			this.lblPrikazObimaKruga.Location = new System.Drawing.Point(424, 239);
			this.lblPrikazObimaKruga.Name = "lblPrikazObimaKruga";
			this.lblPrikazObimaKruga.Size = new System.Drawing.Size(13, 13);
			this.lblPrikazObimaKruga.TabIndex = 12;
			this.lblPrikazObimaKruga.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPrikazObimaKruga);
			this.Controls.Add(this.lblPrikazPovrsineKruga);
			this.Controls.Add(this.btnIzracunajObimKruga);
			this.Controls.Add(this.btnIzracunajPovrsinuKruga);
			this.Controls.Add(this.txtPoluprecnik);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPrikazZbira);
			this.Controls.Add(this.lblObicanTekst);
			this.Controls.Add(this.txtDrugiSabirak);
			this.Controls.Add(this.lblDrugiSabirak);
			this.Controls.Add(this.txtPrviSabirak);
			this.Controls.Add(this.lblPrviSabirak);
			this.Controls.Add(this.btnZbir);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnZbir;
		private System.Windows.Forms.Label lblPrviSabirak;
		private System.Windows.Forms.TextBox txtPrviSabirak;
		private System.Windows.Forms.Label lblDrugiSabirak;
		private System.Windows.Forms.TextBox txtDrugiSabirak;
		private System.Windows.Forms.Label lblObicanTekst;
		private System.Windows.Forms.Label lblPrikazZbira;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPoluprecnik;
		private System.Windows.Forms.Button btnIzracunajPovrsinuKruga;
		private System.Windows.Forms.Button btnIzracunajObimKruga;
		private System.Windows.Forms.Label lblPrikazPovrsineKruga;
		private System.Windows.Forms.Label lblPrikazObimaKruga;
	}
}

