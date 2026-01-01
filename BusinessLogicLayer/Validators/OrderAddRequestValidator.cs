

using eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.Validators
{
    public class OrderAddRequestValidator : AbstractValidator<OrderAddRequest>
    {
        public OrderAddRequestValidator()
        {
            RuleFor(temp => temp.UserID).NotEmpty().WithErrorCode("UserID cannot be empty");
            RuleFor(temp => temp.OrderDate).NotEmpty().WithErrorCode("OrderDate cannot be empty");
            RuleFor(temp => temp.OrderItems).NotEmpty().WithErrorCode("OrderItems cannot be empty");
        }
    }
}
