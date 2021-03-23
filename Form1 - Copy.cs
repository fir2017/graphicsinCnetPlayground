using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphicsplayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peintedcontrol1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("NONE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("DOT");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("LINE");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("SQUARE");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("ARC");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("CIRCLE");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            peintedcontrol2.SetMode("ELIPSE");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            peintedcontrol2.textuldeafisat = this.textBox1.Text;
            peintedcontrol2.SetMode("TEXT");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (peintedcontrol2.EnterInDebugMode == false)
            {
                peintedcontrol2.SetDebugModeOnOff("ON");
            }
            else
            {
                peintedcontrol2.SetDebugModeOnOff("OFF");
            }
        }
    }
}
