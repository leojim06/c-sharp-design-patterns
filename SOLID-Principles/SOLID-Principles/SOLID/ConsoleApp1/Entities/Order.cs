using System;

namespace OrderSystem.Entities
{
    public class Order
    {
        protected Guid id;

        public Order(Guid id)
        {
            this.id = id;
        }
    }

    public class LocalOrder : Order, IImprimible, IAplicableImpuestos
    {
        public LocalOrder(Guid id) : base(id)
        {
        }

        public void AplicarImpuesto(double impuesto)
        {
            Console.WriteLine("Aplicando Impuesto");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo");
        }
    }

    public class InternationalOrder : Order, IImprimible
    {
        public InternationalOrder(Guid id) : base(id)
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo");
        }
    }

    public interface IImprimible
    {
        void Imprimir();
    }

    public interface IAplicableImpuestos
    {
        void AplicarImpuesto(double impuesto);
    }
}
