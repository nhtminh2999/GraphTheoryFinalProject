namespace BellmanFordSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_importFile = new System.Windows.Forms.Button();
            this.btn_importManual = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_To = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.dt = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_importFile
            // 
            this.btn_importFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importFile.Location = new System.Drawing.Point(12, 12);
            this.btn_importFile.Name = "btn_importFile";
            this.btn_importFile.Size = new System.Drawing.Size(82, 35);
            this.btn_importFile.TabIndex = 4;
            this.btn_importFile.Text = "Import from file";
            this.btn_importFile.UseVisualStyleBackColor = true;
            this.btn_importFile.Click += new System.EventHandler(this.btn_importFile_Click);
            // 
            // btn_importManual
            // 
            this.btn_importManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importManual.Location = new System.Drawing.Point(100, 12);
            this.btn_importManual.Name = "btn_importManual";
            this.btn_importManual.Size = new System.Drawing.Size(85, 35);
            this.btn_importManual.TabIndex = 14;
            this.btn_importManual.Text = "Import manually";
            this.btn_importManual.UseVisualStyleBackColor = true;
            this.btn_importManual.Click += new System.EventHandler(this.btn_importManual_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(191, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 35);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(279, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 35);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Enabled = false;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(497, 12);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(154, 36);
            this.btn_Find.TabIndex = 20;
            this.btn_Find.Text = "Find shortest path";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_from
            // 
            this.cb_from.Enabled = false;
            this.cb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Location = new System.Drawing.Point(727, 19);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(51, 28);
            this.cb_from.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_To
            // 
            this.cb_To.Enabled = false;
            this.cb_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_To.FormattingEnabled = true;
            this.cb_To.Location = new System.Drawing.Point(831, 20);
            this.cb_To.Name = "cb_To";
            this.cb_To.Size = new System.Drawing.Size(51, 28);
            this.cb_To.TabIndex = 24;
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(3, 76);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(935, 412);
            this.pb.TabIndex = 25;
            this.pb.TabStop = false;
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt.GridColor = System.Drawing.SystemColors.Control;
            this.dt.Location = new System.Drawing.Point(797, 180);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dt.Size = new System.Drawing.Size(141, 20);
            this.dt.TabIndex = 26;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(3, 523);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 13);
            this.labelResult.TabIndex = 28;
            this.labelResult.Text = "asdfasfas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 57);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.cb_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_importManual);
            this.Controls.Add(this.btn_importFile);
            this.Name = "Form1";
            this.Text = "Bellman-Ford algorithm simulation";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importFile;
        private System.Windows.Forms.Button btn_importManual;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_To;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label4;
    }
}

