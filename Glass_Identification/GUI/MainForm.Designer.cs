
namespace Glass_Identification {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage_rawData = new System.Windows.Forms.TabPage();
            this.t1_dataGridView_raw = new System.Windows.Forms.DataGridView();
            this.tabPage_normalizedData = new System.Windows.Forms.TabPage();
            this.t2_lbl_testing = new System.Windows.Forms.Label();
            this.t2_lbl_training = new System.Windows.Forms.Label();
            this.t2_dataGridView_testing = new System.Windows.Forms.DataGridView();
            this.t2_dataGridView_training = new System.Windows.Forms.DataGridView();
            this.tabPage_trainingGraph = new System.Windows.Forms.TabPage();
            this.t3_numericUpDown_nrOfEpochs = new System.Windows.Forms.NumericUpDown();
            this.lbl_nrOfEpochs = new System.Windows.Forms.Label();
            this.lbl_espilon = new System.Windows.Forms.Label();
            this.t3_numericUpDown_epsilon = new System.Windows.Forms.NumericUpDown();
            this.t3_btn_stop = new System.Windows.Forms.Button();
            this.t3_btn_start = new System.Windows.Forms.Button();
            this.t3_lbl_learningRate = new System.Windows.Forms.Label();
            this.t3_numericUpDown_learningRate = new System.Windows.Forms.NumericUpDown();
            this.t3_btn_network = new System.Windows.Forms.Button();
            this.t3_zedGraphControl = new ZedGraph.ZedGraphControl();
            this.tabPage_testing = new System.Windows.Forms.TabPage();
            this.t4_dataGridView_testing = new System.Windows.Forms.DataGridView();
            this.t4_lbl_testDataset = new System.Windows.Forms.Label();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainTabControl.SuspendLayout();
            this.tabPage_rawData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t1_dataGridView_raw)).BeginInit();
            this.tabPage_normalizedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2_dataGridView_testing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_dataGridView_training)).BeginInit();
            this.tabPage_trainingGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_nrOfEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_epsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_learningRate)).BeginInit();
            this.tabPage_testing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t4_dataGridView_testing)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage_rawData);
            this.mainTabControl.Controls.Add(this.tabPage_normalizedData);
            this.mainTabControl.Controls.Add(this.tabPage_trainingGraph);
            this.mainTabControl.Controls.Add(this.tabPage_testing);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1460, 757);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // tabPage_rawData
            // 
            this.tabPage_rawData.Controls.Add(this.t1_dataGridView_raw);
            this.tabPage_rawData.Location = new System.Drawing.Point(4, 29);
            this.tabPage_rawData.Name = "tabPage_rawData";
            this.tabPage_rawData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rawData.Size = new System.Drawing.Size(1452, 724);
            this.tabPage_rawData.TabIndex = 0;
            this.tabPage_rawData.Text = "Raw Data";
            this.tabPage_rawData.UseVisualStyleBackColor = true;
            // 
            // t1_dataGridView_raw
            // 
            this.t1_dataGridView_raw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t1_dataGridView_raw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t1_dataGridView_raw.Location = new System.Drawing.Point(3, 3);
            this.t1_dataGridView_raw.Name = "t1_dataGridView_raw";
            this.t1_dataGridView_raw.RowHeadersWidth = 51;
            this.t1_dataGridView_raw.RowTemplate.Height = 24;
            this.t1_dataGridView_raw.Size = new System.Drawing.Size(1446, 718);
            this.t1_dataGridView_raw.TabIndex = 0;
            // 
            // tabPage_normalizedData
            // 
            this.tabPage_normalizedData.Controls.Add(this.t2_lbl_testing);
            this.tabPage_normalizedData.Controls.Add(this.t2_lbl_training);
            this.tabPage_normalizedData.Controls.Add(this.t2_dataGridView_testing);
            this.tabPage_normalizedData.Controls.Add(this.t2_dataGridView_training);
            this.tabPage_normalizedData.Location = new System.Drawing.Point(4, 29);
            this.tabPage_normalizedData.Name = "tabPage_normalizedData";
            this.tabPage_normalizedData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_normalizedData.Size = new System.Drawing.Size(1452, 724);
            this.tabPage_normalizedData.TabIndex = 1;
            this.tabPage_normalizedData.Text = "Normalized Data";
            this.tabPage_normalizedData.UseVisualStyleBackColor = true;
            // 
            // t2_lbl_testing
            // 
            this.t2_lbl_testing.AutoSize = true;
            this.t2_lbl_testing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2_lbl_testing.Location = new System.Drawing.Point(6, 370);
            this.t2_lbl_testing.Name = "t2_lbl_testing";
            this.t2_lbl_testing.Size = new System.Drawing.Size(168, 25);
            this.t2_lbl_testing.TabIndex = 3;
            this.t2_lbl_testing.Text = "Testing dataset:";
            // 
            // t2_lbl_training
            // 
            this.t2_lbl_training.AutoSize = true;
            this.t2_lbl_training.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2_lbl_training.Location = new System.Drawing.Point(6, 3);
            this.t2_lbl_training.Name = "t2_lbl_training";
            this.t2_lbl_training.Size = new System.Drawing.Size(175, 25);
            this.t2_lbl_training.TabIndex = 2;
            this.t2_lbl_training.Text = "Training dataset:";
            // 
            // t2_dataGridView_testing
            // 
            this.t2_dataGridView_testing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t2_dataGridView_testing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t2_dataGridView_testing.Location = new System.Drawing.Point(8, 398);
            this.t2_dataGridView_testing.Name = "t2_dataGridView_testing";
            this.t2_dataGridView_testing.RowHeadersWidth = 51;
            this.t2_dataGridView_testing.RowTemplate.Height = 24;
            this.t2_dataGridView_testing.Size = new System.Drawing.Size(1436, 320);
            this.t2_dataGridView_testing.TabIndex = 1;
            // 
            // t2_dataGridView_training
            // 
            this.t2_dataGridView_training.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t2_dataGridView_training.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t2_dataGridView_training.Location = new System.Drawing.Point(8, 31);
            this.t2_dataGridView_training.Name = "t2_dataGridView_training";
            this.t2_dataGridView_training.RowHeadersWidth = 51;
            this.t2_dataGridView_training.RowTemplate.Height = 24;
            this.t2_dataGridView_training.Size = new System.Drawing.Size(1436, 320);
            this.t2_dataGridView_training.TabIndex = 0;
            // 
            // tabPage_trainingGraph
            // 
            this.tabPage_trainingGraph.Controls.Add(this.t3_numericUpDown_nrOfEpochs);
            this.tabPage_trainingGraph.Controls.Add(this.lbl_nrOfEpochs);
            this.tabPage_trainingGraph.Controls.Add(this.lbl_espilon);
            this.tabPage_trainingGraph.Controls.Add(this.t3_numericUpDown_epsilon);
            this.tabPage_trainingGraph.Controls.Add(this.t3_btn_stop);
            this.tabPage_trainingGraph.Controls.Add(this.t3_btn_start);
            this.tabPage_trainingGraph.Controls.Add(this.t3_lbl_learningRate);
            this.tabPage_trainingGraph.Controls.Add(this.t3_numericUpDown_learningRate);
            this.tabPage_trainingGraph.Controls.Add(this.t3_btn_network);
            this.tabPage_trainingGraph.Controls.Add(this.t3_zedGraphControl);
            this.tabPage_trainingGraph.Location = new System.Drawing.Point(4, 29);
            this.tabPage_trainingGraph.Name = "tabPage_trainingGraph";
            this.tabPage_trainingGraph.Size = new System.Drawing.Size(1452, 724);
            this.tabPage_trainingGraph.TabIndex = 2;
            this.tabPage_trainingGraph.Text = "Training Graph";
            this.tabPage_trainingGraph.UseVisualStyleBackColor = true;
            // 
            // t3_numericUpDown_nrOfEpochs
            // 
            this.t3_numericUpDown_nrOfEpochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_numericUpDown_nrOfEpochs.Location = new System.Drawing.Point(221, 530);
            this.t3_numericUpDown_nrOfEpochs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.t3_numericUpDown_nrOfEpochs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.t3_numericUpDown_nrOfEpochs.Name = "t3_numericUpDown_nrOfEpochs";
            this.t3_numericUpDown_nrOfEpochs.Size = new System.Drawing.Size(120, 30);
            this.t3_numericUpDown_nrOfEpochs.TabIndex = 9;
            this.t3_numericUpDown_nrOfEpochs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_nrOfEpochs
            // 
            this.lbl_nrOfEpochs.AutoSize = true;
            this.lbl_nrOfEpochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nrOfEpochs.Location = new System.Drawing.Point(8, 532);
            this.lbl_nrOfEpochs.Name = "lbl_nrOfEpochs";
            this.lbl_nrOfEpochs.Size = new System.Drawing.Size(182, 25);
            this.lbl_nrOfEpochs.TabIndex = 8;
            this.lbl_nrOfEpochs.Text = "Number of epochs: ";
            // 
            // lbl_espilon
            // 
            this.lbl_espilon.AutoSize = true;
            this.lbl_espilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_espilon.Location = new System.Drawing.Point(9, 496);
            this.lbl_espilon.Name = "lbl_espilon";
            this.lbl_espilon.Size = new System.Drawing.Size(87, 25);
            this.lbl_espilon.TabIndex = 7;
            this.lbl_espilon.Text = "Epsilon: ";
            // 
            // t3_numericUpDown_epsilon
            // 
            this.t3_numericUpDown_epsilon.DecimalPlaces = 2;
            this.t3_numericUpDown_epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_numericUpDown_epsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.t3_numericUpDown_epsilon.Location = new System.Drawing.Point(221, 494);
            this.t3_numericUpDown_epsilon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.t3_numericUpDown_epsilon.Name = "t3_numericUpDown_epsilon";
            this.t3_numericUpDown_epsilon.Size = new System.Drawing.Size(120, 30);
            this.t3_numericUpDown_epsilon.TabIndex = 6;
            this.t3_numericUpDown_epsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // t3_btn_stop
            // 
            this.t3_btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t3_btn_stop.BackColor = System.Drawing.SystemColors.Control;
            this.t3_btn_stop.Enabled = false;
            this.t3_btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_btn_stop.Location = new System.Drawing.Point(1369, 460);
            this.t3_btn_stop.Name = "t3_btn_stop";
            this.t3_btn_stop.Size = new System.Drawing.Size(80, 40);
            this.t3_btn_stop.TabIndex = 5;
            this.t3_btn_stop.Text = "Stop";
            this.t3_btn_stop.UseVisualStyleBackColor = false;
            this.t3_btn_stop.Click += new System.EventHandler(this.t3_btn_stop_Click);
            // 
            // t3_btn_start
            // 
            this.t3_btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t3_btn_start.BackColor = System.Drawing.SystemColors.Control;
            this.t3_btn_start.Enabled = false;
            this.t3_btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_btn_start.Location = new System.Drawing.Point(1283, 460);
            this.t3_btn_start.Name = "t3_btn_start";
            this.t3_btn_start.Size = new System.Drawing.Size(80, 40);
            this.t3_btn_start.TabIndex = 4;
            this.t3_btn_start.Text = "Start";
            this.t3_btn_start.UseVisualStyleBackColor = false;
            this.t3_btn_start.Click += new System.EventHandler(this.t3_btn_start_Click);
            // 
            // t3_lbl_learningRate
            // 
            this.t3_lbl_learningRate.AutoSize = true;
            this.t3_lbl_learningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_lbl_learningRate.Location = new System.Drawing.Point(9, 460);
            this.t3_lbl_learningRate.Name = "t3_lbl_learningRate";
            this.t3_lbl_learningRate.Size = new System.Drawing.Size(139, 25);
            this.t3_lbl_learningRate.TabIndex = 3;
            this.t3_lbl_learningRate.Text = "Learning Rate:";
            // 
            // t3_numericUpDown_learningRate
            // 
            this.t3_numericUpDown_learningRate.DecimalPlaces = 1;
            this.t3_numericUpDown_learningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_numericUpDown_learningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.t3_numericUpDown_learningRate.Location = new System.Drawing.Point(221, 458);
            this.t3_numericUpDown_learningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.t3_numericUpDown_learningRate.Name = "t3_numericUpDown_learningRate";
            this.t3_numericUpDown_learningRate.Size = new System.Drawing.Size(120, 30);
            this.t3_numericUpDown_learningRate.TabIndex = 2;
            this.t3_numericUpDown_learningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // t3_btn_network
            // 
            this.t3_btn_network.BackColor = System.Drawing.Color.Lime;
            this.t3_btn_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_btn_network.Location = new System.Drawing.Point(5, 3);
            this.t3_btn_network.Name = "t3_btn_network";
            this.t3_btn_network.Size = new System.Drawing.Size(200, 40);
            this.t3_btn_network.TabIndex = 1;
            this.t3_btn_network.Text = "Generate Network";
            this.t3_btn_network.UseVisualStyleBackColor = false;
            this.t3_btn_network.Click += new System.EventHandler(this.t3_btn_network_Click);
            // 
            // t3_zedGraphControl
            // 
            this.t3_zedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t3_zedGraphControl.Location = new System.Drawing.Point(5, 51);
            this.t3_zedGraphControl.Margin = new System.Windows.Forms.Padding(5);
            this.t3_zedGraphControl.Name = "t3_zedGraphControl";
            this.t3_zedGraphControl.ScrollGrace = 0D;
            this.t3_zedGraphControl.ScrollMaxX = 0D;
            this.t3_zedGraphControl.ScrollMaxY = 0D;
            this.t3_zedGraphControl.ScrollMaxY2 = 0D;
            this.t3_zedGraphControl.ScrollMinX = 0D;
            this.t3_zedGraphControl.ScrollMinY = 0D;
            this.t3_zedGraphControl.ScrollMinY2 = 0D;
            this.t3_zedGraphControl.Size = new System.Drawing.Size(1442, 400);
            this.t3_zedGraphControl.TabIndex = 0;
            // 
            // tabPage_testing
            // 
            this.tabPage_testing.Controls.Add(this.t4_dataGridView_testing);
            this.tabPage_testing.Controls.Add(this.t4_lbl_testDataset);
            this.tabPage_testing.Location = new System.Drawing.Point(4, 29);
            this.tabPage_testing.Name = "tabPage_testing";
            this.tabPage_testing.Size = new System.Drawing.Size(1452, 724);
            this.tabPage_testing.TabIndex = 3;
            this.tabPage_testing.Text = "Testing";
            this.tabPage_testing.UseVisualStyleBackColor = true;
            // 
            // t4_dataGridView_testing
            // 
            this.t4_dataGridView_testing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t4_dataGridView_testing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t4_dataGridView_testing.Location = new System.Drawing.Point(8, 316);
            this.t4_dataGridView_testing.Name = "t4_dataGridView_testing";
            this.t4_dataGridView_testing.RowHeadersWidth = 51;
            this.t4_dataGridView_testing.RowTemplate.Height = 24;
            this.t4_dataGridView_testing.Size = new System.Drawing.Size(1436, 400);
            this.t4_dataGridView_testing.TabIndex = 1;
            // 
            // t4_lbl_testDataset
            // 
            this.t4_lbl_testDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t4_lbl_testDataset.AutoSize = true;
            this.t4_lbl_testDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4_lbl_testDataset.Location = new System.Drawing.Point(3, 288);
            this.t4_lbl_testDataset.Name = "t4_lbl_testDataset";
            this.t4_lbl_testDataset.Size = new System.Drawing.Size(148, 25);
            this.t4_lbl_testDataset.TabIndex = 0;
            this.t4_lbl_testDataset.Text = "Test Dataset: ";
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainBackgroundWorker_DoWork);
            this.mainBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mainBackgroundWorker_ProgressChanged);
            this.mainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 757);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage_rawData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t1_dataGridView_raw)).EndInit();
            this.tabPage_normalizedData.ResumeLayout(false);
            this.tabPage_normalizedData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2_dataGridView_testing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_dataGridView_training)).EndInit();
            this.tabPage_trainingGraph.ResumeLayout(false);
            this.tabPage_trainingGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_nrOfEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_epsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_numericUpDown_learningRate)).EndInit();
            this.tabPage_testing.ResumeLayout(false);
            this.tabPage_testing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t4_dataGridView_testing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage_rawData;
        private System.Windows.Forms.TabPage tabPage_normalizedData;
        private System.Windows.Forms.TabPage tabPage_trainingGraph;
        private System.Windows.Forms.TabPage tabPage_testing;
        private System.Windows.Forms.DataGridView t1_dataGridView_raw;
        private System.Windows.Forms.DataGridView t2_dataGridView_training;
        private System.Windows.Forms.DataGridView t2_dataGridView_testing;
        private System.Windows.Forms.Label t2_lbl_training;
        private System.Windows.Forms.Label t2_lbl_testing;
        private ZedGraph.ZedGraphControl t3_zedGraphControl;
        private System.Windows.Forms.Button t3_btn_network;
        private System.Windows.Forms.Label t3_lbl_learningRate;
        private System.Windows.Forms.NumericUpDown t3_numericUpDown_learningRate;
        private System.Windows.Forms.Button t3_btn_stop;
        private System.Windows.Forms.Button t3_btn_start;
        private System.Windows.Forms.NumericUpDown t3_numericUpDown_epsilon;
        private System.Windows.Forms.Label lbl_espilon;
        private System.Windows.Forms.Label t4_lbl_testDataset;
        private System.Windows.Forms.DataGridView t4_dataGridView_testing;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
        private System.Windows.Forms.Label lbl_nrOfEpochs;
        private System.Windows.Forms.NumericUpDown t3_numericUpDown_nrOfEpochs;
    }
}