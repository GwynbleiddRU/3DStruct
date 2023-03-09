namespace _3DStruct
{
    partial class Matrix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matrix));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LP_Window = new System.Windows.Forms.TableLayoutPanel();
            this.LP_MatrixForm = new System.Windows.Forms.TableLayoutPanel();
            this.LP_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Header_ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_AppName = new System.Windows.Forms.Label();
            this.Header_AppLogo = new DevExpress.XtraEditors.SvgImageBox();
            this.LP_MatrixArea = new System.Windows.Forms.TableLayoutPanel();
            this.LP_Matrix = new System.Windows.Forms.TableLayoutPanel();
            this.M31 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M12 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M33 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M23 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M13 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M21 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M11 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M32 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.M22 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LP_Window.SuspendLayout();
            this.LP_MatrixForm.SuspendLayout();
            this.LP_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_AppLogo)).BeginInit();
            this.LP_MatrixArea.SuspendLayout();
            this.LP_Matrix.SuspendLayout();
            this.LP_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // LP_Window
            // 
            this.LP_Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LP_Window.ColumnCount = 3;
            this.LP_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.LP_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.LP_Window.Controls.Add(this.LP_MatrixForm, 1, 0);
            this.LP_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Window.Location = new System.Drawing.Point(0, 0);
            this.LP_Window.Margin = new System.Windows.Forms.Padding(0);
            this.LP_Window.Name = "LP_Window";
            this.LP_Window.RowCount = 2;
            this.LP_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.LP_Window.Size = new System.Drawing.Size(400, 400);
            this.LP_Window.TabIndex = 0;
            // 
            // LP_MatrixForm
            // 
            this.LP_MatrixForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LP_MatrixForm.ColumnCount = 1;
            this.LP_MatrixForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MatrixForm.Controls.Add(this.LP_Header, 0, 0);
            this.LP_MatrixForm.Controls.Add(this.LP_MatrixArea, 0, 1);
            this.LP_MatrixForm.Controls.Add(this.LP_Buttons, 0, 2);
            this.LP_MatrixForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_MatrixForm.Location = new System.Drawing.Point(1, 0);
            this.LP_MatrixForm.Margin = new System.Windows.Forms.Padding(0);
            this.LP_MatrixForm.Name = "LP_MatrixForm";
            this.LP_MatrixForm.RowCount = 3;
            this.LP_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LP_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.LP_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_MatrixForm.Size = new System.Drawing.Size(397, 398);
            this.LP_MatrixForm.TabIndex = 1;
            // 
            // LP_Header
            // 
            this.LP_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LP_Header.ColumnCount = 4;
            this.LP_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LP_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LP_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LP_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_Header.Controls.Add(this.Header_ExitButton, 3, 0);
            this.LP_Header.Controls.Add(this.Header_MinimizeButton, 2, 0);
            this.LP_Header.Controls.Add(this.Header_AppName, 1, 0);
            this.LP_Header.Controls.Add(this.Header_AppLogo, 0, 0);
            this.LP_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Header.Location = new System.Drawing.Point(0, 0);
            this.LP_Header.Margin = new System.Windows.Forms.Padding(0);
            this.LP_Header.Name = "LP_Header";
            this.LP_Header.RowCount = 1;
            this.LP_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Header.Size = new System.Drawing.Size(397, 46);
            this.LP_Header.TabIndex = 2;
            // 
            // Header_ExitButton
            // 
            this.Header_ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Header_ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.Header_ExitButton.ErrorImage = null;
            this.Header_ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("Header_ExitButton.Image")));
            this.Header_ExitButton.ImageActive = null;
            this.Header_ExitButton.Location = new System.Drawing.Point(356, 5);
            this.Header_ExitButton.Name = "Header_ExitButton";
            this.Header_ExitButton.Size = new System.Drawing.Size(35, 35);
            this.Header_ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Header_ExitButton.TabIndex = 0;
            this.Header_ExitButton.TabStop = false;
            this.Header_ExitButton.Zoom = 10;
            this.Header_ExitButton.Click += new System.EventHandler(this.Header_ExitButton_Click);
            // 
            // Header_MinimizeButton
            // 
            this.Header_MinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Header_MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.Header_MinimizeButton.ErrorImage = null;
            this.Header_MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("Header_MinimizeButton.Image")));
            this.Header_MinimizeButton.ImageActive = null;
            this.Header_MinimizeButton.Location = new System.Drawing.Point(310, 5);
            this.Header_MinimizeButton.Name = "Header_MinimizeButton";
            this.Header_MinimizeButton.Size = new System.Drawing.Size(35, 35);
            this.Header_MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Header_MinimizeButton.TabIndex = 1;
            this.Header_MinimizeButton.TabStop = false;
            this.Header_MinimizeButton.Zoom = 10;
            this.Header_MinimizeButton.Click += new System.EventHandler(this.Header_MinimizeButton_Click);
            // 
            // Header_AppName
            // 
            this.Header_AppName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Header_AppName.AutoSize = true;
            this.Header_AppName.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_AppName.ForeColor = System.Drawing.Color.White;
            this.Header_AppName.Location = new System.Drawing.Point(58, 10);
            this.Header_AppName.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Header_AppName.Name = "Header_AppName";
            this.Header_AppName.Size = new System.Drawing.Size(108, 25);
            this.Header_AppName.TabIndex = 3;
            this.Header_AppName.Text = "Matrix2D";
            // 
            // Header_AppLogo
            // 
            this.Header_AppLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_AppLogo.Location = new System.Drawing.Point(3, 3);
            this.Header_AppLogo.Name = "Header_AppLogo";
            this.Header_AppLogo.Size = new System.Drawing.Size(40, 40);
            this.Header_AppLogo.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.Header_AppLogo.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Header_AppLogo.SvgImage")));
            this.Header_AppLogo.TabIndex = 4;
            this.Header_AppLogo.Text = "svgImageBox1";
            // 
            // LP_MatrixArea
            // 
            this.LP_MatrixArea.ColumnCount = 3;
            this.LP_MatrixArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.LP_MatrixArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MatrixArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.LP_MatrixArea.Controls.Add(this.LP_Matrix, 1, 1);
            this.LP_MatrixArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_MatrixArea.Location = new System.Drawing.Point(0, 46);
            this.LP_MatrixArea.Margin = new System.Windows.Forms.Padding(0);
            this.LP_MatrixArea.Name = "LP_MatrixArea";
            this.LP_MatrixArea.RowCount = 3;
            this.LP_MatrixArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_MatrixArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MatrixArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_MatrixArea.Size = new System.Drawing.Size(397, 300);
            this.LP_MatrixArea.TabIndex = 3;
            // 
            // LP_Matrix
            // 
            this.LP_Matrix.ColumnCount = 3;
            this.LP_Matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.Controls.Add(this.M31, 0, 2);
            this.LP_Matrix.Controls.Add(this.M12, 0, 0);
            this.LP_Matrix.Controls.Add(this.M33, 0, 2);
            this.LP_Matrix.Controls.Add(this.M23, 0, 1);
            this.LP_Matrix.Controls.Add(this.M13, 0, 0);
            this.LP_Matrix.Controls.Add(this.M21, 0, 1);
            this.LP_Matrix.Controls.Add(this.M11, 0, 0);
            this.LP_Matrix.Controls.Add(this.M32, 0, 2);
            this.LP_Matrix.Controls.Add(this.M22, 0, 1);
            this.LP_Matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Matrix.Location = new System.Drawing.Point(72, 23);
            this.LP_Matrix.Name = "LP_Matrix";
            this.LP_Matrix.RowCount = 3;
            this.LP_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LP_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_Matrix.Size = new System.Drawing.Size(253, 254);
            this.LP_Matrix.TabIndex = 0;
            // 
            // M31
            // 
            this.M31.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M31.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M31.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M31.BorderThickness = 1;
            this.M31.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M31.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M31.isPassword = false;
            this.M31.Location = new System.Drawing.Point(10, 179);
            this.M31.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M31.Name = "M31";
            this.M31.Size = new System.Drawing.Size(64, 64);
            this.M31.TabIndex = 30;
            this.M31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M12
            // 
            this.M12.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M12.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M12.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M12.BorderThickness = 1;
            this.M12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M12.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M12.isPassword = false;
            this.M12.Location = new System.Drawing.Point(94, 11);
            this.M12.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M12.Name = "M12";
            this.M12.Size = new System.Drawing.Size(64, 62);
            this.M12.TabIndex = 29;
            this.M12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M33
            // 
            this.M33.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M33.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M33.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M33.BorderThickness = 1;
            this.M33.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M33.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M33.isPassword = false;
            this.M33.Location = new System.Drawing.Point(178, 179);
            this.M33.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M33.Name = "M33";
            this.M33.Size = new System.Drawing.Size(65, 64);
            this.M33.TabIndex = 28;
            this.M33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M23
            // 
            this.M23.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M23.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M23.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M23.BorderThickness = 1;
            this.M23.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M23.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M23.isPassword = false;
            this.M23.Location = new System.Drawing.Point(178, 95);
            this.M23.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M23.Name = "M23";
            this.M23.Size = new System.Drawing.Size(65, 62);
            this.M23.TabIndex = 27;
            this.M23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M13
            // 
            this.M13.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M13.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M13.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M13.BorderThickness = 1;
            this.M13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M13.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M13.isPassword = false;
            this.M13.Location = new System.Drawing.Point(178, 11);
            this.M13.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M13.Name = "M13";
            this.M13.Size = new System.Drawing.Size(65, 62);
            this.M13.TabIndex = 26;
            this.M13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M21
            // 
            this.M21.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M21.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M21.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M21.BorderThickness = 1;
            this.M21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M21.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M21.isPassword = false;
            this.M21.Location = new System.Drawing.Point(10, 95);
            this.M21.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M21.Name = "M21";
            this.M21.Size = new System.Drawing.Size(64, 62);
            this.M21.TabIndex = 25;
            this.M21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M11
            // 
            this.M11.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M11.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M11.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M11.BorderThickness = 1;
            this.M11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M11.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M11.isPassword = false;
            this.M11.Location = new System.Drawing.Point(10, 11);
            this.M11.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M11.Name = "M11";
            this.M11.Size = new System.Drawing.Size(64, 62);
            this.M11.TabIndex = 24;
            this.M11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M32
            // 
            this.M32.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M32.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M32.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M32.BorderThickness = 1;
            this.M32.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M32.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M32.isPassword = false;
            this.M32.Location = new System.Drawing.Point(94, 179);
            this.M32.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M32.Name = "M32";
            this.M32.Size = new System.Drawing.Size(64, 64);
            this.M32.TabIndex = 22;
            this.M32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M22
            // 
            this.M22.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M22.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M22.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.M22.BorderThickness = 1;
            this.M22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.M22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M22.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.M22.isPassword = false;
            this.M22.Location = new System.Drawing.Point(94, 95);
            this.M22.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.M22.Name = "M22";
            this.M22.Size = new System.Drawing.Size(64, 62);
            this.M22.TabIndex = 21;
            this.M22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LP_Buttons
            // 
            this.LP_Buttons.ColumnCount = 2;
            this.LP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LP_Buttons.Controls.Add(this.ButtonAccept, 1, 0);
            this.LP_Buttons.Controls.Add(this.ButtonCancel, 0, 0);
            this.LP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Buttons.Location = new System.Drawing.Point(3, 349);
            this.LP_Buttons.Name = "LP_Buttons";
            this.LP_Buttons.RowCount = 1;
            this.LP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LP_Buttons.Size = new System.Drawing.Size(391, 46);
            this.LP_Buttons.TabIndex = 4;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.ButtonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ButtonAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAccept.BorderRadius = 0;
            this.ButtonAccept.ButtonText = "Применить";
            this.ButtonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAccept.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonAccept.ForeColor = System.Drawing.Color.White;
            this.ButtonAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonAccept.Iconimage = null;
            this.ButtonAccept.Iconimage_right = null;
            this.ButtonAccept.Iconimage_right_Selected = null;
            this.ButtonAccept.Iconimage_Selected = null;
            this.ButtonAccept.IconMarginLeft = 0;
            this.ButtonAccept.IconMarginRight = 0;
            this.ButtonAccept.IconRightVisible = true;
            this.ButtonAccept.IconRightZoom = 0D;
            this.ButtonAccept.IconVisible = true;
            this.ButtonAccept.IconZoom = 90D;
            this.ButtonAccept.IsTab = false;
            this.ButtonAccept.Location = new System.Drawing.Point(199, 5);
            this.ButtonAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ButtonAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.ButtonAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonAccept.selected = false;
            this.ButtonAccept.Size = new System.Drawing.Size(187, 36);
            this.ButtonAccept.TabIndex = 1;
            this.ButtonAccept.Text = "Применить";
            this.ButtonAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAccept.Textcolor = System.Drawing.Color.White;
            this.ButtonAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAccept.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancel.BorderRadius = 0;
            this.ButtonCancel.ButtonText = "Отменить";
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonCancel.Iconimage = null;
            this.ButtonCancel.Iconimage_right = null;
            this.ButtonCancel.Iconimage_right_Selected = null;
            this.ButtonCancel.Iconimage_Selected = null;
            this.ButtonCancel.IconMarginLeft = 0;
            this.ButtonCancel.IconMarginRight = 0;
            this.ButtonCancel.IconRightVisible = true;
            this.ButtonCancel.IconRightZoom = 0D;
            this.ButtonCancel.IconVisible = true;
            this.ButtonCancel.IconZoom = 90D;
            this.ButtonCancel.IsTab = false;
            this.ButtonCancel.Location = new System.Drawing.Point(4, 5);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ButtonCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(0)))), ((int)(((byte)(235)))));
            this.ButtonCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonCancel.selected = false;
            this.ButtonCancel.Size = new System.Drawing.Size(187, 36);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCancel.Textcolor = System.Drawing.Color.White;
            this.ButtonCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.LP_Header;
            this.DragControl.Vertical = true;
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.LP_Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Matrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Matrix_Load);
            this.LP_Window.ResumeLayout(false);
            this.LP_MatrixForm.ResumeLayout(false);
            this.LP_Header.ResumeLayout(false);
            this.LP_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_AppLogo)).EndInit();
            this.LP_MatrixArea.ResumeLayout(false);
            this.LP_Matrix.ResumeLayout(false);
            this.LP_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.TableLayoutPanel LP_Window;
        private System.Windows.Forms.TableLayoutPanel LP_MatrixForm;
        private System.Windows.Forms.TableLayoutPanel LP_Header;
        private Bunifu.Framework.UI.BunifuImageButton Header_ExitButton;
        private Bunifu.Framework.UI.BunifuImageButton Header_MinimizeButton;
        private System.Windows.Forms.Label Header_AppName;
        private DevExpress.XtraEditors.SvgImageBox Header_AppLogo;
        private System.Windows.Forms.TableLayoutPanel LP_MatrixArea;
        private System.Windows.Forms.TableLayoutPanel LP_Matrix;
        private System.Windows.Forms.TableLayoutPanel LP_Buttons;
        private Bunifu.Framework.UI.BunifuMetroTextbox M22;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuMetroTextbox M31;
        private Bunifu.Framework.UI.BunifuMetroTextbox M12;
        private Bunifu.Framework.UI.BunifuMetroTextbox M33;
        private Bunifu.Framework.UI.BunifuMetroTextbox M23;
        private Bunifu.Framework.UI.BunifuMetroTextbox M13;
        private Bunifu.Framework.UI.BunifuMetroTextbox M21;
        private Bunifu.Framework.UI.BunifuMetroTextbox M11;
        private Bunifu.Framework.UI.BunifuMetroTextbox M32;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonAccept;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonCancel;
    }
}