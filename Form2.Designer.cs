namespace TheGlory
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nudPrecio = new NumericUpDown();
            nudStock = new NumericUpDown();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(97, 58, 38);
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 45);
            label1.TabIndex = 0;
            label1.Text = "  Datos del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 183);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 3;
            label4.Text = "Descripción:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 450);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 4;
            label5.Text = "Categoría:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 289);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 5;
            label6.Text = "Precio Unitario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 343);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 6;
            label7.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 396);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 7;
            label8.Text = "Proveedor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 498);
            label9.Name = "label9";
            label9.Size = new Size(77, 28);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(119, 76);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(237, 31);
            txtCodigo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(149, 183);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 80);
            txtDescripcion.TabIndex = 11;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(178, 290);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(180, 31);
            nudPrecio.TabIndex = 12;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(94, 343);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 13;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(139, 396);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 14;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(139, 450);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 33);
            cmbCategoria.TabIndex = 15;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbEstado.Location = new Point(139, 489);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(168, 91, 50);
            btnGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(36, 571);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 42);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 91, 50);
            btnCancelar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(257, 571);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 42);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(484, 627);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbProveedor);
            Controls.Add(nudStock);
            Controls.Add(nudPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Datos del Producto";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}