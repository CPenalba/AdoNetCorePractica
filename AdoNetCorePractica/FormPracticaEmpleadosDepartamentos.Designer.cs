namespace AdoNetCorePractica
{
    partial class FormPracticaEmpleadosDepartamentos
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
            label1 = new Label();
            cmbDepartamentos = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            btnInsertarDepartamento = new Button();
            label5 = new Label();
            lstEmpleados = new ListBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtApellido = new TextBox();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            btnUpdate = new Button();
            txtId = new TextBox();
            labll = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(41, 54);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(213, 28);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 208);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 284);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Localidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 231);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(40, 307);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(214, 27);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertarDepartamento
            // 
            btnInsertarDepartamento.Location = new Point(40, 367);
            btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            btnInsertarDepartamento.Size = new Size(214, 60);
            btnInsertarDepartamento.TabIndex = 8;
            btnInsertarDepartamento.Text = "Insertar Departamento";
            btnInsertarDepartamento.UseVisualStyleBackColor = true;
            btnInsertarDepartamento.Click += btnInsertarDepartamento_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 31);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(340, 54);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(341, 364);
            lstEmpleados.TabIndex = 10;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(778, 31);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 109);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 12;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(778, 198);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 13;
            label8.Text = "Salario";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(778, 54);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 27);
            txtApellido.TabIndex = 14;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(778, 132);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(213, 27);
            txtOficio.TabIndex = 15;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(778, 221);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(213, 27);
            txtSalario.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(778, 288);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(213, 53);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(40, 156);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 27);
            txtId.TabIndex = 5;
            // 
            // labll
            // 
            labll.AutoSize = true;
            labll.Location = new Point(40, 133);
            labll.Name = "labll";
            labll.Size = new Size(22, 20);
            labll.TabIndex = 2;
            labll.Text = "Id";
            // 
            // FormPracticaEmpleadosDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(btnInsertarDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labll);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "FormPracticaEmpleadosDepartamentos";
            Text = "FormPracticaEmpleadosDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button btnInsertarDepartamento;
        private Label label5;
        private ListBox lstEmpleados;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtApellido;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Button btnUpdate;
        private TextBox txtId;
        private Label labll;
    }
}