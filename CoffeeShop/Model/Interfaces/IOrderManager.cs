public interface IOrderManager
{
    List<OrderTask> GetAllOrders();
    void AddOrder(OrderTask order);
    void DeleteOrder(int id);
}