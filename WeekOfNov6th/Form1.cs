using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        bool tempenture = false;
        int meter1 = 0;
        int meter2 = 0;
        float holdA = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            string input1 = TXT1.Text;
            string input2 = TXT2.Text;
            if (tempenture == false)
            {
                RTB1.Text += ((float.Parse(input1) * 9 / 5) + 32).ToString() + Environment.NewLine;
                if (TXT1.Text == "")
                {
                    RTB1.Text += ((float.Parse(input2) * 9 / 5) + 32).ToString() + Environment.NewLine;
                }
                else if (input1 == "" && input2 == "")
                {
                    RTB1.Text = "There's nothing in the output";
                }
            }
            else if (tempenture == true)
            {
                RTB1.Text += ((float.Parse(input1) - 32) * 5/9).ToString() + Environment.NewLine;
                if (TXT1.Text == "")
                {
                    RTB1.Text += ((float.Parse(input2) - 32) * 5 / 9).ToString() + Environment.NewLine;
                }
                else if (input1 == "" && input2 == "")
                {
                    RTB1.Text = "There's nothing in the output";
                }

            }
        }

        private void FTC_CheckedChanged(object sender, EventArgs e)
        {
            tempenture = true;
        }

        private void CTF_CheckedChanged(object sender, EventArgs e)
        {
            tempenture = false;
        }
        private void MTK_CheckedChanged(object sender, EventArgs e)
        {
            if (meter1 == 2)
            {
                meter1 = 1;
                holdA = 2;
            }
            else
            {
                meter1 = 1;
            }
        }
        private void KTM_CheckedChanged(object sender, EventArgs e)
        {
            if (meter1 == 1)
            {
                holdA = 2;
                meter1 = 2;
            }
            else
            {
                meter1 = 2;
            }
        }
        private void BTN3_Click(object sender, EventArgs e)
        {
            string input = TXT1.Text;
            if (meter1 == 1 )
            {
                RTB1.Text += (float.Parse(TXT1.Text) * 1000).ToString() + Environment.NewLine;
            }
            else if (meter1 == 1 && holdA == 2)
            {
                RTB1.Text += (float.Parse(TXT1.Text) * 1000).ToString() + Environment.NewLine + (float.Parse(TXT1.Text) / 1000).ToString();
            }
            else if (meter1 == 2)
            {
                RTB1.Text += (float.Parse(TXT1.Text) /1000).ToString() + Environment.NewLine;
            }
            else if (meter1 == 2 && holdA == 1)
            {
                RTB1.Text += (float.Parse(TXT1.Text) / 1000).ToString() + Environment.NewLine + (float.Parse(TXT1.Text) * 1000).ToString();
            }
        }
        private void MTI_CheckedChanged(object sender, EventArgs e)
        {
            meter2 = 1;
        }

        private void ITM_CheckedChanged(object sender, EventArgs e)
        {
            meter2 = 2;
        }
        private void BTN4_Click(object sender, EventArgs e)
        {
            string input = TXT1.Text;
            if (meter2 == 1)
            {
                RTB1.Text += (float.Parse(TXT1.Text) * 39.37).ToString() + Environment.NewLine;
            }
            else if (meter2 == 2)
            {
                RTB1.Text += (float.Parse(TXT1.Text) / 39.37).ToString() + Environment.NewLine;
            }
        }
        private void BTN5_click(object sender, EventArgs e)
        {
            String[] alphabetStrArray = new string[1];
            alphabetStrArray[0] = "a b c d e f g h i j k l m n o p q r s t u v w x y z";

            String words = alphabetStrArray[1];
            for (int i= alphabetStrArray.Length-1; i>= 0; i--)
            {
                words.Split(' ');
                if (i % 5 == 0)
                {
                    RTB1.Text += " ,";
                }
            }
        }

       
        private void BTN6_Click(object sender, EventArgs e)
        {
            string FileName = "WeekOfNov6th\\bin\\Debug\\test.txt";

            try
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        RTB1.Text += line;
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
        private void BTN2_Click(object sender, EventArgs e)
        {
            if (MC1.Text == "Yen to Dollar")
            {
                RTB1.Text += ((float.Parse(TXT1.Text) / 1) * 0.0067 / 1).ToString() + Environment.NewLine;
            }
            else if (MC1.Text == "Dollar to Yen")
            {
                RTB1.Text += ((float.Parse(TXT1.Text) / 1) * 149.54 / 1).ToString() + Environment.NewLine;
            }
            else if (MC1.Text == "Pound to Dollar")
            {
                RTB1.Text += ((float.Parse(TXT1.Text) / 1) * 1.25 / 1).ToString() + Environment.NewLine;
            }
            else
            {
                RTB1.Text += ((float.Parse(TXT1.Text) / 1) * .80 / 1).ToString() + Environment.NewLine;
            }
        }

    }
}
