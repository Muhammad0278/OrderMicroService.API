

using eCommerce.OrdersMicroservice.DataAccessLayer.Entities;
using MongoDB.Driver;

namespace  eCommerce.OrdersMicroservice.DataAccessLayer.RepositoryContract;

    public interface IOrdersRepository
    {
    Task<IEnumerable<Order>> GetOrders();
    Task<IEnumerable<Order?>> GetOrdersByContdition(FilterDefinition<Order> filter);
    Task<Order?> GetOrderByContdition(FilterDefinition<Order> filter);

    Task<Order?> AddOrder(Order order);
    Task<Order?> UpdateOrder(Order order);

    Task<Order?> DeleteOrder(Guid OrderID);
}

