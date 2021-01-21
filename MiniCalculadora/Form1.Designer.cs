
namespace MiniCalculadora
{
    partial class Form1
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
            this.Pantalla = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonComa = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.AutoSize = true;
            this.Pantalla.BackColor = System.Drawing.Color.Black;
            this.Pantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.ForeColor = System.Drawing.Color.Yellow;
            this.Pantalla.Location = new System.Drawing.Point(114, 100);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(0, 32);
            this.Pantalla.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBox1.Location = new System.Drawing.Point(13, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(383, 68);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.click_button);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(111, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.click_button);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(212, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.click_button);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.click_button);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(111, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.click_button);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(212, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.click_button);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 55);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.click_button);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(111, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 55);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.click_button);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(212, 114);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 55);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.click_button);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(12, 268);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(205, 58);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.click_button);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Navy;
            this.buttonDiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonDiv.ForeColor = System.Drawing.Color.White;
            this.buttonDiv.Location = new System.Drawing.Point(308, 166);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(89, 55);
            this.buttonDiv.TabIndex = 12;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.op_click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.Navy;
            this.buttonMul.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonMul.ForeColor = System.Drawing.Color.White;
            this.buttonMul.Location = new System.Drawing.Point(308, 114);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(89, 55);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.op_click);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.Navy;
            this.buttonRes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonRes.ForeColor = System.Drawing.Color.White;
            this.buttonRes.Location = new System.Drawing.Point(308, 217);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(89, 55);
            this.buttonRes.TabIndex = 14;
            this.buttonRes.Text = "-";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.op_click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.Color.Navy;
            this.buttonSuma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonSuma.ForeColor = System.Drawing.Color.White;
            this.buttonSuma.Location = new System.Drawing.Point(308, 265);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(89, 71);
            this.buttonSuma.TabIndex = 15;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.op_click);
            // 
            // buttonComa
            // 
            this.buttonComa.BackColor = System.Drawing.Color.Navy;
            this.buttonComa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonComa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonComa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonComa.ForeColor = System.Drawing.Color.White;
            this.buttonComa.Location = new System.Drawing.Point(212, 265);
            this.buttonComa.Name = "buttonComa";
            this.buttonComa.Size = new System.Drawing.Size(100, 61);
            this.buttonComa.TabIndex = 16;
            this.buttonComa.Text = ",";
            this.buttonComa.UseVisualStyleBackColor = false;
            this.buttonComa.Click += new System.EventHandler(this.click_button);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonIgual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.ForeColor = System.Drawing.Color.White;
            this.buttonIgual.Location = new System.Drawing.Point(98, 322);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(299, 66);
            this.buttonIgual.TabIndex = 17;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(12, 322);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(89, 66);
            this.buttonC.TabIndex = 18;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // historial
            // 
            this.historial.AutoSize = true;
            this.historial.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.historial.Location = new System.Drawing.Point(10, 18);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(23, 25);
            this.historial.TabIndex = 19;
            this.historial.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(410, 400);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonComa);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pantalla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonComa;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label historial;
    }
}

