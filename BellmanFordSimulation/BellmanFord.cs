using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BellmanFordSimulation
{
    internal class BellmanFord
    {
        #region Field

        private const int infinity = 9999999;

        private int vertices;
        private PointF[] drawList;
        private int[,] weightedMatrix;
        private int[] previous;
        private int[] distance;
        private int[] path;

        #endregion Field

        #region property

        public int Vertices
        {
            get { return vertices; }
        }

        public int[,] WeightedMatrix
        {
            get { return weightedMatrix; }
        }

        public int[] Distacne
        {
            get { return distance; }
        }

        public PointF[] DrawList
        {
            get { return drawList; }
        }

        #endregion property

        #region Constructor

        public BellmanFord(string filename)
        {
            StreamReader file = new StreamReader(filename);
            string tempVertices = file.ReadLine();
            tempVertices = tempVertices.Trim();
            vertices = int.Parse(tempVertices);
            drawList = new PointF[vertices];
            weightedMatrix = new int[vertices, vertices];
            previous = new int[vertices];
            distance = new int[vertices];
            path = new int[vertices];

            for (int i = 0; i < vertices; i++)
            {
                tempVertices = file.ReadLine();
                tempVertices = tempVertices.TrimStart();
                tempVertices = tempVertices.TrimEnd();
                string[] temp = new string[vertices];
                int k = 0;

                for (int j = 0; j < tempVertices.Length; j++)
                {
                    if (tempVertices[j] != ' ')
                    {
                        temp[k] += tempVertices[j];
                    }
                    else
                    {
                        k++;
                    }
                }

                for (int l = 0; l < vertices; l++)
                {
                    weightedMatrix[i, l] = int.Parse(temp[l]);
                }
            }
            file.Close();
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (weightedMatrix[i, j] == 0)
                    {
                        weightedMatrix[i, j] = infinity;
                    }
                }
            }
        }

        public BellmanFord(int vertices, int[,] matrix)
        {
            this.vertices = vertices;
            this.weightedMatrix = matrix;

            drawList = new PointF[vertices];
            previous = new int[vertices];
            distance = new int[vertices];
            path = new int[vertices];

            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (weightedMatrix[i, j] == 0)
                    {
                        weightedMatrix[i, j] = infinity;
                    }
                }
            }
        }

        #endregion Constructor

        #region method

        public bool checkIsConnected(int s)
        {
            int[] check = new int[vertices];
            int[] connectedVertex = new int[vertices];
            int noOfconnectedVertex = 0;

            for (int i = 0; i < Vertices; i++)
            {
                check[i] = 0;
            }

            Stack<int> st = new Stack<int>();
            st.Push(s);

            while (st.Count != 0)
            {
                int v = st.Pop();

                if (check[v] != 1)
                {
                    connectedVertex[noOfconnectedVertex++] = v;
                    check[v] = 1;
                    for (int i = vertices - 1; i >= 0; i--)
                    {
                        if (check[i] == 0 && weightedMatrix[v, i] != infinity)
                        {
                            st.Push(i);
                        }
                    }
                }
            }

            Array.Resize(ref connectedVertex, noOfconnectedVertex);
            if (noOfconnectedVertex == vertices)
                return true;
            return false;
        }

        public override string ToString()
        {
            string st = "";
            for (int i = 1; i <= vertices; i++)
            {
                for (int j = 1; j <= vertices; j++)
                {
                    st += (weightedMatrix[i, j]) + " ";
                }
                st += "\r\n";
            }
            return st;
        }

        public void BellmanFordAlgorithm(int source)
        {
            for (int i = 0; i < vertices; i++)
            {
                distance[i] = weightedMatrix[source, i];
                previous[i] = source;
            }
            distance[source] = 0;

            for (int i = 0; i < vertices - 1; i++)
            {
                for (int u = 0; u < vertices; u++)
                {
                    for (int v = 0; v < vertices; v++)
                    {
                        int tmp = distance[u] + weightedMatrix[u, v];
                        if (distance[u] != infinity && distance[v] > tmp)
                        {
                            distance[v] = tmp;
                            previous[v] = u;
                        }
                    }
                }
            }
        }

        public Bitmap DrawWayPic(int from, int to, Image img)
        {
            Bitmap a = new Bitmap(img);
            int i = previous[to];
            a = LineTo(drawList[to], drawList[previous[to]], a, weightedMatrix[to, previous[to]], Color.Red);
            while (i != from)
            {
                a = LineTo(drawList[i], new PointF(drawList[previous[i]].X, drawList[previous[i]].Y), a, weightedMatrix[i, previous[i]], Color.Red);
                i = previous[i];
            }
            return a;
        }

        public string PrintResult(int from, int to, Image img)
        {
            Bitmap a = new Bitmap(img);

            BellmanFordAlgorithm(from);

            if (distance[to] == infinity)
            {
                return "There is no path from " + (from + 1) + " to " + (to + 1);
            }

            int i, j = 0;
            string st = "";

            path[j] = to + 1;
            if (from == to)
            {
                return "You are already there !!!";
            }

            i = previous[to];
            while (i != from)
            {
                path[++j] = i + 1;
                i = previous[i];
            }

            path[j + 1] = from + 1;
            for (int k = j + 1; k >= 0; k--)
            {
                if (k == j + 1)
                    st += path[k];
                else
                    st += " -> " + path[k];
            }

            return st;
        }

        public bool checkIsDirected()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (weightedMatrix[i, j] != weightedMatrix[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion method

        #region Display

        public Bitmap DrawPic()
        {
            Bitmap result = new Bitmap(900, 450);

            int top = vertices / 2;
            if (vertices == 1)
            {
                top = vertices;
            }

            int startPos = 900 / (top * 2);
            for (int i = 1; i <= top; i++)
            {
                if (i % 2 != 0)
                {
                    result = DrawNode(i.ToString(), startPos + (i - 1) * 900 / (top), 20, result, Color.Red);
                    drawList[i - 1] = new PointF(startPos + (i - 1) * 900 / (float)((top)), 20);
                }
                else
                {
                    result = DrawNode(i.ToString(), startPos + (i - 1) * 900 / (top), 100, result, Color.Red);
                    drawList[i - 1] = new PointF(startPos + (i - 1) * 900 / (float)((top)), 100);
                }
            }

            int dist = vertices - top;

            for (int i = 1; i <= vertices - top; i++)
            {
                if (i % 2 != 0)
                {
                    result = DrawNode((i + top).ToString(), (i - 1) * 900 / (dist), 300, result, Color.Red);
                    drawList[i - 1 + top] = new PointF((i - 1) * 900 / (float)((dist)), 300);
                }
                else
                {
                    result = DrawNode((i + top).ToString(), (i - 1) * 900 / (dist), 380, result, Color.Red);
                    drawList[i - 1 + top] = new PointF((i - 1) * 900 / (float)((dist)), 380);
                }
            }

            result = Line(result);
            return result;
        }

        public Bitmap Line(Bitmap a)
        {
            for (int i = 1; i <= vertices; i++)
            {
                for (int j = 1; j <= vertices; j++)
                {
                    if (weightedMatrix[i - 1, j - 1] != infinity)
                    {
                        a = LineTo(drawList[i - 1], drawList[j - 1], a, weightedMatrix[i - 1, j - 1], Color.Green);
                    }
                }
            }
            return a;
        }

        public Bitmap LineTo(PointF p1, PointF p2, Image img, int k, Color color)
        {
            Bitmap result;

            if (img != null)
            {
                result = new Bitmap(img);
            }
            else
            {
                result = new Bitmap(900, 400);
            }

            Graphics graphicsObj;

            graphicsObj = Graphics.FromImage(result);

            Pen myPen = new Pen(color, 4);

            graphicsObj.DrawLine(myPen, p1, p2);

            Brush myBrush = new SolidBrush(Color.Black);
            Font myFont = new Font("Verdana", 14, FontStyle.Regular);
            graphicsObj.DrawString(k.ToString(), myFont, myBrush, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2 - 20));

            return result;
        }

        public Bitmap DrawNode(string st, float x, float y, Image img, Color color)
        {
            Bitmap result;

            if (img != null)
            {
                result = new Bitmap(img);
            }
            else
            {
                result = new Bitmap(992, 438);
            }

            Graphics graphicsObj;
            graphicsObj = Graphics.FromImage(result);

            Pen myPen = new Pen(Color.Green, 2);
            Font myFont = new Font("Verdana", 17, FontStyle.Regular);
            Brush myBrush = new SolidBrush(color);

            graphicsObj.DrawString(st, myFont, myBrush, x + 5, y - 6);

            return result;
        }

        #endregion Display
    }
}