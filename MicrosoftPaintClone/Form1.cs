using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MicrosoftPaintClone
{
    public partial class mainForm : Form
    {
        class PointNode
        {
            public Point Point;
            public Point PreviousPoint;
            public Color Color;
            public float Size;

            public PointNode(Point previousPoint,Point point, Color color, float size)
            {
                this.PreviousPoint = previousPoint;
                this.Point = point;
                this.Color = color;
                this.Size = size;
            }
        }

        List<PointNode> allPointNodes = new List<PointNode>();
        Graphics graphics;
        Pen pencil;
        Pen eraser;
        bool pencilEnabled = false;
        bool mousePressed = false;
        float previousX = 0.0f;
        float previousY = 0.0f;
        bool eraserEnabled = false;
        bool colorPickerEnabled = false;

        public mainForm()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            pencil = new Pen(Color.White, 1.0f);
            eraser = new Pen(Color.White, 3.0f);

            //temporary combobox
            sizesCombobox.SelectedIndex = 0;

            colorOneWrapperPanel.BackColor = Color.DodgerBlue;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //set the correct menu(home) and make the view menu invisible 
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeSubMenuPanel.Visible = true;
            viewSubMenuPanel.Visible = false;
            homeSubMenuPanel.Size = new Size(homeSubMenuPanel.Size.Width, 135);
            viewSubMenuPanel.Size = new Size(viewSubMenuPanel.Size.Width, 0);
        }

        //set the correct menu(view) and make the home menu invisible
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSubMenuPanel.Visible = true;
            homeSubMenuPanel.Visible = false;
            viewSubMenuPanel.Size = new Size(viewSubMenuPanel.Size.Width, 135);
            homeSubMenuPanel.Size = new Size(homeSubMenuPanel.Size.Width, 0);
        }

        //TODO change sizes
        private void sizesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //thin
            if (sizesCombobox.SelectedIndex == 0)
            {
                pencil.Width = 1.0f;
                eraser.Width = 4.0f;
            }
            //average
            else if (sizesCombobox.SelectedIndex == 1) {
                pencil.Width = 2.0f;
                eraser.Width = 6.0f;
            }
            //fat
            else if(sizesCombobox.SelectedIndex == 2)
            {
                pencil.Width = 3.0f;
                eraser.Width = 8.0f;
            }
            //very fat
            else if(sizesCombobox.SelectedIndex == 3)
            {
                pencil.Width = 4.0f;
                eraser.Width = 10.0f;
            }
        }

        private void toolsPencilPictureBox_Click(object sender, EventArgs e)
        {
            pencilEnabled = true;
            pencil.Color = colorOnePanel.BackColor;
            eraserEnabled = false;
            colorPickerEnabled = false;
        }

        private void toolsEraserPictureBox_Click(object sender, EventArgs e)
        {
            eraserEnabled = true;
            eraser.Color = colorTwoPanel.BackColor;
            pencilEnabled = false;
            colorPickerEnabled = false;
        }

        //TODO change icons based on what is picked
        private void mainForm_MouseEnter(object sender, EventArgs e)
        {
        }

        //TODO reset back to cursor
        private void mainForm_MouseLeave(object sender, EventArgs e)
        {
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;

        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            previousX = 0.0f;
            previousY = 0.0f;
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePressed) return;

            if (previousX == 0.0f) previousX = e.X;
            if (previousY == 0.0f) previousY = e.Y;
            if (pencilEnabled)
            {
                graphics.DrawLine(pencil, previousX, previousY, e.X, e.Y);
                allPointNodes.Add(new PointNode(
                    new Point((int)previousX, (int)previousY),
                    new Point(e.X, e.Y),
                    colorOnePanel.BackColor,
                    pencil.Width));
            }
            else if (eraserEnabled) 
            {
                graphics.DrawLine(eraser, previousX, previousY, e.X, e.Y);
                allPointNodes.Add(new PointNode(
                    new Point((int)previousX, (int)previousY),
                    new Point(e.X, e.Y),
                    colorTwoPanel.BackColor,
                    eraser.Width
                    ));
            }

            previousX = e.X;
            previousY = e.Y;
        }


        //Here below is the code for the swaps between color one and color two
        private void colorOneWrapperPanel_MouseClick(object sender, MouseEventArgs e)
        {
            colorOneWrapperPanel.BackColor = Color.DodgerBlue;
            colorTwoWrapperPanel.BackColor = Color.WhiteSmoke;
        }

        private void colorOnePanel_MouseClick(object sender, MouseEventArgs e)
        {
            colorOneWrapperPanel.BackColor = Color.DodgerBlue;
            colorTwoWrapperPanel.BackColor = Color.WhiteSmoke;
        }

        private void colorOneLabel_Click(object sender, EventArgs e)
        {
            colorOneWrapperPanel.BackColor = Color.DodgerBlue;
            colorTwoWrapperPanel.BackColor = Color.WhiteSmoke;
        }


        private void ColorTwoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            colorTwoWrapperPanel.BackColor = Color.DodgerBlue;
            colorOneWrapperPanel.BackColor = Color.WhiteSmoke;
        }

        private void colorTwoWrapperPanel_MouseClick(object sender, MouseEventArgs e)
        {
            colorTwoWrapperPanel.BackColor = Color.DodgerBlue;
            colorOneWrapperPanel.BackColor = Color.WhiteSmoke;
        }

        private void ColorTwoLabel_Click(object sender, EventArgs e)
        {
            colorTwoWrapperPanel.BackColor = Color.DodgerBlue;
            colorOneWrapperPanel.BackColor = Color.WhiteSmoke;
        }

        
       

        private void toolsColorPickerPictureBox_Click(object sender, EventArgs e)
        {
            colorPickerEnabled = true;
            pencilEnabled = false;
            eraserEnabled = false;
        }


        //Color changes for color 1 and color 2
        private void colorsBlackPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Black; pencil.Color = Color.Black; }
            else { colorTwoPanel.BackColor = Color.Black; eraser.Color = Color.Black; }
        }

        private void colorsGrayPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Gray; pencil.Color = Color.Gray; }
            else { colorTwoPanel.BackColor = Color.Gray; eraser.Color = Color.Gray; }
        }

        private void colorsDarkRedPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.DarkRed; pencil.Color = Color.DarkRed; }
            else colorTwoPanel.BackColor = Color.DarkRed; eraser.Color = Color.DarkRed;
        }

        private void colorsRedPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Red; pencil.Color = Color.Red; }
            else colorTwoPanel.BackColor = Color.Red; eraser.Color = Color.Red;
        }

        private void ColorsOrangePanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Orange; pencil.Color = Color.Orange; }
            else colorTwoPanel.BackColor = Color.Orange; eraser.Color = Color.Orange;
        }

        private void colorsYellowPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Yellow; pencil.Color = Color.Yellow; }
            else colorTwoPanel.BackColor = Color.Yellow; eraser.Color = Color.Yellow;
        }

        private void colorsGreenPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.Green; pencil.Color = Color.Green; }
            else colorTwoPanel.BackColor = Color.Green; eraser.Color = Color.Green;
        }

        private void colorsTurquoisePanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = Color.DeepSkyBlue; pencil.Color = Color.DeepSkyBlue; }
            else colorTwoPanel.BackColor = Color.DeepSkyBlue; eraser.Color = Color.DeepSkyBlue;
        }

        private void colorsIndigoPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Blue; pencil.Color = Color.Blue; }
            else colorTwoPanel.BackColor = Color.Blue; eraser.Color = Color.Blue;
        }

        private void colorsPurplePanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Purple; pencil.Color = Color.Purple; }
            else colorTwoPanel.BackColor = Color.Purple; eraser.Color = Color.Purple;
        }

        private void colorsWhitePanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.White; pencil.Color = Color.White; }
            else colorTwoPanel.BackColor = Color.White; eraser.Color = Color.White;
        }

        private void colorsLightGrayPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.LightGray; pencil.Color = Color.LightGray; }
            else colorTwoPanel.BackColor = Color.LightGray; eraser.Color = Color.LightGray;
        }

        private void colorsBrownPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Sienna; pencil.Color = Color.Sienna; }
            else colorTwoPanel.BackColor = Color.Sienna; eraser.Color = Color.Sienna;
        }

        private void colorsPinkPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Pink; pencil.Color = Color.Pink; }
            else colorTwoPanel.BackColor = Color.Pink; eraser.Color = Color.Pink;
        }

        private void colorsGoldPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Gold; pencil.Color = Color.Gold; }
            else colorTwoPanel.BackColor = Color.Gold; eraser.Color = Color.Gold;
        }

        private void colorsLightYellowPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Khaki; pencil.Color = Color.Khaki; }
            else colorTwoPanel.BackColor = Color.Khaki; eraser.Color = Color.Khaki;
        }

        private void colorsLightGreenPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.LawnGreen; pencil.Color = Color.LawnGreen; }
            else colorTwoPanel.BackColor = Color.LawnGreen; eraser.Color = Color.LawnGreen;
        }

        private void colorsLightTurquoisePanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Aqua; pencil.Color = Color.Aqua; }
            else colorTwoPanel.BackColor = Color.Aqua; eraser.Color = Color.Aqua;
        }

        private void colorsBlueGrayPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.DodgerBlue; pencil.Color = Color.DodgerBlue; }
            else colorTwoPanel.BackColor = Color.DodgerBlue; eraser.Color = Color.DodgerBlue;
        }

        private void colorsLavenderPanel_Click(object sender, EventArgs e)
        {
            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) {colorOnePanel.BackColor = Color.Magenta; pencil.Color = Color.Magenta; }
            else colorTwoPanel.BackColor = Color.Magenta; eraser.Color = Color.Magenta;
        }

        //////
       
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            //create a background thread to do some task
            if (this.WindowState == FormWindowState.Minimized)
            {
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                float tempPencilWidth = pencil.Width;
                foreach(PointNode pointNode in allPointNodes)
                {
                    pencil.Width = pointNode.Size;
                    pencil.Color = pointNode.Color;
                    graphics.DrawLine(pencil, (float)pointNode.PreviousPoint.X, (float)pointNode.PreviousPoint.Y,
                        (float)pointNode.Point.X, (float)pointNode.Point.Y);
                }

                pencil.Width = tempPencilWidth;
            }
        }

        //TODO not working very well yet, fix the colorpicker
        //used by colorPicker
        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {

            if (!colorPickerEnabled) return;

            int x = e.X;
            int y = e.Y;

            Color color = Color.Empty;
            foreach (PointNode pointNode in allPointNodes)
            {
                if ((x <= pointNode.Point.X && x >= pointNode.PreviousPoint.X) && (y <= pointNode.Point.Y && y >= pointNode.PreviousPoint.Y))
                {
                    color = pointNode.Color;
                }
            }

            if (color == Color.Empty) color = this.BackColor;

            if (colorOneWrapperPanel.BackColor == Color.DodgerBlue) { colorOnePanel.BackColor = color; pencil.Color = color; }
            else colorTwoPanel.BackColor = color; eraser.Color = color;
        }
    }
}
