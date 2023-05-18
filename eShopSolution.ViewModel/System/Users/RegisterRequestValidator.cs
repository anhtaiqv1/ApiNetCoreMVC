using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.System.Users
{
    public class RegisterRequestValidator :AbstractValidator<RegisterRequest>
    {
       public RegisterRequestValidator() 
        {  
            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("FirstName is requierd ").MaximumLength(200)
                .WithMessage("FirstName can not over 200 characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is requierd ").MaximumLength(200)
                .WithMessage("LastName can not over 200 characters");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birth day can not greater than 100 year");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").Matches(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`
             {|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");

            RuleFor(x => x.Password).NotEmpty().WithMessage("PassWord is required")
            .MinimumLength(6).WithMessage("PassWord is at least 6 characters");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassWord)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
                

        }
    }
}
