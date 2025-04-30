namespace POOVentasFinal
{
    partial class FrmVenta
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
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtValorUnitario = new TextBox();
            lblValorUnitario = new Label();
            btnAgregar = new Button();
            dgvConceptos = new DataGridView();
            btnEfectivo = new Button();
            btnTarjeta = new Button();
            lblCortesia = new Label();
            txtCortesia = new TextBox();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(36, 44);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(120, 44);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(183, 23);
            txtCantidad.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(120, 88);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(424, 23);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(36, 91);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(120, 139);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(183, 23);
            txtValorUnitario.TabIndex = 5;
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Location = new Point(36, 142);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(78, 15);
            lblValorUnitario.TabIndex = 4;
            lblValorUnitario.Text = "Valor Unitario";
            lblValorUnitario.Click += label3_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(429, 142);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvConceptos
            // 
            dgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConceptos.Location = new Point(572, 28);
            dgvConceptos.Name = "dgvConceptos";
            dgvConceptos.Size = new Size(383, 444);
            dgvConceptos.TabIndex = 7;
            // 
            // btnEfectivo
            // 
            btnEfectivo.Location = new Point(429, 189);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(75, 23);
            btnEfectivo.TabIndex = 8;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = true;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(429, 233);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(75, 23);
            btnTarjeta.TabIndex = 9;
            btnTarjeta.Text = "Tarjeta";
            btnTarjeta.UseVisualStyleBackColor = true;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // lblCortesia
            // 
            lblCortesia.AutoSize = true;
            lblCortesia.Location = new Point(68, 193);
            lblCortesia.Name = "lblCortesia";
            lblCortesia.Size = new Size(50, 15);
            lblCortesia.TabIndex = 10;
            lblCortesia.Text = "Cortesia";
            // 
            // txtCortesia
            // 
            txtCortesia.Location = new Point(120, 191);
            txtCortesia.Name = "txtCortesia";
            txtCortesia.Size = new Size(100, 23);
            txtCortesia.TabIndex = 11;
            txtCortesia.TextChanged += txtCortesia_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(416, 285);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 12;
            txtTotal.Text = "0.00";
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 515);
            Controls.Add(txtTotal);
            Controls.Add(txtCortesia);
            Controls.Add(lblCortesia);
            Controls.Add(btnTarjeta);
            Controls.Add(btnEfectivo);
            Controls.Add(dgvConceptos);
            Controls.Add(btnAgregar);
            Controls.Add(txtValorUnitario);
            Controls.Add(lblValorUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidad;
        private TextBox txtCantidad;
        private TextBox tctDescripcion;
        private Label lblDescripcion;
        private TextBox txtValorUnitario;
        private Label lblValorUnitario;
        private Button btnAgregar;
        private DataGridView dgvConceptos;
        private Button btnEfectivo;
        private Button btnTarjeta;
        private Label lblCortesia;
        private TextBox txtCortesia;
        private TextBox txtTotal;
        private TextBox txtDescripcion;
    }
}