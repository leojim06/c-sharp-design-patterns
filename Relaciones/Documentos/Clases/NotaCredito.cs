using System;

namespace Documentos.Clases
{
    public class NotaCredito : Documento
    {
        public NotaCredito(Cliente cliente) : base(cliente: cliente) { }

        public override void Imprimir() 
        {
            Console.WriteLine($"Nota de crédito para: {this._cliente.Presentarse()}");
            Console.WriteLine($"Imprimiendo nota de crédito No. {_numero} con fecha {_fecha}");
        }
    }
}
