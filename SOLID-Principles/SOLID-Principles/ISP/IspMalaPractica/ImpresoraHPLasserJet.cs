using System;

namespace IspMalaPractica
{
    internal class ImpresoraHPLasserJet : ITareasImpresora
    {
        public void Duplex(string contenidoAEnviarPorDuplex)
        {
            Console.WriteLine("Impresion duplex terminada");
        }

        public void Escanear(string contenidoAEscanear)
        {
            Console.WriteLine("Escaneo terminado");
        }

        public void Fax(string contenidoAEnviarPorFax)
        {
            Console.WriteLine("Envio de Fax terminado");
        }

        public void Imprimir(string contenidoAImprimir)
        {
            Console.WriteLine("Impresion terminada");
        }
    }
}
