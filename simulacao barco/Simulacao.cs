using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacao_barco
{
    internal class Simulacao
    {

        public double larguraRio { get; set; }
        public double vBarco { get; set; }
        public double vCorrenteza { get; set; }
        public double angulo { get; set; }
        public double vyBarco { get; private set; }
        public double vxBarco { get; private set; }

        public Simulacao(double larguraRio, double vBarco, double vCorrenteza, double angulo)
        {
            this.larguraRio = larguraRio;
            this.vBarco = vBarco;
            this.vCorrenteza = vCorrenteza;
            this.angulo = angulo;

            Velocidades();
        }

        public void Velocidades()
        {
            vyBarco = vBarco * Math.Sin(angulo); // velocidade vertical y do barco
            vxBarco = vBarco * Math.Cos(angulo) + vCorrenteza; // velocidade horizontal x do barco
        }

        public double TempoTravessia()
        {
            return larguraRio / vyBarco;
        }

        public void TempoTravessiaLabel(System.Windows.Forms.Label label)
        {
            label.Text = $"-> Tempo de travessia: {TempoTravessia():F1} segundos";
            label.Visible = true;
        }

        public double TempoMinimo()
        {
            return larguraRio / vBarco * Math.Sin(Math.PI / 2);
        }

        public void TempoMinimoLabel(System.Windows.Forms.Label label)
        {
            label.Text = $"-> Tempo mínimo de travessia: {TempoMinimo():F1} segundos";
            label.Visible = true;
        }

        public double AnguloPerpendicular()
        {
            return (Math.Acos((-vCorrenteza) / vBarco)) * (180 / Math.PI);
        }

        public void AnguloPerpendicularLabel(System.Windows.Forms.Label label)
        {
            if (vBarco >= vCorrenteza)
            {
                label.Text = $"-> Ângulo para trajetória perpendicular\nàs margens: {AnguloPerpendicular():F2}°";
            }
            else
            {
                label.Text = "->Trajetória perpendicular às margens impossível.\n" +
                    "Velocidade do barco inferior à da correnteza";
            }
            label.Visible = true;
        }
    }
}
