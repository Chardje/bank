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
            
        }

        private void Вивод_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add($"{S.Value} * {i} = {S.Value*i}");
            }
            //Invalidate();
        }
    }
}
