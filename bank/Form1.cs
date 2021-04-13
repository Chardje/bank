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
        //создайом рандом
        public Random R = new Random();
        public Form1()
        {            
            InitializeComponent();
        }       
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            double rd;
            int x = Convert.ToInt32( S.Value);
            for (int i=0;i<N.Value;i++)
            {
                rd = 1 + (R.Next(0,20)/100);
                x += Convert.ToInt32(rd * x / 100);
                e.Graphics.DrawString($"{i}: {x}",DefaultFont,Brushes.Black,new Point(200,i*10));
            }
        }

        private void Вивод_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
