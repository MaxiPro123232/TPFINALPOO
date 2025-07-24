namespace TPFINAL
{
    partial class FormGestionRubros
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
            txtNombreRubro = new TextBox();
            txtDescripcionRubro = new TextBox();
            btnAgregarRubro = new Button();
            btnModificarRubro = new Button();
            btnEliminarRubro = new Button();
            btnListarRubros = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            lstRubros = new ListBox();
            SuspendLayout();
            // 
            // txtNombreRubro
            // 
            txtNombreRubro.Location = new Point(146, 36);
            txtNombreRubro.Name = "txtNombreRubro";
            txtNombreRubro.Size = new Size(100, 23);
            txtNombreRubro.TabIndex = 0;
            // 
            // txtDescripcionRubro
            // 
            txtDescripcionRubro.Location = new Point(146, 91);
            txtDescripcionRubro.Name = "txtDescripcionRubro";
            txtDescripcionRubro.Size = new Size(100, 23);
            txtDescripcionRubro.TabIndex = 1;
            // 
            // btnAgregarRubro
            // 
            btnAgregarRubro.Location = new Point(64, 148);
            btnAgregarRubro.Name = "btnAgregarRubro";
            btnAgregarRubro.Size = new Size(134, 23);
            btnAgregarRubro.TabIndex = 2;
            btnAgregarRubro.Text = "Agregar Rubro";
            btnAgregarRubro.UseVisualStyleBackColor = true;
            // 
            // btnModificarRubro
            // 
            btnModificarRubro.Location = new Point(64, 183);
            btnModificarRubro.Name = "btnModificarRubro";
            btnModificarRubro.Size = new Size(134, 23);
            btnModificarRubro.TabIndex = 3;
            btnModificarRubro.Text = "Modificar Rubro";
            btnModificarRubro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRubro
            // 
            btnEliminarRubro.Location = new Point(64, 212);
            btnEliminarRubro.Name = "btnEliminarRubro";
            btnEliminarRubro.Size = new Size(134, 23);
            btnEliminarRubro.TabIndex = 4;
            btnEliminarRubro.Text = "Eliminar Rubro";
            btnEliminarRubro.UseVisualStyleBackColor = true;
            // 
            // btnListarRubros
            // 
            btnListarRubros.Location = new Point(64, 241);
            btnListarRubros.Name = "btnListarRubros";
            btnListarRubros.Size = new Size(134, 23);
            btnListarRubros.TabIndex = 5;
            btnListarRubros.Text = "Listar Rubros";
            btnListarRubros.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(64, 270);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre Rubro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripcion Rubro:";
            // 
            // lstRubros
            // 
            lstRubros.FormattingEnabled = true;
            lstRubros.ItemHeight = 15;
            lstRubros.Location = new Point(319, 36);
            lstRubros.Name = "lstRubros";
            lstRubros.Size = new Size(338, 244);
            lstRubros.TabIndex = 9;
            // 
            // FormGestionRubros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 321);
            Controls.Add(lstRubros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnListarRubros);
            Controls.Add(btnEliminarRubro);
            Controls.Add(btnModificarRubro);
            Controls.Add(btnAgregarRubro);
            Controls.Add(txtDescripcionRubro);
            Controls.Add(txtNombreRubro);
            Name = "FormGestionRubros";
            Text = "FormGestionRubros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreRubro;
        private TextBox txtDescripcionRubro;
        private Button btnAgregarRubro;
        private Button btnModificarRubro;
        private Button btnEliminarRubro;
        private Button btnListarRubros;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private ListBox lstRubros;
    }
}