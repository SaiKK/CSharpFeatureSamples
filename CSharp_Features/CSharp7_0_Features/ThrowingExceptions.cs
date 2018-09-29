using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features
{
    public class ThrowingExceptions
    {
        public void ThrowingExceptionsInExpressions()
        {
            string obj = null;

            string noException = obj ?? throw new Exception("Object is null");

            string[] names = {};
            string firstName = names.Length > 0 ? names[0] : throw new ApplicationException("Cannot set a default name");
        }

        public void ThrowingExceptionsInExpressionsOld()
        {
            string obj = null;

            string noException = obj ?? RaiseException();
        }

        public string RaiseException()
        {
            throw new Exception("Object is null");
        }
    }
}
