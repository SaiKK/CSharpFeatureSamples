using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features
{
    public class ExpressionBodiesOld
    {
        private string _myName;

        public string MyName
        {
            get
            {
                return _myName;
            }
            set
            {
                if (value != null)
                    _myName = value;
                else
                    throw new ApplicationException("Cannot be null");
            }
        }

        public ExpressionBodiesOld(string name)
        {
            MyName = name;
        }

        ~ExpressionBodiesOld()
        {
            Console.WriteLine("Released");
        }
        
    }
    public class ExpressionBodies
    {
        private string _myName;

        public string MyName
        {
            // Expression bodied get accessor
            get => _myName;
            // Expression bodied set accessor along with exception expression
            set => _myName = value ?? throw new ApplicationException("Cannot be null");
        }

        // Expression bodied constructor
        public ExpressionBodies(string name) => MyName = name;
        
        // Expression bodied finalizer
        ~ExpressionBodies() => Console.WriteLine("Released");
        
    }
}
