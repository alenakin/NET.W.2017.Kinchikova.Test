using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public abstract class PasswordChecker
    {
        protected IRepository repository;

        public PasswordChecker(IRepository repository)
        {
            this.repository = repository;
        }

        //public abstract Tuple<bool, string> VerifyPassword(string password)
        //{

        //}
    }
}
