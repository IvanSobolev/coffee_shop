public class OrderManager : IOrderManager
{
    private IOrderRepository _orderRepository;

    public OrderManager(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public List<OrderTask> GetAllOrders()
    {
        return _orderRepository.GetAllOrders();
    }

    public void AddOrder(OrderTask order)
    {
        _orderRepository.AddOrder(order);
    }

    public void DeleteOrder(int id)
    {
        _orderRepository.DeleteOrder(id);
    }
}