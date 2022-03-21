using Documentos.Interfaces;
using System;

namespace Documentos.Clases
{
    public class Documento : IImprimible
    {
        protected readonly DateTime _fecha;
        protected readonly int _numero;

        public Documento()
        {
            this._fecha = DateTime.Now;
            this._numero = GenerarNumeroDocumento();
        }

        private int GenerarNumeroDocumento()
        {
            Random random = new Random();
            int numero = random.Next(1, 10000);
            return numero;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"Imprimiendo documento No. {_numero} con fecha {_fecha}");
        }

        public void AgregarItem(Item item) { } 
    }
}
