namespace _3DStruct
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LP_Window = new System.Windows.Forms.TableLayoutPanel();
            this.LP_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Header_ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_AppName = new System.Windows.Forms.Label();
            this.Header_AppLogo = new DevExpress.XtraEditors.SvgImageBox();
            this.LP_MainForm = new System.Windows.Forms.TableLayoutPanel();
            this.LP_SideMenu = new System.Windows.Forms.TableLayoutPanel();
            this.SM_Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SM_Button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SM_Button3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SM_Button4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SM_MenuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.LP_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.LP_WorkspaceFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.Footer_ResizeIcon = new System.Windows.Forms.PictureBox();
            this.TC_Workspace = new DevExpress.XtraTab.XtraTabControl();
            this.TCW_2DEditor = new DevExpress.XtraTab.XtraTabPage();
            this._2DEditor1 = new _3DStruct._2DEditor();
            this.TCW_3DEditor = new DevExpress.XtraTab.XtraTabPage();
            this._3DEditor1 = new _3DStruct._3DEditor();
            this.Header_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LP_Window.SuspendLayout();
            this.LP_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_AppLogo)).BeginInit();
            this.LP_MainForm.SuspendLayout();
            this.LP_SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SM_MenuButton)).BeginInit();
            this.LP_Workspace.SuspendLayout();
            this.LP_WorkspaceFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Footer_ResizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TC_Workspace)).BeginInit();
            this.TC_Workspace.SuspendLayout();
            this.TCW_2DEditor.SuspendLayout();
            this.TCW_3DEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LP_Window
            // 
            this.LP_Window.ColumnCount = 1;
            this.LP_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LP_Window.Controls.Add(this.LP_Header, 0, 0);
            this.LP_Window.Controls.Add(this.LP_MainForm, 0, 1);
            this.LP_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Window.Location = new System.Drawing.Point(0, 0);
            this.LP_Window.Name = "LP_Window";
            this.LP_Window.RowCount = 2;
            this.LP_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LP_Window.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LP_Window.Size = new System.Drawing.Size(868, 555);
            this.LP_Window.TabIndex = 2;
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
            this.LP_Header.Size = new System.Drawing.Size(868, 46);
            this.LP_Header.TabIndex = 1;
            // 
            // Header_ExitButton
            // 
            this.Header_ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Header_ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.Header_ExitButton.ErrorImage = null;
            this.Header_ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("Header_ExitButton.Image")));
            this.Header_ExitButton.ImageActive = null;
            this.Header_ExitButton.Location = new System.Drawing.Point(827, 5);
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
            this.Header_MinimizeButton.Location = new System.Drawing.Point(781, 5);
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
            this.Header_AppName.Size = new System.Drawing.Size(228, 25);
            this.Header_AppName.TabIndex = 3;
            this.Header_AppName.Text = "3DStruct beta v0.7";
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
            // LP_MainForm
            // 
            this.LP_MainForm.ColumnCount = 2;
            this.LP_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.LP_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MainForm.Controls.Add(this.LP_SideMenu, 0, 0);
            this.LP_MainForm.Controls.Add(this.LP_Workspace, 1, 0);
            this.LP_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_MainForm.Location = new System.Drawing.Point(0, 46);
            this.LP_MainForm.Margin = new System.Windows.Forms.Padding(0);
            this.LP_MainForm.Name = "LP_MainForm";
            this.LP_MainForm.RowCount = 1;
            this.LP_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_MainForm.Size = new System.Drawing.Size(868, 509);
            this.LP_MainForm.TabIndex = 2;
            // 
            // LP_SideMenu
            // 
            this.LP_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LP_SideMenu.ColumnCount = 1;
            this.LP_SideMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_SideMenu.Controls.Add(this.SM_Button1, 0, 1);
            this.LP_SideMenu.Controls.Add(this.SM_Button2, 0, 2);
            this.LP_SideMenu.Controls.Add(this.SM_Button3, 0, 3);
            this.LP_SideMenu.Controls.Add(this.SM_Button4, 0, 4);
            this.LP_SideMenu.Controls.Add(this.SM_MenuButton, 0, 0);
            this.LP_SideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.LP_SideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.LP_SideMenu.Name = "LP_SideMenu";
            this.LP_SideMenu.RowCount = 6;
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LP_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_SideMenu.Size = new System.Drawing.Size(250, 509);
            this.LP_SideMenu.TabIndex = 0;
            // 
            // SM_Button1
            // 
            this.SM_Button1.Activecolor = System.Drawing.Color.Transparent;
            this.SM_Button1.BackColor = System.Drawing.Color.Transparent;
            this.SM_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SM_Button1.BorderRadius = 0;
            this.SM_Button1.ButtonText = "2D Редактор";
            this.SM_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SM_Button1.DisabledColor = System.Drawing.Color.Gray;
            this.SM_Button1.ForeColor = System.Drawing.Color.White;
            this.SM_Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.SM_Button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("SM_Button1.Iconimage")));
            this.SM_Button1.Iconimage_right = null;
            this.SM_Button1.Iconimage_right_Selected = null;
            this.SM_Button1.Iconimage_Selected = null;
            this.SM_Button1.IconMarginLeft = 0;
            this.SM_Button1.IconMarginRight = 0;
            this.SM_Button1.IconRightVisible = true;
            this.SM_Button1.IconRightZoom = 0D;
            this.SM_Button1.IconVisible = true;
            this.SM_Button1.IconZoom = 90D;
            this.SM_Button1.IsTab = false;
            this.SM_Button1.Location = new System.Drawing.Point(4, 125);
            this.SM_Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SM_Button1.Name = "SM_Button1";
            this.SM_Button1.Normalcolor = System.Drawing.Color.Transparent;
            this.SM_Button1.OnHovercolor = System.Drawing.Color.Transparent;
            this.SM_Button1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SM_Button1.selected = false;
            this.SM_Button1.Size = new System.Drawing.Size(242, 49);
            this.SM_Button1.TabIndex = 5;
            this.SM_Button1.Text = "2D Редактор";
            this.SM_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SM_Button1.Textcolor = System.Drawing.Color.White;
            this.SM_Button1.TextFont = new System.Drawing.Font("JetBrains Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SM_Button1.Click += new System.EventHandler(this.SM_Button1_Click);
            // 
            // SM_Button2
            // 
            this.SM_Button2.Activecolor = System.Drawing.Color.Transparent;
            this.SM_Button2.BackColor = System.Drawing.Color.Transparent;
            this.SM_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SM_Button2.BorderRadius = 0;
            this.SM_Button2.ButtonText = "3D Редактор";
            this.SM_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SM_Button2.DisabledColor = System.Drawing.Color.Gray;
            this.SM_Button2.ForeColor = System.Drawing.Color.White;
            this.SM_Button2.Iconcolor = System.Drawing.Color.Transparent;
            this.SM_Button2.Iconimage = ((System.Drawing.Image)(resources.GetObject("SM_Button2.Iconimage")));
            this.SM_Button2.Iconimage_right = null;
            this.SM_Button2.Iconimage_right_Selected = null;
            this.SM_Button2.Iconimage_Selected = null;
            this.SM_Button2.IconMarginLeft = 0;
            this.SM_Button2.IconMarginRight = 0;
            this.SM_Button2.IconRightVisible = true;
            this.SM_Button2.IconRightZoom = 0D;
            this.SM_Button2.IconVisible = true;
            this.SM_Button2.IconZoom = 90D;
            this.SM_Button2.IsTab = false;
            this.SM_Button2.Location = new System.Drawing.Point(4, 184);
            this.SM_Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SM_Button2.Name = "SM_Button2";
            this.SM_Button2.Normalcolor = System.Drawing.Color.Transparent;
            this.SM_Button2.OnHovercolor = System.Drawing.Color.Transparent;
            this.SM_Button2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SM_Button2.selected = false;
            this.SM_Button2.Size = new System.Drawing.Size(242, 49);
            this.SM_Button2.TabIndex = 1;
            this.SM_Button2.Text = "3D Редактор";
            this.SM_Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SM_Button2.Textcolor = System.Drawing.Color.White;
            this.SM_Button2.TextFont = new System.Drawing.Font("JetBrains Mono", 8F);
            this.SM_Button2.Click += new System.EventHandler(this.SM_Button2_Click);
            // 
            // SM_Button3
            // 
            this.SM_Button3.Activecolor = System.Drawing.Color.Transparent;
            this.SM_Button3.BackColor = System.Drawing.Color.Transparent;
            this.SM_Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SM_Button3.BorderRadius = 0;
            this.SM_Button3.ButtonText = "Эффекты";
            this.SM_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SM_Button3.DisabledColor = System.Drawing.Color.Gray;
            this.SM_Button3.ForeColor = System.Drawing.Color.White;
            this.SM_Button3.Iconcolor = System.Drawing.Color.Transparent;
            this.SM_Button3.Iconimage = ((System.Drawing.Image)(resources.GetObject("SM_Button3.Iconimage")));
            this.SM_Button3.Iconimage_right = null;
            this.SM_Button3.Iconimage_right_Selected = null;
            this.SM_Button3.Iconimage_Selected = null;
            this.SM_Button3.IconMarginLeft = 0;
            this.SM_Button3.IconMarginRight = 0;
            this.SM_Button3.IconRightVisible = true;
            this.SM_Button3.IconRightZoom = 0D;
            this.SM_Button3.IconVisible = true;
            this.SM_Button3.IconZoom = 90D;
            this.SM_Button3.IsTab = false;
            this.SM_Button3.Location = new System.Drawing.Point(4, 243);
            this.SM_Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SM_Button3.Name = "SM_Button3";
            this.SM_Button3.Normalcolor = System.Drawing.Color.Transparent;
            this.SM_Button3.OnHovercolor = System.Drawing.Color.Transparent;
            this.SM_Button3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SM_Button3.selected = false;
            this.SM_Button3.Size = new System.Drawing.Size(242, 49);
            this.SM_Button3.TabIndex = 2;
            this.SM_Button3.Text = "Эффекты";
            this.SM_Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SM_Button3.Textcolor = System.Drawing.Color.White;
            this.SM_Button3.TextFont = new System.Drawing.Font("JetBrains Mono", 8F);
            this.SM_Button3.Click += new System.EventHandler(this.SM_Button3_Click);
            // 
            // SM_Button4
            // 
            this.SM_Button4.Activecolor = System.Drawing.Color.Transparent;
            this.SM_Button4.BackColor = System.Drawing.Color.Transparent;
            this.SM_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SM_Button4.BorderRadius = 0;
            this.SM_Button4.ButtonText = "Настройки";
            this.SM_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SM_Button4.DisabledColor = System.Drawing.Color.Gray;
            this.SM_Button4.ForeColor = System.Drawing.Color.White;
            this.SM_Button4.Iconcolor = System.Drawing.Color.Transparent;
            this.SM_Button4.Iconimage = ((System.Drawing.Image)(resources.GetObject("SM_Button4.Iconimage")));
            this.SM_Button4.Iconimage_right = null;
            this.SM_Button4.Iconimage_right_Selected = null;
            this.SM_Button4.Iconimage_Selected = null;
            this.SM_Button4.IconMarginLeft = 0;
            this.SM_Button4.IconMarginRight = 0;
            this.SM_Button4.IconRightVisible = true;
            this.SM_Button4.IconRightZoom = 0D;
            this.SM_Button4.IconVisible = true;
            this.SM_Button4.IconZoom = 90D;
            this.SM_Button4.IsTab = false;
            this.SM_Button4.Location = new System.Drawing.Point(4, 302);
            this.SM_Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SM_Button4.Name = "SM_Button4";
            this.SM_Button4.Normalcolor = System.Drawing.Color.Transparent;
            this.SM_Button4.OnHovercolor = System.Drawing.Color.Transparent;
            this.SM_Button4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SM_Button4.selected = false;
            this.SM_Button4.Size = new System.Drawing.Size(242, 49);
            this.SM_Button4.TabIndex = 3;
            this.SM_Button4.Text = "Настройки";
            this.SM_Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SM_Button4.Textcolor = System.Drawing.Color.White;
            this.SM_Button4.TextFont = new System.Drawing.Font("JetBrains Mono", 8F);
            this.SM_Button4.Click += new System.EventHandler(this.SM_Button4_Click);
            // 
            // SM_MenuButton
            // 
            this.SM_MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SM_MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.SM_MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SM_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("SM_MenuButton.Image")));
            this.SM_MenuButton.ImageActive = null;
            this.SM_MenuButton.Location = new System.Drawing.Point(210, 15);
            this.SM_MenuButton.Margin = new System.Windows.Forms.Padding(3, 15, 15, 3);
            this.SM_MenuButton.Name = "SM_MenuButton";
            this.SM_MenuButton.Size = new System.Drawing.Size(25, 25);
            this.SM_MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SM_MenuButton.TabIndex = 4;
            this.SM_MenuButton.TabStop = false;
            this.SM_MenuButton.Zoom = 10;
            this.SM_MenuButton.Click += new System.EventHandler(this.SM_MenuButton_Click);
            // 
            // LP_Workspace
            // 
            this.LP_Workspace.ColumnCount = 1;
            this.LP_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Workspace.Controls.Add(this.LP_WorkspaceFooter, 0, 1);
            this.LP_Workspace.Controls.Add(this.TC_Workspace, 0, 0);
            this.LP_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_Workspace.Location = new System.Drawing.Point(253, 3);
            this.LP_Workspace.Name = "LP_Workspace";
            this.LP_Workspace.RowCount = 2;
            this.LP_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LP_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LP_Workspace.Size = new System.Drawing.Size(612, 503);
            this.LP_Workspace.TabIndex = 1;
            // 
            // LP_WorkspaceFooter
            // 
            this.LP_WorkspaceFooter.AutoSize = true;
            this.LP_WorkspaceFooter.Controls.Add(this.Footer_ResizeIcon);
            this.LP_WorkspaceFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LP_WorkspaceFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.LP_WorkspaceFooter.Location = new System.Drawing.Point(0, 483);
            this.LP_WorkspaceFooter.Margin = new System.Windows.Forms.Padding(0);
            this.LP_WorkspaceFooter.Name = "LP_WorkspaceFooter";
            this.LP_WorkspaceFooter.Size = new System.Drawing.Size(612, 20);
            this.LP_WorkspaceFooter.TabIndex = 3;
            // 
            // Footer_ResizeIcon
            // 
            this.Footer_ResizeIcon.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.Footer_ResizeIcon.Image = global::_3DStruct.Properties.Resources.MF_ResizeCorner;
            this.Footer_ResizeIcon.Location = new System.Drawing.Point(594, 3);
            this.Footer_ResizeIcon.Name = "Footer_ResizeIcon";
            this.Footer_ResizeIcon.Size = new System.Drawing.Size(15, 15);
            this.Footer_ResizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Footer_ResizeIcon.TabIndex = 0;
            this.Footer_ResizeIcon.TabStop = false;
            this.Footer_ResizeIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Footer_ResizeIcon_MouseDown);
            this.Footer_ResizeIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Footer_ResizeIcon_MouseMove);
            this.Footer_ResizeIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Footer_ResizeIcon_MouseUp);
            // 
            // TC_Workspace
            // 
            this.TC_Workspace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TC_Workspace.Appearance.Options.UseBackColor = true;
            this.TC_Workspace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TC_Workspace.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TC_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Workspace.Location = new System.Drawing.Point(3, 3);
            this.TC_Workspace.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.TC_Workspace.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TC_Workspace.Name = "TC_Workspace";
            this.TC_Workspace.SelectedTabPage = this.TCW_2DEditor;
            this.TC_Workspace.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.TC_Workspace.Size = new System.Drawing.Size(606, 477);
            this.TC_Workspace.TabIndex = 2;
            this.TC_Workspace.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TCW_2DEditor,
            this.TCW_3DEditor});
            // 
            // TCW_2DEditor
            // 
            this.TCW_2DEditor.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TCW_2DEditor.Appearance.PageClient.Options.UseBackColor = true;
            this.TCW_2DEditor.Controls.Add(this._2DEditor1);
            this.TCW_2DEditor.Name = "TCW_2DEditor";
            this.TCW_2DEditor.Size = new System.Drawing.Size(606, 477);
            this.TCW_2DEditor.Text = "xtraTabPage1";
            // 
            // _2DEditor1
            // 
            this._2DEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this._2DEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._2DEditor1.Location = new System.Drawing.Point(0, 0);
            this._2DEditor1.Name = "_2DEditor1";
            this._2DEditor1.Size = new System.Drawing.Size(606, 477);
            this._2DEditor1.TabIndex = 0;
            // 
            // TCW_3DEditor
            // 
            this.TCW_3DEditor.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TCW_3DEditor.Appearance.PageClient.Options.UseBackColor = true;
            this.TCW_3DEditor.Controls.Add(this._3DEditor1);
            this.TCW_3DEditor.Name = "TCW_3DEditor";
            this.TCW_3DEditor.Size = new System.Drawing.Size(606, 477);
            this.TCW_3DEditor.Text = "xtraTabPage2";
            // 
            // _3DEditor1
            // 
            this._3DEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this._3DEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._3DEditor1.Location = new System.Drawing.Point(0, 0);
            this._3DEditor1.Name = "_3DEditor1";
            this._3DEditor1.Size = new System.Drawing.Size(606, 477);
            this._3DEditor1.TabIndex = 0;
            // 
            // Header_DragControl
            // 
            this.Header_DragControl.Fixed = true;
            this.Header_DragControl.Horizontal = true;
            this.Header_DragControl.TargetControl = this.LP_Header;
            this.Header_DragControl.Vertical = true;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 4;
            this.Elipse.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 555);
            this.Controls.Add(this.LP_Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 555);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DStruct";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.LP_Window.ResumeLayout(false);
            this.LP_Header.ResumeLayout(false);
            this.LP_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_AppLogo)).EndInit();
            this.LP_MainForm.ResumeLayout(false);
            this.LP_SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SM_MenuButton)).EndInit();
            this.LP_Workspace.ResumeLayout(false);
            this.LP_Workspace.PerformLayout();
            this.LP_WorkspaceFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Footer_ResizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TC_Workspace)).EndInit();
            this.TC_Workspace.ResumeLayout(false);
            this.TCW_2DEditor.ResumeLayout(false);
            this.TCW_3DEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LP_Window;
        private Bunifu.Framework.UI.BunifuDragControl Header_DragControl;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.TableLayoutPanel LP_Header;
        private Bunifu.Framework.UI.BunifuImageButton Header_MinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton Header_ExitButton;
        private System.Windows.Forms.TableLayoutPanel LP_MainForm;
        private System.Windows.Forms.TableLayoutPanel LP_SideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton SM_Button2;
        private Bunifu.Framework.UI.BunifuFlatButton SM_Button3;
        private Bunifu.Framework.UI.BunifuFlatButton SM_Button4;
        private Bunifu.Framework.UI.BunifuImageButton SM_MenuButton;
        private Bunifu.Framework.UI.BunifuFlatButton SM_Button1;
        private System.Windows.Forms.Label Header_AppName;
        private DevExpress.XtraEditors.SvgImageBox Header_AppLogo;
        private System.Windows.Forms.TableLayoutPanel LP_Workspace;
        private DevExpress.XtraTab.XtraTabControl TC_Workspace;
        private DevExpress.XtraTab.XtraTabPage TCW_2DEditor;
        private _2DEditor _2DEditor1;
        private DevExpress.XtraTab.XtraTabPage TCW_3DEditor;
        private _3DEditor _3DEditor1;
        private System.Windows.Forms.FlowLayoutPanel LP_WorkspaceFooter;
        private System.Windows.Forms.PictureBox Footer_ResizeIcon;
    }
}

