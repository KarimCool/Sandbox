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
        private void button10_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                calculationProcessParenthesis(0, numbersOrder);
                while (numbersOrder.Count != 1)
                {
                    calculationProcessSigns(0, numbersOrder.Count-1);
                } 
                numbersShown = numbersOrder[0];
                readOnlyTextBox1.Text = numbersShown;
                //numbersOrder.Clear();
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
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "3";
            }
            else
            {
                numbersOrder.Add("3");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbersShown += "4";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "4";
            }
            else
            {
                numbersOrder.Add("4");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbersShown += "5";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "5";
            }
            else
            {
                numbersOrder.Add("5");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbersShown += "6";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "6";
            }
            else
            {
                numbersOrder.Add("6");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbersShown += "7";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "7";
            }
            else
            {
                numbersOrder.Add("7");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numbersShown += "9";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "9";
            }
            else
            {
                numbersOrder.Add("9");
                enteringNumber = true;
            }
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numbersShown += "0";
            if (enteringNumber == true)
            {
                numbersOrder[numbersOrder.Count - 1] += "0";
            }
            else
            {
                numbersOrder.Add("0");
                enteringNumber = true;
            }
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
            if (numbersOrder.Count != 0)
            {
                if (numbersOrder[numbersOrder.Count - 1].Length != 0)
                {
                    numbersOrder[numbersOrder.Count - 1] = numbersOrder[numbersOrder.Count - 1].Remove(numbersOrder[numbersOrder.Count - 1].Length - 1);
                    numbersShown = numbersShown.Remove(numbersShown.Length - 1);                    
                }
                else
                {
                    numbersOrder.RemoveAt(numbersOrder.Count - 1);                    
                }                
                if (numbersOrder.Count == 0) { enteringNumber = false; }
            }
            readOnlyTextBox1.Text = numbersShown;
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

        private void button17_Click(object sender, EventArgs e)
        {
            numbersShown += "(";
            numbersOrder.Add("(");
            enteringNumber = false;
            readOnlyTextBox1.Text = numbersShown;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            numbersShown += ")";
            numbersOrder.Add(")");
            enteringNumber = false;
            readOnlyTextBox1.Text = numbersShown;
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            numbersShown += ".";
            if (enteringNumber == true){numbersOrder[numbersOrder.Count - 1] += ".";}
            else{numbersOrder.Add("."); enteringNumber = true;}
            readOnlyTextBox1.Text = numbersShown;
        }
    }
}
