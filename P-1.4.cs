using System;

namespace Practice_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 i16 = 1;
            Int32 i32 = 1;
            double db = 1;
            i16 = 132;
            i16 = db;
            i32 = i16;
            i32 = db;
            db = 116;
            db = i32;

        }
    }
}
