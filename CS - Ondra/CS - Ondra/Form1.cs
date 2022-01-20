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
            timer1.Stop();
            timer1.Start();
            timer2.Stop();
            timer2.Start();
            label1.ForeColor = Color.Black;
            label1.Text = "Výpočet se provede za 2s";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Výpočet se provede za 0s";
            timer3.Stop();
            timer3.Start();
            timer1.Stop();
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
                if(vstup != 0)
                {
                    listBox1.Items.Clear();
                    for(int i = 1;i<=Math.Abs(vstup);i++)
                    {
                        if(vstup%i==0)
                        {
                            listBox1.Items.Add(i + " je dělitel čísla " + vstup);
                        }
                    }
                }
                else
                {
                    label1.Text = "Číslo Je nula!!";
                    label1.ForeColor = Color.Red;
                }
            }
            catch
            {
                label1.Text = "Neplatný formát";
                label1.ForeColor = Color.Red;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label1.Text = "Výpočet se provede za 1s";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label1.Text = "";
        }
    }
}
