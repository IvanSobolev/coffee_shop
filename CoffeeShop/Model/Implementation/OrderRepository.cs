public class OrderRepository : IOrderRepository
{
    private readonly OrderContext _context;

    public OrderRepository(OrderContext context)
    {
        _context = context;
    }

    public List<OrderTask> GetAllOrders()
    {
        return _context.OrderTasks.ToList();
    }

    public void AddOrder(OrderTask order)
    {
        _context.OrderTasks.Add(order);
        _context.SaveChanges();
    }

    public void DeleteOrder(int id)
    {
        var task = _context.OrderTasks.FirstOrDefault(t => t.Id == id);
        if(task != null)
        {
            _context.OrderTasks.Remove(task);
            _context.SaveChanges();
        }
    }
}