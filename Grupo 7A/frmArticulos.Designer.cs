namespace Grupo_7A
{
    partial class frmArticulos
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
            this.components = new System.ComponentModel.Container();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdmMarcas = new System.Windows.Forms.Button();
            this.btnAdmCategorias = new System.Windows.Forms.Button();
            this.gbAdministrar = new System.Windows.Forms.GroupBox();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.gbxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slblVacio = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.gbAdministrar.SuspendLayout();
            this.gbxBusquedaRapida.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Location = new System.Drawing.Point(23, 33);
            this.txtBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(233, 22);
            this.txtBusquedaRapida.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblCriterio);
            this.gbFiltros.Controls.Add(this.rbtnCategoria);
            this.gbFiltros.Controls.Add(this.cbxCriterio);
            this.gbFiltros.Controls.Add(this.rbtnMarca);
            this.gbFiltros.Controls.Add(this.txtFiltroAvanzado);
            this.gbFiltros.Controls.Add(this.rbtnNombre);
            this.gbFiltros.Controls.Add(this.rbtnCodigo);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Location = new System.Drawing.Point(20, 410);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltros.Size = new System.Drawing.Size(401, 184);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar por:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(276, 140);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 13);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(1013, 323);
            this.dgvArticulos.TabIndex = 5;
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(749, 355);
            this.pbxArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(277, 239);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxArticulos.TabIndex = 6;
            this.pbxArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 355);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 28);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(602, 355);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(112, 28);
            this.btnEliminarFisico.TabIndex = 8;
            this.btnEliminarFisico.Text = "Eliminar de BD";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(139, 355);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAdmMarcas
            // 
            this.btnAdmMarcas.Location = new System.Drawing.Point(21, 28);
            this.btnAdmMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmMarcas.Name = "btnAdmMarcas";
            this.btnAdmMarcas.Size = new System.Drawing.Size(104, 27);
            this.btnAdmMarcas.TabIndex = 10;
            this.btnAdmMarcas.Text = "Marcas";
            this.btnAdmMarcas.UseVisualStyleBackColor = true;
            // 
            // btnAdmCategorias
            // 
            this.btnAdmCategorias.Location = new System.Drawing.Point(148, 28);
            this.btnAdmCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmCategorias.Name = "btnAdmCategorias";
            this.btnAdmCategorias.Size = new System.Drawing.Size(111, 27);
            this.btnAdmCategorias.TabIndex = 11;
            this.btnAdmCategorias.Text = "Categorías";
            this.btnAdmCategorias.UseVisualStyleBackColor = true;
            // 
            // gbAdministrar
            // 
            this.gbAdministrar.Controls.Add(this.btnAdmMarcas);
            this.gbAdministrar.Controls.Add(this.btnAdmCategorias);
            this.gbAdministrar.Location = new System.Drawing.Point(437, 518);
            this.gbAdministrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdministrar.Name = "gbAdministrar";
            this.gbAdministrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdministrar.Size = new System.Drawing.Size(277, 76);
            this.gbAdministrar.TabIndex = 5;
            this.gbAdministrar.TabStop = false;
            this.gbAdministrar.Text = "Administrar:";
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(257, 355);
            this.btnEliminarLogico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(112, 28);
            this.btnEliminarLogico.TabIndex = 10;
            this.btnEliminarLogico.Text = "Eliminar ";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            // 
            // gbxBusquedaRapida
            // 
            this.gbxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gbxBusquedaRapida.Location = new System.Drawing.Point(437, 410);
            this.gbxBusquedaRapida.Name = "gbxBusquedaRapida";
            this.gbxBusquedaRapida.Size = new System.Drawing.Size(279, 76);
            this.gbxBusquedaRapida.TabIndex = 11;
            this.gbxBusquedaRapida.TabStop = false;
            this.gbxBusquedaRapida.Text = "Busqueda Rapida";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(158, 100);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(218, 22);
            this.txtFiltroAvanzado.TabIndex = 7;
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(23, 33);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(72, 20);
            this.rbtnCodigo.TabIndex = 8;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(23, 69);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(77, 20);
            this.rbtnNombre.TabIndex = 9;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(23, 105);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(66, 20);
            this.rbtnMarca.TabIndex = 10;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(158, 55);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(218, 24);
            this.cbxCriterio.TabIndex = 11;
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(23, 142);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(87, 20);
            this.rbtnCategoria.TabIndex = 12;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoría";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(155, 33);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblVacio,
            this.slblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slblVacio
            // 
            this.slblVacio.Name = "slblVacio";
            this.slblVacio.Size = new System.Drawing.Size(1006, 18);
            this.slblVacio.Spring = true;
            // 
            // slblFechaHora
            // 
            this.slblFechaHora.Name = "slblFechaHora";
            this.slblFechaHora.Size = new System.Drawing.Size(0, 18);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 634);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxBusquedaRapida);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.gbAdministrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1078, 681);
            this.MinimumSize = new System.Drawing.Size(1078, 681);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.gbAdministrar.ResumeLayout(false);
            this.gbxBusquedaRapida.ResumeLayout(false);
            this.gbxBusquedaRapida.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaRapida;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdmMarcas;
        private System.Windows.Forms.Button btnAdmCategorias;
        private System.Windows.Forms.GroupBox gbAdministrar;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.GroupBox gbxBusquedaRapida;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblVacio;
        private System.Windows.Forms.ToolStripStatusLabel slblFechaHora;
        private System.Windows.Forms.Timer timer1;
    }
}

