public interface IOrderRepository
{
    List<OrderTask> GetAllOrders();
    void AddOrder(OrderTask order);
    void DeleteOrder(int id);
}