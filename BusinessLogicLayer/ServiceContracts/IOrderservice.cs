
using eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;
using eCommerce.OrdersMicroservice.DataAccessLayer.Entities;
using MongoDB.Driver;
namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.ServiceContracts;

public interface IOrderservice 
{
    // return list of orders from order repository
    Task<List<OrderResponse?>> GetOrders();

    // return list of orders based on filter condition
    Task<List<OrderResponse?>> GetOrdersByCondition(FilterDefinition<Order> filter);
    // retrive single order on base of condition
    Task<OrderResponse?> GetOrderByCondition(FilterDefinition<Order> filter);

    // insert ofrder into collection using orders repository
    Task<OrderResponse?> AddOrder(OrderAddRequest orderAddRequest);

    Task<OrderResponse?> UpdateOrder(OrderUpdateRequest orderUpdateRequest);
    Task<bool> DeleteOrder(Guid orderID);
}
