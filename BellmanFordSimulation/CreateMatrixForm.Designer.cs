namespace BellmanFordSimulation
{
    partial class CreateMatrixForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBox_Vertex = new System.Windows.Forms.TextBox();
            this.btn_enterVertex = new System.Windows.Forms.Button();
            this.btn_randomMatrix = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveTxt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_WeightedGraph = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBox_Weight = new System.Windows.Forms.TextBox();
            this.cb_Dest = new System.Windows.Forms.ComboBox();
            this.cb_Source = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dt_WeightedGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Vertex
            // 
            this.txtBox_Vertex.Location = new System.Drawing.Point(163, 12);
            this.txtBox_Vertex.Name = "txtBox_Vertex";
            this.txtBox_Vertex.Size = new System.Drawing.Size(273, 20);
            this.txtBox_Vertex.TabIndex = 1;
            // 
            // btn_enterVertex
            // 
            this.btn_enterVertex.Location = new System.Drawing.Point(451, 12);
            this.btn_enterVertex.Name = "btn_enterVertex";
            this.btn_enterVertex.Size = new System.Drawing.Size(140, 23);
            this.btn_enterVertex.TabIndex = 2;
            this.btn_enterVertex.Text = "Enter number of vertices";
            this.btn_enterVertex.UseVisualStyleBackColor = true;
            this.btn_enterVertex.Click += new System.EventHandler(this.btn_enterVertex_Click);
            // 
            // btn_randomMatrix
            // 
            this.btn_randomMatrix.Enabled = false;
            this.btn_randomMatrix.Location = new System.Drawing.Point(44, 162);
            this.btn_randomMatrix.Name = "btn_randomMatrix";
            this.btn_randomMatrix.Size = new System.Drawing.Size(231, 23);
            this.btn_randomMatrix.TabIndex = 44;
            this.btn_randomMatrix.Text = "Random matrix";
            this.btn_randomMatrix.UseVisualStyleBackColor = true;
            this.btn_randomMatrix.Click += new System.EventHandler(this.btn_randomMatrix_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(47, 329);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(239, 52);
            this.btn_Cancel.TabIndex = 42;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveTxt
            // 
            this.btn_SaveTxt.Enabled = false;
            this.btn_SaveTxt.Location = new System.Drawing.Point(44, 191);
            this.btn_SaveTxt.Name = "btn_SaveTxt";
            this.btn_SaveTxt.Size = new System.Drawing.Size(231, 23);
            this.btn_SaveTxt.TabIndex = 43;
            this.btn_SaveTxt.Text = "Save graph (.txt)";
            this.btn_SaveTxt.UseVisualStyleBackColor = true;
            this.btn_SaveTxt.Click += new System.EventHandler(this.btn_SaveTxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Source";
            // 
            // btn_Finish
            // 
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Location = new System.Drawing.Point(44, 265);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(242, 52);
            this.btn_Finish.TabIndex = 38;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Weighted Graph";
            // 
            // dt_WeightedGraph
            // 
            this.dt_WeightedGraph.AllowUserToAddRows = false;
            this.dt_WeightedGraph.AllowUserToDeleteRows = false;
            this.dt_WeightedGraph.AllowUserToOrderColumns = true;
            this.dt_WeightedGraph.AllowUserToResizeColumns = false;
            this.dt_WeightedGraph.AllowUserToResizeRows = false;
            this.dt_WeightedGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_WeightedGraph.ColumnHeadersVisible = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_WeightedGraph.DefaultCellStyle = dataGridViewCellStyle13;
            this.dt_WeightedGraph.Location = new System.Drawing.Point(307, 85);
            this.dt_WeightedGraph.MultiSelect = false;
            this.dt_WeightedGraph.Name = "dt_WeightedGraph";
            this.dt_WeightedGraph.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_WeightedGraph.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dt_WeightedGraph.RowHeadersVisible = false;
            this.dt_WeightedGraph.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dt_WeightedGraph.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dt_WeightedGraph.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dt_WeightedGraph.Size = new System.Drawing.Size(449, 296);
            this.dt_WeightedGraph.TabIndex = 36;
            this.dt_WeightedGraph.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_WeightedGraph_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(44, 133);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(231, 23);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_Weight
            // 
            this.txtBox_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Weight.Location = new System.Drawing.Point(163, 87);
            this.txtBox_Weight.Name = "txtBox_Weight";
            this.txtBox_Weight.Size = new System.Drawing.Size(103, 26);
            this.txtBox_Weight.TabIndex = 34;
            // 
            // cb_Dest
            // 
            this.cb_Dest.Enabled = false;
            this.cb_Dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Dest.FormattingEnabled = true;
            this.cb_Dest.Location = new System.Drawing.Point(106, 85);
            this.cb_Dest.Name = "cb_Dest";
            this.cb_Dest.Size = new System.Drawing.Size(51, 28);
            this.cb_Dest.TabIndex = 33;
            // 
            // cb_Source
            // 
            this.cb_Source.Enabled = false;
            this.cb_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Source.FormattingEnabled = true;
            this.cb_Source.Location = new System.Drawing.Point(44, 85);
            this.cb_Source.Name = "cb_Source";
            this.cb_Source.Size = new System.Drawing.Size(51, 28);
            this.cb_Source.TabIndex = 32;
            // 
            // CreateMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 416);
            this.Controls.Add(this.btn_randomMatrix);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_WeightedGraph);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Weight);
            this.Controls.Add(this.cb_Dest);
            this.Controls.Add(this.cb_Source);
            this.Controls.Add(this.btn_enterVertex);
            this.Controls.Add(this.txtBox_Vertex);
            this.Name = "CreateMatrixForm";
            this.Text = "Enter graph data";
            ((System.ComponentModel.ISupportInitialize)(this.dt_WeightedGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Vertex;
        private System.Windows.Forms.Button btn_enterVertex;
        private System.Windows.Forms.Button btn_randomMatrix;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_WeightedGraph;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_Weight;
        private System.Windows.Forms.ComboBox cb_Dest;
        private System.Windows.Forms.ComboBox cb_Source;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}