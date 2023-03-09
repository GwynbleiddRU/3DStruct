namespace _3DStruct
{
    partial class _3DEditor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._3DE_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.OGCanvas_Panel = new System.Windows.Forms.Panel();
            this.OGCanvas = new OpenTK.GLControl();
            this.OGCanvas_Frame = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Label_PageName = new System.Windows.Forms.Label();
            this.FL_AxisControls = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this._3DE_Workspace.SuspendLayout();
            this.OGCanvas_Panel.SuspendLayout();
            this.FL_AxisControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // _3DE_Workspace
            // 
            this._3DE_Workspace.ColumnCount = 1;
            this._3DE_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._3DE_Workspace.Controls.Add(this.OGCanvas_Panel, 0, 1);
            this._3DE_Workspace.Controls.Add(this.Label_PageName, 0, 0);
            this._3DE_Workspace.Controls.Add(this.FL_AxisControls, 0, 2);
            this._3DE_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._3DE_Workspace.Location = new System.Drawing.Point(0, 0);
            this._3DE_Workspace.Name = "_3DE_Workspace";
            this._3DE_Workspace.RowCount = 3;
            this._3DE_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._3DE_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._3DE_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._3DE_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._3DE_Workspace.Size = new System.Drawing.Size(813, 488);
            this._3DE_Workspace.TabIndex = 4;
            // 
            // OGCanvas_Panel
            // 
            this.OGCanvas_Panel.Controls.Add(this.OGCanvas);
            this.OGCanvas_Panel.Controls.Add(this.OGCanvas_Frame);
            this.OGCanvas_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OGCanvas_Panel.Location = new System.Drawing.Point(3, 53);
            this.OGCanvas_Panel.Name = "OGCanvas_Panel";
            this.OGCanvas_Panel.Size = new System.Drawing.Size(807, 332);
            this.OGCanvas_Panel.TabIndex = 4;
            // 
            // OGCanvas
            // 
            this.OGCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OGCanvas.BackColor = System.Drawing.Color.Black;
            this.OGCanvas.Location = new System.Drawing.Point(2, 2);
            this.OGCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OGCanvas.Name = "OGCanvas";
            this.OGCanvas.Size = new System.Drawing.Size(804, 329);
            this.OGCanvas.TabIndex = 4;
            this.OGCanvas.VSync = false;
            this.OGCanvas.Load += new System.EventHandler(this.OGCanvas_Load);
            this.OGCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.OGCanvas_Paint);
            this.OGCanvas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OGCanvas_KeyDown);
            this.OGCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OGCanvas_MouseMove);
            this.OGCanvas.Resize += new System.EventHandler(this.OGCanvas_Resize);
            // 
            // OGCanvas_Frame
            // 
            this.OGCanvas_Frame.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.OGCanvas_Frame.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.OGCanvas_Frame.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.OGCanvas_Frame.BorderThickness = 1;
            this.OGCanvas_Frame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OGCanvas_Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OGCanvas_Frame.Enabled = false;
            this.OGCanvas_Frame.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OGCanvas_Frame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OGCanvas_Frame.isPassword = false;
            this.OGCanvas_Frame.Location = new System.Drawing.Point(0, 0);
            this.OGCanvas_Frame.Margin = new System.Windows.Forms.Padding(1);
            this.OGCanvas_Frame.Name = "OGCanvas_Frame";
            this.OGCanvas_Frame.Size = new System.Drawing.Size(807, 332);
            this.OGCanvas_Frame.TabIndex = 3;
            this.OGCanvas_Frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_PageName
            // 
            this.Label_PageName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_PageName.AutoSize = true;
            this.Label_PageName.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PageName.ForeColor = System.Drawing.Color.White;
            this.Label_PageName.Location = new System.Drawing.Point(12, 12);
            this.Label_PageName.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Label_PageName.Name = "Label_PageName";
            this.Label_PageName.Size = new System.Drawing.Size(120, 25);
            this.Label_PageName.TabIndex = 5;
            this.Label_PageName.Text = "3D editor";
            // 
            // FL_AxisControls
            // 
            this.FL_AxisControls.Controls.Add(this.trackBar1);
            this.FL_AxisControls.Controls.Add(this.trackBar2);
            this.FL_AxisControls.Controls.Add(this.trackBar3);
            this.FL_AxisControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_AxisControls.Location = new System.Drawing.Point(3, 391);
            this.FL_AxisControls.Name = "FL_AxisControls";
            this.FL_AxisControls.Size = new System.Drawing.Size(807, 94);
            this.FL_AxisControls.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 56);
            this.trackBar1.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(209, 3);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(200, 56);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(415, 3);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(200, 56);
            this.trackBar3.TabIndex = 2;
            // 
            // _3DEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this._3DE_Workspace);
            this.Name = "_3DEditor";
            this.Size = new System.Drawing.Size(813, 488);
            this._3DE_Workspace.ResumeLayout(false);
            this._3DE_Workspace.PerformLayout();
            this.OGCanvas_Panel.ResumeLayout(false);
            this.FL_AxisControls.ResumeLayout(false);
            this.FL_AxisControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _3DE_Workspace;
        private System.Windows.Forms.Panel OGCanvas_Panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox OGCanvas_Frame;
        private OpenTK.GLControl OGCanvas;
        private System.Windows.Forms.Label Label_PageName;
        private System.Windows.Forms.FlowLayoutPanel FL_AxisControls;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}
