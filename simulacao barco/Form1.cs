using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace simulacao_barco
{
    public partial class Form1 : Form
    {
        private Simulacao sim;
        private Graficos graf;
        private Animacao anim;
        private Arquivos arq;

        public Form1()
        {
            InitializeComponent();
            arq = new Arquivos();
        }


        // botão "ver gráficos"
        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurarExibicao(true, false, false, false, false, false, false);
            
            EntradaSaidaDados();
            arq.ArmazenarDados(numericUpDown4);
            graf.PlotarGraficos(chart1);

            timer1.Stop();
        }

        // botão "ver animação"
        private void button2_Click(object sender, EventArgs e)
        {
            ConfigurarExibicao(false, true, false, false, false, false, false);

            EntradaSaidaDados();
            graf.PlotarAnimacao(chart2);
            anim.ConfigurarTimer(timer1.Interval);

            timer1.Start();
        }

        // botão "ver histórico"
        private void button3_Click_1(object sender, EventArgs e)
        {
            ConfigurarExibicao(false, false, true, true, true, true, false);
            
            dateTimePicker1.Value = DateTime.Now;
            timer1.Stop();
            listBox1.Items.Clear();
        }

        // botão "selecionar"
        private void button4_Click(object sender, EventArgs e)
        {
            ConfigurarExibicao(false, false, false, false, false, false, false);

            arq.LerDados();
            arq.ValorLargura(numericUpDown1);
            arq.ValorvBarco(numericUpDown2);
            arq.ValorvCorrenteza(numericUpDown3);
            arq.ValorAngulo(numericUpDown4);
        }

        // botão "exibir todos"
        private void button5_Click(object sender, EventArgs e)
        {
            arq.ExibirDados(listBox1);
        }

        // botão "buscar"
        private void button6_Click(object sender, EventArgs e)
        {
            arq.FiltrarValor(listBox1, numericUpDown5);
        }

        // intervalo do timer
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            anim.RodarAnimacao(chart2, timer1);
        }

        // lista de arquivos
        private void listBox1_DoubleClick(object sender, EventArgs e)
        { 
            if (listBox1.SelectedItem.ToString() != null)
            {
                string arquivo = listBox1.SelectedItem.ToString();
                arq = new Arquivos(arquivo);
                arq.SelecionarArquivo(listBox1, textBox1, button4);
            }
        }

        // calendário
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataFiltro = dateTimePicker1.Value.Date;
            arq = new Arquivos(dataFiltro);
            arq.FiltrarData(listBox1);
        }

        // caixa de opções de filtragem
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlternarFiltro();
        }

        // caixa de seleção de valores
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                object valorFiltro = comboBox2.SelectedItem;
                arq = new Arquivos(valorFiltro);
                arq.AlternarFiltroValor(numericUpDown5, button6);
            }
        }

        public void EntradaSaidaDados()
        {
            double larguraRio = (double)numericUpDown1.Value;
            double vBarco = (double)numericUpDown2.Value;
            double vCorrenteza = (double)numericUpDown3.Value;
            double angulo = (double)numericUpDown4.Value * (Math.PI / 180);
            sim = new Simulacao(larguraRio, vBarco, vCorrenteza, angulo);
            graf = new Graficos(sim);
            anim = new Animacao(sim);
            arq = new Arquivos(sim);
            sim.TempoTravessiaLabel(label6);
            sim.AnguloPerpendicularLabel(label7);
            sim.TempoMinimoLabel(label8);
        }

        public void AlternarFiltro()
        {
            string filtro = comboBox1.SelectedItem.ToString();
            if (filtro == "data")
            {
                dateTimePicker1.Visible = true;
                comboBox2.Visible = false;
                numericUpDown5.Visible = false;
                button6.Visible = false;
            }
            else if (filtro == "valor")
            {
                dateTimePicker1.Visible = false;
                comboBox2.Visible = true;
            }
        }

        public void ConfigurarExibicao(bool ch1, bool ch2, bool lx1, bool lb9, bool bt5, bool cb1, bool outros)
        {
            chart1.Visible = ch1;
            chart2.Visible = ch2;
            listBox1.Visible = lx1;
            textBox1.Visible = outros;
            button4.Visible = outros;
            button5.Visible = bt5;
            button6.Visible = outros;
            label6.Visible = outros;
            label7.Visible = outros;
            label8.Visible = outros;
            label9.Visible = lb9;
            comboBox1.Visible = cb1;
            comboBox2.Visible = outros;
            numericUpDown5.Visible = outros;
            dateTimePicker1.Visible = outros;
        }







        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
