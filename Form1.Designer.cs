
namespace ProyectoInv1
{
    partial class CalculadoraPRN115_Grupo6
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(20, 361);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 49);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.White;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.Black;
            this.btnPunto.Location = new System.Drawing.Point(163, 361);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(67, 49);
            this.btnPunto.TabIndex = 1;
            this.btnPunto.Tag = ".";
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.White;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.Black;
            this.btnMas.Location = new System.Drawing.Point(324, 206);
            this.btnMas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(75, 66);
            this.btnMas.TabIndex = 2;
            this.btnMas.Tag = "+";
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.White;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Black;
            this.btnIgual.Location = new System.Drawing.Point(324, 273);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 137);
            this.btnIgual.TabIndex = 3;
            this.btnIgual.Tag = "=";
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.Black;
            this.btnMenos.Location = new System.Drawing.Point(324, 135);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 64);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Tag = "-";
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.White;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicacion.Location = new System.Drawing.Point(244, 206);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 63);
            this.btnMultiplicacion.TabIndex = 5;
            this.btnMultiplicacion.Tag = "x";
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.White;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Black;
            this.btnDividir.Location = new System.Drawing.Point(244, 135);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 63);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(20, 292);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 58);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(93, 292);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 58);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(163, 292);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 58);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(20, 229);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 58);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(93, 228);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 58);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(163, 229);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 58);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(20, 161);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 62);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(93, 160);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(61, 62);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(163, 160);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 62);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.White;
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.ForeColor = System.Drawing.Color.Black;
            this.btnCuadrado.Location = new System.Drawing.Point(244, 273);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(75, 62);
            this.btnCuadrado.TabIndex = 17;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "X²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.BackColor = System.Drawing.Color.White;
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.ForeColor = System.Drawing.Color.Black;
            this.btnRaizCuadrada.Location = new System.Drawing.Point(244, 347);
            this.btnRaizCuadrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(75, 63);
            this.btnRaizCuadrada.TabIndex = 18;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = false;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Grupo 6";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(163, 101);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(67, 49);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "E";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.White;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarTodo.Location = new System.Drawing.Point(20, 101);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(136, 49);
            this.btnBorrarTodo.TabIndex = 21;
            this.btnBorrarTodo.Text = "CE";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(20, 15);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(368, 50);
            this.txtResultado.TabIndex = 23;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculadoraPRN115_Grupo6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(411, 454);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CalculadoraPRN115_Grupo6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calculadora Grupo 6";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

