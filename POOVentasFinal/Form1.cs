namespace POOVentasFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVentaContado_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("contado");
            frmVenta.ShowDialog();
        }

        private void btnVentaCredito_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("credito");
            frmVenta.ShowDialog();
        }

        private void btnCortesia_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("cortesia");
            frmVenta.ShowDialog();
        }

        private void BtnVentaCredito_Click_1(object sender, EventArgs e)
        {
            FrmVenta frmventa = new FrmVenta("credito");
            frmventa.ShowDialog();
        }
    }
}
