using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private double Calc(String op, String val1, String val2)
        {
            double res = 0;
            switch (op)
            {
                case "+":
                    res = Convert.ToDouble(val1) + Convert.ToDouble(val2);
                    break;
                case "*":
                    res = Convert.ToDouble(val1) * Convert.ToDouble(val2);
                    break;
                case "/":
                    res = Convert.ToDouble(val1) / Convert.ToDouble(val2);
                    break;
                case "-":
                    res = Convert.ToDouble(val1) - Convert.ToDouble(val2);
                    break;

            }


            return res;

        }

        protected void Number_Pressed(object sender, EventArgs e)
        {
            // Add it to the display.
            string number = (sender as Button).Text;
            String temp;
         
              if (! number.CharactersAreValid())
            {
                return;
            }
            if (number == "C") { 
                temp = Display.Text = "" ;
                return;
            }
            else
                temp = Display.Text == "0" ? number : Display.Text + number;

            int noofchar;

            double res = 0;
            if (temp.Length > 1)
            {
                String mysign = "";
                String mysign1 = "";
                String[] nos_in_arrray = temp.GetNumbersArray();
                noofchar = nos_in_arrray.Length;
                if (noofchar > 2)
                {
                    for (int x = 0; x < temp.Length; x++)
                    {
                        if (mysign == "")
                        {
                            if (temp[x].ToString().ThisIsValidSymbol())
                            {
                                mysign = temp[x].ToString();
                            }
                        }
                        if (temp[x].ToString().ThisIsValidSymbol())
                        {
                            mysign1 = temp[x].ToString();
                        }

                    }
                    if (mysign1 == "=")
                    {
                        double valout = 0;
                        if (Double.TryParse(nos_in_arrray[0], out valout) && Double.TryParse(nos_in_arrray[1], out valout))
                        {
                            res = Calc(mysign, nos_in_arrray[0], nos_in_arrray[1]);
                            temp = res.ToString();
                        }
                        else
                        {
                            Display.Text = Display.Text.Substring(0, Display.Text.Length );
                            return;
                        }


                    }
                    else
                    {
                        res = Calc(mysign, nos_in_arrray[0], nos_in_arrray[1]);
                        mysign = "";
                        temp = res.ToString() + mysign1;
                    }

                }

            }
            Display.Text = temp;
        }


    }
}
