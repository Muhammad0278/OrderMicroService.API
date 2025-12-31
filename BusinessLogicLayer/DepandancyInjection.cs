using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace eCommerce.OrdersMicroservice.BusinessLogicLayer;

public static class DependancyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {

        //services.AddDbContext<OrderDbContext>(options =>
        //    options.UseSqlServer(configuration.GetConnectionString("OrderDatabase")));
        //// Register repositories
        //services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }
}
