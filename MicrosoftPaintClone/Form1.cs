using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftPaintClone
{
    public partial class mainForm : Form
    {
        Graphics graphics;
        Pen pencil;
        //Pen eraser;
        bool pencilEnabled = false;
        bool mousePressed = false;
        float previousX = 0.0f;
        float previousY = 0.0f;
        //bool eraserEnabled = false;

        public mainForm()
        {
            InitializeComponent();
            //temporary combobox
            sizesCombobox.SelectedIndex = 0;

            colorOneWrapperPanel.BackColor = Color.DodgerBlue;

            graphics = this.CreateGraphics();
            pencil = new Pen(Color.White, 1.0f);
            //eraser = new Pen(Color.White, 3.0f);
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
        }

        private void toolsPencilPictureBox_Click(object sender, EventArgs e)
        {
            pencilEnabled = true;
            pencil.Color = colorOnePanel.BackColor;
            //eraserEnabled = false;
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
    }
}
