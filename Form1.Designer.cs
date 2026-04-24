namespace MenuCafeteria
{
    partial class frmMenuCafeteria
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBorrarMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(57, 78);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(117, 14);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre de Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(57, 116);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(71, 14);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(57, 40);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(59, 14);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(57, 154);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 14);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Baguettes",
            "Bebidas calientes",
            "Bebidas frías",
            "Bebidas frozen",
            "Chapatas",
            "Crepas",
            "Pasteles",
            "Otros"});
            this.cmbCategoria.Location = new System.Drawing.Point(182, 37);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 22);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.Text = "- Seleccione -";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(182, 75);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(180, 22);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(182, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(182, 151);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(60, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(545, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiarForm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarForm.Location = new System.Drawing.Point(545, 84);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(150, 38);
            this.btnLimpiarForm.TabIndex = 9;
            this.btnLimpiarForm.Text = "&Limpiar Formulario";
            this.btnLimpiarForm.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(545, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 38);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 192);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnBorrarMenu
            // 
            this.btnBorrarMenu.Location = new System.Drawing.Point(585, 438);
            this.btnBorrarMenu.Name = "btnBorrarMenu";
            this.btnBorrarMenu.Size = new System.Drawing.Size(110, 23);
            this.btnBorrarMenu.TabIndex = 12;
            this.btnBorrarMenu.Text = "&Borrar Menú";
            this.btnBorrarMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menú";
            // 
            // frmMenuCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreProducto);
            this.Name = "frmMenuCafeteria";
            this.Text = "MENU CAFETERIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorrarMenu;
        private System.Windows.Forms.Label label1;
    }
}

