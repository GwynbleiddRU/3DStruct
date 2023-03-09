using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using ZedGraph;
using Newtonsoft.Json;
using System.IO.IsolatedStorage;
using Newtonsoft.Json.Linq;

namespace _3DStruct
{
    public partial class _2DEditor : UserControl
    {
        public _2DEditor()
        {
            InitializeComponent();
        }

        private bool ShowAxis = false;
        private bool ShowGrid = false;

        int halfWidth;
        int halfHeight;

        private bool IsDrawing = false;
        // The "size" of an object for mouse over purposes.
        private const int object_radius = 3;

        // We're over an object if the distance squared
        // between the mouse and the object is less than this.
        private const int over_dist_squared = object_radius * object_radius;

        private Point ClickPos = new Point(); //fix mousedown position for selection

        Point hit_point;
        private _3DLine Line = new _3DLine();
        private List<_3DLine> Lines = new List<_3DLine>();
        private List<_3DSpline> Splines = new List<_3DSpline>();

        private List<_3DLine> SelectedLines = new List<_3DLine>();
        private List<List<_3DLine>> GrouppedObjects = new List<List<_3DLine>>();

        // Calculate the trash can dimensions.
        private int TrashWidth, TrashHeight;
        private void _2DEditor_Load(object sender, EventArgs e)
        {
            halfWidth = Canvas2D.Size.Width / 2;
            halfHeight = Canvas2D.Size.Height / 2;

            const float TrashScale = 0.15f; //change trash can size in settings
            TrashWidth = (int)(TrashScale * Properties.Resources._2DE_TrashCan.Width);
            TrashHeight = (int)(TrashScale * Properties.Resources._2DE_TrashCan.Height);

            Operations_MoveButton.ImageOptions.SvgImage = svgImageCollection["moving"];
            Operations_ScaleButton.ImageOptions.SvgImage = svgImageCollection["scaling"];
            Operations_RotateButton.ImageOptions.SvgImage = svgImageCollection["rotation"];
            Operations_MirrorButton.ImageOptions.SvgImage = svgImageCollection["mirroring"];
            Operations_ProjectionButton.ImageOptions.SvgImage = svgImageCollection["projection"];
            
            Groupping_ButtonGroup.ImageOptions.SvgImage = svgImageCollection["group"];
            Groupping_ButtonUngroup.ImageOptions.SvgImage = svgImageCollection["ungroup"];
            Groupping_ButtonManageGroups.ImageOptions.SvgImage = svgImageCollection["managegroups"];
            
            Export_PNGButton.ImageOptions.SvgImage = svgImageCollection["ExportPNG"];
            Export_ProjectButton.ImageOptions.SvgImage = svgImageCollection["ExportProject"];
            Import_LoadButton.ImageOptions.SvgImage = svgImageCollection["loadImage"];

            TransformButton.ImageOptions.SvgImage = svgImageCollection["modify"];
            SplineButton.ImageOptions.SvgImage = svgImageCollection["spline"];
            ClearButton.ImageOptions.SvgImage = svgImageCollection["clear"];

            Button_JoinLines.ImageOptions.SvgImage = svgImageCollection["binding"];
            LP_2DEditor.ColumnStyles[1].Width = 0;
        }

        #region "Canvas Events"

        #region "Drawing"

        // We're drawing a new segment.
        private void Canvas2D_MouseMove_Drawing(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);
            // Save the new point.
            Line.EndPoint = new Point(e.X, e.Y);

            // Redraw.
            Canvas2D.Refresh();
        }

        // Stop drawing.
        private void Canvas2D_MouseUp_Drawing(object sender, MouseEventArgs e)
        {
            IsDrawing = false;

            // Reset the event handlers.
            Canvas2D.MouseMove -= Canvas2D_MouseMove_Drawing;
            Canvas2D.MouseMove += Canvas2D_MouseMove;
            Canvas2D.MouseUp -= Canvas2D_MouseUp_Drawing;

            // Create the new segment.
            if (Line.StartPoint != Line.EndPoint)
                Lines.Add(new _3DLine(Line.StartPoint, Line.EndPoint, S_ColorPicker.Color, (float)S_WidthUpDown.Value));
            
            // Redraw.
            Canvas2D.Refresh();
        }

        #endregion // Drawing

        private void Canvas2D_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(halfWidth, halfHeight); //начало координат в центре
            //e.Graphics.ScaleTransform(1, -1); //y снизу вверх


            if (ShowAxis)
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(127,0,255), width: (float)2.2), -halfWidth, 0, Canvas2D.Size.Width, 0);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(127, 0, 255), width: (float)2.2), 0, -halfHeight, 0, Canvas2D.Size.Height);

                int xSegments = Canvas2D.Size.Width / 25;
                for (int i = -halfWidth; i < xSegments + 1; i++)
                {
                    Rectangle rectStart = new Rectangle(25 * i, 0, 3, 3);
                    e.Graphics.FillEllipse(Brushes.Lavender, rectStart);
                    e.Graphics.DrawEllipse(Pens.White, rectStart);
                }

                int ySegments = Canvas2D.Size.Height / 25;
                for (int i = -halfHeight; i < ySegments + 1; i++)
                {
                    Rectangle rectStart = new Rectangle(0, 25 * i, 3, 3);
                    e.Graphics.FillEllipse(Brushes.Lavender, rectStart);
                    e.Graphics.DrawEllipse(Pens.White, rectStart);
                }
            }
            if (ShowGrid)
            {
                for (int i = -halfWidth; i < Canvas2D.Size.Width / 25 + 1; i++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Silver), 25 * i, -halfHeight, 25 * i, Canvas2D.Size.Height);
                }

                for (int i = -halfHeight; i < Canvas2D.Size.Height / 25 + 1; i++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Silver), -halfWidth, 25 * i, Canvas2D.Size.Width, 25 * i);
                }
            }

            // Draw the segments.
            foreach (_3DLine line in Lines)
            {
                e.Graphics.DrawLine(new Pen(line.Color, line.Width), line.StartPoint, line.EndPoint);
            }

            foreach (_3DLine line in SelectedLines)
            {
                Rectangle rectStart = new Rectangle(
                    line.StartPoint.X - object_radius, line.StartPoint.Y - object_radius,
                    2 * object_radius + 1, 2 * object_radius + 1);
                e.Graphics.FillEllipse(Brushes.Lavender, rectStart);
                e.Graphics.DrawEllipse(Pens.White, rectStart);

                Rectangle rectEnd = new Rectangle(
                    line.EndPoint.X - object_radius, line.EndPoint.Y - object_radius,
                    2 * object_radius + 1, 2 * object_radius + 1);
                e.Graphics.FillEllipse(Brushes.Lavender, rectEnd);
                e.Graphics.DrawEllipse(Pens.White, rectEnd);
            }

            if (Splines.Count > 0)          
                foreach (var spline in Splines)
                    e.Graphics.DrawCurve(new Pen(spline.Color, spline.Width), spline.SplinePoints, 0.1f);
            

            // If there's a new segment under constructions, draw it.
            if (IsDrawing)
            {
                e.Graphics.DrawLine(Pens.MediumSlateBlue, Line.StartPoint, Line.EndPoint);
            }

            // Draw the trash can.
            Rectangle trash_rect = new Rectangle(-halfWidth, -halfHeight,
                TrashWidth, TrashHeight);
            e.Graphics.DrawImage(
                Properties.Resources._2DE_TrashCan,
                trash_rect);
        }
        private void Canvas2D_MouseMove(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);
            Cursor new_cursor = Cursors.Cross;

            // See what we're over.
            Point hit_point;
            int segment_number;
            int spline_number;

            if (MouseIsOverEndpoint(e.Location, out segment_number, out hit_point))
            {
                new_cursor = Cursors.Arrow;

                if (SelectedLines.Count == 0)
                    Output(hit_point, new Point(), "[*] ", true);
            }
            else if (MouseIsOverSegment(e.Location, out segment_number))
            {
                new_cursor = Cursors.Hand;

                if (SelectedLines.Count == 0)
                    Output(Lines[segment_number].StartPoint, Lines[segment_number].EndPoint, "", true);
            }
            else if (MouseIsOverSpline(e.Location, out spline_number))
            {
                new_cursor = Cursors.Hand;
            }
            else if (SelectedLines.Count == 0)
            {
                Output(e.Location, new Point(), "", true);
            }
            // Set the new cursor.
            if (Canvas2D.Cursor != new_cursor)
                Canvas2D.Cursor = new_cursor;
        }

        private void Canvas2D_MouseDown(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);

            ClickPos = e.Location; //fix mousedown pos to compare with mouseup (moving segment)
            // See what we're over.
            int segment_number;

            if (MouseIsOverEndpoint(e.Location, out segment_number, out hit_point))
            {
                //LinesToMove = new List<_3DLine>(Lines.Where(x => x.StartPoint == hit_point || x.EndPoint == hit_point).ToList());

                // Start moving this end point.
                Canvas2D.MouseMove -= Canvas2D_MouseMove;
                Canvas2D.MouseMove += Canvas2D_MouseMove_MovingEndPoint;
                Canvas2D.MouseUp += picCanvas_MouseUp_MovingEndPoint;

                // Remember the segment number.
                MovingSegment = segment_number;

                // See if we're moving the start end point.
                MovingStartEndPoint = (Lines[segment_number].StartPoint.Equals(hit_point));

                // Remember the offset from the mouse to the point.
                OffsetX = hit_point.X - e.X;
                OffsetY = hit_point.Y - e.Y;
            }
            else if (MouseIsOverSegment(e.Location, out segment_number))
            {
                // Start moving this segment.
                Canvas2D.MouseMove -= Canvas2D_MouseMove;
                Canvas2D.MouseMove += Canvas2D_MouseMove_MovingSegment;
                Canvas2D.MouseUp += Canvas2D_MouseUp_MovingSegment;

                // Remember the segment number.
                MovingSegment = segment_number;

                // Remember the offset from the mouse to the segment's first point.
                OffsetX = Lines[segment_number].StartPoint.X - e.X;
                OffsetY = Lines[segment_number].StartPoint.Y - e.Y;
            }
            else if (MouseIsOverSpline(e.Location, out segment_number))
            {
                MovingSegment = segment_number;

                Canvas2D.MouseClick += Canvas2D_MouseClick_Spline;
            }
            else
            {
                // Start drawing a new segment.
                Canvas2D.MouseMove -= Canvas2D_MouseMove;
                Canvas2D.MouseMove += Canvas2D_MouseMove_Drawing;
                Canvas2D.MouseUp += Canvas2D_MouseUp_Drawing;

                IsDrawing = true;

                Line.StartPoint = new Point(e.X, e.Y);
                Line.EndPoint = new Point(e.X, e.Y);

                SelectedLines.Clear();
            }
        }
        private void Canvas2D_MouseClick_Spline(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);

            Canvas2D.MouseClick -= Canvas2D_MouseClick_Spline;

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                MenuItem delete = new MenuItem(text: "Удалить");
                MenuItem hide = new MenuItem(text: "Скрыть");

                cm.MenuItems.Add(delete);
                cm.MenuItems.Add(hide);

                delete.Click += new EventHandler(delete_click);
                hide.Click += new EventHandler(hide_click);

                cm.Show(Canvas2D, e.Location);

                void delete_click(object click_sender, EventArgs ee)
                {
                    Splines.RemoveAt(MovingSegment);
                    cm.Dispose();
                    Canvas2D.Refresh();
                }

                void hide_click(object click_sender, EventArgs ee)
                {
                    cm.Dispose();
                }
            }
        }

        #endregion "Canvas Events"

        #region "Moving End Point"

        // The segment we're moving or the segment whose end point we're moving.
        private int MovingSegment = -1;

        // The end point we're moving.
        private bool MovingStartEndPoint = false;

        // The offset from the mouse to the object being moved.
        private int OffsetX, OffsetY;


        // We're moving an end point.
        private void Canvas2D_MouseMove_MovingEndPoint(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);

            //var ll = Lines.Intersect(LinesToMove).ToList();

            //for (int i = 0; i < ll.Count; i++)
            //{
            //    if (LinesToMove.FirstOrDefault(x => x == ll[i]).StartPoint == hit_point)
            //    {
            //        ll[i].StartPoint = new Point(e.X + OffsetX, e.Y + OffsetY);
            //        Console.WriteLine("SP: " + LinesToMove[i].StartPoint.X + ";" + LinesToMove[i].StartPoint.Y + "\n");
            //    }
            //    else
            //    {
            //        ll[i].EndPoint = new Point(e.X + OffsetX, e.Y + OffsetY);
            //        Console.WriteLine("EP: " + LinesToMove[i].EndPoint.X + ";" + LinesToMove[i].EndPoint.Y + "\n");

            //    }
            //}

            //if (Lines[MovingSegment].StartPoint == MousePosition)
            if (MovingStartEndPoint)
                Lines[MovingSegment].StartPoint = new Point(e.X + OffsetX, e.Y + OffsetY);
            else
                Lines[MovingSegment].EndPoint = new Point(e.X + OffsetX, e.Y + OffsetY);


            Console.WriteLine("HP: " + hit_point.X + ";" + hit_point.Y + "\n");

            // Redraw.
            Canvas2D.Refresh();
        }

        // Stop moving the end point.
        private void picCanvas_MouseUp_MovingEndPoint(object sender, MouseEventArgs e)
        {
            //LinesToMove.Clear();

            // Reset the event handlers.
            Canvas2D.MouseMove += Canvas2D_MouseMove;
            Canvas2D.MouseMove -= Canvas2D_MouseMove_MovingEndPoint;
            Canvas2D.MouseUp -= picCanvas_MouseUp_MovingEndPoint;

            // Redraw.
            Canvas2D.Refresh();
        }

        #endregion // Moving End Point

        #region "Moving Segment"

        // We're moving a segment.
        private void Canvas2D_MouseMove_MovingSegment(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);

            // See how far the first point will move.
            int new_x1 = e.X + OffsetX;
            int new_y1 = e.Y + OffsetY;

            int dx = new_x1 - Lines[MovingSegment].StartPoint.X;
            int dy = new_y1 - Lines[MovingSegment].StartPoint.Y;

            if (dx == 0 && dy == 0) return; //line wasnt moved

            if (GrouppedObjects.Exists(x => x.Contains(Lines[MovingSegment]))) //move group of objects
            {
                var GroupToMove = GrouppedObjects.Where(x => x.Contains(Lines[MovingSegment])).SelectMany(a => a, (a, b) => b);
                var UngrouppedLines = SelectedLines.Except(GroupToMove);

                //check if group is selected (not moved without selection)
                //prevent moving selected lines when operating with unselected group
                if (SelectedLines.Intersect(GroupToMove).Any())                    
                    foreach (var ungrouppedLine in UngrouppedLines) //move lines which are not in group but also selected
                        MoveLine(ungrouppedLine);
                
                foreach (var line in GroupToMove) //move lines in group
                    MoveLine(line);
            }
            else if (SelectedLines.Contains(Lines[MovingSegment]) && SelectedLines.Count > 1) //move selected lines
            {
                foreach (var line in SelectedLines)
                    MoveLine(line);
            }
            else // Move single segment to its new location.
                MoveLine(Lines[MovingSegment]);
                //Lines[MovingSegment].StartPoint = new Point(new_x1, new_y1);
                //Lines[MovingSegment].EndPoint = new Point(
                //    Lines[MovingSegment].EndPoint.X + dx,
                //    Lines[MovingSegment].EndPoint.Y + dy);
           
            Canvas2D.Refresh(); // Redraw.

            void MoveLine(_3DLine line)
            {
                line.StartPoint = new Point(line.StartPoint.X + dx, line.StartPoint.Y + dy);
                line.EndPoint = new Point(
                    line.EndPoint.X + dx,
                    line.EndPoint.Y + dy);
            }
        }

        // Stop moving the segment (unpress mouse button).
        private void Canvas2D_MouseUp_MovingSegment(object sender, MouseEventArgs e)
        {
            e = new MouseEventArgs(e.Button, e.Clicks, e.X - halfWidth, e.Y - halfHeight, e.Delta);

            // Reset the event handlers.
            Canvas2D.MouseMove += Canvas2D_MouseMove;
            Canvas2D.MouseMove -= Canvas2D_MouseMove_MovingSegment;
            Canvas2D.MouseUp -= Canvas2D_MouseUp_MovingSegment;

            if (e.Location == ClickPos && !SelectedLines.Contains(Lines[MovingSegment])) //select line
            {
                SelectObjects(Lines[MovingSegment]);
            }

            // See if the mouse is over the trash can.
            if (/*(e.X >= -halfWidth) &&*/ (e.X < TrashWidth - halfWidth) && /*(e.Y >= -halfHeight) &&*/ (e.Y < TrashHeight - halfHeight))
            {
                if (MessageBox.Show(
                    "Объект будет безвозвратно удален\nВы уверены, что хотите продолжить?", 
                    "Удаление объекта", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<_3DLine> SelectedLinesOnDeletion = new List<_3DLine>(SelectedLines);

                    // Delete the group if this object is part of it
                    // Delete group (moving group) or group in selectedlines (move line with group selected as well)
                    if (GrouppedObjects.Exists(x => x.Contains(Lines[MovingSegment]) || x.Intersect(SelectedLines).Any()))
                    {
                        var SelectedGroups = new List<List<_3DLine>>(GrouppedObjects.Where(x => x.Contains(Lines[MovingSegment]) || x.Intersect(SelectedLines).Any()));
                        foreach (var GrouppedLines in SelectedGroups)
                        {
                            foreach (var line in GrouppedLines)
                            {
                                SelectedLines.Remove(line);
                                Lines.Remove(line);
                            }

                            if (SelectedLinesOnDeletion.Count > 1)
                            {
                                List<_3DLine> UngrouppedLines = SelectedLines.Except(GrouppedLines).ToList() ?? new List<_3DLine>();
                                foreach (var line in UngrouppedLines)
                                {
                                    SelectedLines.Remove(line);
                                    Lines.Remove(line);
                                }
                            }
                            GrouppedObjects.Remove(GrouppedLines);
                        }
                        UpdateTreeView();
                    }
                    // There are no groups in selectedlines - just delete lines
                    else if (SelectedLines.Count > 1)
                        foreach (var line in SelectedLinesOnDeletion)
                        {
                            SelectedLines.Remove(line);
                            Lines.Remove(line);
                        }
                    // Delete the segment.
                    else
                    {
                        SelectedLines.Remove(Lines[MovingSegment]);
                        Lines.RemoveAt(MovingSegment);
                    }
                }
            }
            
            // Redraw.
            Canvas2D.Refresh();
        }

        #endregion // Moving End Point

        #region "Mouse tracking"
        // See if the mouse is over an end point.
        private bool MouseIsOverEndpoint(Point mouse_pt, out int segment_number, out Point hit_pt)
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                // Check the starting point.
                if (FindDistanceToPointSquared(mouse_pt, Lines[i].StartPoint) < over_dist_squared)
                {
                    // We're over this point.
                    segment_number = i;
                    hit_pt = Lines[i].StartPoint;
                    return true;
                }

                // Check the end point.
                if (FindDistanceToPointSquared(mouse_pt, Lines[i].EndPoint) < over_dist_squared)
                {
                    // We're over this point.
                    segment_number = i;
                    hit_pt = Lines[i].EndPoint;
                    return true;
                }
            }

            segment_number = -1;
            hit_pt = new Point(-1, -1);
            return false;
        }

        // See if the mouse is over a line segment.
        private bool MouseIsOverSegment(Point mouse_pt, out int segment_number)
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                // See if we're over the segment.
                PointF closest;
                if (FindDistanceToSegmentSquared(
                    mouse_pt, Lines[i].StartPoint, Lines[i].EndPoint, out closest)
                        < over_dist_squared)
                {
                    // We're over this segment.
                    segment_number = i;
                    return true;
                }
            }

            segment_number = -1;
            return false;
        }

        private bool MouseIsOverSpline(Point mouse_pt, out int spline_number)
        {
            for (int i = 0; i < Splines.Count; i++)
            {
                foreach (var point in Splines[i].SplinePoints)
                {
                    if (FindDistanceToPointSquared(mouse_pt, Point.Round(point)) < over_dist_squared)
                    {
                        spline_number = i;
                        return true;
                    }
                }
            }

            spline_number = -1;
            return false;
        }
        #endregion

        #region "Distance methods"

        // Calculate the distance squared between two points.
        private int FindDistanceToPointSquared(Point pt1, Point pt2)
        {
            int dx = pt1.X - pt2.X;
            int dy = pt1.Y - pt2.Y;
            return dx * dx + dy * dy;
        }

        // Calculate the distance squared between
        // point pt and the segment p1 --> p2.
        private double FindDistanceToSegmentSquared(Point pt, Point p1, Point p2, out PointF closest)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            if ((dx == 0) && (dy == 0))
            {
                // It's a point not a line segment.
                closest = p1;
                dx = pt.X - p1.X;
                dy = pt.Y - p1.Y;
                return dx * dx + dy * dy;
            }

            // Calculate the t that minimizes the distance.
            float t = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) / (dx * dx + dy * dy);

            // See if this represents one of the segment's
            // end points or a point in the middle.
            if (t < 0)
            {
                closest = new PointF(p1.X, p1.Y);
                dx = pt.X - p1.X;
                dy = pt.Y - p1.Y;
            }
            else if (t > 1)
            {
                closest = new PointF(p2.X, p2.Y);
                dx = pt.X - p2.X;
                dy = pt.Y - p2.Y;
            }
            else
            {
                closest = new PointF(p1.X + t * dx, p1.Y + t * dy);
                dx = pt.X - closest.X;
                dy = pt.Y - closest.Y;
            }

            return dx * dx + dy * dy;
        }

        #endregion "Distance Methods"

        private void Settings_CheckBoxAxis_OnChange(object sender, EventArgs e)
        {
            if (Settings_CheckBoxAxis.Checked)
                ShowAxis = true;
            else
                ShowAxis = false;
            Canvas2D.Refresh();
        }
        private void Settings_CheckBoxGrid_OnChange(object sender, EventArgs e)
        {
            if (Settings_CheckBoxGrid.Checked)
                ShowGrid = true;
            else
                ShowGrid = false;
            Canvas2D.Refresh();
        }

        #region "Header Buttons"

        #region "Groupping Buttons"
        private void Groupping_ButtonGroup_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count < 2)
            {
                MessageBox.Show("Для группировки нужно выбрать как минимум 2 объекта");
                return;
            }

            foreach (_3DLine line in SelectedLines)
            {
                if (GrouppedObjects.Exists(x => x.Contains(line))) //one of objects is already in the group
                {
                    GrouppedObjects.RemoveAll(x => x.Contains(line)); //delete group with that object to group it into a new one
                }
            }
            List<_3DLine> tempList = new List<_3DLine>(SelectedLines);
            GrouppedObjects.Add(tempList);

            MessageBox.Show("Выделенные объекты успешно сгруппированы");
            UpdateTreeView();
        }

        private void Groupping_ButtonUngroup_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count >= 2 && GrouppedObjects.Exists(x => x.Intersect(SelectedLines).Any()))
            {
                foreach (_3DLine line in SelectedLines)
                {
                    if (GrouppedObjects.Exists(x => x.Contains(line)))
                    {
                        GrouppedObjects.RemoveAll(x => x.Contains(line));
                    }
                }
                MessageBox.Show("Выделенные объекты успешно разгруппированы");
                UpdateTreeView();
            }
            else
                MessageBox.Show("Не выбрано ни одной группы");
            return;

        }

        private void Groupping_ButtonManageGroups_Click(object sender, EventArgs e)
        {
            if (LP_2DEditor.ColumnStyles[1].Width == 0)
                LP_2DEditor.ColumnStyles[1].Width = 200;
            else
                LP_2DEditor.ColumnStyles[1].Width = 0;
        }

        #endregion "Groupping Buttons"

        #region "Import/Export Buttons"
        private void Export_ProjectButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "|*.json";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            string sfdname;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfdname = Path.GetFullPath(sfd.FileName);

                string jsonTypeNameAll = JsonConvert.SerializeObject(Lines, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.None
                });

                File.WriteAllText(sfdname, jsonTypeNameAll);
            }
        }

        private void Export_PNGButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "|*.png";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            string sfdname = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfdname = Path.GetFullPath(sfd.FileName);

                Bitmap targetBitmap = new Bitmap(Canvas2D.ClientSize.Width,
                    Canvas2D.ClientSize.Height);
                Canvas2D.DrawToBitmap(targetBitmap, Canvas2D.ClientRectangle);

                targetBitmap.Save(sfdname, ImageFormat.Png);
            }
        }

        private void Import_LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|*.json|*.json";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            string ofdname;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofdname = Path.GetFullPath(ofd.FileName);
                if (ofdname.Substring(ofdname.LastIndexOf('.')) == ".json")
                {
                    string json = File.ReadAllText(ofdname);
                    Lines = JsonConvert.DeserializeObject<List<_3DLine>>(json);
                }
                else
                    Canvas2D.Image = Image.FromFile(ofdname);

                Canvas2D.Refresh();
            }
        }

        #endregion "Import/Export Buttons"

        #region "Operations Buttons"

        private void Operations_MirrorButton_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count > 0)
            {
                using (Matrix matrixMirror = new Matrix("Mirror"))
                {
                    matrixMirror.FormClosed += new FormClosedEventHandler(matrix_FormClosed);
                    matrixMirror.ButtonClicked += new EventHandler(matrix_ButtonClicked);

                    matrixMirror.ShowDialog(this);
                }
            }
        }

        private void Operations_RotateButton_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count > 0)
            {
                using (Matrix matrixRotation = new Matrix("Rotate"))
                {
                    matrixRotation.FormClosed += new FormClosedEventHandler(matrix_FormClosed);
                    matrixRotation.ButtonClicked += new EventHandler(matrix_ButtonClicked);

                    matrixRotation.ShowDialog(this);
                }
            }
        }

        private void Operations_ScaleButton_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count > 0)
            {
                using (Matrix matrixScale = new Matrix("Scale"))
                {
                    matrixScale.FormClosed += new FormClosedEventHandler(matrix_FormClosed);
                    matrixScale.ButtonClicked += new EventHandler(matrix_ButtonClicked);

                    matrixScale.ShowDialog(this);
                }
            }
        }

        private void Operations_MoveButton_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count > 0)
            {
                using (Matrix matrixMove = new Matrix("Move"))
                {
                    matrixMove.FormClosed += new FormClosedEventHandler(matrix_FormClosed);
                    matrixMove.ButtonClicked += new EventHandler(matrix_ButtonClicked);

                    matrixMove.ShowDialog(this);
                }
            }
        }

        private void Operations_ProjectionButton_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count > 0)
            {
                using (Matrix matrixMove = new Matrix())
                {
                    matrixMove.FormClosed += new FormClosedEventHandler(matrix_FormClosed);
                    matrixMove.ButtonClicked += new EventHandler(matrix_ButtonClicked);

                    matrixMove.ShowDialog(this);
                }
            }
        }

        void matrix_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void matrix_ButtonClicked(object sender, EventArgs e)
        {
            var a = sender as Matrix;
            for (int i = 0; i < SelectedLines.Count; i++)
            {
                //MessageBox.Show(" line: " + SelectedLines[i].StartPoint.X + ";" + SelectedLines[i].StartPoint.Y + " " + SelectedLines[i].EndPoint.X + ";" + SelectedLines[i].EndPoint.Y);

                SelectedLines[i] = a.Calculate(SelectedLines[i]);
                //MessageBox.Show("New line: " + SelectedLines[i].StartPoint.X + ";" + SelectedLines[i].StartPoint.Y + " " + SelectedLines[i].EndPoint.X + ";" + SelectedLines[i].EndPoint.Y);
            }
            //process button clicked
            Canvas2D.Refresh();
        }
        #endregion "Operations Buttons"

        private void Button_JoinLines_Click(object sender, EventArgs e)
        {
            if (SelectedLines.Count == 1)
            {
                _3DLine selectedLine = SelectedLines[0];

                List<Point> Points = new List<Point>();
                Point closestPoint = new Point();
                double minDist = double.MaxValue;
                bool nearStartPoint = true; //true if closest point is near startpoint, false if its closer to endpoint

                foreach (_3DLine line in Lines)
                {
                    if (!Points.Contains(line.StartPoint) && (line.StartPoint != selectedLine.StartPoint) && (line.StartPoint != selectedLine.EndPoint))
                        Points.Add(line.StartPoint);
                    if (!Points.Contains(line.EndPoint) && (line.EndPoint != selectedLine.StartPoint) && (line.EndPoint != selectedLine.EndPoint))
                        Points.Add(line.EndPoint);
                }

                //Point closestPoint = Points.Where(point => point != selectedLine.StartPoint)
                //    .Where(point => point != selectedLine.EndPoint)
                //    .OrderBy(point => NotReallyDistanceButShouldDo(selectedLine.StartPoint, point))
                //    .ThenBy(point => NotReallyDistanceButShouldDo(selectedLine.EndPoint, point))
                //    .Take(1).FirstOrDefault();


                foreach (Point point in Points)
                {
                    //double dist = FindDistanceToSegmentSquared(point, selectedLine.StartPoint, selectedLine.EndPoint, out closestPointOut);
                    //if (dist < minDist)
                    //{
                    //    minDist = dist;
                    //    ClosestPoint = point;
                    //}

                    double distanceToStartPoint = NotReallyDistanceButShouldDo(selectedLine.StartPoint, point);
                    double distanceToEndPoint = NotReallyDistanceButShouldDo(selectedLine.EndPoint, point);

                    
                    if (distanceToStartPoint < minDist)
                    {
                        minDist = distanceToStartPoint;
                        closestPoint = point;
                        nearStartPoint = true;
                    }
                    if (distanceToEndPoint < minDist)
                    {
                        minDist = distanceToEndPoint;
                        closestPoint = point;
                        nearStartPoint = false;
                    }
                }

                if (nearStartPoint)
                    selectedLine.StartPoint = closestPoint;
                else
                    selectedLine.EndPoint = closestPoint;

                Canvas2D.Refresh();
            }
            else
                MessageBox.Show("Select 1 line to join it with the nearest point");

            double NotReallyDistanceButShouldDo(Point source, Point target)
            {
                double dx = target.X - source.X; double dy = target.Y - source.Y; return dx*dx + dy*dy;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GrouppedObjects.Clear();
            SelectedLines.Clear();
            Lines.Clear();
            Splines.Clear();

            UpdateTreeView();
            Canvas2D.Refresh();
        }

        private void SplineButton_Click(object sender, EventArgs e)
        {
            List<Point> sePoints = new List<Point>();

            foreach (_3DLine lineWithPoints in SelectedLines)
            {
                if (!sePoints.Contains(lineWithPoints.StartPoint))
                    sePoints.Add(lineWithPoints.StartPoint);
                if (!sePoints.Contains(lineWithPoints.EndPoint))
                    sePoints.Add(lineWithPoints.EndPoint);
            }

            if (sePoints.Count > 3)
            {
                PointF[] coords;

                coords = new PointF[sePoints.Count + 2];

                for (int i = 0; i < sePoints.Count; i++)
                {
                    coords[i + 1].X = sePoints[i].X;
                    coords[i + 1].Y = sePoints[i].Y;
                }

                // для правильного отображения сплайна необходимо дважды добавить первую и последнюю точку
                coords[0] = coords[1];
                coords[sePoints.Count + 1] = coords[sePoints.Count];

                Splines.Add(Draw_spline(coords, sePoints)); // рисуем сплайн
                Canvas2D.Refresh();
            }
            else
            {
                MessageBox.Show("Select at least 4 points to make a spline");
            }
        }

        #endregion "Header Buttons"

        private _3DSpline Draw_spline(PointF[] coords, List<Point> sePoints)
        {
            float[] a = new float[4]; // массив для рассчёта коэффициентов а
            float[] b = new float[4]; // для рассчёта коэффициентов b
            List<PointF> points = new List<PointF>();

            for (int i = 1; i < sePoints.Count; i++)// в цикле по всем четвёркам точек
            {
                Coefficient(i);// считаем коэффициенты
                PointF[] curPoints = new PointF[100];// создаём массив промежуточных точек
                for (int j = 0; j < 100; j++)
                {
                    float t = (float)((float)j / 100);// шаг интерполяции
                                                      // передаём массиву точек значения по методу beta-spline
                    curPoints[j].X = (a[0] + t * (a[1] + t * (a[2] + t * a[3])));
                    curPoints[j].Y = (b[0] + t * (b[1] + t * (b[2] + t * b[3])));
                }

                points.AddRange(curPoints);
            }

            return new _3DSpline(points.ToArray(), S_ColorPicker.Color, (float)S_WidthUpDown.Value);

            void Coefficient(int i)// в функции рассчитываются коэффициенты a0-a3, b0-b3
            {
                a[3] = (-coords[i - 1].X + 3 * coords[i].X - 3 * coords[i + 1].X + coords[i + 2].X) / 6;
                a[2] = (coords[i - 1].X - 2 * coords[i].X + coords[i + 1].X) / 2;
                a[1] = (-coords[i - 1].X + coords[i + 1].X) / 2;
                a[0] = (coords[i - 1].X + 4 * coords[i].X + coords[i + 1].X) / 6;
                b[3] = (-coords[i - 1].Y + 3 * coords[i].Y - 3 * coords[i + 1].Y + coords[i + 2].Y) / 6;
                b[2] = (coords[i - 1].Y - 2 * coords[i].Y + coords[i + 1].Y) / 2;
                b[1] = (-coords[i - 1].Y + coords[i + 1].Y) / 2;
                b[0] = (coords[i - 1].Y + 4 * coords[i].Y + coords[i + 1].Y) / 6;
            }
        }

        public void UpdateTreeView()
        {
            GM_TreeView.Nodes.Clear();

            List<TreeNode> lines = new List<TreeNode>();

            for (int i = 0; i < GrouppedObjects.Count; i++)
            {
                foreach (var line in GrouppedObjects[i])
                    lines.Add(new TreeNode("Line: P1 [" + line.StartPoint.X + "; " + line.StartPoint.Y + "] : P2 [" + line.EndPoint.X + "; " + line.EndPoint.Y + "]\n"));

                GM_TreeView.Nodes.Add(new TreeNode("Group " + (i + 1), lines.ToArray()));
                lines.Clear();
            }
        }

        private void Canvas2D_Resize(object sender, EventArgs e)
        {
            halfWidth = Canvas2D.Size.Width / 2;
            halfHeight = Canvas2D.Size.Height / 2;
            Refresh();
        }

        private void SelectObjects(_3DLine segment)
        {
            if ((ModifierKeys & Keys.Shift) != Keys.Shift)
            {
                SelectedLines.Clear();
            }

            if (GrouppedObjects.Any(x => x.Contains(segment) == true))
            {
                List<_3DLine> tempList = new List<_3DLine>();

                var group = GrouppedObjects.Select(x => x).FirstOrDefault(x => x.Contains(segment));
                foreach (var line in group)
                {
                    if (!SelectedLines.Contains(line))
                        SelectedLines.Add(line);
                }
            }
            else
                SelectedLines.Add(segment);

            //output selected group
            OutputRichTextBox.Text = "Selected lines:\n";
            foreach (_3DLine line in SelectedLines)
            {
                Output(line.StartPoint, line.EndPoint);
            }
        }
        private void Output(Point p1, Point p2 = new Point(), string prefix = "", bool clear = false)
        {
            if (clear) OutputRichTextBox.Text = "Currently at:\n" + prefix;
            else OutputRichTextBox.Text += prefix;

            if (p2.IsEmpty)
                OutputRichTextBox.Text += "Point: (" + p1.X + "," + p1.Y + ")\n";
            else
            {
                int a = p2.Y - p1.Y;
                int b = p1.X - p2.X;
                int c = a * (p1.X) + b * (p1.Y);

                string equation;

                if (a < 0)
                {
                    if (b < 0) //orig
                    {
                        //OutputRichTextBox.Text += "Line: " + a + "X - " + b + "Y - " + c + " = 0\n";

                        equation = c > 0 ? Math.Abs(a) + "X + " + Math.Abs(b) + "Y - " + c + " = 0" : Math.Abs(a) + "X + " + Math.Abs(b) + "Y + " + Math.Abs(c) + " = 0";
                        OutputRichTextBox.Text += "Line: " + equation + "\n";
                    }
                    else
                    {
                        //OutputRichTextBox.Text += "Line: " + a + "X + " + b + "Y - " + c + " = 0\n";
                        equation = c > 0 ? a + "X + " + b + "Y - " + c + " = 0" : a + "X + " + b + "Y + " + Math.Abs(c) + " = 0";
                        OutputRichTextBox.Text += "Line: " + equation + "\n";
                    }
                }
                else
                {
                    if (b < 0) //orig
                    {
                        //OutputRichTextBox.Text += "Line: " + a + "X - " + b + "Y - " + c + " = 0\n";

                        equation = c > 0 ? "-" + a + "X + " + Math.Abs(b) + "Y - " + c + " = 0" : "-" + a + "X + " + Math.Abs(b) + "Y + " + Math.Abs(c) + " = 0";
                        OutputRichTextBox.Text += "Line: " + equation + "\n";
                    }
                    else
                    {
                        //OutputRichTextBox.Text += "Line: " + a + "X + " + b + "Y - " + c + " = 0\n";
                        equation = c > 0 ? a + "X + " + b + "Y - " + c + " = 0" : a + "X + " + b + "Y + " + Math.Abs(c) + " = 0";
                        OutputRichTextBox.Text += "Line: " + equation + "\n";
                    }
                }
            }
        }
    }
}
