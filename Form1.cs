using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInv1
{
    public partial class CalculadoraPRN115 : Form
    {
        //variables publicas
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public CalculadoraPRN115()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";
                txtResultado.Text += boton.Text;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'x')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                txtResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            //Numero al cuadrado
            if (Operador == '²')
            {
                txtResultado.Text = Math.Pow(Numero1, 2).ToString();
                //Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            ///Sacar raiz cuadrada
            else if (Operador == '√')
            {
                txtResultado.Text = Math.Sqrt(Numero1).ToString();
                //Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else
            {
                txtResultado.Text = "0";
            }
            
        }

        
    }
}
