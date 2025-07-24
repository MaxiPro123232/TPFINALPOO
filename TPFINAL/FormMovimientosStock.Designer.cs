namespace TPFINAL
{
    partial class FormMovimientosStock
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
            cmbProducto = new ComboBox();
            cmbProveedor = new ComboBox();
            nudCantidad = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            rdbIngreso = new RadioButton();
            btnRegistrarMovimiento = new Button();
            btnListarMovimientos = new Button();
            btnFiltrarPorProducto = new Button();
            btnFiltrarPorFecha = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            btnFiltrarPorTipo = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(141, 41);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 0;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(141, 91);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(121, 23);
            cmbProveedor.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(142, 139);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(141, 194);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // rdbIngreso
            // 
            rdbIngreso.AutoSize = true;
            rdbIngreso.Location = new Point(142, 257);
            rdbIngreso.Name = "rdbIngreso";
            rdbIngreso.Size = new Size(64, 19);
            rdbIngreso.TabIndex = 4;
            rdbIngreso.TabStop = true;
            rdbIngreso.Text = "Ingreso";
            rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.Location = new Point(404, 45);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(142, 23);
            btnRegistrarMovimiento.TabIndex = 5;
            btnRegistrarMovimiento.Text = "Registrar Movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            // 
            // btnListarMovimientos
            // 
            btnListarMovimientos.Location = new Point(404, 74);
            btnListarMovimientos.Name = "btnListarMovimientos";
            btnListarMovimientos.Size = new Size(142, 23);
            btnListarMovimientos.TabIndex = 6;
            btnListarMovimientos.Text = "Listar Movimientos";
            btnListarMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPorProducto
            // 
            btnFiltrarPorProducto.Location = new Point(404, 103);
            btnFiltrarPorProducto.Name = "btnFiltrarPorProducto";
            btnFiltrarPorProducto.Size = new Size(142, 28);
            btnFiltrarPorProducto.TabIndex = 7;
            btnFiltrarPorProducto.Text = "Filtrar Por Producto";
            btnFiltrarPorProducto.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPorFecha
            // 
            btnFiltrarPorFecha.Location = new Point(404, 182);
            btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            btnFiltrarPorFecha.Size = new Size(142, 28);
            btnFiltrarPorFecha.TabIndex = 9;
            btnFiltrarPorFecha.Text = "Filtrar Por Fecha";
            btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(404, 228);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 12;
            label2.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 202);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 147);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 259);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 16;
            label5.Text = "Ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 300);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 17;
            label6.Text = "Egreso:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(141, 300);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Egreso";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPorTipo
            // 
            btnFiltrarPorTipo.Location = new Point(404, 140);
            btnFiltrarPorTipo.Name = "btnFiltrarPorTipo";
            btnFiltrarPorTipo.Size = new Size(142, 28);
            btnFiltrarPorTipo.TabIndex = 19;
            btnFiltrarPorTipo.Text = "Filtrar por Tipo";
            btnFiltrarPorTipo.UseVisualStyleBackColor = true;
            // 
            // FormMovimientosStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 362);
            Controls.Add(btnFiltrarPorTipo);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnFiltrarPorFecha);
            Controls.Add(btnFiltrarPorProducto);
            Controls.Add(btnListarMovimientos);
            Controls.Add(btnRegistrarMovimiento);
            Controls.Add(rdbIngreso);
            Controls.Add(dtpFecha);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbProducto);
            Name = "FormMovimientosStock";
            Text = "FormMovimientosStock";
            Load += FormMovimientosStock_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducto;
        private ComboBox cmbProveedor;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFecha;
        private RadioButton rdbIngreso;
        private Button btnRegistrarMovimiento;
        private Button btnListarMovimientos;
        private Button btnFiltrarPorProducto;
        private Button btnFiltrarPorFecha;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private Button btnFiltrarPorTipo;
    }
}