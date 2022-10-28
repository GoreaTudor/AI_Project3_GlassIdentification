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
    public partial class MyDialog : Form {
        public MyDialog (string text) {
            InitializeComponent ();

            this.lbl_text.Text = text;
        }

        private void btn_ok_Click (object sender, EventArgs e) {
            this.Close ();
        }
    }
}
