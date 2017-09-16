using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_1Day
{
    static class PubMod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Msg"></param>
        static public  void LogWrite(string Msg)
        {
            Console.WriteLine("{0} - {1} ", DateTime.Now, Msg);
        }
    }
}
