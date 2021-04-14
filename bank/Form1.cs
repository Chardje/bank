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
            //double rd;
            decimal x =0;
            for (int i=0;i<N.Value;i++)
            {
                //rd = 1 + (R.Next(0,20)/100);
                
                e.Graphics.DrawString($"{i}: {(i * r.Value) + S.Value + x}",DefaultFont,Brushes.Black,new Point(200,i*10));    
                x = (i * r.Value) + S.Value;
            }
        }

        private void Вивод_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
