﻿using OrderSystem.Entities;
using System;

namespace OrderSystem
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;

        public OrderService(IOrderRepository orderRepository,
            INotificationService notificationService,
            IInvoiceService invoiceService,
            ILoggerService loggerService = null)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InsertOrder(order);

                Invoice invoice = _invoiceService.CreateInvoice(order);

                _notificationService.NotifyInvoice(invoice);

                _loggerService.Info("The order has been complete");
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message, e);
            }
        }

    }
}
