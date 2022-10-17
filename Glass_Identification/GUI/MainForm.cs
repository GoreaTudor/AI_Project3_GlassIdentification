using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Glass_Identification.Data;

namespace Glass_Identification {
    public partial class MainForm : Form {
        public MainForm () {
            InitializeComponent ();
        }

        private void btn_load_Click (object sender, EventArgs e) {
            List <GlassData> glassData = new List <GlassData> ();
        }
    }
}
