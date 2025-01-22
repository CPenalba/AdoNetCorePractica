namespace AdoNetCorePractica
{
    partial class FormEmpleadosHospitales
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
            cmbHospitales = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            label5 = new Label();
            lstEmpleadosHospital = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(46, 60);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(253, 28);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 169);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Suma salarial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 252);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 3;
            label3.Text = "Media salarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 341);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 4;
            label4.Text = "Personas";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(46, 192);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(178, 27);
            txtSuma.TabIndex = 5;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(46, 275);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(178, 27);
            txtMedia.TabIndex = 6;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(46, 364);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(178, 27);
            txtPersonas.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 37);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 8;
            label5.Text = "Empleados Hospital";
            // 
            // lstEmpleadosHospital
            // 
            lstEmpleadosHospital.FormattingEnabled = true;
            lstEmpleadosHospital.Location = new Point(360, 60);
            lstEmpleadosHospital.Name = "lstEmpleadosHospital";
            lstEmpleadosHospital.Size = new Size(400, 324);
            lstEmpleadosHospital.TabIndex = 9;
            lstEmpleadosHospital.SelectedIndexChanged += lstEmpleadosHospital_SelectedIndexChanged;
            // 
            // FormEmpleadosHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleadosHospital);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "FormEmpleadosHospitales";
            Text = "FormEmpleadosHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
        private Label label5;
        private ListBox lstEmpleadosHospital;
    }
}