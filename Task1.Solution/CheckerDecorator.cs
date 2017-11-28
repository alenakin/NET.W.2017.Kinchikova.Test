using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public abstract class CheckerDecorator : PasswordChecker
    {
        PasswordChecker checker;

        public CheckerDecorator(IRepository repository, PasswordChecker checker) : base(repository)
        {
            this.checker = checker;
        }
    }
}
