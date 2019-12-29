using System;
using System.Globalization;
using System.Collections;
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
    partial class Form1
    {
        private string numbersShown;
        private decimal resultLocal;
        private List<string> numbersOrder = new List<string>();       
        private int progressionStart;
        private int progressionIndicator;
        private decimal first;
        private decimal second;
        private bool enteringNumber;
        private int calculationCounter;
        private List<string> pieceOfNumbersOrder = new List<string>();
        NumberFormatInfo engFormat = CultureInfo.GetCultureInfo("en-US").NumberFormat;
        private void calculationProcessParenthesis(int positionStart, List<string> numbers)
        {
            while (numbers.Contains("("))
            {
                for (int i = positionStart; i < numbersOrder.Count - 1; i++)
                {
                    if (numbers[i].Contains("("))
                    {
                        for (int e = i; e < numbersOrder.Count - 1; e++)
                        {
                            if (numbersOrder[e].Contains("(") == true)
                            {
                                progressionStart = e;
                                e++;                               
                                calculationProcessParenthesis(e, pieceOfNumbersOrder);
                            }
                            else if (numbersOrder[e].Contains(")") == true)
                            {
                                i = progressionStart;
                                break;
                            }
                        }                        
                        progressionIndicator = i;
                        while (numbersOrder[progressionIndicator].Contains(")") == false && progressionIndicator < numbersOrder.Count - 1)
                        {
                            progressionIndicator++;                           
                        }
                        if (numbersOrder[progressionIndicator] == ")" )
                        {              
                            numbersOrder.RemoveAt(progressionStart);
                            numbersOrder.RemoveAt(progressionIndicator - calculationProcessSigns(progressionIndicator + 1, progressionIndicator - 2) - 1);                            
                        }
                        else
                        {
                            numbersOrder.RemoveAt(progressionStart);
                            pieceOfNumbersOrder = numbersOrder.GetRange(i, (progressionIndicator - 1) - i);
                        }
                    }                        
                }
            }
            
        }
        private int calculationProcessSigns(int numberBeforeLocation, int numberAfterLocation)
        {
            calculationCounter = 0;
            for (int u = numberBeforeLocation; u < numberAfterLocation; u++)
            {
                if (numbersOrder[u].Contains("*"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1], engFormat);
                    second = Convert.ToDecimal(numbersOrder[u + 1], engFormat);
                    resultLocal = first * second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                    calculationCounter += 2;
                    numberAfterLocation -= 2;
                }
                else if (numbersOrder[u].Contains("/"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1], engFormat);
                    second = Convert.ToDecimal(numbersOrder[u + 1], engFormat);
                    resultLocal = first / second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                    calculationCounter += 2;
                    numberAfterLocation -= 2;
                }
            }
            for (int u = numberBeforeLocation; u < numberAfterLocation; u++) 
            {
                if (numbersOrder[u].Contains("-"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1], engFormat);
                    second = Convert.ToDecimal(numbersOrder[u + 1], engFormat);
                    resultLocal = first - second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                    calculationCounter += 2;
                    numberAfterLocation -= 2;
                }
                else if (numbersOrder[u].Contains("+"))
                {
                    dodgingExceptions(u);
                    first = Convert.ToDecimal(numbersOrder[u - 1], engFormat);
                    second = Convert.ToDecimal(numbersOrder[u + 1], engFormat);
                    resultLocal = first + second;
                    numbersOrder.RemoveRange(u - 1, 2);
                    numbersOrder[u - 1] = resultLocal.ToString();
                    calculationCounter += 2;
                    numberAfterLocation -= 2;
                }
            }
                
            
            return calculationCounter;            
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
