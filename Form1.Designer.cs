namespace TheGlory
{
    partial class btnProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnInventario = new Button();
            btnProveedores = new Button();
            btnprod = new Button();
            btncategoria = new Button();
            pictureBox1 = new PictureBox();
            btnNuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBuscarCodigo = new TextBox();
            dataGridView1 = new DataGridView();
            dgvProducto = new DataGridViewTextBoxColumn();
            dgvCategoría = new DataGridViewTextBoxColumn();
            dgvStock = new DataGridViewTextBoxColumn();
            dgActualizacion = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewTextBoxColumn();
            btnVer = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 58, 38);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnprod);
            panel1.Controls.Add(btncategoria);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 671);
            panel1.TabIndex = 1;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = SystemColors.ButtonHighlight;
            btnInventario.Location = new Point(24, 423);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(171, 57);
            btnInventario.TabIndex = 11;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += button2_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(97, 58, 38);
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = SystemColors.ButtonHighlight;
            btnProveedores.Location = new Point(24, 340);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(171, 55);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnprod
            // 
            btnprod.BackColor = Color.FromArgb(97, 58, 38);
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprod.ForeColor = SystemColors.ButtonHighlight;
            btnprod.Location = new Point(24, 183);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(171, 59);
            btnprod.TabIndex = 9;
            btnprod.Text = "Productos";
            btnprod.UseVisualStyleBackColor = false;
            btnprod.Click += btnprod_Click;
            // 
            // btncategoria
            // 
            btncategoria.BackColor = Color.FromArgb(97, 58, 38);
            btncategoria.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btncategoria.FlatAppearance.BorderSize = 0;
            btncategoria.FlatStyle = FlatStyle.Flat;
            btncategoria.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategoria.ForeColor = SystemColors.ButtonHighlight;
            btncategoria.Location = new Point(24, 267);
            btncategoria.Name = "btncategoria";
            btncategoria.Size = new Size(171, 53);
            btncategoria.TabIndex = 9;
            btncategoria.Text = "Categorías";
            btncategoria.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(168, 91, 50);
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(790, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(254, 66);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "     Nuevo Producto";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(168, 91, 50);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(800, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 54);
            label1.TabIndex = 5;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(97, 58, 38);
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(258, 9);
            label2.Name = "label2";
            label2.Size = new Size(482, 62);
            label2.TabIndex = 6;
            label2.Text = "Listado de Productos";
            label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscarNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBuscarCodigo);
            panel2.Location = new Point(258, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 90);
            panel2.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(168, 91, 50);
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(602, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 56);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(301, 46);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(260, 31);
            txtBuscarNombre.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(17, 12);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 10;
            label3.Text = "código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(301, 12);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 11;
            label4.Text = "Nombre:";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(17, 46);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(265, 31);
            txtBuscarCodigo.TabIndex = 12;
            txtBuscarCodigo.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(97, 58, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvProducto, dgvCategoría, dgvStock, dgActualizacion, Column5, btnEditar, btnVer, btnEliminar });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(258, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(786, 225);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvProducto
            // 
            dgvProducto.HeaderText = "Producto";
            dgvProducto.MinimumWidth = 8;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            // 
            // dgvCategoría
            // 
            dgvCategoría.HeaderText = "Categoría";
            dgvCategoría.MinimumWidth = 8;
            dgvCategoría.Name = "dgvCategoría";
            dgvCategoría.ReadOnly = true;
            // 
            // dgvStock
            // 
            dgvStock.HeaderText = "Stock";
            dgvStock.MinimumWidth = 8;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            // 
            // dgActualizacion
            // 
            dgActualizacion.HeaderText = "Última actualización";
            dgActualizacion.MinimumWidth = 8;
            dgActualizacion.Name = "dgActualizacion";
            dgActualizacion.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Acciones";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.UseColumnTextForButtonValue = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 8;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            // 
            // btnVer
            // 
            btnVer.HeaderText = "Ver";
            btnVer.MinimumWidth = 8;
            btnVer.Name = "btnVer";
            btnVer.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 8;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            // 
            // btnProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1215, 671);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "btnProductos";
            Text = "Categorías";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnNuevo;
        private Label label1;
        private Label label2;
        private Button btncategoria;
        private Button btnprod;
        private Button btnInventario;
        private Button btnProveedores;
        private Panel panel2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtBuscarCodigo;
        private TextBox txtBuscarNombre;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn dgvProducto;
        private DataGridViewTextBoxColumn dgvCategoría;
        private DataGridViewTextBoxColumn dgvStock;
        private DataGridViewTextBoxColumn dgActualizacion;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn btnEditar;
        private DataGridViewTextBoxColumn btnVer;
        private DataGridViewTextBoxColumn btnEliminar;
    }
}
