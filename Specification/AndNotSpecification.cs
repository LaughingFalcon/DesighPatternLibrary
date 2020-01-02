using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Specification
{
    public class AndNotSpecification : CompositeSpecification
    {
        private ISpecification leftCondition;
        private ISpecification rightCondition;

        public AndNotSpecification(ISpecification left, ISpecification right)
        {
            leftCondition = left;
            rightCondition = right;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return leftCondition.IsSatisfiedBy(candidate) && rightCondition.IsSatisfiedBy(candidate) != true;
        }
    }
}
