using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new SqlRepository();
            var service = new PasswordCheckerService(repository);
            service.AddValidationRule(x =>
            {
                if (x == null)
                    throw new ArgumentException($"{x} is null arg");
                return Tuple.Create(true, "Password is Ok. User was created");
            }
            );

            service.AddValidationRule(x =>
            {
                if (x.Length <= 7)
                    return Tuple.Create(false, $"{x} length too short");
                return Tuple.Create(true, "Password is Ok. User was created");
            })
        }
    }
}
