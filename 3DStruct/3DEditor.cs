using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace _3DStruct
{
    public partial class _3DEditor : UserControl
    {
        float x = 0;
        float y = 0;
        float z = 0;

        private float width = 20;
        private bool _loaded;
        //private Shader shader;

        public _3DEditor()
        {
            InitializeComponent();
        }

        private void OGCanvas_Load(object sender, EventArgs e)
        {
            //GL.ClearColor(0.3f, 0.2f, 0.3f, 1.0f);
            //GL.Enable(EnableCap.DepthTest);
            //GL.Viewport(0, 0, OGCanvas.Width, OGCanvas.Height);
            //shader = new Shader("shader.vert", "shader.frag");
            //shader.Use();
            //_loaded = true;
            //OGCanvas.Invalidate();

            _loaded = true;
            GL.ClearColor(Color.BlueViolet);
            GL.Enable(EnableCap.DepthTest);

            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView((float)(80 * Math.PI / 180), 1, 20, 500);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref p);

            Matrix4 modelview = Matrix4.LookAt(70, 70, 70, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            //SetupViewport();
        }

        private void OGCanvas_Paint(object sender, PaintEventArgs e)
        {
            //GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //shader.Use();

            if (!_loaded)
                return;

            GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);

            /*задняя*/
            GL.Color3(Color.Silver);
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(width, 0, 0);
            GL.Vertex3(width, width, 0);
            GL.Vertex3(0, width, 0);
            GL.End();

            /*левая*/
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, width);
            GL.Vertex3(0, width, width);
            GL.Vertex3(0, width, 0);
            GL.End();

            /*нижняя*/
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, width);
            GL.Vertex3(width, 0, width);
            GL.Vertex3(width, 0, 0);
            GL.End();

            /*верхняя*/
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(0, width, 0);
            GL.Vertex3(0, width, width);
            GL.Vertex3(width, width, width);
            GL.Vertex3(width, width, 0);
            GL.End();

            /*передняя*/
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(0, 0, width);
            GL.Vertex3(width, 0, width);
            GL.Vertex3(width, width, width);
            GL.Vertex3(0, width, width);
            GL.End();

            /*правая*/
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(width, 0, 0);
            GL.Vertex3(width, 0, width);
            GL.Vertex3(width, width, width);
            GL.Vertex3(width, width, 0);
            GL.End();

            GL.Color3(Color.Black);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, width, 0);
            GL.Vertex3(width, width, 0);
            GL.Vertex3(width, 0, 0);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(width, 0, 0);
            GL.Vertex3(width, 0, width);
            GL.Vertex3(width, width, width);
            GL.Vertex3(width, width, 0);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0, 0, width);
            GL.Vertex3(width, 0, width);
            GL.Vertex3(width, width, width);
            GL.Vertex3(0, width, width);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, width);
            GL.Vertex3(0, width, width);
            GL.Vertex3(0, width, 0);
            GL.End();

            GL.Color3(Color.Black);
            GL.Begin(BeginMode.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(50, 0, 0);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 50, 0);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 50);
            GL.End();

            OGCanvas.SwapBuffers();

        }

        private void OGCanvas_Resize(object sender, EventArgs e)
        {
            if (!_loaded)
                return;

            //SetupViewport();
            GL.Viewport(0, 0, OGCanvas.Width, OGCanvas.Height);
            OGCanvas.Invalidate();
        }
        private void SetupViewport()
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            int w = OGCanvas.Width;
            int h = OGCanvas.Height;

            float orthoW = w * (z + 1);
            float orthoH = h * (z + 1);

            GL.Ortho(0, orthoW, 0, orthoH, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the OGCanvas painting area

            OGCanvas.Invalidate();
        }

        private void OGCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_loaded) return;

            if (e.KeyCode == Keys.A)
            {
                GL.MatrixMode(MatrixMode.Projection);
                GL.Rotate(30, 0, 0, 1);
            }
            if (e.KeyCode == Keys.B)
            {
                GL.MatrixMode(MatrixMode.Modelview);
                GL.Rotate(30, 0, 0, 1);
            }

            OGCanvas.Invalidate();
        }


        // Calculate Translation of  (X, Y, Z) - according to mouse input
        private void SetupCursorXYZ()
        {
            x = PointToClient(Cursor.Position).X * (z + 1);
            y = (-PointToClient(Cursor.Position).Y + OGCanvas.Height) * (z + 1);
        }

        private void OGCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            x = PointToClient(Cursor.Position).X * (z + 1);
            y = (-PointToClient(Cursor.Position).Y + OGCanvas.Height) * (z + 1);

            SetupCursorXYZ();

            OGCanvas.Invalidate();
        }

        private void OnMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0 && z > 0) z -= 0.5f;
            if (e.Delta < 0 && z < 5) z += 0.5f;

            SetupCursorXYZ();

            SetupViewport();
            OGCanvas.Invalidate();
        }
    }


}
