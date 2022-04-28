using OrderSystem.Entities;

namespace OrderSystem
{
    public interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }

    public class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            //Code to email Invoice
            return true;
        }
    }
}
