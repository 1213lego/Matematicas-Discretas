namespace Juegos
{
    partial class guiLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxGenero = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.butLeerEn = new System.Windows.Forms.Button();
            this.buttBuscar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butVolcar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butGuardor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttEliminarN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grillaListas = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListas)).BeginInit();
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
            // butLeerEn
            // 
            this.butLeerEn.ImageKey = "(ninguno)";
            this.butLeerEn.Location = new System.Drawing.Point(5, 42);
            this.butLeerEn.Name = "butLeerEn";
            this.butLeerEn.Size = new System.Drawing.Size(118, 23);
            this.butLeerEn.TabIndex = 11;
            this.butLeerEn.Text = "Buscar por posicion";
            this.butLeerEn.UseVisualStyleBackColor = true;
            this.butLeerEn.Click += new System.EventHandler(this.butLeerEn_Click);
            // 
            // buttBuscar
            // 
            this.buttBuscar.Location = new System.Drawing.Point(5, 71);
            this.buttBuscar.Name = "buttBuscar";
            this.buttBuscar.Size = new System.Drawing.Size(118, 24);
            this.buttBuscar.TabIndex = 14;
            this.buttBuscar.Text = "Buscar Por Titulo";
            this.buttBuscar.UseVisualStyleBackColor = true;
            this.buttBuscar.Click += new System.EventHandler(this.buttBuscar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(5, 131);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(118, 24);
            this.butEliminar.TabIndex = 18;
            this.butEliminar.Text = "Eliminar Registro";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butVolcar
            // 
            this.butVolcar.Location = new System.Drawing.Point(5, 161);
            this.butVolcar.Name = "butVolcar";
            this.butVolcar.Size = new System.Drawing.Size(118, 24);
            this.butVolcar.TabIndex = 20;
            this.butVolcar.Text = "Importar datos";
            this.butVolcar.UseVisualStyleBackColor = true;
            this.butVolcar.Click += new System.EventHandler(this.butVolcar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblTitulo);
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
            // butGuardor
            // 
            this.butGuardor.Image = ((System.Drawing.Image)(resources.GetObject("butGuardor.Image")));
            this.butGuardor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGuardor.Location = new System.Drawing.Point(54, 212);
            this.butGuardor.Name = "butGuardor";
            this.butGuardor.Size = new System.Drawing.Size(96, 25);
            this.butGuardor.TabIndex = 8;
            this.butGuardor.Text = "Guardar";
            this.butGuardor.UseVisualStyleBackColor = true;
            this.butGuardor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Guardar ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttEliminarN);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.butLeerEn);
            this.panel2.Controls.Add(this.buttBuscar);
            this.panel2.Controls.Add(this.butEliminar);
            this.panel2.Controls.Add(this.butVolcar);
            this.panel2.Location = new System.Drawing.Point(244, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 256);
            this.panel2.TabIndex = 23;
            // 
            // buttEliminarN
            // 
            this.buttEliminarN.Location = new System.Drawing.Point(5, 192);
            this.buttEliminarN.Name = "buttEliminarN";
            this.buttEliminarN.Size = new System.Drawing.Size(118, 23);
            this.buttEliminarN.TabIndex = 28;
            this.buttEliminarN.Text = "Eliminar N Registros";
            this.buttEliminarN.UseVisualStyleBackColor = true;
            this.buttEliminarN.Click += new System.EventHandler(this.buttEliminarN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ordenar por Precio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Opciones";
            // 
            // grillaListas
            // 
            this.grillaListas.AllowUserToAddRows = false;
            this.grillaListas.AllowUserToDeleteRows = false;
            this.grillaListas.AllowUserToResizeRows = false;
            this.grillaListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.titulo,
            this.genero,
            this.precio,
            this.fecha});
            this.grillaListas.Location = new System.Drawing.Point(397, 62);
            this.grillaListas.Name = "grillaListas";
            this.grillaListas.ReadOnly = true;
            this.grillaListas.Size = new System.Drawing.Size(525, 223);
            this.grillaListas.TabIndex = 25;
            this.grillaListas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaListas_CellContentClick);
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posicion";
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "Consultar Numero Registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // guiLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaListas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "guiLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juegos Servicio Listas";
            this.Load += new System.EventHandler(this.guiLista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaListas)).EndInit();
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
        private System.Windows.Forms.Button butLeerEn;
        private System.Windows.Forms.Button buttBuscar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butVolcar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grillaListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttEliminarN;
    }
}

