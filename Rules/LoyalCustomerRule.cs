using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Rules
{
    public class LoyalCustomerRule : IDiscountRule
    {
        private readonly int _yearsAsCustomer;
        private readonly decimal _discount;
        private readonly int _date;

        public LoyalCustomerRule(int yearsAsCustomer, decimal discount)
        {
            _yearsAsCustomer = yearsAsCustomer;
            _discount = discount;
            _date = 2019;
        }

        public decimal CalculateCustomerDiscount(Lead lead)
        {
            if (_date-lead.YearFirst >= _yearsAsCustomer)
            {
                var birthdayRule = new BirthdayDiscountRule();

                return _discount + birthdayRule.CalculateCustomerDiscount(lead);
            }
            return 0;
        }
    }
}
