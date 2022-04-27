using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace FluentValidationDemo.Models
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Address).NotEmpty();
        }
    }
}