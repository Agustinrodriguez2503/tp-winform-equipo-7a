namespace Grupo_7A
{
    partial class frmAdministrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMarcaCategoria = new System.Windows.Forms.DataGridView();
            this.btnAgregarMC = new System.Windows.Forms.Button();
            this.btnModificarMC = new System.Windows.Forms.Button();
            this.btnEliminarMC = new System.Windows.Forms.Button();
            this.gbxBusquedaRapidaMC = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapidaMC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaCategoria)).BeginInit();
            this.gbxBusquedaRapidaMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcaCategoria
            // 
            this.dgvMarcaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcaCategoria.Location = new System.Drawing.Point(24, 22);
            this.dgvMarcaCategoria.Name = "dgvMarcaCategoria";
            this.dgvMarcaCategoria.RowHeadersWidth = 51;
            this.dgvMarcaCategoria.RowTemplate.Height = 24;
            this.dgvMarcaCategoria.Size = new System.Drawing.Size(314, 210);
            this.dgvMarcaCategoria.TabIndex = 0;
            // 
            // btnAgregarMC
            // 
            this.btnAgregarMC.Location = new System.Drawing.Point(24, 320);
            this.btnAgregarMC.Name = "btnAgregarMC";
            this.btnAgregarMC.Size = new System.Drawing.Size(96, 33);
            this.btnAgregarMC.TabIndex = 1;
            this.btnAgregarMC.Text = "Agregar";
            this.btnAgregarMC.UseVisualStyleBackColor = true;
            // 
            // btnModificarMC
            // 
            this.btnModificarMC.Location = new System.Drawing.Point(133, 320);
            this.btnModificarMC.Name = "btnModificarMC";
            this.btnModificarMC.Size = new System.Drawing.Size(96, 33);
            this.btnModificarMC.TabIndex = 2;
            this.btnModificarMC.Text = "Modificar";
            this.btnModificarMC.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMC
            // 
            this.btnEliminarMC.Location = new System.Drawing.Point(242, 320);
            this.btnEliminarMC.Name = "btnEliminarMC";
            this.btnEliminarMC.Size = new System.Drawing.Size(96, 33);
            this.btnEliminarMC.TabIndex = 3;
            this.btnEliminarMC.Text = "Eliminar";
            this.btnEliminarMC.UseVisualStyleBackColor = true;
            // 
            // gbxBusquedaRapidaMC
            // 
            this.gbxBusquedaRapidaMC.Controls.Add(this.txtBusquedaRapidaMC);
            this.gbxBusquedaRapidaMC.Location = new System.Drawing.Point(24, 238);
            this.gbxBusquedaRapidaMC.Name = "gbxBusquedaRapidaMC";
            this.gbxBusquedaRapidaMC.Size = new System.Drawing.Size(314, 76);
            this.gbxBusquedaRapidaMC.TabIndex = 12;
            this.gbxBusquedaRapidaMC.TabStop = false;
            this.gbxBusquedaRapidaMC.Text = "Busqueda Rapida";
            // 
            // txtBusquedaRapidaMC
            // 
            this.txtBusquedaRapidaMC.Location = new System.Drawing.Point(25, 34);
            this.txtBusquedaRapidaMC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaRapidaMC.Name = "txtBusquedaRapidaMC";
            this.txtBusquedaRapidaMC.Size = new System.Drawing.Size(262, 22);
            this.txtBusquedaRapidaMC.TabIndex = 0;
            // 
            // frmAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 376);
            this.Controls.Add(this.gbxBusquedaRapidaMC);
            this.Controls.Add(this.btnEliminarMC);
            this.Controls.Add(this.btnModificarMC);
            this.Controls.Add(this.btnAgregarMC);
            this.Controls.Add(this.dgvMarcaCategoria);
            this.Name = "frmAdministrar";
            this.Text = "Administrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaCategoria)).EndInit();
            this.gbxBusquedaRapidaMC.ResumeLayout(false);
            this.gbxBusquedaRapidaMC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcaCategoria;
        private System.Windows.Forms.Button btnAgregarMC;
        private System.Windows.Forms.Button btnModificarMC;
        private System.Windows.Forms.Button btnEliminarMC;
        private System.Windows.Forms.GroupBox gbxBusquedaRapidaMC;
        private System.Windows.Forms.TextBox txtBusquedaRapidaMC;
    }
}