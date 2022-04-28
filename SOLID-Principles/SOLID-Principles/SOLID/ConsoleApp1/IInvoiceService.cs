using OrderSystem.Entities;

namespace OrderSystem
{
    public interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }

    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            // Code to create Invoice
            return new Invoice();
        }
    }
}
