using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını giriniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini giriniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini yükleyiniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığı en fazla 150 karakter olabilir.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığı en az 5 karakter olabilir.");
        }
    }
}
