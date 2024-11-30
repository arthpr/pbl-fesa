using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace simulacao_barco
{
    internal class Arquivos
    {
        private Simulacao sim;

        public string pastaDados { get; private set; } = Path.Combine("C:\\", "Histórico_Simulação");
        public string arquivo { get; set; }

        public DateTime dataFiltro { get; set; }

        public string valorFiltro { get; set; }

        public List<decimal> dadosArquivo { get; set; }

        public Arquivos()
        {
            CriarPasta();
        }
        
        public Arquivos(Simulacao sim)
        {
            this.sim = sim;
        }

        public Arquivos(string arquivo)
        {
            this.arquivo = arquivo;
        }

        public Arquivos(DateTime dataFiltro)
        {
            this.dataFiltro = dataFiltro;
        }

        public Arquivos(object valorFiltro)
        {
            this.valorFiltro = valorFiltro.ToString();
        }

        private void CriarPasta()
        {
            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }
        }
        
        // cria um arquivo e salva os dados dos numericUpDown
        public void ArmazenarDados(NumericUpDown numeric)
        {
            try
            {
                string novoArquivo = $"Dados_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string caminho = Path.Combine(pastaDados, novoArquivo);

                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine("Data e Hora: " + DateTime.Now.ToString("G"));
                    sw.WriteLine();
                    sw.WriteLine("Largura L do rio: " + sim.larguraRio);
                    sw.WriteLine("Velocidade do barco (m/s): " + sim.vBarco);
                    sw.WriteLine("Velocidade da correnteza (m/s): " + sim.vCorrenteza);
                    sw.WriteLine("Ângulo de inclinação θ: " + numeric.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados no arquivo: " + ex.Message);
            }
        }

        // exibe todos os arquivos no listbox
        public void ExibirDados(ListBox listBox)
        {
            try
            {
                listBox.Items.Clear();
                if (!Directory.Exists(pastaDados))
                {
                    MessageBox.Show("Erro: pasta não encontrada");
                }
                string[] arquivos = Directory.GetFiles(pastaDados);
                foreach (string a in arquivos)
                {
                    listBox.Items.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: arquivo não encontrado" + ex.Message);
            }
        }

        // lê os dados do arquivo escolhido e adiciona-os a uma lista
        public void LerDados()
        {
            try
            {
                if (File.Exists(arquivo))
                {
                    dadosArquivo = new List<decimal>();
                    string[] linhas = File.ReadAllLines(arquivo);

                    for (int i = 2; i < linhas.Length; i++)
                    {
                        string[] partes = linhas[i].Split(' ');
                        for (int j = 0; j < partes.Length; j++)
                        {
                            if (decimal.TryParse(partes[j], out decimal valor))
                            {
                                dadosArquivo.Add(valor);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Erro: arquivo não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler os dados do arquivo: " + ex.Message);
            }
        }

        // adiciona os dados da lista aos numericUpDown
        
        public void ValorLargura(NumericUpDown numeric)
        {
            numeric.Value = dadosArquivo[0];
        }

        public void ValorvBarco(NumericUpDown numeric)
        {
            numeric.Value = dadosArquivo[1];
        }

        public void ValorvCorrenteza(NumericUpDown numeric)
        {
            numeric.Value = dadosArquivo[2];
        }

        public void ValorAngulo(NumericUpDown numeric)
        {
            numeric.Value = dadosArquivo[3];
        }

        // exibe somente os arquivos salvos em uma data escolhida pelo usuário
        public void FiltrarData(ListBox listBox)
        {
            try
            {
                listBox.Items.Clear();
                List<string> arquivosFiltrados = new List<string>();
                string[] arquivos = Directory.GetFiles(pastaDados);

                foreach (string a in arquivos)
                {
                    DateTime dataArquivo = File.GetLastWriteTime(a).Date;
                    if (dataArquivo == dataFiltro)
                    {
                        arquivosFiltrados.Add(a);
                    }
                }
                if (arquivosFiltrados.Count > 0)
                {
                    foreach (string af in arquivosFiltrados)
                    {
                        listBox.Items.Add(af);
                    }
                }
                else
                {
                    listBox.Items.Add("Nenhum arquivo correspondente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar os arquivos: " + ex.Message);
            }
        }

        // exibe somente os arquivos que possuem um valor escolhido pelo usuário
        public void FiltrarValor(ListBox listBox, NumericUpDown numeric)
        {
            listBox.Items.Clear();
            string[] arquivos = Directory.GetFiles(pastaDados);
            List<string> valoresFiltrados = new List<string>();

            foreach (string a in arquivos)
            {
                string[] linhas = File.ReadAllLines(a);
                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].Contains(valorFiltro))
                    {
                        string[] partes = linhas[i].Split(' ');
                        for (int j = 0; j < partes.Length; j++)
                        {
                            if (decimal.TryParse(partes[j], out decimal numero))
                            {
                                if (numero == numeric.Value)
                                {
                                    valoresFiltrados.Add(a);
                                }
                            }
                        }
                    }
                }
            }
            if (valoresFiltrados.Count > 0)
            {
                foreach (string vf in valoresFiltrados)
                {
                    listBox.Items.Add(vf);
                }
            }
            else
            {
                listBox.Items.Add("Nenhum arquivo correspondente");
            }
        }

        // abre no textbox o arquivo selecionado
        public void SelecionarArquivo(ListBox listBox, System.Windows.Forms.TextBox textBox, System.Windows.Forms.Button button)
        {
            if (File.Exists(arquivo))
            {
                textBox.Visible = true;
                button.Visible = true;
                textBox.Clear();
                textBox.Text = File.ReadAllText(arquivo);
            }
        }

        // alterna os valores 
        public void AlternarFiltroValor(NumericUpDown numeric, System.Windows.Forms.Button button)
        {
            numeric.Visible = true;
            button.Visible = true;
            if (valorFiltro == "Largura L do rio")
            {
                numeric.Minimum = 20;
                numeric.Maximum = 100;
            }
            else if (valorFiltro == "Velocidade do barco")
            {
                numeric.Minimum = 2;
                numeric.Maximum = 10;
            }
            else if (valorFiltro == "Velocidade da correnteza")
            {
                numeric.Minimum = 1;
                numeric.Maximum = 4;
            }
            else if (valorFiltro == "Ângulo de inclinação θ")
            {
                numeric.Minimum = 21;
                numeric.Maximum = 159;
            }
            else
            {
                MessageBox.Show("Valor inválido");
            }
        }
    }
}
