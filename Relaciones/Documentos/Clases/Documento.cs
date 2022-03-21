﻿using Documentos.Interfaces;
using System;

namespace Documentos.Clases
{
    public class Documento : IImprimible
    {
        protected readonly DateTime _fecha;
        protected readonly int _numero;

        protected readonly Cliente _cliente;

        public Documento(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException($"{nameof(cliente)} no puede ser null");
            _cliente = cliente;
            _fecha = DateTime.Now;
            _numero = GenerarNumeroDocumento();
        }

        private int GenerarNumeroDocumento()
        {
            Random random = new Random();
            int numero = random.Next(1, 10000);
            return numero;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"Documento para: {this._cliente.Presentarse()}");
            Console.WriteLine($"Imprimiendo documento No. {_numero} con fecha {_fecha}");
        }

        public void AgregarItem(Item item) { }
    }
}
