using FluentValidation;
using MusicStoreAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Services.Validators
{
    public class SongValidator : AbstractValidator<Song>
    {
        public SongValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(x => x.ArtistId)
                .NotEmpty()
                .WithMessage("Song MUST have a ArtistId");
        }
    }
}
