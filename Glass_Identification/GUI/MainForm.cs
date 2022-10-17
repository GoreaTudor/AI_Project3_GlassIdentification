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
            try {
                loadData ();
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
            }
        }


        private void loadData () {
            List <GlassData> glassData = new List <GlassData> ();

            using (var reader = new StreamReader (HiddenClass.datasetPath)) {
                string line;
                string[] values;

                while (!reader.EndOfStream) {
                    line = reader.ReadLine ();
                    values = line.Split (',');

                    GlassData data = new GlassData {
                        ID = Convert.ToInt32(values[0]),
                        RefractiveIndex = Convert.ToDouble (values[1]),
                        SodiumPercentage = Convert.ToDouble (values[2]),
                        MagnesiumPercentage = Convert.ToDouble (values[3]),
                        AluminumPercentage = Convert.ToDouble (values[4]),
                        SiliconPercentage = Convert.ToDouble (values[5]),
                        PotassiumPercentage = Convert.ToDouble (values[6]),
                        CalciumPercentage = Convert.ToDouble (values[7]),
                        BariumPercentage = Convert.ToDouble (values[8]),
                        IronPercentage = Convert.ToDouble (values[9]),
                        TypeOfGlass = Convert.ToInt32 (values[10])
                    };

                    glassData.Add (data);
                    //Console.WriteLine (data.ToString());
                }
            }

            dataGridView_dataset.DataSource = glassData;
        }


    }
}
