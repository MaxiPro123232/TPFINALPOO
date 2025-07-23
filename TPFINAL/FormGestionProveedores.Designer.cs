namespace TPFINAL
{
    partial class FormGestionProveedores
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
            txtNombreProveedor = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtContacto = new TextBox();
            btnAgregarProveedor = new Button();
            btnModificarProveedor = new Button();
            btnEliminarProveedor = new Button();
            btnBuscarProveedor = new Button();
            btnListarProveedores = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(139, 43);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(100, 23);
            txtNombreProveedor.TabIndex = 0;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(139, 203);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(139, 156);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(139, 101);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 3;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(340, 38);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(146, 23);
            btnAgregarProveedor.TabIndex = 4;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(340, 91);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(146, 23);
            btnModificarProveedor.TabIndex = 5;
            btnModificarProveedor.Text = "Modificar Proveedor";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(340, 135);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(146, 23);
            btnEliminarProveedor.TabIndex = 6;
            btnEliminarProveedor.Text = "Eliminar Proveedor";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Location = new Point(340, 178);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(146, 23);
            btnBuscarProveedor.TabIndex = 7;
            btnBuscarProveedor.Text = "Buscar Proveedor";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnListarProveedores
            // 
            btnListarProveedores.Location = new Point(340, 228);
            btnListarProveedores.Name = "btnListarProveedores";
            btnListarProveedores.Size = new Size(146, 23);
            btnListarProveedores.TabIndex = 8;
            btnListarProveedores.Text = "Listar Proveedores";
            btnListarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(340, 278);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(146, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 11;
            label2.Text = "Contacto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 164);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 211);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // FormGestionProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 341);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnListarProveedores);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnModificarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(txtContacto);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreProveedor);
            Name = "FormGestionProveedores";
            Text = "FormGestionProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProveedor;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtContacto;
        private Button btnAgregarProveedor;
        private Button btnModificarProveedor;
        private Button btnEliminarProveedor;
        private Button btnBuscarProveedor;
        private Button btnListarProveedores;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}