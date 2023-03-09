using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DStruct
{
    public partial class Matrix : Form
    {
        SimpleMatrix m = new SimpleMatrix(3, 3);
        _3DLine Line = new _3DLine();
        string operation;


        public class SimpleMatrix
        {
            public double[,] matrix;

            public int Row { get; protected set; }
            public int Column { get; protected set; }

            public SimpleMatrix(int row, int column)
            {
                Row = row;
                Column = column;
                matrix = new double[row, column];
            }

            public SimpleMatrix Multiple(SimpleMatrix value)
            {
                SimpleMatrix result = new SimpleMatrix(Row, value.Column);
                for (int i = 0; i < Row; i++)
                    for (int j = 0; j < value.Column; j++)
                        for (int k = 0; k < value.Row; k++)
                            result.matrix[i, j] += matrix[i, k] * value.matrix[k, j];
                return result;
            }
        }

        public Matrix()
        {
            InitializeComponent();
        }

        public Matrix(string operation = "")
        {
            //this.Line = line;
            this.operation = operation;

            InitializeComponent();
        }

        public _3DLine Calculate(_3DLine line)
        {
            Point p1 = new Point(), p2 = new Point();
            SimpleMatrix lineVector = new SimpleMatrix(1, 3);
            SimpleMatrix result = new SimpleMatrix(1, 3);

            ReadMatrix(m.matrix);

            //Calculation
            lineVector.matrix[0, 0] = line.StartPoint.X;
            lineVector.matrix[0, 1] = line.StartPoint.Y;
            lineVector.matrix[0, 2] = 1;
            result = lineVector.Multiple(m);

            p1.X = Convert.ToInt32(result.matrix[0, 0]);
            p1.Y = Convert.ToInt32(result.matrix[0, 1]);

            lineVector.matrix[0, 0] = line.EndPoint.X;
            lineVector.matrix[0, 1] = line.EndPoint.Y;
            lineVector.matrix[0, 2] = 1;
            result = lineVector.Multiple(m);

            p2.X = Convert.ToInt32(result.matrix[0, 0]);
            p2.Y = Convert.ToInt32(result.matrix[0, 1]);

            line.StartPoint = p1;
            line.EndPoint = p2;

            return line;

            void ReadMatrix(double[,] matrix)
            {
                int counter = 0;
                var matrixBoxes = GetAll(this, typeof(Bunifu.Framework.UI.BunifuMetroTextbox)).OrderBy(x => x.Name).ToList();               

                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        string inputValue = matrixBoxes[counter].Text;
                        if (inputValue.Contains("sin"))
                        {
                            int pos = inputValue.IndexOf("sin");
                            matrix[i, j] = pos == 0 ? matrix[i, j] = Math.Sin(Convert.ToDouble(inputValue.Substring(inputValue.IndexOf("(") + 1, inputValue.Length - inputValue.IndexOf("(") - 2))) : matrix[i, j] = Math.Sin(Convert.ToDouble(inputValue.Substring(inputValue.IndexOf("(") + 1, inputValue.Length - inputValue.IndexOf("(") - 2))) * -1;
                        }
                        else if (inputValue.Contains("cos"))
                        {
                            int pos = inputValue.IndexOf("cos");
                            matrix[i, j] = pos == 0 ? matrix[i, j] = Math.Cos(Convert.ToDouble(inputValue.Substring(inputValue.IndexOf("(") + 1, inputValue.Length - inputValue.IndexOf("(") - 2))) : matrix[i, j] = Math.Cos(Convert.ToDouble(inputValue.Substring(inputValue.IndexOf("(") + 1, inputValue.Length - inputValue.IndexOf("(") - 2))) * -1;
                        }
                        else if (inputValue.All(x => char.IsDigit(x) || x == '-' || x == ','))
                            matrix[i, j] = Convert.ToDouble(inputValue);
                        else
                        {
                            MessageBox.Show("Wrong matrix input");
                            return;
                        }
                        counter++;
                    }

                IEnumerable<Control> GetAll(Control control, Type type)
                {
                    var controls = control.Controls.Cast<Control>();

                    return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                              .Concat(controls)
                                              .Where(c => c.GetType() == type);
                }
            }
        }

        #region Buttons
        private void Header_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //AcceptButtonClicked += AcceptButtonClicked;
            AcceptButtonClicked(e);
        }

        #endregion Buttons

        public event EventHandler ButtonClicked;

        public void AcceptButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);

        }

        private void Matrix_Load(object sender, EventArgs e)
        {
            if (operation == "Mirror")
            {
                M11.Text = "-1";
                M12.Text = "0";
                M13.Text = "0";
                M21.Text = "0";
                M22.Text = "1";
                M23.Text = "0";
                M31.Text = "0";
                M32.Text = "0";
                M33.Text = "1";

                M12.Enabled = false;
                M13.Enabled = false;
                M21.Enabled = false;
                M23.Enabled = false;
                M31.Enabled = false;
                M32.Enabled = false;
            }

            if (operation == "Rotate")
            {
                M11.Text = "cos(45)";
                M12.Text = "sin(45)";
                M13.Text = "0";
                M21.Text = "-sin(45)";
                M22.Text = "cos(45)";
                M23.Text = "0";
                M31.Text = "0";
                M32.Text = "0";
                M33.Text = "1";

                M13.Enabled = false;
                M23.Enabled = false;
                M31.Enabled = false;
                M32.Enabled = false;
                M33.Enabled = false;
            }

            if (operation == "Scale")
            {
                M11.Text = "7";
                M12.Text = "0";
                M13.Text = "0";
                M21.Text = "0";
                M22.Text = "7";
                M23.Text = "0";
                M31.Text = "0";
                M32.Text = "0";
                M33.Text = "1";

                M12.Enabled = false;
                M13.Enabled = false;
                M21.Enabled = false;
                M23.Enabled = false;
                M31.Enabled = false;
                M32.Enabled = false;
                M33.Enabled = false;
            }

            if (operation == "Move")
            {
                M11.Text = "1";
                M12.Text = "0";
                M13.Text = "0";
                M21.Text = "0";
                M22.Text = "1";
                M23.Text = "0";
                M31.Text = "7";
                M32.Text = "7";
                M33.Text = "1";

                M11.Enabled = false;
                M12.Enabled = false;
                M13.Enabled = false;
                M21.Enabled = false;
                M22.Enabled = false;
                M23.Enabled = false;
                M33.Enabled = false;
            }
        }


    }
}
