using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace simulacao_barco
{
    internal class Graficos
    {
        private Simulacao sim;

        public Graficos(Simulacao sim)
        {
            this.sim = sim;
        }

        public void PlotarGraficos(Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            // eixo x - tempo
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = sim.TempoTravessia();
            chart.ChartAreas[0].AxisX.Interval = sim.TempoTravessia() / 10;

            // grafico 1: eixo y - distância horizontal
            if (sim.vxBarco >= 0)
            {
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Maximum = sim.vxBarco * sim.TempoTravessia();
            }
            else
            {
                chart.ChartAreas[0].AxisY.Minimum = sim.vxBarco * sim.TempoTravessia();
                chart.ChartAreas[0].AxisY.Maximum = 0;
            }
            chart.ChartAreas[0].AxisY.Interval = sim.vxBarco * sim.TempoTravessia() / 10;

            chart.ChartAreas[1].AxisX.Minimum = 0;
            chart.ChartAreas[1].AxisX.Maximum = sim.TempoTravessia();
            chart.ChartAreas[1].AxisX.Interval = sim.TempoTravessia() / 10;

            // gráfico 2: eixo y - distância vertical
            chart.ChartAreas[1].AxisY.Minimum = 0;
            chart.ChartAreas[1].AxisY.Maximum = sim.larguraRio;
            chart.ChartAreas[1].AxisY.Interval = sim.larguraRio / 10;

            // marca os pontos nos gráficos
            for (int i = 0; i <= 10; i++)
            {
                double pontosX = sim.TempoTravessia() / 10 * i;
                double posicaoX = sim.vxBarco * pontosX;
                chart.Series[0].Points.AddXY(pontosX, posicaoX);
                double posicaoY = sim.vyBarco * pontosX;
                chart.Series[1].Points.AddXY(pontosX, posicaoY);
            }
        }

        public void PlotarAnimacao(Chart chart)
        {
            chart.Series[0].Points.Clear();

            double proporcaoX = sim.larguraRio + sim.vxBarco * sim.TempoTravessia();

            // eixo x - distância horizontal
            if (sim.vxBarco >= 0)
            {
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = proporcaoX;
            }
            else
            {
                proporcaoX = -(sim.larguraRio) + sim.vxBarco * sim.TempoTravessia();
                chart.ChartAreas[0].AxisX.Minimum = proporcaoX;
                chart.ChartAreas[0].AxisX.Maximum = 0;
            }
            chart.ChartAreas[0].AxisX.Interval = proporcaoX / 10;

            // eixo y - distância vertical
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = sim.larguraRio;
            chart.ChartAreas[0].AxisY.Interval = sim.larguraRio / 10;
        }
    }
}
