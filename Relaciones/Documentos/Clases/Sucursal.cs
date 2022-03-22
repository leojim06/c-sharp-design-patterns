using System;
using System.Collections.Generic;

namespace Documentos.Clases
{
    public class Sucursal
    {
        private readonly string _direccion;
        private List<Documento> _documentos;

        public Sucursal(string direccion)
        {
            _direccion = direccion;
            _documentos = new List<Documento>();
        }

        public void Agregar(Documento documento)
        {
            if (documento == null)
                throw new ArgumentNullException($"{nameof(documento)} no puede ser nulo");
            _documentos.Add(documento);
        }

        public IReadOnlyCollection<Documento> Documentos
        {
            get { return _documentos.AsReadOnly(); }
        }
    }
}
