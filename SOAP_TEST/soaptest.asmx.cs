using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_TEST
{
    /// <summary>
    /// soaptest의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    // [System.Web.Script.Services.ScriptService]
    public class soaptest : System.Web.Services.WebService
    {

        [WebMethod]
        public string ClientIP()
        {
            return HttpContext.Current.Request.UserHostAddress.ToString();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Boolean UserLogin(String Uid, String Upw)
        {
            Boolean ireturn = false;
            if (Uid=="1234" && Upw=="1234")
            {
                ireturn = true;
            } 
            return ireturn;
        }

        [WebMethod]
        public DataSet BDTIT()
        {
            SqlConnection DB = new SqlConnection("Server=127.0.0.1; Database=CS; User ID=sa; Password=vision21!");
            SqlDataAdapter ADT = new SqlDataAdapter("select * from tb_boardinfo", DB);
            DataSet DBSET = new DataSet();

            ADT.Fill(DBSET);


            return DBSET;

        }
    }
}
