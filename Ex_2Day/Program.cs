using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2Day
{

    delegate void Completes(string Msg);
    delegate void dgtFsCopy(string srcpath);

    class Program
    {
        delegate void DirectoryFiles(string dstpath);

        static void Main(string[] args)
        {
            clsFS Fs = new clsFS();

            Fs.evtEnd += MsgShow;

            //Fs.FsCopy(@"c:\temp\scan.txt", @"c:\temp\test.txt");
            
            
            //Fs.FsDir(@"c:\temp");

            DirectoryFiles DD = new DirectoryFiles(Fs.FsDir);

            DD(@"C:\temp");

            Fs.FsWatcher(@"c:\temp");
            Fs.evtCopy += FileCopy;
            Fs.evtCopy += MsgBox;


            while (true)
            {
                System.Threading.Thread.Sleep(1000);
            }

        }

        static void FileCopy(string srcpath)
        {
            try
            {
                File.Copy(srcpath, string.Format(@"c:\src\{0}", new FileInfo(srcpath).Name), true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void MsgBox(string srcpath)
        {
            Console.WriteLine("{0} ==> 이벤트 완료", srcpath);
        }

        static void MsgShow(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }

    class clsFS
    {

        public event Completes evtEnd;
        public event dgtFsCopy evtCopy;

        public void FsDir(string dstpath)
        {
            foreach(string ifile in Directory.GetFiles(dstpath))
            {
                Console.WriteLine(ifile);
                
            }
            evtEnd(string.Format("{0} 파일검색 끝났습니다.", dstpath));
        }

        public void FsCopy(string srcpath, string dstpath)
        {
            try
            {
                File.Copy(srcpath, dstpath, File.Exists(dstpath));
                //File.Copy(srcpath, dstpath);
                evtEnd(string.Format("{0} --> {1} 파일복제 끝났습니다.",srcpath, dstpath));
            }
            catch ( Exception e)
            {
                Console.WriteLine("프로그램오류 : {0}", e.ToString());
            }

        }
        public void FsWatcher(string srcpath)
        {
            FileSystemWatcher fsw = new FileSystemWatcher(@"c:\temp");
            fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            fsw.Created += FsCreate;
            fsw.Changed += FsCreate;
            fsw.Deleted += FsCreate;
            fsw.Renamed += FsRename;
            fsw.EnableRaisingEvents = true;
            evtEnd("모니터링 시작!!");
           

        }

        private void FsCreate(object o, FileSystemEventArgs e)
        {

            Console.WriteLine("event : {1}, File Name : {0}", e.FullPath, e.ChangeType );
            evtCopy(e.FullPath);
        }

        private void FsRename(object o, RenamedEventArgs   e)
        {

            Console.WriteLine("event : {2}, Old File Name : {0} ==> New File Name : {1}",e.OldFullPath,  e.FullPath, e.ChangeType);

        }


    }
}
