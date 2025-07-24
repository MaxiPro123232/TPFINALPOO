namespace TPFINAL
{
    partial class FormReportes
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
            btnStockActual = new Button();
            btnStockPorRubro = new Button();
            btnMovimientosPorProveedor = new Button();
            btnProductosBajoStock = new Button();
            btnHistorialProducto = new Button();
            btnProductosPorVencer = new Button();
            btnVolver = new Button();
            dgvResultados = new DataGridView();
            cmbProductoHistorial = new ComboBox();
            label1 = new Label();
            nudUmbralStock = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUmbralStock).BeginInit();
            SuspendLayout();
            // 
            // btnStockActual
            // 
            btnStockActual.Location = new Point(98, 46);
            btnStockActual.Name = "btnStockActual";
            btnStockActual.Size = new Size(195, 23);
            btnStockActual.TabIndex = 0;
            btnStockActual.Text = "Stock Actual";
            btnStockActual.UseVisualStyleBackColor = true;
            // 
            // btnStockPorRubro
            // 
            btnStockPorRubro.Location = new Point(98, 75);
            btnStockPorRubro.Name = "btnStockPorRubro";
            btnStockPorRubro.Size = new Size(195, 23);
            btnStockPorRubro.TabIndex = 1;
            btnStockPorRubro.Text = "Stock Por Rubro";
            btnStockPorRubro.UseVisualStyleBackColor = true;
            // 
            // btnMovimientosPorProveedor
            // 
            btnMovimientosPorProveedor.Location = new Point(98, 104);
            btnMovimientosPorProveedor.Name = "btnMovimientosPorProveedor";
            btnMovimientosPorProveedor.Size = new Size(195, 23);
            btnMovimientosPorProveedor.TabIndex = 2;
            btnMovimientosPorProveedor.Text = "Movimientos Por Proveedor";
            btnMovimientosPorProveedor.UseVisualStyleBackColor = true;
            // 
            // btnProductosBajoStock
            // 
            btnProductosBajoStock.Location = new Point(98, 133);
            btnProductosBajoStock.Name = "btnProductosBajoStock";
            btnProductosBajoStock.Size = new Size(195, 23);
            btnProductosBajoStock.TabIndex = 3;
            btnProductosBajoStock.Text = "Productos Bajo Stock";
            btnProductosBajoStock.UseVisualStyleBackColor = true;
            // 
            // btnHistorialProducto
            // 
            btnHistorialProducto.Location = new Point(98, 220);
            btnHistorialProducto.Name = "btnHistorialProducto";
            btnHistorialProducto.Size = new Size(195, 23);
            btnHistorialProducto.TabIndex = 4;
            btnHistorialProducto.Text = "Historial Producto";
            btnHistorialProducto.UseVisualStyleBackColor = true;
            // 
            // btnProductosPorVencer
            // 
            btnProductosPorVencer.Location = new Point(98, 191);
            btnProductosPorVencer.Name = "btnProductosPorVencer";
            btnProductosPorVencer.Size = new Size(195, 23);
            btnProductosPorVencer.TabIndex = 5;
            btnProductosPorVencer.Text = "Productos Por Vencer";
            btnProductosPorVencer.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(98, 249);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(195, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(350, 41);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(361, 202);
            dgvResultados.TabIndex = 7;
            // 
            // cmbProductoHistorial
            // 
            cmbProductoHistorial.FormattingEnabled = true;
            cmbProductoHistorial.Location = new Point(98, 7);
            cmbProductoHistorial.Name = "cmbProductoHistorial";
            cmbProductoHistorial.Size = new Size(195, 23);
            cmbProductoHistorial.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Producto:";
            // 
            // nudUmbralStock
            // 
            nudUmbralStock.Location = new Point(98, 162);
            nudUmbralStock.Name = "nudUmbralStock";
            nudUmbralStock.Size = new Size(195, 23);
            nudUmbralStock.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 7);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 11;
            label2.Text = "Resultados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 170);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 12;
            label3.Text = "Stock menor a:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 296);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudUmbralStock);
            Controls.Add(label1);
            Controls.Add(cmbProductoHistorial);
            Controls.Add(dgvResultados);
            Controls.Add(btnVolver);
            Controls.Add(btnProductosPorVencer);
            Controls.Add(btnHistorialProducto);
            Controls.Add(btnProductosBajoStock);
            Controls.Add(btnMovimientosPorProveedor);
            Controls.Add(btnStockPorRubro);
            Controls.Add(btnStockActual);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUmbralStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStockActual;
        private Button btnStockPorRubro;
        private Button btnMovimientosPorProveedor;
        private Button btnProductosBajoStock;
        private Button btnHistorialProducto;
        private Button btnProductosPorVencer;
        private Button btnVolver;
        private DataGridView dgvResultados;
        private ComboBox cmbProductoHistorial;
        private Label label1;
        private NumericUpDown nudUmbralStock;
        private Label label2;
        private Label label3;
    }
}