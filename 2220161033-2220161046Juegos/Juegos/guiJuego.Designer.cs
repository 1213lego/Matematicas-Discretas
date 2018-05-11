namespace Juegos
{
    partial class guiJuego
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxGenero = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.butGuardor = new System.Windows.Forms.Button();
            this.butExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.butLeerEn = new System.Windows.Forms.Button();
            this.txtLeerPosicion = new System.Windows.Forms.TextBox();
            this.buttBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butCambiarPrecio = new System.Windows.Forms.Button();
            this.butReiniciar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butVolcar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(5, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "&Titulo";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(5, 52);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "&Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Precio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/aa";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // listBoxGenero
            // 
            this.listBoxGenero.FormattingEnabled = true;
            this.listBoxGenero.Items.AddRange(new object[] {
            "Accion",
            "Rol",
            "Estrategia",
            "Lucha",
            "Arcade",
            "Simulacion",
            "MMO",
            "Survival",
            "Musica",
            "Deportes",
            "Carreras"});
            this.listBoxGenero.Location = new System.Drawing.Point(65, 52);
            this.listBoxGenero.Name = "listBoxGenero";
            this.listBoxGenero.Size = new System.Drawing.Size(128, 69);
            this.listBoxGenero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Fecha";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(65, 19);
            this.txtTitulo.MaxLength = 30;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(128, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 136);
            this.txtPrecio.MaxLength = 9;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // butGuardor
            // 
            this.butGuardor.Location = new System.Drawing.Point(49, 225);
            this.butGuardor.Name = "butGuardor";
            this.butGuardor.Size = new System.Drawing.Size(96, 25);
            this.butGuardor.TabIndex = 8;
            this.butGuardor.Text = "Guardar";
            this.butGuardor.UseVisualStyleBackColor = true;
            this.butGuardor.Click += new System.EventHandler(this.button1_Click);
            // 
            // butExaminar
            // 
            this.butExaminar.Location = new System.Drawing.Point(39, 3);
            this.butExaminar.Name = "butExaminar";
            this.butExaminar.Size = new System.Drawing.Size(102, 20);
            this.butExaminar.TabIndex = 9;
            this.butExaminar.Text = "Examinar";
            this.butExaminar.UseVisualStyleBackColor = true;
            this.butExaminar.Click += new System.EventHandler(this.butExaminar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(158, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(216, 20);
            this.txtRuta.TabIndex = 10;
            // 
            // butLeerEn
            // 
            this.butLeerEn.Location = new System.Drawing.Point(3, 42);
            this.butLeerEn.Name = "butLeerEn";
            this.butLeerEn.Size = new System.Drawing.Size(120, 23);
            this.butLeerEn.TabIndex = 11;
            this.butLeerEn.Text = "Buscar Por posicion";
            this.butLeerEn.UseVisualStyleBackColor = true;
            this.butLeerEn.Click += new System.EventHandler(this.butLeerEn_Click);
            // 
            // txtLeerPosicion
            // 
            this.txtLeerPosicion.Location = new System.Drawing.Point(65, 201);
            this.txtLeerPosicion.Name = "txtLeerPosicion";
            this.txtLeerPosicion.ReadOnly = true;
            this.txtLeerPosicion.Size = new System.Drawing.Size(128, 20);
            this.txtLeerPosicion.TabIndex = 12;
            // 
            // buttBuscar
            // 
            this.buttBuscar.Location = new System.Drawing.Point(3, 71);
            this.buttBuscar.Name = "buttBuscar";
            this.buttBuscar.Size = new System.Drawing.Size(120, 24);
            this.buttBuscar.TabIndex = 14;
            this.buttBuscar.Text = "Buscar Por Titulo";
            this.buttBuscar.UseVisualStyleBackColor = true;
            this.buttBuscar.Click += new System.EventHandler(this.buttBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "&Posicion";
            // 
            // butCambiarPrecio
            // 
            this.butCambiarPrecio.Location = new System.Drawing.Point(3, 101);
            this.butCambiarPrecio.Name = "butCambiarPrecio";
            this.butCambiarPrecio.Size = new System.Drawing.Size(120, 25);
            this.butCambiarPrecio.TabIndex = 16;
            this.butCambiarPrecio.Text = "Cambiar precio";
            this.butCambiarPrecio.UseVisualStyleBackColor = true;
            this.butCambiarPrecio.Click += new System.EventHandler(this.butCambiarPrecio_Click);
            // 
            // butReiniciar
            // 
            this.butReiniciar.Location = new System.Drawing.Point(3, 131);
            this.butReiniciar.Name = "butReiniciar";
            this.butReiniciar.Size = new System.Drawing.Size(120, 25);
            this.butReiniciar.TabIndex = 17;
            this.butReiniciar.Text = "Reiniciar Campos";
            this.butReiniciar.UseVisualStyleBackColor = true;
            this.butReiniciar.Click += new System.EventHandler(this.butReiniciar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(3, 225);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(120, 24);
            this.butEliminar.TabIndex = 18;
            this.butEliminar.Text = "Eliminar Registro";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butVolcar
            // 
            this.butVolcar.Location = new System.Drawing.Point(3, 195);
            this.butVolcar.Name = "butVolcar";
            this.butVolcar.Size = new System.Drawing.Size(120, 24);
            this.butVolcar.TabIndex = 20;
            this.butVolcar.Text = "Importar datos";
            this.butVolcar.UseVisualStyleBackColor = true;
            this.butVolcar.Click += new System.EventHandler(this.butVolcar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtLeerPosicion);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxGenero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.butGuardor);
            this.panel1.Location = new System.Drawing.Point(20, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 257);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Guardar / Mostrar datos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.butLeerEn);
            this.panel2.Controls.Add(this.buttBuscar);
            this.panel2.Controls.Add(this.butEliminar);
            this.panel2.Controls.Add(this.butVolcar);
            this.panel2.Controls.Add(this.butCambiarPrecio);
            this.panel2.Controls.Add(this.butReiniciar);
            this.panel2.Location = new System.Drawing.Point(244, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 256);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Opciones";
            // 
            // guiJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 344);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.butExaminar);
            this.Name = "guiJuego";
            this.Text = "Juegos Servicio archivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button butGuardor;
        private System.Windows.Forms.Button butExaminar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button butLeerEn;
        private System.Windows.Forms.TextBox txtLeerPosicion;
        private System.Windows.Forms.Button buttBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butCambiarPrecio;
        private System.Windows.Forms.Button butReiniciar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butVolcar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}

