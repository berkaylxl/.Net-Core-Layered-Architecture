using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class TopicValidator:AbstractValidator<Topic>
    {
        public TopicValidator()
        {
            RuleFor(p => p.Title).MinimumLength(3);
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.TopicText).NotEmpty();
        }

    }
}
