using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features
{
    public class NumericBinaryLiterals
    {
        public void NumbericLiteralsDemo()
        {
            //large complex numbers delcaration in C# 6.0
            int cSharp6IntDemo = 100000;
            double cSharp6DoubleDemo = 12.45;

            Console.WriteLine(cSharp6IntDemo);  //output: 100000
            Console.WriteLine(cSharp6DoubleDemo); //output: 12.45

            //large complex numbers delcaration Seperation with Litaral for better readability in C# 7.0
            int cSharp7IntDemo = 1_00_000;
            double cSharp7DoubleDemo = 1_2_3.45_00;

            Console.WriteLine(cSharp7IntDemo);  //output: 100000
            Console.WriteLine(cSharp7DoubleDemo); //output: 123.4500
        }

        public void BinaryBitLiteralsDemo()
        {
            // C# 6.0
            int hexFifteen = 0xF;
            int hexTwoFiftyFive = 0xFF;

            Console.WriteLine(hexFifteen);  //output: 15
            Console.WriteLine(hexTwoFiftyFive); //output: 255

            // C# 7.0
            int bitFifteen = 0b1111;
            int bitTwoFiftyFive = 0b1111_1111;

            Console.WriteLine(bitFifteen);  //output: 15
            Console.WriteLine(bitTwoFiftyFive); //output: 255
        }
    }
}
