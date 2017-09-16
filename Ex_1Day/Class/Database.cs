using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_1Day
{
    public partial class Database
    {
        private int _id;
        public int idata
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public void partMod()
        {
            Console.WriteLine("ffff");
        }
    }
}
