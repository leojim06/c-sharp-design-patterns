using OrderSystem.Entities;
using OrderSystem.Reports;
using System;
using System.Collections.Generic;

namespace OrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrderRepository repository = new OrderDataBaseRepository();
            INotificationService notificationService = new EmailService();
            IInvoiceService invoiceService = new InvoiceDataBaseService();
            ILoggerService loggerService = new LoggerDataBaseService();

            OrderService orderService = new OrderService(
                repository,
                notificationService,
                invoiceService,
                loggerService);

            Order order = new Order(new Guid());
            order = new LocalOrder(new Guid());
            order = new InternationalOrder(new Guid());

            ReportingService report = new ReportingService(new JsonReportGenerator());
            report.GenerateReport(new List<Order> { order });

            orderService.SaveOrder(order);
        }
    }
}
