using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Decorators
{
    //public class NullArgChecker : CheckerDecorator
    //{
    //    public override Tuple<bool, string> VerifyPassword(string password)
    //    {
    //        Tuple<bool, string> prev = checker.VerifyPassword(password);
    //        if (prev.Item1 == false)
    //            return prev;

    //        if (password == null)
    //            throw new ArgumentException($"{password} is null arg");

    //        return Tuple.Create(true, "Password is Ok");
    //    }
    //}
}
