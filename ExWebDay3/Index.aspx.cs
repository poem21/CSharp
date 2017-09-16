using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExWebDay3
{
    public partial class Index : System.Web.UI.Page
    {
        private SqlConnection DB = new SqlConnection("Server=127.0.0.1; Database=CS; User ID=sa; Password=vision21!");
        private String SQL = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Footer.PopMsg("페이지로드");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SQL = "SELECT UNM FROM TB_USERINFO WHERE UNM=@UNM AND UID=@UID";

            SqlDataAdapter ADT = new SqlDataAdapter(SQL, DB);
            DataSet DBSET = new DataSet();

            ADT.SelectCommand.Parameters.Add("@UNM", SqlDbType.NVarChar, 100).Value = this.TXTID.Text;
            ADT.SelectCommand.Parameters.Add("@UID", SqlDbType.VarChar, 20).Value = this.TXTPW.Text ;

            try
            {
                ADT.Fill(DBSET);
                if (DBSET.Tables[0].Rows.Count > 0)
                {
                    this.Label1.Text = "로그인 성공";
                    Response.Redirect("http://visit.seoulsemicon.com");
                }
                else
                {
                    this.Label1.Text = "<script>alert('사용자 계정을 확인해 주세요');</script>";
                }
                DBSET.Clear();
            }
            catch (Exception EX)
            {
                this.Label1.Text = EX.ToString();
            }
            DBSET.Dispose();
            ADT.Dispose();

            DBSET = null;
            ADT = null;

        }
    }
}