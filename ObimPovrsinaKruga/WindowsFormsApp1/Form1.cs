using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		

		private void btnZbir_Click(object sender, EventArgs e) {
			float prviSabirak = (float)Convert.ToDecimal(txtPrviSabirak.Text);
			float drugiSabirak = (float)Convert.ToDecimal(txtDrugiSabirak.Text);
			float zbir = prviSabirak + drugiSabirak;
			lblPrikazZbira.Text = zbir.ToString();
		}

		private void btnIzracunajPovrsinuKruga_Click(object sender, EventArgs e) {
			float poluprecnik = (float)Convert.ToDecimal(txtPoluprecnik.Text);
			float povrsinaKruga = (float)(poluprecnik * poluprecnik * 3.14);
			lblPrikazPovrsineKruga.Text = povrsinaKruga.ToString();
		}

		private void btnIzracunajObimKruga_Click(object sender, EventArgs e) {
			float poluprecnik = (float)Convert.ToDecimal(txtPoluprecnik.Text);
			float obimKruga = (float)(2 * poluprecnik * 3.14);
			lblPrikazObimaKruga.Text = obimKruga.ToString();
		}
	}
}
