using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.System.Users
{
    public class LoginRequestValidator : AbstractValidator <LoginRequest>
    {
        public LoginRequestValidator() 
        { 
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x=> x.Password).NotEmpty().WithMessage("PassWord is required")
            .MinimumLength(6).WithMessage("PassWord is at least 6 characters");
        }
    }
}
