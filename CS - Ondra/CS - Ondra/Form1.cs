using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS___Ondra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(program);
        }

        public void program(object sender, EventArgs e)
        {
            try
            {
                int vstup = int.Parse(textBox1.Text);
                label1.Text = "";
                if (vstup > 0)
                {
                    if (vstup > 9)
                    {
                        int cifSouc = 0;
                        int pVstup = vstup;
                        while (pVstup > 1)
                        {
                            int cifra = pVstup % 10;
                            cifSouc += cifra;
                            pVstup /= 10;
                        }
                        MessageBox.Show("Ciferný součin je " + cifSouc);
                    }
                    else
                        MessageBox.Show("Ciferný součin je " + vstup);
                }
                else
                {
                    label1.Text = "Číslo není kladné!!";
                    label1.ForeColor = Color.Red;
                }
            }
            catch
            {
                label1.Text = "Neplatný formát";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
