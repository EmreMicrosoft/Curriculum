using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Courses.CSharp.Fundamentals
{
    public class DataTypes
    {
        public void IntegralTypes()
        {
            // const: constant (sabit)

            const byte byteMin =   0;
            const byte byteMax = 255;

            const sbyte sbyteMin = -128;
            const sbyte sbyteMax =  127;

            const short shortMin = -32768;
            const short shortMax =  32767;

            const ushort ushortMin =     0;
            const ushort ushortMax = 65535;

            const int intMin = -2147483648;
            const int intMax =  2147483647;

            const uint uintMin =          0;
            const uint uintMax = 4294967295;
        }
    }
}