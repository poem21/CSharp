using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExWebDay3
{
    public partial class Footer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void PopMsg(string msg)
        {
            Response.Write(string.Format("<script>alert('{0}');</script>", msg));

        }
    }
}