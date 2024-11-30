using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace simulacao_barco
{
    internal class Animacao
    {
        private Simulacao sim;

        public Animacao(Simulacao sim)
        {
            this.sim = sim;
        }

        public int atualFrame { get; set; }
        public double fps { get; set; }
        public double totalFrames { get; set; }

        public void ConfigurarTimer(int intervaloTimer)
        {
            atualFrame = 0;
            fps = 1000 / intervaloTimer; // frames por segundo
            totalFrames = fps * sim.TempoTravessia(); // total de frames da animação
        }
       
        public void RodarAnimacao(Chart chart, System.Windows.Forms.Timer timer)
        {
            if (atualFrame <= fps)
            {
                double tempoAtual = ((totalFrames * (atualFrame / fps)) / totalFrames) * sim.TempoTravessia();
                double xBarco = sim.vxBarco * tempoAtual; // progresso horizontal
                double yBarco = sim.vyBarco * tempoAtual; // progresso vertical

                chart.Series[0].Points.Clear();
                chart.Series[0].Points.AddXY(xBarco, yBarco);

                atualFrame++;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Travessia completa!!!");
            }

            chart.Invalidate();
        }
    }
}
