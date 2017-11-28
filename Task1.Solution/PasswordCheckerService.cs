using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        private Func<string, Tuple<bool, string>> validationRules;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public PasswordCheckerService(IRepository repository, Func<string, Tuple<bool, string>> validationRules)
        {
            this.repository = repository;
            this.validationRules += validationRules;
        }

        public void AddValidationRule(Func<string, Tuple<bool, string>> validationRule)
        {
            validationRules += validationRule;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (validationRules(password).Item1 == false)
            {

            }
        }
    }
}
