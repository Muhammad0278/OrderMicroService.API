

using eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.Validators
{
    public class OrderUpdateRequestValidator : AbstractValidator<OrderUpdateRequest>
    {
        public OrderUpdateRequestValidator()
        {
            //OrderID
            RuleFor(temp => temp.OrderID).NotEmpty().WithErrorCode("OrderID can not be blank");
            //UserID
            RuleFor(temp => temp.UserID).NotEmpty().WithErrorCode("UserID can not be blank");
            //OrderDate
            RuleFor(temp => temp.OrderDate).NotEmpty().WithErrorCode("Order Date can not be blank");
            //OrderItems
            RuleFor(temp => temp.OrderItems).NotEmpty().WithErrorCode("Order Items can not be blank");
        }

    }
}
