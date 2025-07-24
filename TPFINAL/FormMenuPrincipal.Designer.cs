namespace TPFINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProductos = new Button();
            btnRubros = new Button();
            btnProveedores = new Button();
            btnReportes = new Button();
            btnMovimientos = new Button();
            btnIntegrantes = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(32, 23);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(151, 23);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Gestion de Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnRubros
            // 
            btnRubros.Location = new Point(32, 68);
            btnRubros.Name = "btnRubros";
            btnRubros.Size = new Size(151, 23);
            btnRubros.TabIndex = 1;
            btnRubros.Text = "Gestion de Rubros";
            btnRubros.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(32, 116);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(151, 23);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Gestion de Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(32, 229);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(151, 23);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(32, 176);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(151, 23);
            btnMovimientos.TabIndex = 4;
            btnMovimientos.Text = "Gestion de Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.Location = new Point(32, 292);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(151, 23);
            btnIntegrantes.TabIndex = 5;
            btnIntegrantes.Text = "Integrantes del Desarrollo";
            btnIntegrantes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(214, 150);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 336);
            Controls.Add(btnSalir);
            Controls.Add(btnIntegrantes);
            Controls.Add(btnMovimientos);
            Controls.Add(btnReportes);
            Controls.Add(btnProveedores);
            Controls.Add(btnRubros);
            Controls.Add(btnProductos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnRubros;
        private Button btnProveedores;
        private Button btnReportes;
        private Button btnMovimientos;
        private Button btnIntegrantes;
        private Button btnSalir;
    }
}
