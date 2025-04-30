namespace POOVentasFinal
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
            btnVentaContado = new Button();
            BtnVentaCredito = new Button();
            btnCortesia = new Button();
            SuspendLayout();
            // 
            // btnVentaContado
            // 
            btnVentaContado.Location = new Point(231, 190);
            btnVentaContado.Name = "btnVentaContado";
            btnVentaContado.Size = new Size(113, 23);
            btnVentaContado.TabIndex = 0;
            btnVentaContado.Text = "Venta Contado";
            btnVentaContado.UseVisualStyleBackColor = true;
            btnVentaContado.Click += btnVentaContado_Click;
            // 
            // BtnVentaCredito
            // 
            BtnVentaCredito.Location = new Point(567, 190);
            BtnVentaCredito.Name = "BtnVentaCredito";
            BtnVentaCredito.Size = new Size(108, 23);
            BtnVentaCredito.TabIndex = 0;
            BtnVentaCredito.Text = "Venta Credito";
            BtnVentaCredito.UseVisualStyleBackColor = true;
            BtnVentaCredito.Click += BtnVentaCredito_Click_1;
            // 
            // btnCortesia
            // 
            btnCortesia.Location = new Point(393, 190);
            btnCortesia.Name = "btnCortesia";
            btnCortesia.Size = new Size(115, 23);
            btnCortesia.TabIndex = 1;
            btnCortesia.Text = "Venta Cortesia";
            btnCortesia.UseVisualStyleBackColor = true;
            btnCortesia.Click += btnCortesia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 600);
            Controls.Add(btnCortesia);
            Controls.Add(BtnVentaCredito);
            Controls.Add(btnVentaContado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentaContado;
        private Button BtnVentaCredito;
        private Button btnCortesia;
    }
}
