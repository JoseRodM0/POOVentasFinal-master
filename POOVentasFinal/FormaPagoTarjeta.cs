namespace POOVentasFinal
{
    public class FormaPagoTarjeta : IFormaPago
    {
        public void Cobrar(decimal total) 
        {
            MessageBox.Show("Esperando terminal...");
            MessageBox.Show("El codigo fue aprobado! :D");
        }
    }
}
