using System;

namespace IspModificado
{
    internal class ImpresoraLiquidInkjet : ITareasImpresora
    {
        public void Escanear(string contenidoAEscanear)
        {
            Console.WriteLine("Escaneo terminado");
        }

        public void Imprimir(string contenidoAImprimir)
        {
            Console.WriteLine("Impresion terminada");
        }
    }
}
