using eCommerce.OrdersMicroservice.DataAccessLayer.Entities;
using eCommerce.OrdersMicroservice.DataAccessLayer.RepositoryContract;
using MongoDB.Driver;

namespace eCommerce.OrdersMicroservice.DataAccessLayer.Repositories;

public class OrderRepository : IOrdersRepository
{
    private readonly IMongoCollection<Order> _orders;
    private readonly string collectionName = "Orders";
    public OrderRepository(IMongoDatabase mongoDatabase)
    {
        _orders = mongoDatabase.GetCollection<Order>(collectionName);
    }
    public async Task<Order?> AddOrder(Order order)
    {
      order.OrderID = Guid.NewGuid();

       await _orders.InsertOneAsync(order);
        return order;

    }

    public async Task<Order?> DeleteOrder(Guid orderID)
    {
      FilterDefinition<Order> filter=  Builders<Order>.Filter.Eq(o => o.OrderID, orderID);
       Order? existingOrder = (await _orders.FindAsync(filter)).FirstOrDefault();
       if(existingOrder == null)
       {
        return null;
        }
     DeleteResult deleteResult=  await _orders.DeleteOneAsync(filter);

        return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0 ? existingOrder : null;
    }

    public async Task<Order?> GetOrderByContdition(FilterDefinition<Order> filter)
    {
    return (await  _orders.FindAsync(filter)).FirstOrDefault();
     
    }

    public async Task<IEnumerable<Order>> GetOrders()
    {
        return (await _orders.FindAsync(Builders<Order>.Filter.Empty)).ToList();
    }

    public async Task<IEnumerable<Order?>> GetOrdersByContdition(FilterDefinition<Order> filter)
    {
        return (await _orders.FindAsync(filter)).ToList();
    }

    public async Task<Order?> UpdateOrder(Order order)
    {
        FilterDefinition<Order> filter = Builders<Order>.Filter.Eq(o => o.OrderID, order.OrderID);
        Order? existingOrder = (await _orders.FindAsync(filter)).FirstOrDefault();
        if (existingOrder == null)
        {
            return null;
        }
       ReplaceOneResult replaceOneResult = await _orders.ReplaceOneAsync(filter, order);
        return order;
    }
}
