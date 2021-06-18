using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellmanFordSimulation
{
    public partial class Form1 : Form
    {
        const int infinity = 9999999;
        public Form1()
        {
            InitializeComponent();
        }

        BellmanFord a;

        void ToListView()
        {
            if (a.Vertices > 0)
            {
                dt.Height = 50;
                dt.Columns.Add("Begin", "Begin");
                dt.Columns.Add("End", "End");
                dt.Columns.Add("Distance", "Distance");
                dt.Rows.Clear();

                dt.Columns[0].Width = 40;
                dt.Columns[1].Width = 40;
                dt.Columns[2].Width = 60;

                int row = 0;
                int[,] check = new int[a.Vertices, a.Vertices];

                for (int i = 0; i < a.Vertices; i++)
                {

                    for (int j = 0; j < a.Vertices; j++)
                    {
                        if (a.WeightedMatrix[i, j] != infinity && check[i, j] == 0)
                        {
                            dt.Rows.Add();
                            if (dt.Height < 250)
                            {
                                dt.Height += 20;
                            }

                            dt[0, row].Value = i + 1;
                            dt[1, row].Value = j + 1;
                            dt[2, row].Value = a.WeightedMatrix[i, j];
                            row++;
                            check[i, j] = check[j, i] = 1;
                        }
                    }

                }
            }

        }

        private void btn_importFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Exported matrix file |*.txt";
                openFileDialog1.ShowDialog();

                a = new BellmanFord(openFileDialog1.FileName);

                if (a.checkIsDirected())
                {
                    cb_from.Items.Clear();
                    cb_To.Items.Clear();

                    for (int i = 1; i <= a.Vertices; i++)
                    {
                        cb_from.Items.Add(i);
                        cb_To.Items.Add(i);
                    }

                    cb_To.Enabled = cb_from.Enabled = true;
                    btn_Find.Enabled = true;
                    cb_To.Text = a.Vertices.ToString();
                    cb_from.Text = "1";

                    pb.Image = a.DrawPic();
                    if (a.checkIsConnected(1))
                    {
                        labelResult.Text = "Connected graph";
                    }
                    else
                    {
                        labelResult.Text = "Unconnected graph";
                    }

                    Graph.matrix = a.WeightedMatrix;
                    Graph.vertices = a.Vertices;
                    
                    ToListView();
                }
                else
                {
                    MessageBox.Show("This is not a directed graph", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_importFile_Click(sender, e);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Invalid graph!!! \r\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            this.Width = 962;
            this.Height = 630;
            btn_Update.Enabled = true;
        }

        private void btn_importManual_Click(object sender, EventArgs e)
        {
            CreateMatrixForm a = new CreateMatrixForm();
            btn_Update.Enabled = true;
            a.ShowDialog();
            this.Width = 962;
            this.Height = 630;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_from.Text != cb_To.Text)
                {
                    pb.Image = a.DrawPic();

                    string st = a.PrintResult(int.Parse(cb_from.Text) - 1, int.Parse(cb_To.Text) - 1, pb.Image);

                    st = "The shortest path from " + cb_from.Text + " to " + cb_To.Text + " : " + st + "  ||  ";

                    if (a.Distacne[Convert.ToInt32(cb_To.Text) - 1] == infinity)
                    {
                        st += "Distance: ∞";
                    }
                    else
                    {
                        st += "Distance: " + a.Distacne[Convert.ToInt32(cb_To.Text) - 1].ToString();
                        pb.Image = a.DrawWayPic(int.Parse(cb_from.Text) - 1, int.Parse(cb_To.Text) - 1, pb.Image);
                    }
                    label4.Text = st;
                }
                else
                {
                    MessageBox.Show("You are already there !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            a = new BellmanFord(Graph.vertices, Graph.matrix);

            cb_from.Items.Clear();
            cb_To.Items.Clear();

            for (int i = 1; i <= a.Vertices; i++)
            {
                cb_To.Items.Add(i);
                cb_from.Items.Add(i);
            }

            cb_from.Enabled = cb_To.Enabled = true;
            btn_Find.Enabled = true;
            cb_To.Text = a.Vertices.ToString();
            cb_from.Text = "1";

            pb.Image = a.DrawPic();
            if (a.checkIsConnected(1))
            {
                labelResult.Text = "Connected graph";
            }
            else
            {
                labelResult.Text = "Unconnected graph";
            }
            a.DrawPic();
            ToListView();

        }

        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pb.Image = a.DrawPic();

            int temp = e.RowIndex;
            PointF p1 = a.DrawList[Convert.ToInt32(dt[0, temp].Value) - 1];
            PointF p2 = a.DrawList[Convert.ToInt32(dt[1, temp].Value) - 1];
            int weight = a.WeightedMatrix[Convert.ToInt32(dt[0, temp].Value) - 1, Convert.ToInt32(dt[1, temp].Value) - 1];
            pb.Image = a.LineTo(p1, p2, pb.Image, weight, Color.Yellow);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
