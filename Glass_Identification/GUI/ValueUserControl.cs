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
    public partial class ValueUserControl : UserControl {
        public int Value {
            get {
                return (int) this.numericUpDown_value.Value;
            }
        }

        public ValueUserControl (string text) {
            InitializeComponent ();
            this.lbl_name.Text = text;
        }
    }
}
