using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        public struct PointA // A Value Type Container with a parameterized constructor
        {
            private double X;
            private double Y;

            public PointA(double x, double y) 
            {
                X = x;
                Y = y;
            }
        }
        public struct PointB // A Value Type Container with default constructor
        {
            public double X { get; set; }
            public double Y { get; set; }
        } 

        public enum MyEnum { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size         |                           VALUES                          |
            sbyte _sbyte;               // 8 bit	                      -128 to 127
            byte _byte;                 // 8 bit	                         0 to 255
            short _short;               // 16 bit	                   -32,768 to 32,767
            ushort _ushort;             // 16 bit	                         0 to 65,535
            int _int;                   // 32 bit	            -2,147,483,648 to 2,147,483,647
            uint _uint;                 // 32 bit	                         0 to 4,294,967,295
            long _long;                 // 64 bit	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong _ulong;               // 64 bit	                         0 to 18,446,744,073,709,551,615

            float _float;               // 32 bit	               -1.5 x 1045 to 3.4 x 1038
            double _double;             // 64 bit	                -5 x 10324 to 1.7 x 10308
            decimal _decimal;           // 128 bit	                     -1028 to 7.9 x 1028

            char _char;                 // 16 bit	                         0 to 65535
            bool _bool;                 // ~1 bit	                      True or false
            #endregion

            // TODO: Declare 5 constansts
            const sbyte mySByte = -114;
            const int myInt = 10;
            const float myFloat = 20.123f;
            const char myChar = 'x';
            const bool myBool = true;


            // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // Make sure to use C# naming convention best practices (camelCase, PascalCase, etc...)
            sbyte mySByte01;
            sbyte mySByte02;

            byte myByte01;
            byte myByte02;

            short myShort01;
            short myShort02;

            ushort myUShort01;
            ushort myUShort02;

            int myInt01;
            int myInt02;

            uint myUInt01;
            uint myUInt02;

            long myLong01;
            long myLong02;

            ulong myULong01;
            ulong myULong02;

            float myFloat01;
            float myFloat02;

            double myDouble01;
            double myDouble02;

            decimal myDecimal01;
            decimal myDecimal02;

            char myChar01;
            char myChar02;

            bool myBool01;
            bool myBool02;

            // TODO: Initialize 1 of the variables with that datatypes minimum value
            // TODO: Initialize the other variable with that datatypes maximum value
            // TODO: Write out each of the variables to the Console 
            mySByte01 = sbyte.MinValue;
            mySByte02 = sbyte.MaxValue;
            System.Console.WriteLine($"sbyte:    Min: {mySByte01} || Max: {mySByte02}");

            myByte01 = byte.MinValue;
            myByte02 = byte.MaxValue;
            System.Console.WriteLine($"byte:    Min: {myByte01} || Max: {myByte02}");

            myShort01 = short.MinValue;
            myShort02 = short.MaxValue;
            System.Console.WriteLine($"short:    Min: {myShort01} || Max: {myShort02}");

            myUShort01 = ushort.MinValue;
            myUShort02 = ushort.MaxValue;
            System.Console.WriteLine($"ushort:    Min: {myUShort01} || Max: {myUShort02}");

            myInt01 = int.MinValue;
            myInt02 = int.MaxValue;
            System.Console.WriteLine($"int:    Min: {myInt01} || Max: {myInt02}");

            myUInt01 = uint.MinValue;
            myUInt02 = uint.MaxValue;
            System.Console.WriteLine($"uint:    Min: {myUInt01} || Max: {myUInt02}");

            myLong01 = long.MinValue;
            myLong02 = long.MaxValue;
            System.Console.WriteLine($"long:    Min: {myLong01} || Max: {myLong02}");

            myULong01 = ulong.MinValue;
            myULong02 = ulong.MaxValue;
            System.Console.WriteLine($"ulong:    Min: {myULong01} || Max: {myULong02}");

            myFloat01 = float.MinValue;
            myFloat02 = float.MaxValue;
            System.Console.WriteLine($"float:    Min: {myFloat01} || Max: {myFloat02}");

            myDouble01 = double.MinValue;
            myDouble02 = double.MaxValue;
            System.Console.WriteLine($"double:    Min: {myDouble01} || Max: {myDouble02}");

            myDecimal01 = decimal.MinValue;
            myDecimal02 = decimal.MaxValue;
            System.Console.WriteLine($"decimal:    Min: {myDecimal01} || Max: {myDecimal02}");

            myChar01 = char.MinValue;
            myChar02 = char.MaxValue;
            System.Console.WriteLine($"char:    Min: {myChar01} || Max: {myChar02}");

            myBool01 = false;
            myBool02 = true;
            System.Console.WriteLine($"bool:    Min: {myBool01} || Max: {myBool02}");
        }
        // **BONUS**
        // TODO: Create your own enum and initialize it with constants of your choosing
        // TODO: Declare it and then iterate through it writing out to the console            
        // TODO: Instantiate a struct and initialize all of it's members
    }
}
