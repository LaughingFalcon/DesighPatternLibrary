using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Rules
{
    public interface IDiscountRule
    {
        decimal CalculateCustomerDiscount(Lead lead);
    }
}
