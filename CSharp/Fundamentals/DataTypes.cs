namespace CSharp.Fundamentals
{
    public class DataTypes
    {
        //   C# DATA TYPES
        //   ¯¯¯¯¯¯¯¯¯¯¯¯¯
        //   |- VALUE TYPES
        //     |- Simple Types
        //       |- Integral
        //       |- Floating-point
        //       |- Char
        //       |- Boolean
        //     |- Enum Types
        //     |- Struct Types
        //     |- Nullable Types
        //
        //   |- REFERENCE TYPES
        //     |- Class Types
        //     |- Interface Types
        //     |- Array Types
        //     |- Delegate Types

        public void IntegralTypes()
        {
            // const = constant.

            // 1 byte = 8 bit (bit = 1 or 0)
            // Example for 1 byte = 00110110

            // System.Byte - 1 byte
            const byte byteMin =   0;
            const byte byteMax = 255;

            // System.SByte - 1 byte
            // s = signed.
            const sbyte sbyteMin = -128;
            const sbyte sbyteMax =  127;

            // System.Int16 - 2 bytes
            const short shortMin = -32768;
            const short shortMax =  32767;

            // System.UInt16 - 2 bytes
            // u = unsigned.
            const ushort ushortMin =     0;
            const ushort ushortMax = 65535;

            // System.Int32 - 4 bytes
            const int intMin = -2147483648;
            const int intMax =  2147483647;

            // System.UInt32 - 4 bytes
            const uint uintMin =          0;
            const uint uintMax = 4294967295;

            // System.Int64 - 8 bytes
            const long longMin = -9223372036854775808;
            const long longMax = 9223372036854775807;

            // System.UInt64 - 8 bytes
            const ulong ulongMin = 0;
            const ulong ulongMax = 18446744073709551615;
        }

        public void DecimalTypes()
        {
            // System.Single - 4 bytes
            const float floatSample = 3.1415f;
            const float floatMin = -3.40282346638528859e+38f;
            const float floatMax =  3.40282346638528859e+38f;


            // System.Double - 8 bytes
            const double doubleSample = 3.1415d;
            const double doubleMin = -1.7976931348623157E+308;
            const double doubleMax =  1.7976931348623157E+308;


            // System.Decimal - 16 bytes
            const decimal decimalSample = 3.1415m;
            const decimal decimalMin = -79228162514264337593543950335m;
            const decimal decimalMax =  79228162514264337593543950335m;
        }
    }
}