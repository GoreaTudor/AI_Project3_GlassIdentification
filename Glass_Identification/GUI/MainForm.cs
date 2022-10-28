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
using Glass_Identification.GUI;
using Glass_Identification.AI;
using ZedGraph;

namespace Glass_Identification {
    public partial class MainForm : Form {
        public MainForm () {
            InitializeComponent ();

            T1_setup ();
            T2_setup ();
            T3_setup ();
            T4_setup ();

            mainBackgroundWorker.WorkerReportsProgress = true;
            mainBackgroundWorker.WorkerSupportsCancellation = true;
            
            tabChange (this.mainTabControl.SelectedIndex);
        }

        private bool rawDataLoaded = false;
        private bool dataNormalized = false;
        private bool networkGenerated {
            get {
                return (Global.network != null);
            }
        }


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
                if (networkGenerated) { // enable train buttons
                    ;
                }

                T4_loadData ();
            }
        }


        #region Events
        private void mainTabControl_SelectedIndexChanged (object sender, EventArgs e) {
            tabChange (this.mainTabControl.SelectedIndex);
        }

        private void t3_btn_network_Click (object sender, EventArgs e) {
            List <int> neuronsPerHL = new List <int> ();
            GenerateNetworkForm form = new GenerateNetworkForm(neuronsPerHL);
            form.ShowDialog ();

            Global.network = new NeuralNetwork (neuronsPerHL);

            t3_btn_start.Enabled = true;
        }


        private void t3_btn_start_Click (object sender, EventArgs e) {
            if (! mainBackgroundWorker.IsBusy) {
                t3_btn_start.Enabled = false;
                t3_btn_stop.Enabled = true;

                T3_clearGraph ();

                TrainingArguments arguments = new TrainingArguments {
                    epsilon = (double) t3_numericUpDown_epsilon.Value,
                    learningRate = (double) t3_numericUpDown_learningRate.Value,
                    numberOfEpochs = (int) t3_numericUpDown_nrOfEpochs.Value,
                    trainingDataset = Global.TrainingData
                };

                T3_initEpsilon (arguments.epsilon, arguments.numberOfEpochs);

                Console.WriteLine ("Starting BackgroundWorker...");
                mainBackgroundWorker.RunWorkerAsync (arguments);

            } else {
                Console.WriteLine ("Couldn't Start BackgroundWorker!");
            }
        }

        private void t3_btn_stop_Click (object sender, EventArgs e) {
            Console.WriteLine ("Stop");

            if (mainBackgroundWorker.WorkerSupportsCancellation) {
                mainBackgroundWorker.CancelAsync ();
            }

            t3_btn_start.Enabled = true;
            t3_btn_stop.Enabled = false;
        }

        private void t3_btn_rescale_Click (object sender, EventArgs e) {
            double xScale = (double) t3_numericUpDown_XScale.Value;
            double yScale = (double) t3_numericUpDown_YScale.Value;

            T3_rescaleGraph (xScale, yScale);
            T3_refreshGraph ();
        }


        private void t4_btn_test_Click (object sender, EventArgs e) {
            if (networkGenerated) {
                Console.WriteLine ("Test");
                T4_testData ();

            } else {
                Console.WriteLine ("Network not generated!");
                MyDialog dialog = new MyDialog ("Network not generated!");
                dialog.ShowDialog ();
            }
            
        }


        private void mainBackgroundWorker_DoWork (object sender, DoWorkEventArgs e) {
            Console.WriteLine ("BackgroundWorker Started.");

            BackgroundWorker worker = sender as BackgroundWorker;
            TrainingArguments arguments = e.Argument as TrainingArguments;

            double epochError = arguments.epsilon + 1;

            for (int epoch = 1; epoch <= arguments.numberOfEpochs && epochError > arguments.epsilon; epoch ++) {
                if (worker.CancellationPending) {
                    e.Cancel = true;
                    Console.WriteLine ("Cancelling BackgroundWorker...");
                    break;

                } else { /// Inside the epoch ///
                    Global.network.epoch_error_sum = 0;

                    foreach (GlassDataNormalized item in arguments.trainingDataset) { /// Inside each step ///
                        Global.network.backpropagation (item.getInputs(), item.getOutputs(), arguments.learningRate);
                    }

                    epochError = Global.network.epoch_error_sum / (double) arguments.trainingDataset.Count;

                    if (epoch % 1 == 0) {
                        PointPair point = new PointPair (epoch, epochError);
                        worker.ReportProgress (0, point);
                    }
                }
            }
        }

        private void mainBackgroundWorker_ProgressChanged (object sender, ProgressChangedEventArgs e) {
            PointPair point = e.UserState as PointPair;
            Console.WriteLine ($"epoch: {point.X} ---> {point.Y}");

            epochPointsList.Add (point);
            T3_refreshGraph ();
        }

        private void mainBackgroundWorker_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                Console.WriteLine ("BackroundWorker Canceled.");

            } else if (e.Error != null) {
                Console.WriteLine ("BackgroundWorker Error: " + e.Error);

            } else {
                Console.WriteLine ("BackgroundWorker DONE");
            }

            t3_btn_start.Enabled = true;
            t3_btn_stop.Enabled = false;
        }
        #endregion


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
        private PointPairList epochPointsList = new PointPairList ();
        private PointPairList epsilonPointsList = new PointPairList ();

        private void T3_setup () {
            if (! networkGenerated) {
                this.t3_btn_start.Enabled = false;
                this.t3_btn_stop.Enabled = false;
            }

            T3_initGraph ();
        }

        private void T3_initGraph  () {
            GraphPane graphPane = t3_zedGraphControl.GraphPane;

            graphPane.XAxis.Title.Text = "Epochs";
            graphPane.YAxis.Title.Text = "Error";

            graphPane.AddCurve ("Error", epochPointsList, Color.Blue, SymbolType.Circle);
            graphPane.AddCurve ("Epsilon", epsilonPointsList, Color.Red, SymbolType.Circle);
        }

        private void T3_initEpsilon (double epsilon, int numberOfEpochs) {
            T3_rescaleGraph (numberOfEpochs + 1, 0.5);

            epsilonPointsList.Add (1.0, epsilon);
            epsilonPointsList.Add (numberOfEpochs, epsilon);
            T3_refreshGraph ();
        }

        private void T3_rescaleGraph (double x, double y) {
            t3_zedGraphControl.GraphPane.XAxis.Scale.Min = -1;
            t3_zedGraphControl.GraphPane.XAxis.Scale.Max = x + 1;

            t3_zedGraphControl.GraphPane.YAxis.Scale.Min = 0;
            t3_zedGraphControl.GraphPane.YAxis.Scale.Max = y;
        }

        private void T3_refreshGraph () {
            t3_zedGraphControl.AxisChange ();
            t3_zedGraphControl.Invalidate ();
            t3_zedGraphControl.Update ();
            t3_zedGraphControl.Refresh ();
        }

        private void T3_clearGraph () {
            epochPointsList.Clear ();
            epsilonPointsList.Clear ();
            T3_refreshGraph ();
        }
        #endregion


        #region Tab 4 - testing
        private void T4_setup () {
            T4_setupDGV (t4_dataGridView_testing);
        }

        private void T4_setupDGV (DataGridView dataGridView) {
            T2_setupDGV (dataGridView);
        }

        private void T4_loadData () {
            t4_dataGridView_testing.Rows.Clear ();
            foreach (GlassDataNormalized item in Global.TestingData) {
                t4_dataGridView_testing.Rows.Add (
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

        private void T4_testData () {
            double percentage = Global.network.testNetwork (Global.TestingData);

            MyDialog dialog = new MyDialog ($"Performance: {HiddenClass.f(percentage)}%");
            dialog.ShowDialog ();
        }

        #endregion

        
    }
}
