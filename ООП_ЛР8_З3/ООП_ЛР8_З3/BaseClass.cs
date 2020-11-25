using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_ЛР8_З3
{
    class BaseClass
    {
        public BaseClass()
        {
            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                Array[i] = rnd.Next(0, 25);
            }

        }
        protected int[] Array = new int[20];
        public int this[int index]
        {
            get { return Array[index]; }
            set { Array[index] = value; }
        }
        public int ArrLength
        {
            get { return Array.Length; }
        }
    }
}
