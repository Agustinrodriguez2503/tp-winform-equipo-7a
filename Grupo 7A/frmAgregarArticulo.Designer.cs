namespace Grupo_7A
{
    partial class frmAgregarArticulo
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
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pbxAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCargarArticulo = new System.Windows.Forms.GroupBox();
            this.lblPrecioVacio = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.lblcbxMarca = new System.Windows.Forms.Label();
            this.lblcbxCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArticulo)).BeginInit();
            this.gbCargarArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(17, 34);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(17, 172);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 144);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(17, 207);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 241);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(87, 237);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(87, 203);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 5;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(87, 170);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(100, 21);
            this.cbxMarca.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(87, 139);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(100, 21);
            this.cbxCategoria.TabIndex = 3;
            // 
            // pbxAgregarArticulo
            // 
            this.pbxAgregarArticulo.Location = new System.Drawing.Point(277, 26);
            this.pbxAgregarArticulo.Name = "pbxAgregarArticulo";
            this.pbxAgregarArticulo.Size = new System.Drawing.Size(223, 278);
            this.pbxAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarArticulo.TabIndex = 14;
            this.pbxAgregarArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 323);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(151, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbCargarArticulo
            // 
            this.gbCargarArticulo.Controls.Add(this.lblPrecioVacio);
            this.gbCargarArticulo.Controls.Add(this.txtPrecio);
            this.gbCargarArticulo.Controls.Add(this.lblCodigoArticulo);
            this.gbCargarArticulo.Controls.Add(this.lblNombre);
            this.gbCargarArticulo.Controls.Add(this.lblDescripcion);
            this.gbCargarArticulo.Controls.Add(this.lblMarca);
            this.gbCargarArticulo.Controls.Add(this.cbxMarca);
            this.gbCargarArticulo.Controls.Add(this.cbxCategoria);
            this.gbCargarArticulo.Controls.Add(this.lblCategoria);
            this.gbCargarArticulo.Controls.Add(this.lblImagen);
            this.gbCargarArticulo.Controls.Add(this.txtNombre);
            this.gbCargarArticulo.Controls.Add(this.lblPrecio);
            this.gbCargarArticulo.Controls.Add(this.txtDescripcion);
            this.gbCargarArticulo.Controls.Add(this.txtCodigo);
            this.gbCargarArticulo.Controls.Add(this.txtImagen);
            this.gbCargarArticulo.Location = new System.Drawing.Point(26, 20);
            this.gbCargarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargarArticulo.Name = "gbCargarArticulo";
            this.gbCargarArticulo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargarArticulo.Size = new System.Drawing.Size(236, 284);
            this.gbCargarArticulo.TabIndex = 18;
            this.gbCargarArticulo.TabStop = false;
            // 
            // lblPrecioVacio
            // 
            this.lblPrecioVacio.AutoSize = true;
            this.lblPrecioVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVacio.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioVacio.Location = new System.Drawing.Point(190, 240);
            this.lblPrecioVacio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioVacio.Name = "lblPrecioVacio";
            this.lblPrecioVacio.Size = new System.Drawing.Size(13, 17);
            this.lblPrecioVacio.TabIndex = 22;
            this.lblPrecioVacio.Text = "*";
            this.lblPrecioVacio.Visible = false;
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNumeros.Location = new System.Drawing.Point(280, 314);
            this.lblSoloNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(232, 13);
            this.lblSoloNumeros.TabIndex = 19;
            this.lblSoloNumeros.Text = "* Solo se aceptan numeros en el campo \'Precio\'";
            this.lblSoloNumeros.Visible = false;
            // 
            // lblcbxMarca
            // 
            this.lblcbxMarca.AutoSize = true;
            this.lblcbxMarca.ForeColor = System.Drawing.Color.Red;
            this.lblcbxMarca.Location = new System.Drawing.Point(280, 347);
            this.lblcbxMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcbxMarca.Name = "lblcbxMarca";
            this.lblcbxMarca.Size = new System.Drawing.Size(121, 13);
            this.lblcbxMarca.TabIndex = 20;
            this.lblcbxMarca.Text = "* Seleccione una Marca";
            this.lblcbxMarca.Visible = false;
            // 
            // lblcbxCategoria
            // 
            this.lblcbxCategoria.AutoSize = true;
            this.lblcbxCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblcbxCategoria.Location = new System.Drawing.Point(280, 331);
            this.lblcbxCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcbxCategoria.Name = "lblcbxCategoria";
            this.lblcbxCategoria.Size = new System.Drawing.Size(136, 13);
            this.lblcbxCategoria.TabIndex = 21;
            this.lblcbxCategoria.Text = "* Seleccione una Categoria";
            this.lblcbxCategoria.Visible = false;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 371);
            this.Controls.Add(this.lblcbxCategoria);
            this.Controls.Add(this.lblcbxMarca);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.gbCargarArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxAgregarArticulo);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArticulo)).EndInit();
            this.gbCargarArticulo.ResumeLayout(false);
            this.gbCargarArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pbxAgregarArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbCargarArticulo;
        private System.Windows.Forms.Label lblSoloNumeros;
        private System.Windows.Forms.Label lblcbxMarca;
        private System.Windows.Forms.Label lblcbxCategoria;
        private System.Windows.Forms.Label lblPrecioVacio;
    }
}