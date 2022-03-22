using Documentos.Interfaces;
using System;
using System.Collections.Generic;

namespace Documentos.Clases
{
    public class Documento : IImprimible
    {
        protected readonly DateTime _fecha;
        protected readonly int _numero;

        protected readonly Cliente _cliente;
        private readonly List<Item> _items;

        public Sucursal Sucursal { get; set; }

        public Documento(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException($"{nameof(cliente)} no puede ser null");
            _cliente = cliente;
            _fecha = DateTime.Now;
            _numero = GenerarNumeroDocumento();
            _items = new List<Item>();
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

        public void AgregarItem(string descripcion, double precio, int cantidad)
        {
            Item nuevoItem = new Item(
                descripcion: descripcion,
                precio: precio,
                cantidad: cantidad);

            _items.Add(nuevoItem);
        }
    }
}
