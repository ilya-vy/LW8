using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_ЛР8_З3
{
    class DerivedClass : BaseClass
    {
        protected char[] CharArray = new char[200];
        public DerivedClass()
        {
            ArrLength[1] = CharArray.Length;
            ArrLength[0] = Array.Length;
        }
        public char this[char index]
        {
            get { return CharArray[index]; }
            set { CharArray[index] = value; }
        }
        public new int[] ArrLength = new int[2];
    }
}
