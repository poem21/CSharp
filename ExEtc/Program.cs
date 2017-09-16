using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEtc.Proc;

namespace ExEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string iParam in args)
            {
                Console.WriteLine("Param : {0}", iParam);

            }
            clsStart ProcStart = new clsStart();
            ProcStart.Start();
    
        }

        
    }
}
