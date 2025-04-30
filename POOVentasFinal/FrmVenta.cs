using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOVentasFinal
{
    public partial class FrmVenta : Form
    {

        private Venta _venta;
        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();

            if (tipoVenta == "credito")
            {

                _venta = new VentaCredito();
                this.Text = "Venta de Credito";
                txtCortesia.Text = "No";
                btnTarjeta.Visible = false;
                btnEfectivo.Visible = false;

            }
            else if (tipoVenta == "Contado")
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
                txtCortesia.Text = "No";
                btnTarjeta.Visible = true;
                btnEfectivo.Visible = true;
            }
            else
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesia";
                txtCortesia.Text = "No";
                btnTarjeta.Visible = true;
                btnEfectivo.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            FormaPagoTarjeta tarjeta = new FormaPagoTarjeta();
            AplicarPago(tarjeta);
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvConceptos.DataSource = null;

            ConceptoVenta concepto = new ConceptoVenta();
            concepto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            concepto.Descripcion = txtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text);
            _venta.Conceptos.Add(concepto);

            dgvConceptos.DataSource = _venta.Conceptos;

            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            txtTotal.Text = _venta.Total.ToString();
            txtCantidad.Focus();

        }

        private void txtCortesia_TextChanged(object sender, EventArgs e)
        {
            if (txtCortesia.Text.ToLower() == "Si")
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesia";
            }
            else
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            FormaPagoEfectivo efectivo = new FormaPagoEfectivo();
            AplicarPago(efectivo);
        }
        void AplicarPago(IFormaPago formaPago) 
        {
            formaPago.Cobrar(_venta.Total);
        }
    }
}
