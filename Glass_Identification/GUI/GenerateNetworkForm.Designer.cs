
namespace Glass_Identification.GUI {
    partial class GenerateNetworkForm {
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
            this.lbl_nrOfHL = new System.Windows.Forms.Label();
            this.flowLayoutPanel_neuronsPerHL = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_neuronsPerHL = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nrOfHL
            // 
            this.lbl_nrOfHL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nrOfHL.AutoSize = true;
            this.lbl_nrOfHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nrOfHL.Location = new System.Drawing.Point(273, 9);
            this.lbl_nrOfHL.Name = "lbl_nrOfHL";
            this.lbl_nrOfHL.Size = new System.Drawing.Size(229, 25);
            this.lbl_nrOfHL.TabIndex = 0;
            this.lbl_nrOfHL.Text = "Number of hidden layers:";
            // 
            // flowLayoutPanel_neuronsPerHL
            // 
            this.flowLayoutPanel_neuronsPerHL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_neuronsPerHL.AutoScroll = true;
            this.flowLayoutPanel_neuronsPerHL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel_neuronsPerHL.Location = new System.Drawing.Point(12, 37);
            this.flowLayoutPanel_neuronsPerHL.Name = "flowLayoutPanel_neuronsPerHL";
            this.flowLayoutPanel_neuronsPerHL.Size = new System.Drawing.Size(240, 404);
            this.flowLayoutPanel_neuronsPerHL.TabIndex = 2;
            // 
            // lbl_neuronsPerHL
            // 
            this.lbl_neuronsPerHL.AutoSize = true;
            this.lbl_neuronsPerHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neuronsPerHL.Location = new System.Drawing.Point(12, 9);
            this.lbl_neuronsPerHL.Name = "lbl_neuronsPerHL";
            this.lbl_neuronsPerHL.Size = new System.Drawing.Size(155, 25);
            this.lbl_neuronsPerHL.TabIndex = 3;
            this.lbl_neuronsPerHL.Text = "Neurons per HL:";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(336, 37);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(336, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 40);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(422, 401);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(80, 40);
            this.btn_done.TabIndex = 6;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // GenerateNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 453);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_neuronsPerHL);
            this.Controls.Add(this.flowLayoutPanel_neuronsPerHL);
            this.Controls.Add(this.lbl_nrOfHL);
            this.Name = "GenerateNetworkForm";
            this.Text = "GenerateNetworkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nrOfHL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_neuronsPerHL;
        private System.Windows.Forms.Label lbl_neuronsPerHL;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_done;
    }
}