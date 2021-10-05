using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafíoHerencia_francisco_linan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbuttonPiso_Click(object sender, EventArgs e)
        {
            inputNroVentanas.Enabled = false;
            inputNroPiso.Enabled = true;
        }

        private void rbuttonLocal_Click(object sender, EventArgs e)
        {
            inputNroVentanas.Enabled = true;
            inputNroPiso.Enabled = false;
        }

        private void buttonPrecioFinal_Click(object sender, EventArgs e)
        {
            bool calcular = true;

            if (rbuttonPiso.Checked)
            {
                if (Utiles.ValidarCampo(inputNroPiso.Text, "int"))
                {
                    inputNroPiso.BackColor = Color.White;
                }
                else
                {
                    inputNroPiso.BackColor = Color.Red;
                    calcular = false;
                }
            }
            else
            {
                inputNroPiso.BackColor = Color.White;
            }

            if (rbuttonLocal.Checked)
            {
                if (Utiles.ValidarCampo(inputNroVentanas.Text, "int"))
                {
                    inputNroVentanas.BackColor = Color.White;
                }
                else
                {
                    inputNroVentanas.BackColor = Color.Red;
                    calcular = false;
                }
            }
            else
            {
                inputNroVentanas.BackColor = Color.White;
            }

            if (Utiles.ValidarCampo(inputSuperficie.Text, "int"))
            {
                inputSuperficie.BackColor = Color.White;
            }
            else
            {
                inputSuperficie.BackColor = Color.Red;
                calcular = false;
            }

            if (Utiles.ValidarCampo(inputAntiguedad.Text, "int"))
            {
                inputAntiguedad.BackColor = Color.White;
            }
            else
            {
                inputAntiguedad.BackColor = Color.Red;
                calcular = false;
            }

            if (Utiles.ValidarCampo(inputPrecioBase.Text, "int"))
            {
                inputPrecioBase.BackColor = Color.White;
            }
            else
            {
                inputPrecioBase.BackColor = Color.Red;
                calcular = false;
            }

            if (calcular)
            {
                if (rbuttonPiso.Checked)
                {
                    Piso piso = new Piso(Convert.ToInt32(inputNroPiso.Text), Convert.ToInt32(inputSuperficie.Text), Convert.ToInt32(inputAntiguedad.Text), Convert.ToInt32(inputPrecioBase.Text));
                    outputPrecioFinal.Text = Convert.ToString(piso.CalcularPrecio());
                }

                if (rbuttonLocal.Checked)
                {
                    Local piso = new Local(Convert.ToInt32(inputNroVentanas.Text), Convert.ToInt32(inputSuperficie.Text), Convert.ToInt32(inputAntiguedad.Text), Convert.ToInt32(inputPrecioBase.Text));
                    outputPrecioFinal.Text = Convert.ToString(piso.CalcularPrecio());
                }
            }
        }
    }
}
