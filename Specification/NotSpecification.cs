using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Specification
{
    public class NotSpecification : CompositeSpecification
    {
        private ISpecification Wrapped;

        public NotSpecification(ISpecification x)
        {
            Wrapped = x;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return !Wrapped.IsSatisfiedBy(candidate);
        }
    }
}
