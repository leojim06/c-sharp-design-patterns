using System;

namespace SrpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de unica responsabilidad");
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de factura sin SRP");
            GenerarFacturaSinSRP();
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de factura con SRP");
            GenerarFacturaConSRP();
        }

        static void GenerarFacturaSinSRP()
        {
            SrpMalaPractica.Factura factura = new SrpMalaPractica.Factura();
            factura.AgregarFactura();
        }

        static void GenerarFacturaConSRP()
        {
            SrpModificado.Factura factura = new SrpModificado.Factura();
            factura.AgregarFactura();
        }
    }
}
