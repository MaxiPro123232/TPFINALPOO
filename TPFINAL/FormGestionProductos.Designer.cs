namespace TPFINAL
{
    partial class FormGestionProductos
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
            txtNombre = new TextBox();
            txtStockInicial = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtDescripcion = new TextBox();
            cmbRubro = new ComboBox();
            dtpFechaVencimiento = new DateTimePicker();
            btnAgregarProducto = new Button();
            btnModificarProducto = new Button();
            btnEliminarProducto = new Button();
            btnBuscarProducto = new Button();
            btnListarProductos = new Button();
            btnFiltrarPorRubro = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtStockInicial
            // 
            txtStockInicial.Location = new Point(135, 164);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(100, 23);
            txtStockInicial.TabIndex = 1;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(135, 112);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(135, 63);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // cmbRubro
            // 
            cmbRubro.FormattingEnabled = true;
            cmbRubro.Location = new Point(135, 216);
            cmbRubro.Name = "cmbRubro";
            cmbRubro.Size = new Size(121, 23);
            cmbRubro.TabIndex = 4;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(135, 262);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(200, 23);
            dtpFechaVencimiento.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(311, 15);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(120, 23);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(311, 66);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(120, 23);
            btnModificarProducto.TabIndex = 7;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(311, 115);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(120, 23);
            btnEliminarProducto.TabIndex = 8;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(311, 164);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(120, 23);
            btnBuscarProducto.TabIndex = 9;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(450, 15);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(112, 23);
            btnListarProductos.TabIndex = 10;
            btnListarProductos.Text = " Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPorRubro
            // 
            btnFiltrarPorRubro.Location = new Point(450, 63);
            btnFiltrarPorRubro.Name = "btnFiltrarPorRubro";
            btnFiltrarPorRubro.Size = new Size(112, 23);
            btnFiltrarPorRubro.TabIndex = 11;
            btnFiltrarPorRubro.Text = "Filtrar Por Rubro";
            btnFiltrarPorRubro.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(450, 115);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 23);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 14;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 115);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 164);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 16;
            label4.Text = "Stock Inicial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 219);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 17;
            label5.Text = "Rubro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 268);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 18;
            label6.Text = "Fecha Vencimiento:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 19;
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnFiltrarPorRubro);
            Controls.Add(btnListarProductos);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(cmbRubro);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtStockInicial);
            Controls.Add(txtNombre);
            Name = "FormGestionProductos";
            Text = "FormGestionProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtStockInicial;
        private TextBox txtPrecioUnitario;
        private TextBox txtDescripcion;
        private ComboBox cmbRubro;
        private DateTimePicker dtpFechaVencimiento;
        private Button btnAgregarProducto;
        private Button btnModificarProducto;
        private Button btnEliminarProducto;
        private Button btnBuscarProducto;
        private Button btnListarProductos;
        private Button btnFiltrarPorRubro;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
    }
}