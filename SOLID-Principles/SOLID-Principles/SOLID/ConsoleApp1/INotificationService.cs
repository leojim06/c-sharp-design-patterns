using OrderSystem.Entities;

namespace OrderSystem
{
    public interface INotificationService
    {
        bool NotifyInvoice(Invoice invoice);
    }

    public class EmailService : INotificationService
    {
        public bool NotifyInvoice(Invoice invoice)
        {
            //Code to email Invoice
            return true;
        }
    }
}
