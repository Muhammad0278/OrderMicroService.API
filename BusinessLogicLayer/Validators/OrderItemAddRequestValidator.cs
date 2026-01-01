

using eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.Validators
{
    public class OrderItemAddRequestValidator : AbstractValidator<OrderItemAddRequest>
    {
        public OrderItemAddRequestValidator()
        {
            RuleFor(temp => temp.ProductID).NotEmpty().WithErrorCode("ProductID cannot be empty");
            RuleFor(temp => temp.UnitPrice).NotEmpty().WithErrorCode("UnitPrice cannot be empty").GreaterThan(0).WithErrorCode("unite price can not be less then or equal to zero");
            RuleFor(temp => temp.Quantity).NotEmpty().WithErrorCode("Quantity cannot be empty").GreaterThan(0).WithErrorCode("Quantity can not be less then or equal to zero");

        }

    }
}
