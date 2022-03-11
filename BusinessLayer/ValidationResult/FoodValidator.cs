using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationResult
{
  public  class FoodValidator :AbstractValidator<Foods>
    {
        public FoodValidator()
        {
            RuleFor(x => x.FoodName).NotEmpty().WithMessage("bos gecilemez");

        }

    }
}
