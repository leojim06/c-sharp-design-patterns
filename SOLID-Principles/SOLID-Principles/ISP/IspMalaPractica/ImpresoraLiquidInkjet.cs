using System;

namespace IspMalaPractica
{
    internal class ImpresoraLiquidInkjet : ITareasImpresora
    {
        public void Duplex(string contenidoAEnviarPorDuplex)
        {
            throw new NotImplementedException();
        }

        public void Escanear(string contenidoAEscanear)
        {
            Console.WriteLine("Escaneo terminado");
        }

        public void Fax(string contenidoAEnviarPorFax)
        {
            throw new NotImplementedException();
        }

        public void Imprimir(string contenidoAImprimir)
        {
            Console.WriteLine("Impresion terminada");
        }
    }
}
