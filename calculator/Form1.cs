using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string number;
        string number2;
        string ras;
        double result;

         
        private void button1_Click(object sender, EventArgs e)
        {
            if(label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {
                
                string one = number2 + 1;
                number2 = one;
                richTextBox1.Text = $"{number2}";
                

            }
            else { 
            string one = number + 1;
            number = one;
            richTextBox1.Text = $"{number}";
        }
    }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string two = number2 + 2;
                number2 = two;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string two = number + 2;
                number = two;
                richTextBox1.Text = $"{number }";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string three = number2 + 3;
                number2 = three;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string three = number + 3;
                number = three;
                richTextBox1.Text = $"{number}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string four = number2 + 4;
                number2 = four;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string four = number + 4;
                number = four;
                richTextBox1.Text = $"{number}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string five = number2 + 5;
                number2 = five;
                richTextBox1.Text = $"{number2}";


            }
            else
            {

                string five = number + 5;
                number = five;
                richTextBox1.Text = $"{number }";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string six = number2 + 6;
                number2 = six;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string six = number + 6;
                number = six;
                richTextBox1.Text = $"{number }";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string seven = number2 + 7;
                number2 = seven;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string seven = number + 7;
                number = seven;
                richTextBox1.Text = $"{number }";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string eight = number2 + 8;
                number2 = eight;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string eight = number + 8;
                number = eight;
                richTextBox1.Text = $"{number }";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string nine = number2 + 9;
                number2 = nine;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string nine = number + 9;
                number = nine;
                richTextBox1.Text = $"{number }";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {

                string noll = number2 + 0;
                number2 = noll;
                richTextBox1.Text = $"{number2}";


            }
            else
            {
                string noll = number + 0;
                number = noll;
                richTextBox1.Text = $"{number }";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {
                if (!label2.Text.Contains("+"))
                {
                    
                        string ras = label2.Text + richTextBox1.Text;
                        if (label2.Text.Contains("-"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("-"))) - Convert.ToDouble(ras.Substring(ras.LastIndexOf("-") + 1));
                        label2.Text = $"{result}+";
                        number = "";
                        number2 = "";
                        richTextBox1.Text = $"{Convert.ToString(result)}";
                    }
                        if (label2.Text.Contains("*")) 
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("*"))) * Convert.ToDouble(ras.Substring(ras.LastIndexOf("*") + 1));
                        label2.Text = $"{result}+";
                        number = "";
                        number2 = "";
                        richTextBox1.Text = $"{Convert.ToString(result)}";
                    }
                        if(label2.Text.Contains("/"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("/"))) / Convert.ToDouble(ras.Substring(ras.LastIndexOf("/") + 1));
                        label2.Text = $"{result}+";
                        number = "";
                        number2 = "";
                        richTextBox1.Text = $"{Convert.ToString(result)}";
                    }
                        
                        
                    


                }
                else {
                    string ras = label2.Text + richTextBox1.Text;
                    double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("+"))) + Convert.ToDouble(ras.Substring(ras.IndexOf("+") + 1));
                    
                }
                
            }
            else
            {
                if (number == "") 
                {
                    number = richTextBox1.Text;
                }
                string plus = number + "+";
                label2.Text = $"{plus}";
                richTextBox1.Text = $"{number}";
            }

        }    // plus

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                   label2.Text.Contains("*"))
            {

                string comma = number2 + ",";
                number2 = comma;
                richTextBox1.Text = $"{number2}";
                if (number2.Contains(",,"))
                {
                    number2 = number2.Replace(",,", ",");
                    richTextBox1.Text = $"{number2}";

                }
                if (number2.IndexOf(",") != (number2.LastIndexOf(",")))
                {
                    number2 = number2.Remove(number2.LastIndexOf(','), 1);
                    richTextBox1.Text = $"{number2}";
                }


            }
            else
            {

                string comma = number + ",";
                number = comma;
                richTextBox1.Text = $"{number}";
                if (number.Contains(",,"))
                {
                    number = number.Replace(",,", ",");
                    richTextBox1.Text = $"{number}";

                }
                if (number.IndexOf(",") != (number.LastIndexOf(",")))
                {
                    number = number.Remove(number.LastIndexOf(','), 1);
                    richTextBox1.Text = $"{number}";
                }
            }

        }       // comma

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)      // -
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {
                if (!label2.Text.Contains("-"))
                {
                    try
                    {
                        string ras = label2.Text + richTextBox1.Text;
                        if (label2.Text.Contains("+"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("+"))) + Convert.ToDouble(ras.Substring(ras.LastIndexOf("+") + 1));
                            label2.Text = $"{result}-";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("*"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("*"))) * Convert.ToDouble(ras.Substring(ras.LastIndexOf("*") + 1));
                            label2.Text = $"{result}-";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("/"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("/"))) / Convert.ToDouble(ras.Substring(ras.LastIndexOf("/") + 1));
                            label2.Text = $"{result}-";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }

                        
                    }
                    finally { }
                }
                else
                {
                    string ras = label2.Text + richTextBox1.Text;
                    double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("-"))) - Convert.ToDouble(ras.Substring(ras.IndexOf("-") + 1));
                    label2.Text = $"{result}-";
                    number = "";
                    number2 = "";
                    richTextBox1.Text = $"{Convert.ToString(result)}";
                }

            }
            else
            {
                if (number == "")
                {
                    number = richTextBox1.Text;
                }
                string minus = number + "-";
                label2.Text = $"{minus}";
                richTextBox1.Text = $"{number}";
            }
        }

        private void button12_Click(object sender, EventArgs e)      // *
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {
                if (!label2.Text.Contains("*"))
                {
                    try
                    {
                        string ras = label2.Text + richTextBox1.Text;
                        if (label2.Text.Contains("-"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("-"))) - Convert.ToDouble(ras.Substring(ras.LastIndexOf("-") + 1));
                            label2.Text = $"{result}*";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("+"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("+"))) + Convert.ToDouble(ras.Substring(ras.LastIndexOf("+") + 1));
                            label2.Text = $"{result}*";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("/"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("/"))) / Convert.ToDouble(ras.Substring(ras.LastIndexOf("/") + 1));
                            label2.Text = $"{result}*";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }

                        
                    }
                    finally { }
                }
                else
                {
                    string ras = label2.Text + richTextBox1.Text;
                    double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("*"))) * Convert.ToDouble(ras.Substring(ras.IndexOf("*") + 1));
                    label2.Text = $"{result}*";
                    number = "";
                    number2 = "";
                    richTextBox1.Text = $"{Convert.ToString(result)}";
                }

            }
            else
            {
                if (number == "")
                {
                    number = richTextBox1.Text;
                }
                string umn = number + "*";
                label2.Text = $"{umn}";
                richTextBox1.Text = $"{number}";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("/") ||
                label2.Text.Contains("*"))
            {
                if (!label2.Text.Contains("/"))
                {
                    try
                    {
                        string ras = label2.Text + richTextBox1.Text;
                        if (label2.Text.Contains("-"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("-"))) - Convert.ToDouble(ras.Substring(ras.LastIndexOf("-") + 1));
                            label2.Text = $"{result}/";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("*"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("*"))) * Convert.ToDouble(ras.Substring(ras.LastIndexOf("*") + 1));
                            label2.Text = $"{result}/";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }
                        if (label2.Text.Contains("+"))
                        {
                            double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("+"))) + Convert.ToDouble(ras.Substring(ras.LastIndexOf("+") + 1));
                            label2.Text = $"{result}/";
                            number = "";
                            number2 = "";
                            richTextBox1.Text = $"{Convert.ToString(result)}";
                        }

                        
                    }
                    finally { }
                }
                else
                {
                    string ras = label2.Text + richTextBox1.Text;
                    double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("/"))) / Convert.ToDouble(ras.Substring(ras.IndexOf("/") + 1));
                    label2.Text = $"{result}/";
                    number = "";
                    number2 = "";
                    richTextBox1.Text = $"{Convert.ToString(result)}";
                }

            }
            else
            {
                if (number == "")
                {
                    number = richTextBox1.Text;
                }
                string del = number + "/";
                label2.Text = $"{del}";
                richTextBox1.Text = $"{number}";
            }
        } //   /

        private void button17_Click(object sender, EventArgs e)
        {
            number = "";
            number2 = "";
            richTextBox1.Text = "";
            label2.Text = "";
        }  //clear

        private void button15_Click(object sender, EventArgs e)
        {
            string ras = label2.Text + richTextBox1.Text;
            if (label2.Text.Contains("+"))
                
            {
                double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("+"))) 
                    + Convert.ToDouble(ras.Substring(ras.IndexOf("+") + 1));
                label2.Text = "";
                number = "";
                number2 = "";
                richTextBox1.Text = $"{Convert.ToString(result)}";
            } 
            if (label2.Text.Contains("/")) 
            {
                double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("/")))
                    / Convert.ToDouble(ras.Substring(ras.IndexOf("/") + 1));
                label2.Text = "";
                number = "";
                number2 = "";
                richTextBox1.Text = $"{Convert.ToString(result)}";
            }
            if (label2.Text.Contains("-"))
            {
                
                double result = Convert.ToDouble(ras.Substring(0, ras.LastIndexOf("-")))
                    - Convert.ToDouble(ras.Substring(ras.LastIndexOf("-") + 1));
                label2.Text = "";
                number = "";
                number2 = "";
                richTextBox1.Text = $"{Convert.ToString(result)}";
            }
            if (label2.Text.Contains("*"))
            {
                double result = Convert.ToDouble(ras.Substring(0, ras.IndexOf("*")))
                    * Convert.ToDouble(ras.Substring(ras.IndexOf("*") + 1));
                label2.Text = "";
                number = "";
                number2 = "";
                richTextBox1.Text = $"{Convert.ToString(result)}";
            }
        }  //ravno

      /*  private void button18_Click(object sender, EventArgs e) // ←
        {
            if (number.Length >0) 
            {
                string temp = number.Substring(0, number.Length - 1);
                number = temp;
                
            }
            else 
            { 
                number = "0"; 
            }
            if (number2.Length > 0) 
            {
                string temp = number2.Substring(0, number2.Length - 1);
                number2 = temp;
            }
            else 
            {
                number2 = "0";
            }
        } */
    }
}
