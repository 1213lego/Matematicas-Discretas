namespace ArbolDeExpresiones
{
    partial class GUIArbolDeExpresiones
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPostOrder = new System.Windows.Forms.TextBox();
            this.textBoxInorder = new System.Windows.Forms.TextBox();
            this.buttonRecorrer = new System.Windows.Forms.Button();
            this.textBoxPreOrder = new System.Windows.Forms.TextBox();
            this.buttonEvaluar = new System.Windows.Forms.Button();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.textBoxEvaluar = new System.Windows.Forms.TextBox();
            this.textBoxGeneral = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.mostrarRuta = new System.Windows.Forms.Button();
            this.txtNumeroRuta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "&Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "&Expresión:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPostOrder);
            this.panel1.Controls.Add(this.textBoxInorder);
            this.panel1.Controls.Add(this.buttonRecorrer);
            this.panel1.Controls.Add(this.textBoxPreOrder);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 135);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "&InOrden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "&PostOrden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&PreOrden:";
            // 
            // textBoxPostOrder
            // 
            this.textBoxPostOrder.Location = new System.Drawing.Point(75, 76);
            this.textBoxPostOrder.Name = "textBoxPostOrder";
            this.textBoxPostOrder.ReadOnly = true;
            this.textBoxPostOrder.Size = new System.Drawing.Size(240, 20);
            this.textBoxPostOrder.TabIndex = 20;
            // 
            // textBoxInorder
            // 
            this.textBoxInorder.Location = new System.Drawing.Point(75, 44);
            this.textBoxInorder.Name = "textBoxInorder";
            this.textBoxInorder.ReadOnly = true;
            this.textBoxInorder.Size = new System.Drawing.Size(240, 20);
            this.textBoxInorder.TabIndex = 19;
            // 
            // buttonRecorrer
            // 
            this.buttonRecorrer.Location = new System.Drawing.Point(127, 102);
            this.buttonRecorrer.Name = "buttonRecorrer";
            this.buttonRecorrer.Size = new System.Drawing.Size(75, 23);
            this.buttonRecorrer.TabIndex = 17;
            this.buttonRecorrer.Text = "Recorrer";
            this.buttonRecorrer.UseVisualStyleBackColor = true;
            this.buttonRecorrer.Click += new System.EventHandler(this.buttonRecorrer_Click_1);
            // 
            // textBoxPreOrder
            // 
            this.textBoxPreOrder.Location = new System.Drawing.Point(75, 8);
            this.textBoxPreOrder.Name = "textBoxPreOrder";
            this.textBoxPreOrder.ReadOnly = true;
            this.textBoxPreOrder.Size = new System.Drawing.Size(240, 20);
            this.textBoxPreOrder.TabIndex = 18;
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Location = new System.Drawing.Point(273, 37);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(75, 23);
            this.buttonEvaluar.TabIndex = 18;
            this.buttonEvaluar.Text = "Evaluar";
            this.buttonEvaluar.UseVisualStyleBackColor = true;
            this.buttonEvaluar.Click += new System.EventHandler(this.buttonEvaluar_Click_1);
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(273, 8);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerar.TabIndex = 16;
            this.buttonGenerar.Text = "Generar Arbol";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click_1);
            // 
            // textBoxEvaluar
            // 
            this.textBoxEvaluar.Location = new System.Drawing.Point(80, 66);
            this.textBoxEvaluar.Name = "textBoxEvaluar";
            this.textBoxEvaluar.ReadOnly = true;
            this.textBoxEvaluar.Size = new System.Drawing.Size(172, 20);
            this.textBoxEvaluar.TabIndex = 15;
            // 
            // textBoxGeneral
            // 
            this.textBoxGeneral.Location = new System.Drawing.Point(80, 11);
            this.textBoxGeneral.Name = "textBoxGeneral";
            this.textBoxGeneral.Size = new System.Drawing.Size(172, 20);
            this.textBoxGeneral.TabIndex = 13;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(80, 37);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(172, 20);
            this.textBoxValor.TabIndex = 14;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(8, 40);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(66, 13);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "&Valor de X";
            // 
            // panelDibujo
            // 
            this.panelDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDibujo.AutoSize = true;
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDibujo.Location = new System.Drawing.Point(371, 8);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(856, 439);
            this.panelDibujo.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Numero de Nodos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "&Buscar Nodo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(51, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "&Eliminar Nodo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(138, 38);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(100, 20);
            this.txtRuta.TabIndex = 26;
            // 
            // mostrarRuta
            // 
            this.mostrarRuta.Location = new System.Drawing.Point(248, 21);
            this.mostrarRuta.Name = "mostrarRuta";
            this.mostrarRuta.Size = new System.Drawing.Size(86, 23);
            this.mostrarRuta.TabIndex = 27;
            this.mostrarRuta.Text = "&Mostar ruta";
            this.mostrarRuta.UseVisualStyleBackColor = true;
            this.mostrarRuta.Click += new System.EventHandler(this.mostrarRuta_Click);
            // 
            // txtNumeroRuta
            // 
            this.txtNumeroRuta.Location = new System.Drawing.Point(138, 12);
            this.txtNumeroRuta.Name = "txtNumeroRuta";
            this.txtNumeroRuta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroRuta.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "&Mostrar ruta del nodo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "&Ruta del nodo:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mostrarRuta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtRuta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNumeroRuta);
            this.panel2.Location = new System.Drawing.Point(12, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 75);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Location = new System.Drawing.Point(13, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 76);
            this.panel3.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "&Nodo:";
            // 
            // GUIArbolDeExpresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEvaluar);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.textBoxEvaluar);
            this.Controls.Add(this.textBoxGeneral);
            this.Name = "GUIArbolDeExpresiones";
            this.Text = "Arbol de Expresiones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPostOrder;
        private System.Windows.Forms.TextBox textBoxInorder;
        private System.Windows.Forms.Button buttonRecorrer;
        private System.Windows.Forms.TextBox textBoxPreOrder;
        private System.Windows.Forms.Button buttonEvaluar;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.TextBox textBoxEvaluar;
        private System.Windows.Forms.TextBox textBoxGeneral;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button mostrarRuta;
        private System.Windows.Forms.TextBox txtNumeroRuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}

