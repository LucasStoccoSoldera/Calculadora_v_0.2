using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CALCULADORA2._0
{
   
    public partial class Form1 : Form
    {
        string op, n1, n2;
        Conta ChamadodeClasse = new Conta();
        Int32 contVirgula = 0;
        public void ajusteVirgula()
        {
            if (contVirgula == 0)
            {
                escrevedor(",");
                contVirgula = 1;
            }
        }
        public Form1()
        {
           
            InitializeComponent();
        }

        public void escrevedor(String valor)
        {
                textBox1.Text = textBox1.Text + valor;
            
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            escrevedor("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escrevedor("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escrevedor("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escrevedor("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escrevedor("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            escrevedor("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            escrevedor("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escrevedor("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escrevedor("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            escrevedor("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Conta ChamadodeClasse = new Conta();
            //ChamadodeClasse.fazedordeconta("+", textBox1.Text);
            op = "+";
            n1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Conta ChamadodeClasse = new Conta();
            //ChamadodeClasse.fazedordeconta("-", textBox1.Text);
            op = "-";
            n1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Conta ChamadodeClasse = new Conta();
            //ChamadodeClasse.fazedordeconta("*", textBox1.Text);
            op = "*";
            n1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Conta ChamadodeClasse = new Conta();
            //ChamadodeClasse.fazedordeconta("/", textBox1.Text);
            op = "/";
            n1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Conta ChamadodeClasse = new Conta();
            ChamadodeClasse.n2 = textBox1.Text;

            if (ChamadodeClasse.n2 == "0")
            {
                MessageBox.Show(ChamadodeClasse.fazedordeconta(op, n1), "Presta Atenção!");
            }
            else
            {
                textBox1.Text = ChamadodeClasse.fazedordeconta(op, n1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Saves.txt", textBox1.Text);
            label1.Text = "Ta mec, o conteúdo digitado foi salvo.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {

                if (System.IO.File.Exists(@"Saves.txt") == true) 
                if (System.IO.File.ReadAllText(@"Saves.txt") != "") 
                        textBox1.Text = System.IO.File.ReadAllText(@"Saves.txt");
                label1.Text = "Ta na mão.";
            }
            catch
            {
                MessageBox.Show("Houve um erro inesperado! Não foi possível efetuar a leitura.");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Text = "A sua disposição chefia!";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja fechar essa maravilhosa calculadora?", "Confirmação de Fechamento!", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Saves.txt", "");
            textBox1.Text = "";
            label1.Text = "Deletado com sucesso.";            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ajusteVirgula();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Sobre about = new Sobre();
            about.Show();
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            op = "%";
            n1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            op = "";
            n1 = "";
            n2 = "";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
