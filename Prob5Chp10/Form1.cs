using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob5Chp10
{
    public partial class Form1 : Form
    {
        ColorDialog color = new ColorDialog();
        FontDialog font = new FontDialog();

        public Form1()
        {
             

            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            quote.Text = userQuote.Text;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font.ShowDialog();
            quote.Font = font.Font;
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
            quote.ForeColor = color.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.Close();
        }
    }
}
