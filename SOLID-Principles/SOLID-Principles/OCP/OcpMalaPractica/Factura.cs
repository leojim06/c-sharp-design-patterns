namespace OcpMalaPractica
{
    public class Factura
    {
        public double ObtenerDescuentoFactura(double cantidad, TipoFactura tipoFactura)
        {
            double cantidadFinal = 0;

            if (tipoFactura == TipoFactura.FacturaFinal)
            {
                cantidadFinal = cantidad - 100;
            }
            else if (tipoFactura == TipoFactura.FacturaPropuesta)
            {
                cantidadFinal = cantidad - 50;
            }

            return cantidadFinal;
        }
    }

    public enum TipoFactura
    {
        FacturaFinal,
        FacturaPropuesta,
        FacturaRecurrente
    }
}
