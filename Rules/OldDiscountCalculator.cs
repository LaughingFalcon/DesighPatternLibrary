using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Rules
{
    public class OldDiscountCalculator
    {
        static int now = 2019;
        public static decimal CalculateDiscountPercentage(Lead lead)
        {
            decimal discount = 0;
            if (lead.YearOfBirth < (now-65))
            {
                // senior discount 5%
                discount = .05m;
            }

            if (lead.DayOfBirth == DateTime.Today.Day &&
                lead.MonthOfBirth == DateTime.Today.Month)
            {
                // birthday 10%
                discount = Math.Max(discount, .10m);
            }

            if (lead.YearFirst!=-1)
            {
                if (lead.YearFirst < now-1)
                {
                    // after 1 year, loyal customers get 10%
                    discount = Math.Max(discount, .10m);
                    if (lead.YearFirst < (now-5))
                    {
                        // after 5 years, 12%
                        discount = Math.Max(discount, .12m);
                        if (lead.YearFirst < (now-10))
                        {
                            // after 10 years, 20%
                            discount = Math.Max(discount, .2m);
                        }
                    }

                    if (lead.DayOfBirth == DateTime.Today.Day &&
                        lead.MonthOfBirth == DateTime.Today.Month)
                    {
                        // birthday additional 10%
                        discount += .10m;
                    }
                }
            }
            else
            {
                // first time purchase discount of 15%
                discount = Math.Max(discount, .15m);
            }
            if (lead.IsVeteran)
            {
                // veterans get 10%
                discount = Math.Max(discount, .10m);
            }

            return discount;
        }
    }
}
