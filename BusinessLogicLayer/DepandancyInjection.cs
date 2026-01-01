using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using eCommerce.OrdersMicroservice.BusinessLogicLayer.Validators;

namespace eCommerce.OrdersMicroservice.BusinessLogicLayer;

public static class DependancyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {

      
        services.AddValidatorsFromAssemblyContaining<OrderAddRequestValidator>();
        return services;
    }
}
