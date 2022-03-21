using Documentos.Clases;
using System;

namespace Documentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Documento doc = new Documento();
            doc.Imprimir();

            Console.ReadKey();
        }
    }
}
