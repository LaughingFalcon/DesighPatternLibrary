using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(object candidate);
        ISpecification And(ISpecification other);
        ISpecification AndNot(ISpecification other);
        ISpecification Or(ISpecification other);
        ISpecification OrNot(ISpecification other);
        ISpecification Not();
    }
}
