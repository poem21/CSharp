using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4Days
{
    public partial class Index : System.Web.UI.Page
    {
        private string iName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            LogMsg("1.페이지 로드 이벤트 실행");

            iName = Request["iName"];

            this.HyperLink1.NavigateUrl = "mailto:poem21@gmail.com";
            if (IsPostBack == false )
            {
                LogMsg("2. 포스트백이 아님");
            }
            else
            {
                LogMsg("3. 포스트백임....");
            }
            LogMsg(iName);
        }

        protected void rdo01_CheckedChanged(object sender, EventArgs e)
        {
            this.txtName.Text = "남자";
        }

        protected void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtName.Text = "여자";
        }

        private void LogMsg(string iMsg)
        {

            Response.Write(string.Format("<p>{0}</p>", iMsg));

        }

        private void PopMsg(string iMsg)
        {

            Response.Write(string.Format("<script>alert('{0}');</script>", iMsg));

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LogMsg("4. 버튼 포스트백임....");
            //PopMsg(this.txtName.Text);

            if (this.rdo01.Checked)
            {
                PopMsg("남자를 선택했습니다.");
            }
            else
            {
                PopMsg("여자를 선택했습니다.");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LogMsg("5. 링크드버튼 포스트백임....");
            //PopMsg(this.txtName.Text);

            this.LinkButton1.Text = "눌렀네";
            this.LinkButton1.Enabled = false;
            this.LinkButton1.Visible = false;
            if (this.rdo01.Checked)
            {
                PopMsg("남자를 선택했습니다.");
            }
            else
            {
                PopMsg("여자를 선택했습니다.");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Panel1.Visible = true;

        }
    }
}