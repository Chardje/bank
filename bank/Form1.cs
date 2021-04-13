using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i=0;i<N.Value;i++)
            {
                e.Graphics.DrawString($"{i}: {((i+1)*R.Value*S.Value/100)+S.Value}",DefaultFont,Brushes.Black,new Point(200,i*10));
            }
        }

        private void Вивод_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
