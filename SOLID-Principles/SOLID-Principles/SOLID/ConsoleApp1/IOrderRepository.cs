using OrderSystem.Entities;

namespace OrderSystem
{
    public interface IOrderRepository
    {
        bool InsertOrder(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            // Code to Insert the order on the database
            return true;
        }
    }
}
