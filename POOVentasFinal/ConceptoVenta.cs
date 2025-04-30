namespace POOVentasFinal
{
    class ConceptoVenta
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe
        {
            get
            {
                return CalcularImporte();
            }
        }

        private decimal CalcularImporte()
        {
            return Cantidad * ValorUnitario;
        }
    }
}
