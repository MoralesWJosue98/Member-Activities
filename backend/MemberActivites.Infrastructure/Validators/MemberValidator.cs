using FluentValidation;
using MemberActivities.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure.Validators
{
    public class MemberValidator : AbstractValidator<MemberDTO>
    {
        public MemberValidator() {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.email).NotNull();
            RuleFor(x => x.Address).NotNull();
           RuleFor(x => x.isMember).NotNull();

        }

    }
}
