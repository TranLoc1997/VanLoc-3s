﻿using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels;

namespace TaskUser.Validator
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {

        public  LoginValidator(IUserService userService, SharedViewLocalizer<LoginValidatorResource> localizer){

            RuleFor(x => x.Email).Length(1, 100).WithMessage(localizer.GetLocalizedString("msg_LengthFrom1To100Characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty") );
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("msg_EmailIsNotAvalidEmailAddress"));
            RuleFor(x => x.PassWord).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(localizer.GetLocalizedString("msg_MinimumLengthOf6Characters"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(localizer.GetLocalizedString("msg_PasswordMustContainBothLetterSandNumbers."));
        }
    }
}
