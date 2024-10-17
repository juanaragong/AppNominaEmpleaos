namespace WinFormsApp25
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtNumeroSeguro = new TextBox();
            txtDiasTrabajados = new TextBox();
            cbEmpleado = new ComboBox();
            btnCalcular = new Button();
            label1 = new Label();
            lsvDatos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(202, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtNumeroSeguro
            // 
            txtNumeroSeguro.Location = new Point(202, 163);
            txtNumeroSeguro.Name = "txtNumeroSeguro";
            txtNumeroSeguro.Size = new Size(150, 31);
            txtNumeroSeguro.TabIndex = 2;
            // 
            // txtDiasTrabajados
            // 
            txtDiasTrabajados.Location = new Point(202, 268);
            txtDiasTrabajados.Name = "txtDiasTrabajados";
            txtDiasTrabajados.Size = new Size(150, 31);
            txtDiasTrabajados.TabIndex = 3;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Items.AddRange(new object[] { "Profesor", "Mantenimiento", "Administrativo" });
            cbEmpleado.Location = new Point(202, 211);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(182, 33);
            cbEmpleado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(451, 132);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 52);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular Nomina";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 274);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 6;
            label1.Text = "Dias Trabajados";
            // 
            // lsvDatos
            // 
            lsvDatos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvDatos.GridLines = true;
            lsvDatos.Location = new Point(60, 354);
            lsvDatos.Name = "lsvDatos";
            lsvDatos.Size = new Size(465, 146);
            lsvDatos.TabIndex = 7;
            lsvDatos.UseCompatibleStateImageBehavior = false;
            lsvDatos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Numero Seguro";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dias Trabajados";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nomina Neta";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nomina Impuestos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(lsvDatos);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cbEmpleado);
            Controls.Add(txtDiasTrabajados);
            Controls.Add(txtNumeroSeguro);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtNumeroSeguro;
        private TextBox txtDiasTrabajados;
        private ComboBox cbEmpleado;
        private Button btnCalcular;
        private Label label1;
        private ListView lsvDatos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
