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

            T1_setup ();
            T2_setup ();
            T3_setup ();
            T4_setup ();
            
            tabChange (this.mainTabControl.SelectedIndex);
        }

        #region Events
        private void mainTabControl_SelectedIndexChanged (object sender, EventArgs e) {
            tabChange (this.mainTabControl.SelectedIndex);
        }
        #endregion

        private bool rawDataLoaded = false;
        private bool dataNormalized = false;


        private void tabChange (int index) {
            Console.WriteLine (this.mainTabControl.SelectedIndex);

            if (index >= 0) { // load raw data
                if (!rawDataLoaded) {
                    T1_loadData ();

                    rawDataLoaded = true;
                }
            }

            if (index >= 1) { // normalize data, shuffle and split (70% - training, 30% - testing)
                if (!dataNormalized) {
                    List<GlassDataNormalized> normalizedData = DataUtilities.NormalizeData (Global.RawData);
                    DataUtilities.ShuffleData (normalizedData);
                    DataUtilities.SplitData (normalizedData);

                    T2_loadData ();

                    dataNormalized = true;
                }
                
            }

            if (index >= 2) { // prepare and train the network
                ;
            }

            if (index >= 3) {
                ;
            }
        }


        #region Tab 1 - raw data
        private void T1_setup () {
            T1_setupDGV (this.t1_dataGridView_raw);
        }

        private void T1_loadData () {
            t1_dataGridView_raw.Rows.Clear ();

            using (var reader = new StreamReader (HiddenClass.datasetPath)) {
                string line;
                string[] values;

                while (!reader.EndOfStream) {
                    line = reader.ReadLine ();
                    values = line.Split (',');

                    GlassDataRaw data = new GlassDataRaw {
                        ID = Convert.ToInt32 (values[0]),
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

                    Global.RawData.Add (data);

                    t1_dataGridView_raw.Rows.Add (
                        values[0], 
                        values[1], 
                        values[2], 
                        values[3], 
                        values[4], 
                        values[5],
                        values[6],
                        values[7],
                        values[8],
                        values[9],
                        values[10]
                    );
                }
            }
        }

        private void T1_setupDGV (DataGridView dataGridView) {
            dataGridView.ColumnCount = 11;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Refractive index";
            dataGridView.Columns[2].Name = "Sodium %";
            dataGridView.Columns[3].Name = "Magnesium %";
            dataGridView.Columns[4].Name = "Aluminum %";
            dataGridView.Columns[5].Name = "Silicon %";
            dataGridView.Columns[6].Name = "Potassium %";
            dataGridView.Columns[7].Name = "Calcium %";
            dataGridView.Columns[8].Name = "Barium %";
            dataGridView.Columns[9].Name = "Iron %";
            dataGridView.Columns[10].Name = "Type of glass";
        }
        #endregion


        #region Tab 2 - normalized data
        private void T2_setup () {
            T2_setupDGV (this.t2_dataGridView_training);
            T2_setupDGV (this.t2_dataGridView_testing);
        }

        private void T2_setupDGV (DataGridView dataGridView) {
            dataGridView.ColumnCount = 17;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Refractive index";
            dataGridView.Columns[2].Name = "Sodium %";
            dataGridView.Columns[3].Name = "Magnesium %";
            dataGridView.Columns[4].Name = "Aluminum %";
            dataGridView.Columns[5].Name = "Silicon %";
            dataGridView.Columns[6].Name = "Potassium %";
            dataGridView.Columns[7].Name = "Calcium %";
            dataGridView.Columns[8].Name = "Barium %";
            dataGridView.Columns[9].Name = "Iron %";
            dataGridView.Columns[10].Name = "Type 1 - building flat";
            dataGridView.Columns[11].Name = "Type 2 - building non flat";
            dataGridView.Columns[12].Name = "Type 3 - vehicle flat";
            dataGridView.Columns[13].Name = "Type 4 - vehicle non flat";
            dataGridView.Columns[14].Name = "Type 5 - containers";
            dataGridView.Columns[15].Name = "Type 6 - tableware";
            dataGridView.Columns[16].Name = "Type 7 - headlamps";
        }

        private void T2_loadData () {
            t2_dataGridView_training.Rows.Clear();
            foreach (GlassDataNormalized item in Global.TrainingData) {
                t2_dataGridView_training.Rows.Add (
                    item.ID,
                    item.RefractiveIndex,       // 2
                    item.SodiumPercentage,      // 3
                    item.MagnesiumPercentage,   // 4
                    item.AluminumPercentage,    // 5
                    item.SiliconPercentage,     // 6
                    item.PotassiumPercentage,   // 7
                    item.CalciumPercentage,     // 8
                    item.BariumPercentage,      // 9
                    item.IronPercentage,        // 10

                    item.Type_1,
                    item.Type_2,
                    item.Type_3,
                    item.Type_4,
                    item.Type_5,
                    item.Type_6,
                    item.Type_7
                );
            }

            t2_dataGridView_testing.Rows.Clear ();
            foreach (GlassDataNormalized item in Global.TestingData) {
                t2_dataGridView_testing.Rows.Add (
                    item.ID,
                    item.RefractiveIndex,       // 2
                    item.SodiumPercentage,      // 3
                    item.MagnesiumPercentage,   // 4
                    item.AluminumPercentage,    // 5
                    item.SiliconPercentage,     // 6
                    item.PotassiumPercentage,   // 7
                    item.CalciumPercentage,     // 8
                    item.BariumPercentage,      // 9
                    item.IronPercentage,        // 10

                    item.Type_1,
                    item.Type_1,
                    item.Type_2,
                    item.Type_3,
                    item.Type_4,
                    item.Type_5,
                    item.Type_6,
                    item.Type_7
                );
            }
        }
        #endregion


        #region Tab 3 - training graph
        private void T3_setup () {

        }
        #endregion


        #region Tab 4 - testing
        private void T4_setup () {

        }
        #endregion
    }
}
