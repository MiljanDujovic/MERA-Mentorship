using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			ListViewItem kontaktPodaci = new ListViewItem();
			kontaktPodaci.SubItems.Add(txtName.Text);
			kontaktPodaci.SubItems.Add(txtStreet.Text);
			kontaktPodaci.SubItems.Add(txtCity.Text);
			kontaktPodaci.SubItems.Add(txtState.Text);
			kontaktPodaci.SubItems.Add(txtZip.Text);
			lsvContacts.Items.Add(kontaktPodaci);
		}
	}
}
