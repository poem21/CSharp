using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSSys
{
   
    public class Program
    {
        static void Main(string[] args)
        {

            //int a, b;

            //a = 10;
            //b = 20;
            ////Console.WriteLine(a + b);
            //csum(a, b);
            //Console.Write("{0:0000}+{1:0000}={2:0000.00}", a, b, fsum(a, b));
            //Console.WriteLine("홍성호");

            //Console.WriteLine();

            //csTest cst = new csTest();
            //Console.WriteLine(cst.csum(a, b));
            //Console.WriteLine( cst.csum(20, 90));
            //csTest dst = new csTest("메시지");
            //csTest gst = new csTest(10);
            //Console.WriteLine("내부필드 : {0}, 외부필드 : {1}", gst.getZ(), gst.z);

            //InhClass TestCs = new InhClass();

            //Ex_1Day.Database Db = new Ex_1Day.Database();
            //Db.partialData();
            //Db.partMod();

            InhClass cstest = new InhClass();
            Console.WriteLine(cstest.csum(10, 3));

        }

        public static void csum(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        static int fsum(int a, int b)
        {
            return a + b;
        }
    }

    class csTest
    {
        public int z;
        private int _z;


        public  csTest()
        {
            Console.WriteLine("생성자 실행");
        }

        public csTest(int z)
        {
            this._z = z;
            this.z = z;

        }

       
        public csTest(string iMsg)
        {
            Console.WriteLine("메시지 초기화 : {0}",iMsg );
        }

        /// <summary>
        /// 이함수는 두개의 정수형 인자를 받아 합을 구하는 함수입니다.
        /// </summary>
        /// <param name="a">정수형 데이터</param>
        /// <param name="b">정수형 데이터</param>
        /// <returns>두수의 합을 정수로 리턴</returns>
        public virtual int csum(int a, int b)
        {
            return a + b;
        }

        public int getZ()
        {
            return _z;
        }

    }

    class InhClass : csTest
    {
        public InhClass()
        {
            Console.WriteLine("하위 생성자");
            //Console.WriteLine(base.csum(10, 40));

        }

        public override int csum(int a, int b)
        {
            return a - b;
        }
    }
}
