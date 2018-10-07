using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_1_Features
{
    public class AsynchronousMainMethod
    {
        public static void Main(string[] args)
        {
            MyMainAsync(args).GetAwaiter().GetResult();
        }

        public static async Task MyMainAsync(string[] args)
        {
            //Do Some Logic here.
        }
    }

    public class AsynchronousMainMethod_7_1
    {
        public static async Task Main(string[] args)
        {
            //Do Some Logic here.
        }

    }
}
