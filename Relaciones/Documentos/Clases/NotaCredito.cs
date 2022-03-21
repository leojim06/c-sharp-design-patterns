using System;

namespace Documentos.Clases
{
    public class NotaCredito : Documento
    {
        public NotaCredito() : base() { }

        public override void Imprimir() 
        {
            Console.WriteLine($"Imprimiendo nota de credito No. {_numero} con fecha {_fecha}");
        }
    }
}
