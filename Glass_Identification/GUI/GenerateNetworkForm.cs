using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glass_Identification.GUI {
    public partial class GenerateNetworkForm : Form {

        private List <int> neuronsPerHL;

        public GenerateNetworkForm (List <int> neuronsPerHL) {
            InitializeComponent ();
            this.neuronsPerHL = neuronsPerHL;

            addHL ();
        }


        private void btn_add_Click (object sender, EventArgs e) {
            addHL ();
        }

        private void addHL () {
            var list = flowLayoutPanel_neuronsPerHL.Controls;

            if (list.Count < 10) {
                list.Add (new ValueUserControl ("HL " + list.Count));
            }
        }

        private void btn_delete_Click (object sender, EventArgs e) {
            var list = flowLayoutPanel_neuronsPerHL.Controls;

            if (list.Count > 1) {
                list.RemoveAt (list.Count - 1);
            }
        }

        private void btn_done_Click (object sender, EventArgs e) {
            var list = flowLayoutPanel_neuronsPerHL.Controls;
            neuronsPerHL.Clear ();

            foreach (Control control in list) {
                if (control is ValueUserControl) {
                    ValueUserControl valueUserControl = (ValueUserControl) control;
                    neuronsPerHL.Add (valueUserControl.Value);
                }
            }

            this.Close ();
        }
    }
}
