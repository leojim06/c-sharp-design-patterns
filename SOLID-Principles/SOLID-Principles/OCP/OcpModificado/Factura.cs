namespace OcpModificado
{
    public class Factura
    {
        public virtual double ObtenerDescuentoFactura(double cantidad)
        {
            return cantidad;
        }
    }

    public class FacturaFinal : Factura
    {
        public override double ObtenerDescuentoFactura(double cantidad)
        {
            return base.ObtenerDescuentoFactura(cantidad) - 100;
        }
    }

    public class FacturaPropuesta : Factura
    {
        public override double ObtenerDescuentoFactura(double cantidad)
        {
            return base.ObtenerDescuentoFactura(cantidad) - 50;
        }
    }

    public class FacturaRecurrente : Factura
    {
        public override double ObtenerDescuentoFactura(double cantidad)
        {
            return base.ObtenerDescuentoFactura(cantidad) - 25;
        }
}
