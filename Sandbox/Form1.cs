using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            result = new Deveel.Math.BigDecimal(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
           if (e.KeyChar == (char)Keys.Enter)
           {
                MessageBox.Show("easy");

               // numbersShown = result.ToString();
               // readOnlyTextBox1.Text = numbersShown;
           }

            
        }
    }
}
