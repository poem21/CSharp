using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SOAP.soaptest SLogin = new SOAP.soaptest();

            if (SLogin.UserLogin(this.TextBox1.Text, this.TextBox2.Text) == true )
            {
                Response.Write("안녕하세요 회원님!!!"); 
            } else
            {
                Response.Write("넌 이름이 뭐니?");
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}