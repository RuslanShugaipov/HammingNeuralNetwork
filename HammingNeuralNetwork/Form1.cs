using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace HammingNeuralNetwork
{
    public partial class Form1 : Form
    {
        private List<List<double>> patterns = new List<List<double>>();
        private string filePath = @"C:\Users\nabon\source\repos\HammingNeuralNetwork\HammingNeuralNetwork\patterns5.txt";
        private List<double> userInput = new List<double>();
        private Dictionary<int, Point> points = new Dictionary<int, Point>
        {
            { 0,  new Point( 0,  0) },
            { 1,  new Point(29,  0) },
            { 2,  new Point(59,  0) },
            { 3,  new Point(89 , 0) },
            { 4,  new Point(119, 0) },

            { 5,  new Point( 0, 29) },
            { 6,  new Point(29, 29) },
            { 7,  new Point(59, 29) },
            { 8,  new Point(89, 29) },
            { 9,  new Point(119,29) },

            { 10, new Point( 0, 59) },
            { 11, new Point(29, 59) },
            { 12, new Point(59, 59) },
            { 13, new Point(89 ,59) },
            { 14, new Point(119,59) },

            { 15, new Point( 0, 89) },
            { 16, new Point(29, 89) },
            { 17, new Point(59, 89) },
            { 18, new Point(89 ,89) },
            { 19, new Point(119,89) },

            { 20, new Point( 0, 119) },
            { 21, new Point(29, 119) },
            { 22, new Point(59, 119) },
            { 23, new Point(89, 119) },
            { 24, new Point(119,119) }
        };
        private NeuralNetwork neuralNetwork;
        private int SNeuronsCount, YNeuronsCount;

        public Form1()
        {
            InitializeComponent();
            var pictureBoxList = this.Controls.OfType<PictureBox>()
                .Where(x => x.Name.StartsWith("pictureBox"))
                .ToList();
            SetSizesForPictureBoxes(pictureBoxList, 149);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patterns = ReadFile(filePath);
            SNeuronsCount = patterns[0].Count;
            YNeuronsCount = patterns.Count;

            userInput = Enumerable.Range(0, SNeuronsCount).Select(value => -1.0).ToList();
        }

        private void SetSizesForPictureBoxes(List<PictureBox> pictureBoxList, int width)
        {
            for (int i = 0; i < pictureBoxList.Count; ++i)
                pictureBoxList[i].Width = pictureBoxList[i].Height = width;
        }

        private void FillCell(int x, int y, Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Gray);
            var size = 29;
            g.FillRectangle(b, x, y, size, size);
        }

        private void DrawPattern(List<Point> pattern, Graphics g)
        {

            foreach (Point cell in pattern)
            {
                FillCell(cell.X, cell.Y, g);
            }
        }

        private void DrawGrid(Graphics g)
        {
            int numOfCells = 5;
            Pen p = new Pen(Color.Black);
            int cellSize = 30;

            for (int y = 0; y <= numOfCells; ++y)
            {
                if (y == 0)
                    g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
                else
                    g.DrawLine(p, 0, y * cellSize - 2, numOfCells * cellSize, y * cellSize - 2);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                if (x == 0)
                    g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
                else
                    g.DrawLine(p, x * cellSize - 2, 0, x * cellSize - 2, numOfCells * cellSize);
            }
        }

        private List<List<double>> ReadFile(string filePath)
        {
            List<List<double>> result = new List<List<double>>();
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                List<double> line = new List<double>(Array.ConvertAll(lines[i].Split(' '), Double.Parse));
                result.Add(line);
            }
            return result;
        }

        private void pictureBox_Pattern1_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 1)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[0][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Pattern2_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 2)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[1][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Pattern3_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 3)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[2][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Pattern4_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 4)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[3][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Pattern5_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 5)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[4][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Pattern6_Paint(object sender, PaintEventArgs e)
        {
            if (patterns.Count < 6)
                return;
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < patterns[0].Count; ++i)
            {
                if (patterns[5][i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void pictureBox_Input_Paint(object sender, PaintEventArgs e)
        {
            List<Point> pattern = new List<Point>();

            for (int i = 0; i < userInput.Count; ++i)
            {
                if (userInput[i] == 1)
                    pattern.Add(points[i]);
            }
            DrawPattern(pattern, e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void button_Predict_Click(object sender, EventArgs e)
        {
            Topology topology = new Topology(SNeuronsCount, YNeuronsCount, YNeuronsCount, YNeuronsCount);
            Parameters parameters = new Parameters(patterns, 0.04);
            neuralNetwork = new NeuralNetwork(topology, parameters);
            int result = neuralNetwork.Predict(userInput);
            if (result == -1)
                label_Result.Text = "Neural network is unable to determine";
            else
                label_Result.Text = (result + 1).ToString();
        }

        private void pictureBox_Input_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            var x = mouseEventArgs.X;
            var y = mouseEventArgs.Y;
            var size = Math.Sqrt(userInput.Count);
            for(int i = 0; i < size; ++i)
            {
                if(x > (i * 30) - 1 && x < (i + 1) * 30 - 1)
                {
                    for(int j = 0; j < size; ++j)
                    {
                        if(y > (j * 30) - 1 && y < (j + 1) * 30 - 1)
                        {
                            userInput[(j * (int)size)+ i] *= -1;
                        }
                    }
                }
            }
            pictureBox_Input.Refresh();
        }
    }
}
