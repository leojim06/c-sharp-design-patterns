using System;

namespace OcpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de abierto / cerrado");
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de factura sin OCP");
            GenerarFacturaSinOCP();
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de factura con OCP");
            GenerarFacturaConOCP();
        }

        private static void GenerarFacturaSinOCP()
        {
            OcpMalaPractica.Factura factura = new OcpMalaPractica.Factura();
            var descuentoFacturaFinal = factura.ObtenerDescuentoFactura(10_000, OcpMalaPractica.TipoFactura.FacturaFinal);
            Console.WriteLine("Descuento para factura final: " + descuentoFacturaFinal);
            
            var descuentoFacturaPropuesta = factura.ObtenerDescuentoFactura(10_000, OcpMalaPractica.TipoFactura.FacturaPropuesta);
            Console.WriteLine("Descuento para factura propuesta: " + descuentoFacturaPropuesta);
        }

        private static void GenerarFacturaConOCP()
        {
            OcpModificado.Factura facturaFinal = new OcpModificado.FacturaFinal();
            var descuentoFacturaFinal = facturaFinal.ObtenerDescuentoFactura(10_000);
            Console.WriteLine("Descuento para factura final: " + descuentoFacturaFinal);

            OcpModificado.Factura facturaPropuesta = new OcpModificado.FacturaPropuesta();
            var descuentoFacturaPropuesta = facturaPropuesta.ObtenerDescuentoFactura(10_000);
            Console.WriteLine("Descuento para factura final: " + descuentoFacturaPropuesta);
        }
    }
}
