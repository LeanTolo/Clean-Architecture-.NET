using FluentValidation;
using MusicStoreAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Services.Validators
{
    public class ArtistValidator : AbstractValidator<Artist>
    {
        public ArtistValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(x => x.SurName)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}
