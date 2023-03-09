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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        #region ButtonEvents
        private void Header_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Header_MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SM_MenuButton_Click(object sender, EventArgs e)
        {
            if (LP_MainForm.ColumnStyles[0].Width == 250)
            {
                LP_MainForm.ColumnStyles[0].Width = 55;
            }
            else
            {
                LP_MainForm.ColumnStyles[0].Width = 250;
            }
        }

        #region MenuButtons

        private void SM_Button1_Click(object sender, EventArgs e)
        {
            TC_Workspace.SelectedTabPage = TCW_2DEditor;
        }

        private void SM_Button2_Click(object sender, EventArgs e)
        {
            TC_Workspace.SelectedTabPage = TCW_3DEditor;
        }

        private void SM_Button3_Click(object sender, EventArgs e)
        {

        }

        private void SM_Button4_Click(object sender, EventArgs e)
        {

        }

        #endregion MenuButtons

        #endregion ButtonEvents

        #region FormResize

        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        private void Footer_ResizeIcon_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void Footer_ResizeIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void Footer_ResizeIcon_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        #endregion FormResize

    }
}
