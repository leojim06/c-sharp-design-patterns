﻿using System;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de unica responsabilidad");
            Console.WriteLine("Ejemplo de factura sin SRP");
            GenerarFacturaSinSRP();
            Console.WriteLine("Ejemplo de factura con SRP");
            GenerarFacturaConSRP();
        }

        static void GenerarFacturaSinSRP()
        {
            SRP.NoSRP.Factura factura = new SRP.NoSRP.Factura();
        }

        static void GenerarFacturaConSRP()
        {
            SRP.SRP.Factura factura = new SRP.SRP.Factura();
        }
    }
}
