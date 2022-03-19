using System;

namespace LspConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de sustitucion de Liskov");
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de fruta sin LSP");
            ObtenerFrutaSinLSP();
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de fruta con LSP");
            ObtenerFrutaConLSP();
        }

        private static void ObtenerFrutaSinLSP()
        {
            ManzanaSinLsp manzana = new NaranjaSinLsp();
            Console.WriteLine(manzana.ObtenerColor());
        }

        private static void ObtenerFrutaConLSP()
        {
            Fruta fruta = new Naranja();
            Console.WriteLine(fruta.ObtenerColor());

            fruta = new Manzana();
            Console.WriteLine(fruta.ObtenerColor());
        }
    }
}
