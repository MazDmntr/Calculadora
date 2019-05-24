using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        String operador;
        double a = 0;
        bool validar = false;
        bool som = true;

        public void Som()
        {
            if(som == true)
            {
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Som/1.wav");
                Player.Play();
            }
            
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Som();
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            
            txt_valor.Text = "";
            lbl_valor.Text = "";
            a = 0;
            validar = false;
        }

        private void Btn_soma_Click(object sender, EventArgs e)
        {
            Som();
            if (validar == true)
            {
                a = a + Convert.ToDouble(txt_valor.Text);
                lbl_valor.Text = Convert.ToString(a) + " + ";
                txt_valor.Text = "";
                operador = "+";
            }
            else
            {
                lbl_valor.Text = txt_valor.Text + btn_soma.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void Lbl_valor_Click(object sender, EventArgs e)
        {

        }

        private void Btn_subtracao_Click(object sender, EventArgs e)
        {
            Som();
            if (validar == true)
            {
                a = a - Convert.ToDouble(txt_valor.Text);
                lbl_valor.Text = Convert.ToString(a) + " - ";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                lbl_valor.Text = txt_valor.Text + btn_subtracao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            Som();
            if (validar == true)
            {
                a = a / Convert.ToDouble(txt_valor.Text);
                lbl_valor.Text = Convert.ToString(a) + " / ";
                txt_valor.Text = "";
                operador = "/";
            }
            else
            {
                lbl_valor.Text = txt_valor.Text + btn_divisao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void Btn_multiplicacao_Click(object sender, EventArgs e)
        {
            Som();
            if (validar == true)
            {
                a = a * Convert.ToDouble(txt_valor.Text);
                lbl_valor.Text = Convert.ToString(a) + " * ";
                txt_valor.Text = "";
                operador = "*";
            }
            else
            {
                lbl_valor.Text = txt_valor.Text + btn_multiplicacao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void Btn_resultado_Click(object sender, EventArgs e)
        {
            Som();
            if (operador == "+")
            {
                lbl_valor.Text = lbl_valor.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a + Convert.ToDouble(txt_valor.Text));
            }
            else if (operador == "-")
            {
                lbl_valor.Text = lbl_valor.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a - Convert.ToDouble(txt_valor.Text));
            }
            else if (operador == "*")
            {
                lbl_valor.Text = lbl_valor.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a * Convert.ToDouble(txt_valor.Text));
            }
            else if (operador == "/")
            {
                lbl_valor.Text = lbl_valor.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a / Convert.ToDouble(txt_valor.Text));
            }
        }

        private void Btnsom_Click(object sender, EventArgs e)
        {
            if(som == true)
            {
                som = false;
            }
            else
            {
                som = true;
            }
        }
    }
}
