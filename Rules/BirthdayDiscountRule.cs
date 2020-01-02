using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Rules
{
    public class BirthdayDiscountRule: IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Lead lead)
        {
            return lead.IsBirthday() ? 0.10m : 0;
        }
    }
}
