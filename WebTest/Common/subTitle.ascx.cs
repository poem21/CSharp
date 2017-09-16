using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest.Common
{
    public partial class subTitle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SubTitle(string iTitle)
        {
            this.subTit.Text = iTitle;
        }
        public void AddUrl(string btnTitle, string UrlNav)
        {
            this.BTNWRITE.Text = btnTitle;
            this.btnnav.Value = UrlNav;

        }

        protected void BTNSEARCH_Click(object sender, EventArgs e)
        {
            Response.Redirect(this.btnnav.Value);
        }
    }
}