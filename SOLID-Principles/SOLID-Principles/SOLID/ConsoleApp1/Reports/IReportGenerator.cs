using OrderSystem.Entities;
using System.Collections.Generic;

namespace OrderSystem.Reports
{
    public interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
