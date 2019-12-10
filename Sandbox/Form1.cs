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
            
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numbersShown += "1";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "1";
            }
            else
            {
                numbersOrder.Add("1");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
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
            numbersShown += "8";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "8";
            }
            else
            {
                numbersOrder.Add("8");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            numbersShown += "+";
            numbersOrder.Add("+");
            enteringNumber = false;         
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numbersShown += "-";
            numbersOrder.Add("-");
            enteringNumber = false;
            readOnlyTextBox1.Text = numbersShown;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                calculationProcessParenthesis();
                while (numbersOrder.Count != 1)
                {
                    calculationProcessSigns(0, numbersOrder.Count);
                }
                numbersShown = numbersOrder[0];
                readOnlyTextBox1.Text = numbersShown;
                numbersOrder.Clear();
                enteringNumber = false;
                return true;
            }
            else return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numbersShown += "2";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "2";
            }
            else
            {
                numbersOrder.Add("2");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }
       


        private void button5_Click(object sender, EventArgs e)
        {
            numbersShown += "3";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbersShown += "4";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbersShown += "5";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbersShown += "6";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbersShown += "7";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numbersShown += "9";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numbersShown += "0";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbersOrder.Clear();
            numbersShown = "";
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numbersOrder[numbersOrder.Count - 1].Length != 0)
            {
                numbersOrder[numbersOrder.Count - 1] = numbersOrder[numbersOrder.Count - 1].Remove(numbersOrder[numbersOrder.Count - 1].Length - 1);                
                numbersShown = numbersShown.Remove(numbersShown.Length - 1);
                readOnlyTextBox1.Text = numbersShown;
            }
            else
            {
                numbersOrder.RemoveAt(numbersOrder.Count - 1);
            }
        }          
        private void button14_Click(object sender, EventArgs e)
        {
            numbersShown += "*";
            numbersOrder.Add("*");
            enteringNumber = false;
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numbersShown += "/";
            numbersOrder.Add("/");
            enteringNumber = false;
            readOnlyTextBox1.Text = numbersShown;
        }
    }
}
