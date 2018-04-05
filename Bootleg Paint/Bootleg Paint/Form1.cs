using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootleg_Paint
{
    public partial class Form1 : Form
    {
        private static Color baseColor = Color.Black;
        private Pen ChosenPen;
        private Pen erase = new Pen(Color.White);
        private Pen specialErase = new Pen(Color.White);
        private Pen ChosenHighlighter;
        private SolidBrush FillBrush = new SolidBrush(Color.Black);
        public static int a;
        public static int r;
        public static int b;
        public static int g;
        Rectangle Rect;
        Graphics Doodle;
        Color BucketColor;
        bool Painting = false;
        bool Eraser = false;
        bool Hightlighting = false;
        bool Line = false;
        bool Rekt = false;
        bool Circle = false;
        bool Triangle = false;
        bool nGon = false;
        Point start;
        Point end;
        int CircleX1;
        int CircleY1;
        int CircleX2;
        int CircleY2;
        Point Vertex1;
        Point Vertex2;
        Point Vertex3;
        Point[] nGonPts = new Point[3];
        int ClickCount = 0;
        private static Bitmap bmp = new Bitmap(600, 414, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        public Form1()

        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = bmp;
            Doodle = Graphics.FromImage(pnlMain.BackgroundImage);
            Doodle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Doodle.Clear(Color.White);
            
            pnlSpecialErase.BackColor = cldBucket.Color;
            
           this.Width += 4;
           this.Height += 98;
           ChosenPen = new Pen(Color.Black, 4);
           ChosenHighlighter = new Pen(Color.FromArgb(10, baseColor));
           BucketColor = Color.White;
           cboDrawType.SelectedIndex = 0;
           specialErase.Color = BucketColor;

           ChosenPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
           ChosenPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
           ChosenHighlighter.StartCap = System.Drawing.Drawing2D.LineCap.Square;//WIP
           ChosenHighlighter.EndCap = System.Drawing.Drawing2D.LineCap.Square;//WIP
           erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
           erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
           specialErase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
           specialErase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Doodle.Dispose();
            ChosenPen.Dispose();
            ChosenHighlighter.Dispose();
            erase.Dispose();
            specialErase.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = cldPicker.ShowDialog();

            if (result == DialogResult.OK)
            {
                ChosenPen.Color = cldPicker.Color;
                FillBrush.Color = cldPicker.Color;
                pnlChosenColor.BackColor = cldPicker.Color;
                Color ChosenHighlightColor = cldPicker.Color;
                ChosenHighlighter.Color = Color.FromArgb(10, ChosenHighlightColor);
                pnlChosenColor.BackColor = cldPicker.Color;
                pnlSpecialErase.BackColor = cldPicker.Color;
                BucketColor = cldPicker.Color;
                cldBucket.Color = cldPicker.Color;
            }
        }


        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            if (cboDrawType.SelectedIndex == 0)
            {
            Painting = true;
            }
            else if (cboDrawType.SelectedIndex == 1)
            {
                Doodle.Clear(BucketColor);
                pnlMain.Refresh();
            }
            else if (cboDrawType.SelectedIndex == 2)
            {
                Eraser = true;
            }
            else if (cboDrawType.SelectedIndex == 3)
            {
                Hightlighting = true;
            }
            else if (cboDrawType.SelectedIndex == 4)
            {
                Line = true;
            }
            else if (cboDrawType.SelectedIndex == 5)
            {
                Rekt = true;
                start = e.Location;
            }
            else if (cboDrawType.SelectedIndex == 6)
            {
                Circle = true;
                CircleX1 = e.X;
                CircleY1 = e.Y;
            }
            else if (cboDrawType.SelectedIndex == 7)
            {
                Triangle = true;
                Vertex1 = e.Location;
            }
            else if (cboDrawType.SelectedIndex == 8)
            {
                Triangle = false;
                nGon = true;
                nGonPts[ClickCount] = e.Location;
                ClickCount++;
            }
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (cboDrawType.SelectedIndex == 0)
            {
            Painting = false;
            }
            else if (cboDrawType.SelectedIndex == 2)
            {
            Eraser = false;
            }
            else if (cboDrawType.SelectedIndex == 3)
            {
            Hightlighting = false;
            }
           else if (Line == true) //Draw Line
           {
               end = e.Location;
               Doodle.DrawLine(ChosenPen, start, end);
               Line = false;
               this.Refresh();
           }
           else if (Rekt == true) //Draw Recktangle
            {
               if (chkFill.Checked == false)
               {
                Doodle.DrawRectangle(ChosenPen, Rect);
               }
               else if (chkFill.Checked == true)
               {
                   Doodle.FillRectangle(FillBrush, Rect);
               }
                Rekt = false;
                this.Refresh();
            }
           else if (Circle == true) //Draw Circle
            {
                CircleX2 = (e.X - CircleX1);
                CircleY2 = (e.Y - CircleY1);
               if (chkFill.Checked == false)
               {
                Doodle.DrawEllipse(ChosenPen, CircleX1, CircleY1, CircleX2, CircleY2);
               }
               else if (chkFill.Checked == true)
               {
                   Doodle.FillEllipse(FillBrush, CircleX1, CircleY1, CircleX2, CircleY2);
               }
                Circle = false;
                this.Refresh();
            }
           else if (Triangle == true) //Triangle
            {
               if (rdoEquilIso.Checked == true)
               {
                    if (rdoUpDown.Checked == true) //Isoceles/Equilateral - UpDown
                    {
                        Vertex2.X = e.X;
                        Vertex2.Y = Vertex1.Y;
                        Vertex3.Y = e.Y;
                        Vertex3.X = Vertex1.X + (Vertex2.X - Vertex1.X) / 2; 
                    }
                    else if (rdoLeftRight.Checked == true) //Isoceles/Equilateral - LeftRight
                    {
                        Vertex2.Y = e.Y;
                        Vertex2.X = Vertex1.X;
                        Vertex3.X = e.X;
                        Vertex3.Y = Vertex1.Y + (Vertex2.Y - Vertex1.Y) / 2;
                    }
               }
               else if (rdoRightAngle.Checked == true) //Right Angled
               {
                   Vertex2.X = Vertex1.X;
                   Vertex2.Y = e.Y;
                   Vertex3.Y = Vertex1.Y;
                   Vertex3.X = e.X;
               }
                Point[] pts = new Point[3] { Vertex1, Vertex3, Vertex2 };
               if (chkFill.Checked == false)
               {
                Doodle.DrawPolygon(ChosenPen, pts);
               }
               else if (chkFill.Checked == true)
               {
                   Doodle.FillPolygon(FillBrush, pts);
               }
                this.Refresh();
            }
            else if (nGon == true)
            {
                lblClickCount.Text = Convert.ToString(Convert.ToInt32(lblClickCount.Text) -1);
                if (ClickCount == 3 && nudSides.Value == 3)
                {
                    if (chkFill.Checked == false)
                    {
                    Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 4 && nudSides.Value == 4)
                {
                    if (chkFill.Checked == false)
                    {
                    Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 5 && nudSides.Value == 5)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 6 && nudSides.Value == 6)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 7 && nudSides.Value == 7)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 8 && nudSides.Value == 8)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 9 && nudSides.Value == 9)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 10 && nudSides.Value == 10)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 11 && nudSides.Value == 11)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 12 && nudSides.Value == 12)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 13 && nudSides.Value == 13)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 14 && nudSides.Value == 14)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 15 && nudSides.Value == 15)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 16 && nudSides.Value == 16)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 17 && nudSides.Value == 17)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 18 && nudSides.Value == 18)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 19 && nudSides.Value == 19)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
                else if (ClickCount == 20 && nudSides.Value == 20)
                {
                    if (chkFill.Checked == false)
                    {
                        Doodle.DrawPolygon(ChosenPen, nGonPts);
                    }
                    else if (chkFill.Checked == true)
                    {
                        Doodle.FillPolygon(FillBrush, nGonPts);
                    }
                    ClickCount = 0;
                    this.Refresh();
                }
            }
            
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosition.Text = "X: " + e.X.ToString() + "," + " Y: " + e.Y.ToString();
            if (Painting == true && cboDrawType.SelectedIndex == 0)
            {
                end = e.Location;
                Doodle.DrawLine(ChosenPen, start, end);
                pnlMain.Refresh();
                start = end;
            }
            else if (Eraser == true && cboDrawType.SelectedIndex == 2)
            {
                if (rdoEraseAll.Checked == true)
                {
                    end = e.Location;
                    Doodle.DrawLine(erase, start, end);
                    pnlMain.Refresh();
                    start = end;
                }
                else if (rdoEraseBrush.Checked == true)
                {
                    specialErase.Color = BucketColor;
                    end = e.Location;
                   Doodle.DrawLine(specialErase, start, end);
                   pnlMain.Refresh();
                   start = end;
                }
                
            }
            else if (Hightlighting == true)
            {
                end = e.Location;
                Doodle.DrawLine(ChosenHighlighter, start, end);
                pnlMain.Refresh();
                start = end;
            }
            else if (Rekt == true)
            {
                Point p = e.Location;
                int x = Math.Min(start.X, p.X);
                int y = Math.Min(start.Y, p.Y);
                int w = Math.Abs(p.X - start.X);
                int h = Math.Abs(p.Y - start.Y);
                Rect = new Rectangle(x, y, w, h);
            }
            else if (nGon == true)
            {
                if (lblClickCount.Text == "0")
                {
                    lblClickCount.Text = Convert.ToInt32(nudSides.Value).ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(599, 412, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            pnlMain.BackgroundImageLayout = ImageLayout.Tile;
            pnlMain.BackgroundImage = bmp;
            Doodle = Graphics.FromImage(pnlMain.BackgroundImage);
            Doodle.Clear(Color.White);
            pnlMain.Refresh();
        }


        private void pnlBlack_Click(object sender, EventArgs e)
        {
            BucketColor = Color.Black;
            ChosenPen.Color = Color.Black;
            pnlChosenColor.BackColor = Color.Black;
            pnlSpecialErase.BackColor = Color.Black;
        }

        private void cboDrawType_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (cboDrawType.SelectedIndex == 0) //Brush
        {
            btnBucketColor.Visible = false;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            nudSize.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Brush";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            lblFill.Visible = false;
            chkFill.Visible = false;
        }
        else if (cboDrawType.SelectedIndex == 1) //Bucket
        {
            //this.Cursor = new Cursor(GetType(), "Bucket Cursor.cur");
            nudSize.Visible = false;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Bucket";
            lblpx.Visible = false;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            lblFill.Visible = true;
            btnBucketColor.Visible = true;
            btnColor.Visible = false;
            btnAdvancedColor.Visible = true;
            pnlChosenColor.Visible = false;
            pnlSpecialErase.Visible = true;
            chkFill.Visible = false;
        }
        else if (cboDrawType.SelectedIndex == 2) //Eraser
        {
            nudSize.Visible = true;
            btnColor.Visible = false;
            btnAdvancedColor.Visible = false;
            pnlChosenColor.BackColor = Color.White;
            lblChosenColor.Text = "Eraser";
            lblpx.Visible = true;
            grpErasers.Visible = true;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            specialErase.Color = BucketColor;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = false;
        }
        else if (cboDrawType.SelectedIndex == 3) //Hightlighter
        {
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Hightlight";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = false;
        }
        else if (cboDrawType.SelectedIndex == 4) //Line
        {
            ChosenPen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            ChosenPen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Line";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = false;
        }

        else if (cboDrawType.SelectedIndex == 5) //Recktangle
        {
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Rectangle";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = true;
        }

        else if (cboDrawType.SelectedIndex == 6) //Circle
        {
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Circle";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = false;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = true;
        }
        else if (cboDrawType.SelectedIndex == 7) //Triangle
        {
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Triangle";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = true;
            grpTriangleType.Visible = true;
            grpPolygon.Visible = false;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            rdoEquilIso.Checked = true;
            rdoUpDown.Checked = true;
            chkFill.Visible = true;
        }
        else if (cboDrawType.SelectedIndex == 8) //Polygon
        {
            nudSize.Visible = true;
            btnColor.Visible = true;
            btnAdvancedColor.Visible = true;
            //pnlChosenColor.BackColor = cldPicker.Color;
            lblChosenColor.Text = "Polygon";
            lblpx.Visible = true;
            grpErasers.Visible = false;
            grpVertexType.Visible = false;
            grpTriangleType.Visible = false;
            grpPolygon.Visible = true;
            lblFill.Visible = false;
            btnBucketColor.Visible = false;
            btnColor.Visible = true;
            pnlChosenColor.Visible = true;
            pnlSpecialErase.Visible = false;
            chkFill.Visible = true;
        }

            if (cboDrawType.SelectedIndex != 4) //Re-set ChosenPen to Round if it's not a line
            {
                ChosenPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                ChosenPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            ChosenPen.Width = Convert.ToUInt16(nudSize.Value);
            erase.Width = Convert.ToUInt16(nudSize.Value);
            specialErase.Width = Convert.ToUInt16(nudSize.Value);
            ChosenHighlighter.Width = Convert.ToUInt16(nudSize.Value);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosition.Text = "X: Out, Y: Out";
            Painting = false; 
            
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (cboDrawType.SelectedIndex == 1)
            {
                Doodle.Clear(BucketColor);
            }
        }

        private void btnBucketColor_Click(object sender, EventArgs e)
        {
            DialogResult result = cldBucket.ShowDialog();

            if (result == DialogResult.OK)
            {
                BucketColor = cldBucket.Color;
                pnlSpecialErase.BackColor = BucketColor;
                specialErase.Color = BucketColor;
                cldPicker.Color = BucketColor;
            }
        }

        private void btnClearBucket_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(599, 412, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            pnlMain.BackgroundImageLayout = ImageLayout.Tile;
            pnlMain.BackgroundImage = bmp;
            Doodle = Graphics.FromImage(pnlMain.BackgroundImage);
            Doodle.Clear(cldBucket.Color);
            pnlMain.Refresh();
        }

        private void rdoEraseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEraseAll.Checked == true)
            {
                pnlChosenColor.BackColor = erase.Color;
            }
            else if (rdoEraseBrush.Checked == true)
            {
                pnlChosenColor.BackColor = specialErase.Color;
            }
        }

        private void rdoEraseBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEraseAll.Checked == true)
            {
                pnlChosenColor.BackColor = erase.Color;
            }
            else if (rdoEraseBrush.Checked == true)
            {
                pnlChosenColor.BackColor = specialErase.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            svdDoodle.ShowDialog();
        }

        private void svdDoodle_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                switch (svdDoodle.FilterIndex)
                {
                    case 1:
                        bmp.Save(svdDoodle.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        bmp.Save(svdDoodle.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception " + ex);
            }
        }

        private void rdoEquilIso_CheckedChanged(object sender, EventArgs e)
        {
            grpVertexType.Visible = true;
        }

        private void rdoRightAngle_CheckedChanged(object sender, EventArgs e)
        {
            grpVertexType.Visible = false;
        }

        private void nudSides_ValueChanged(object sender, EventArgs e)
        {
            nGonPts = new Point[Convert.ToInt32(nudSides.Value)];
            lblClickCount.Text = nudSides.Value.ToString();
            ClickCount = 0;
            if (nudSides.Value == 3)
            {
            lblPolygon.Text = "Trigon";
            }
            else if (nudSides.Value == 4)
            {
                lblPolygon.Text = "Tetragon";
            }
            else if (nudSides.Value == 5)
            {
                lblPolygon.Text = "Pentagon";
            }
            else if (nudSides.Value == 6)
            {
                lblPolygon.Text = "Hexagon";
            }
            else if (nudSides.Value == 7)
            {
                lblPolygon.Text = "Heptagon";
            }
            else if (nudSides.Value == 8)
            {
                lblPolygon.Text = "Octagon";
            }
            else if (nudSides.Value == 9)
            {
                lblPolygon.Text = "Enneagon";
            }
            else if (nudSides.Value == 10)
            {
                lblPolygon.Text = "Decagon";
            }
            else if (nudSides.Value == 11)
            {
                lblPolygon.Text = "Hendecagon";
            }
            else if (nudSides.Value == 12)
            {
                lblPolygon.Text = "Dodecagon";
            }
            else if (nudSides.Value == 13)
            {
                lblPolygon.Text = "Tridecagon";
            }
            else if (nudSides.Value == 14)
            {
                lblPolygon.Text = "Tetradecagon";
            }
            else if (nudSides.Value == 15)
            {
                lblPolygon.Text = "Pendedecagon";
            }
            else if (nudSides.Value == 16)
            {
                lblPolygon.Text = "Hexdecagon";
            }
            else if (nudSides.Value == 17)
            {
                lblPolygon.Text = "Heptdecagon";
            }
            else if (nudSides.Value == 18)
            {
                lblPolygon.Text = "Octdecagon";
            }
            else if (nudSides.Value == 19)
            {
                lblPolygon.Text = "Enneadecagon";
            }
            else if (nudSides.Value == 20)
            {
                lblPolygon.Text = "Icosagon";
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ofdDoodle.ShowDialog();
        }

        private void ofdDoodle_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                switch (ofdDoodle.FilterIndex)
                {
                    case 1:
                        bmp = (Bitmap)Image.FromFile(ofdDoodle.FileName);
                        pnlMain.BackgroundImage = bmp;
                        Doodle = Graphics.FromImage(pnlMain.BackgroundImage);
                        break;
                    case 2:
                        bmp = (Bitmap)Image.FromFile(ofdDoodle.FileName);
                        pnlMain.BackgroundImage = bmp;
                        Doodle = Graphics.FromImage(pnlMain.BackgroundImage);
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception " + ex);
            }
        }

        private void ofdDoodle_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Image dimensions must be 599 x 412 for exceptional performace." + Environment.NewLine + "Doodles saved from the application will always be of proper dimensions.");
        }

        private void svdDoodle_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Image dimensions will be saved as 599 x 412." + Environment.NewLine + "Dimensions are best compatible for importing Doodles or previewing in Desktop.");
        }

        private void btnAdvancedColor_Click(object sender, EventArgs e)
        {
            if (cboDrawType.SelectedIndex == 3)
            {
                a = 10;
            }
            else
            {
                a = 255;
            }
            Form2 frm3 = new Form2();
            frm3.ShowDialog();
            if (Form2.ok == true)
            {
                ChosenPen.Color = Color.FromArgb(a, r, g, b);
                FillBrush.Color = Color.FromArgb(a, r, g, b);
                pnlChosenColor.BackColor = Color.FromArgb(a, r, g, b);
                Color ChosenHighlightColor = Color.FromArgb(a, r, g, b);
                ChosenHighlighter.Color = Color.FromArgb(10, ChosenHighlightColor);
                BucketColor = Color.FromArgb(a, r, g, b);
                pnlSpecialErase.BackColor = BucketColor;
                pnlChosenColor.BackColor = Color.FromArgb(a, r, g, b);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Size.Width) / 2;
            pnlMain.Top = ((this.ClientSize.Height - pnlMain.Size.Height) / 2) + 30;
            pnlTools.Left = (this.ClientSize.Width - pnlTools.Size.Width) / 2;
        }


    }
}
