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
            SuspendLayout();
            // 
            // btnStockActual
            // 
            btnStockActual.Location = new Point(41, 27);
            btnStockActual.Name = "btnStockActual";
            btnStockActual.Size = new Size(195, 23);
            btnStockActual.TabIndex = 0;
            btnStockActual.Text = "Stock Actual";
            btnStockActual.UseVisualStyleBackColor = true;
            // 
            // btnStockPorRubro
            // 
            btnStockPorRubro.Location = new Point(41, 73);
            btnStockPorRubro.Name = "btnStockPorRubro";
            btnStockPorRubro.Size = new Size(195, 23);
            btnStockPorRubro.TabIndex = 1;
            btnStockPorRubro.Text = "Stock Por Rubro";
            btnStockPorRubro.UseVisualStyleBackColor = true;
            // 
            // btnMovimientosPorProveedor
            // 
            btnMovimientosPorProveedor.Location = new Point(41, 119);
            btnMovimientosPorProveedor.Name = "btnMovimientosPorProveedor";
            btnMovimientosPorProveedor.Size = new Size(195, 23);
            btnMovimientosPorProveedor.TabIndex = 2;
            btnMovimientosPorProveedor.Text = "Movimientos Por Proveedor";
            btnMovimientosPorProveedor.UseVisualStyleBackColor = true;
            // 
            // btnProductosBajoStock
            // 
            btnProductosBajoStock.Location = new Point(41, 171);
            btnProductosBajoStock.Name = "btnProductosBajoStock";
            btnProductosBajoStock.Size = new Size(195, 23);
            btnProductosBajoStock.TabIndex = 3;
            btnProductosBajoStock.Text = "Productos Bajo Stock";
            btnProductosBajoStock.UseVisualStyleBackColor = true;
            // 
            // btnHistorialProducto
            // 
            btnHistorialProducto.Location = new Point(41, 217);
            btnHistorialProducto.Name = "btnHistorialProducto";
            btnHistorialProducto.Size = new Size(195, 23);
            btnHistorialProducto.TabIndex = 4;
            btnHistorialProducto.Text = "Historial Producto";
            btnHistorialProducto.UseVisualStyleBackColor = true;
            // 
            // btnProductosPorVencer
            // 
            btnProductosPorVencer.Location = new Point(41, 263);
            btnProductosPorVencer.Name = "btnProductosPorVencer";
            btnProductosPorVencer.Size = new Size(195, 23);
            btnProductosPorVencer.TabIndex = 5;
            btnProductosPorVencer.Text = "Productos Por Vencer";
            btnProductosPorVencer.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(41, 309);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(195, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnProductosPorVencer);
            Controls.Add(btnHistorialProducto);
            Controls.Add(btnProductosBajoStock);
            Controls.Add(btnMovimientosPorProveedor);
            Controls.Add(btnStockPorRubro);
            Controls.Add(btnStockActual);
            Name = "FormReportes";
            Text = "FormReportes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStockActual;
        private Button btnStockPorRubro;
        private Button btnMovimientosPorProveedor;
        private Button btnProductosBajoStock;
        private Button btnHistorialProducto;
        private Button btnProductosPorVencer;
        private Button btnVolver;
    }
}