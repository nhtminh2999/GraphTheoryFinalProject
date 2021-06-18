using System;
using System.IO;
using System.Windows.Forms;

namespace BellmanFordSimulation
{
    public partial class CreateMatrixForm : Form
    {
        public CreateMatrixForm()
        {
            InitializeComponent();
        }

        public int[,] matrix;
        public int vertices;

        private void ToListView()
        {
            dt_WeightedGraph.Columns.Clear();
            dt_WeightedGraph.Rows.Clear();
            int width = dt_WeightedGraph.Width / vertices;
            int height = dt_WeightedGraph.Height / vertices;

            for (int i = 1; i <= vertices; i++)
            {
                dt_WeightedGraph.Columns.Add(i.ToString(), i.ToString());
                dt_WeightedGraph.Columns[i - 1].Width = width;
            }

            for (int i = 0; i < vertices; i++)
            {
                dt_WeightedGraph.Rows.Add();
                dt_WeightedGraph.Rows[i].Height = height;

                for (int j = 0; j < vertices; j++)
                {
                    if (matrix[i, j] == 0 && i != j)
                    {
                        dt_WeightedGraph[j, i].Value = "∞";
                    }
                    else
                        dt_WeightedGraph[j, i].Value = matrix[i, j];
                }
            }
        }

        private void btn_enterVertex_Click(object sender, EventArgs e)
        {
            try
            {
                vertices = Convert.ToInt32(txtBox_Vertex.Text);

                if (vertices <= 1)
                {
                    MessageBox.Show("You must enter 2 or more vertices!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (vertices > 10)
                {
                    MessageBox.Show("You can only enter up to 10 vertices  !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btn_enterVertex.Enabled = false;
                    txtBox_Vertex.Enabled = false;

                    matrix = new int[vertices, vertices];
                    cb_Source.Items.Clear();
                    cb_Dest.Items.Clear();
                    for (int i = 1; i <= vertices; i++)
                    {
                        cb_Source.Items.Add(i);
                        cb_Dest.Items.Add(i);
                    }
                    cb_Source.Enabled = cb_Dest.Enabled = btn_Finish.Enabled
                        = btn_Add.Enabled = btn_randomMatrix.Enabled = btn_SaveTxt.Enabled = true;

                    ToListView();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int source = int.Parse(cb_Source.Text);
            int dest = int.Parse(cb_Dest.Text);
            int weight = int.Parse(txtBox_Weight.Text);
            if (source == dest)
            {
                MessageBox.Show("Invalid data");
            }
            else
                matrix[source - 1, dest - 1] = matrix[dest - 1, source - 1] = weight;

            ToListView();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            Graph.matrix = matrix;
            Graph.vertices = vertices;

            this.Close();
        }

        private void dt_WeightedGraph_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Source.Text = (e.RowIndex + 1).ToString();
            cb_Dest.Text = (e.ColumnIndex + 1).ToString();

            txtBox_Weight.Text = matrix[e.RowIndex, e.ColumnIndex].ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveTxt_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Exported matrix file |*.txt";
                saveFileDialog1.ShowDialog();
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                file.WriteLine(vertices);
                for (int i = 0; i < vertices; i++)
                {
                    string st = "";
                    for (int j = 0; j < vertices; j++)
                    {
                        st += matrix[i, j] + " ";
                    }
                    file.WriteLine(st);
                }
                file.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_randomMatrix_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] check = new int[vertices, vertices];
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (i != j && check[i, j] == 0)
                    {
                        matrix[i, j] = matrix[j, i] = rand.Next(10);
                        check[i, j] = check[j, i] = 1;
                    }
                }
            }
            ToListView();
        }
    }
}