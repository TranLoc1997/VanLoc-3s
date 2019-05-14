//using System.Linq;
//using FluentValidation;
//using FluentValidation.Validators;
//using Microsoft.Extensions.Localization;
//using TaskUser.Models;
//
//namespace TaskUser.Validator
//{
//    public class UserValidator : AbstractValidator<User>
//    {
//
//        public UserValidator(IStringLocalizer<LoginValidator> localizer)
//        {
//          
//            RuleFor(x => x.Name).Length(1, 100).WithMessage(localizer["length from 1 to 50 characters"]);
//            RuleFor(x => x.Name).NotNull().WithMessage(localizer["Do not leave"]);;
//            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer["length from 1 to 50 characters"]);
//            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer["Do not leave"] );
//            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer["'Email' is not a valid email address."]);
//            RuleFor(x => x.PassWord).NotNull().WithMessage(localizer["Do not leave"]);
//            RuleFor(x => x.PassWord).MaximumLength(50).WithMessage(localizer["maximum length of 50 characters"]);
//            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(localizer["Minimum length of 6 characters"]);
//          //  RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$");
//            RuleFor(x => x.Phone).NotNull().WithMessage(localizer["Do not leave"]);            
//            RuleFor(x => x.IsActiver).NotNull().WithMessage(localizer["Do not leave"]);
//            
//        }
//    }
//
//}
