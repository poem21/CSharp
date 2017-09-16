using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEtc.Proc
{
    class clsStart
    {
        public void Start()
        {
            while(true)
            {
                ChkProc("NotePad");
                Thread.Sleep(5000);
            }
        }

        private void ChkProc(string ProcName)
        {

            Boolean Flag = true ;

            foreach(Process Iproc in Process.GetProcessesByName(ProcName))
            {
                Console.WriteLine(Iproc.ProcessName);
                Console.WriteLine(Iproc.PrivateMemorySize64.ToString());

                Flag = false ;
                //Iproc.Kill();
            }

            if (Flag == true )
            {
                ProcessRun("NotePad.exe");
            }
                //foreach(Process iProc in Process.GetProcessesByName(ProcName.ToUpper())) 
                //    {
                //    iProc.Kill();
                //}
            
        }

        private void ProcessRun(string ProcCmd)
        {
            Process Proc = new Process();

            Proc.StartInfo.FileName = ProcCmd;
            Proc.Start();


        }
    }
}

