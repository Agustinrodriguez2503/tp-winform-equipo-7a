namespace Grupo_7A
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCodigo = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdmMarcas = new System.Windows.Forms.Button();
            this.btnAdmCategorias = new System.Windows.Forms.Button();
            this.gbAdministrar = new System.Windows.Forms.GroupBox();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAdministrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnCodigo);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Controls.Add(this.cbCategoria);
            this.gbFiltros.Controls.Add(this.cbMarca);
            this.gbFiltros.Controls.Add(this.cbNombre);
            this.gbFiltros.Location = new System.Drawing.Point(558, 38);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(228, 71);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar por:";
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.cbNombre.Location = new System.Drawing.Point(6, 19);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(63, 17);
            this.cbNombre.TabIndex = 0;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = false;
            // 
            // cbMarca
            // 
            this.cbMarca.AutoSize = true;
            this.cbMarca.BackColor = System.Drawing.SystemColors.Control;
            this.cbMarca.Location = new System.Drawing.Point(75, 19);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(56, 17);
            this.cbMarca.TabIndex = 1;
            this.cbMarca.Text = "Marca";
            this.cbMarca.UseVisualStyleBackColor = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoSize = true;
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategoria.Location = new System.Drawing.Point(137, 19);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(73, 17);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.Text = "Categoría";
            this.cbCategoria.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(71, 38);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCódigo,
            this.dgvNombre,
            this.dgvMarca,
            this.dgvCategoría,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 397);
            this.dataGridView1.TabIndex = 5;
            // 
            // dgvCódigo
            // 
            this.dgvCódigo.HeaderText = "Código";
            this.dgvCódigo.Name = "dgvCódigo";
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvMarca
            // 
            this.dgvMarca.HeaderText = "Marca";
            this.dgvMarca.Name = "dgvMarca";
            // 
            // dgvCategoría
            // 
            this.dgvCategoría.HeaderText = "Categoría";
            this.dgvCategoría.Name = "dgvCategoría";
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(558, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCodigo
            // 
            this.btnCodigo.AutoSize = true;
            this.btnCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCodigo.Location = new System.Drawing.Point(6, 42);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(59, 17);
            this.btnCodigo.TabIndex = 4;
            this.btnCodigo.Text = "Código";
            this.btnCodigo.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAdmMarcas
            // 
            this.btnAdmMarcas.Location = new System.Drawing.Point(6, 19);
            this.btnAdmMarcas.Name = "btnAdmMarcas";
            this.btnAdmMarcas.Size = new System.Drawing.Size(97, 23);
            this.btnAdmMarcas.TabIndex = 10;
            this.btnAdmMarcas.Text = "Marcas";
            this.btnAdmMarcas.UseVisualStyleBackColor = true;
            // 
            // btnAdmCategorias
            // 
            this.btnAdmCategorias.Location = new System.Drawing.Point(109, 19);
            this.btnAdmCategorias.Name = "btnAdmCategorias";
            this.btnAdmCategorias.Size = new System.Drawing.Size(99, 23);
            this.btnAdmCategorias.TabIndex = 11;
            this.btnAdmCategorias.Text = "Categorías";
            this.btnAdmCategorias.UseVisualStyleBackColor = true;
            // 
            // gbAdministrar
            // 
            this.gbAdministrar.Controls.Add(this.btnAdmMarcas);
            this.gbAdministrar.Controls.Add(this.btnAdmCategorias);
            this.gbAdministrar.Location = new System.Drawing.Point(558, 115);
            this.gbAdministrar.Name = "gbAdministrar";
            this.gbAdministrar.Size = new System.Drawing.Size(228, 47);
            this.gbAdministrar.TabIndex = 5;
            this.gbAdministrar.TabStop = false;
            this.gbAdministrar.Text = "Administrar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAdministrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAdministrar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox cbCategoria;
        private System.Windows.Forms.CheckBox cbMarca;
        private System.Windows.Forms.CheckBox cbNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.CheckBox btnCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdmMarcas;
        private System.Windows.Forms.Button btnAdmCategorias;
        private System.Windows.Forms.GroupBox gbAdministrar;
    }
}

