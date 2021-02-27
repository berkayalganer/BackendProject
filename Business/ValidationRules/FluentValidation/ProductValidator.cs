using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        // Kurallar ctor içine yazılır. Dtolar içinde aynı mantık.
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            // Kategori idsi 1 ise minimum fiyat 10 birim olmalı.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            // Kendi kuralımızı yazmak
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı.");
        }
        private bool StartWithA(string arg)
        {
            // A ile başlıyorsa true döner.
            return arg.StartsWith("A");
        }
    }
}
