using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCalvo
{
    public partial class Form1 : Form
    {
        enum Operacoes
        {
            soma,
            sub,
            div, 
            mult,
            nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.nenhuma;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonlim_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.nenhuma;
            
        }

        private void buttonapa_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                 textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttoncop_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonvir_Click(object sender, EventArgs e)
        {

        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.nenhuma)
            {
                ultimaOperacao = Operacoes.div;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;

        }

        private void buttonvezes_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.nenhuma)
            {
                ultimaOperacao = Operacoes.mult;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.nenhuma)
            {
                ultimaOperacao = Operacoes.sub;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;

        }

        private void buttonmais_Click(object sender, EventArgs e)
        {
           if (ultimaOperacao == Operacoes.nenhuma)
            {
                ultimaOperacao = Operacoes.soma;
            }
           else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;


        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            List<double> listadenum = new List<double>();
            switch (ultimaOperacao) 
            { 
            case Operacoes.nenhuma:
                    break;
            case Operacoes.soma:  
                    listadenum = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenum[0] + listadenum[1]).ToString() ;
                    break;
            case Operacoes.sub:
                    listadenum = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenum[0] - listadenum[1]).ToString();
                    break;
            case Operacoes.div:
                    listadenum = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenum[0] / listadenum[1]).ToString();
                    break;
            case Operacoes.mult:
                    listadenum = textBoxDisplay.Text.Split('X').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenum[0] * listadenum[1]).ToString();
                    break;
            default:
                    break;
            } 
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
           if (ultimaOperacao != Operacoes.nenhuma)
           {
            FazerCalculo(ultimaOperacao);
           }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.nenhuma)
            {
                textBoxDisplay.Clear();
            }
            textBoxDisplay.Text += (sender as Button).Text ;
        }

        private void buttonpor_Click(object sender, EventArgs e)
        {

        }
    }
}
