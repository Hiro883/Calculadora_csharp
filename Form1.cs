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
    public partial class CalculadoraPRN115_Grupo6 : Form
    {
        //variables publicas para almacenar los números y el operador actual
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public CalculadoraPRN115_Grupo6()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se carga la calculadora.
        }
        // Este evento es cuando se presiona un botón numérico.
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            // si el campo de texto muestra ¨0¨ lo reemplazara con el número selecionado
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
                txtResultado.Text += boton.Text;
        }

            // Es la accion de presionar el botón "=" para mostrar el resultado.
        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Convierte el texto del campo de texto a numero
            Numero2 = Convert.ToDouble(txtResultado.Text);

            //Realiza la operación seleccionada y muestra el resultado.
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

        //Es la acción de presionar el botón ¨C¨ para borrar los digitos.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Borra el último dígito del campo de texto o restablece a ¨0¨ si solo queda un dígito
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        // Es la acción de presionar el botón ¨CE¨ para borrar todo el contenido.
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            //Borra todo el contenido del campo de texto
            txtResultado.Clear();
        }
        // Es esta linea se maneja el evento de presionar un botón de operador ( +, -, x, /, ², √) 
        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            //Realiza una operacion especial (Elevar al cuadrado)
            if (Operador == '²')
            {
                txtResultado.Text = Math.Pow(Numero1, 2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            //Realiza una operacion especial (Raíz cuadrada)
            else if (Operador == '√')
            {
                txtResultado.Text = Math.Sqrt(Numero1).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else
            {
                txtResultado.Text = "0";
            }
            
        }

        
    }
}
