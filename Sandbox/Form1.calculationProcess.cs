using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sandbox
{
    partial class Form1
    {
        private string numbersShown;
        private decimal resultLocal;
        private bool enteringNumber = false;
        private List<string> numbersOrder = new List<string>();       
        private int progressionStart;
        private int progressionIndicator;
        private decimal first;
        private decimal second;
        private void calculationProcessParenthesis()
        {
            while (numbersOrder.Contains("("))
            {
                for (int i = 0; i < numbersOrder.Count - 1; i++)
                {
                    if (numbersOrder[i].Contains("(") == true)
                    {

                        progressionStart = i + 1;
                        progressionIndicator = i;
                        while (numbersOrder[progressionIndicator].Contains(")") == false && progressionIndicator < numbersOrder.Count - 1)
                        {
                            progressionIndicator++;
                            
                        }
                        if (progressionIndicator == numbersOrder.Count - 1)
                        {
                            numbersOrder.RemoveAt(i);
                        }
                        else
                        {
                            calculationProcessSigns(progressionStart, progressionIndicator - 1);
                            numbersOrder.RemoveAt(i);
                            numbersOrder.RemoveAt(progressionIndicator);
                        }
                    }                        
                }
            }
        }
        private void calculationProcessSigns(int numberBeforeLocation, int numberAfterLocation)
        {
            for (int u = numberBeforeLocation; u < numberAfterLocation; u++)
            {          
                if (numbersOrder[u].Contains("*"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1]);
                    second = Convert.ToDecimal(numbersOrder[u + 1]);
                    resultLocal = first * second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                }
                else if (numbersOrder[u].Contains("/"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1]);
                    second = Convert.ToDecimal(numbersOrder[u + 1]);
                    resultLocal = first / second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                }
                else if (numbersOrder[u].Contains("-"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1]);
                    second = Convert.ToDecimal(numbersOrder[u + 1]);
                    resultLocal = first - second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                }
                else if (numbersOrder[u].Contains("+"))
                {
                    //dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1]);
                    second = Convert.ToDecimal(numbersOrder[u + 1]);
                    resultLocal = first + second;
                    numbersOrder[u - 1] = resultLocal.ToString();
                    numbersOrder.RemoveRange(u, 2);
                    
                }
            }
        }

        private void dodgingExceptions(int index)
        {
            while (numbersOrder[index + 1].Contains("*") || numbersOrder[index + 1].Contains("/") || numbersOrder[index + 1].Contains("+") || numbersOrder[index + 1].Contains("-"))
            {
                numbersOrder.RemoveAt(index + 1);
            }
        }



    }
}
