using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoapClient_Con
{
    class Program
    {
        static void Main(string[] args)
        {
            Soap.soaptest SoapClient = new Soap.soaptest();

            SoapClient.Url = string.Format("http://{0}/soap/soaptest.asmx", "localhost") ;



            Console.Write(SoapClient.UserLogin("poem21", "1234").ToString());

            DataSet dbset = SoapClient.BDTIT();

            foreach (DataRow irow in dbset.Tables[0].Rows)
            {
                Console.WriteLine(irow[0].ToString());
            }
            dbset.WriteXml(@"c:\test.xml");

        }
    }
}
