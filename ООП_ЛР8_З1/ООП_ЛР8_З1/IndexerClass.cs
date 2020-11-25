using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_ЛР8_З1
{
    class IndexerClass
    {
        private string x = "This is X";
        private string y = "This is Y";
        public string this[int numname]
        {
            get
            {
                switch (numname)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return "ERROR: index is not defined";
                }
            }
        }
    }
}
