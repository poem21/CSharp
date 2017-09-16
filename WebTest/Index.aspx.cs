using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;

namespace WebTest
{
    public partial class Index : System.Web.UI.Page
    {
        private SqlConnection DB = new SqlConnection(ConfigurationManager.AppSettings["DBSTRING"]);
        private string SQL;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false )
            {
                UISET();
            }
                

        }

        protected void BTNWRITE_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Write.aspx?itype=1&ibid=_");
        }

        private void UISET()
        {
            this.subTitle.SubTitle("게시판 이름");
            this.subTitle.AddUrl("신규등록1", "Write.aspx?itype=1&ibid=_");
            TBLSET();
        }

        private void TBLSET()
        {
            TableHeaderRow TR;
            TableHeaderCell TD;

            TR = new TableHeaderRow();
            TR.BackColor = System.Drawing.Color.WhiteSmoke;

            TD = new TableHeaderCell();
            TD.Width = 60;
            TD.Text = "No";
            TD.Attributes["style"] = "text-align:center;";
            TR.Cells.Add(TD);

            TD = new TableHeaderCell();
            TD.Width = 180;
            TD.Text = "Reg Date";
            TR.Cells.Add(TD);

            TD = new TableHeaderCell();
            TD.Text = "Subject";
            TR.Cells.Add(TD);

            TD = new TableHeaderCell();
            TD.Width = 80;
            TD.Text = "Func.";
            TR.Cells.Add(TD);

            this.TBLLIST.Rows.Add(TR);

            TBLLOAD();
        }

        private void TBLLOAD()
        {
            SQL = "SELECT * FROM TB_BOARDINFO ORDER BY ADDDATE DESC";

            SqlDataAdapter ADT = new SqlDataAdapter(SQL, DB);
            DataSet DBSET = new DataSet();
            long ino = 0;
            try
            {
                ADT.Fill(DBSET, "BD");
                if (DBSET.Tables["BD"].Rows.Count > 0)
                {
                    foreach ( DataRow irow in DBSET.Tables["BD"].Rows)
                    {
                        ino += 1;
                        TBLADD(ino, irow["adddate"].ToString(), irow["BNM"].ToString(), irow["bid"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        private void TBLADD(long ino, String idate, String subject, String bid)
        {
            TableRow TR;
            TableCell TD;

            TR = new TableRow();
            TR.BackColor = System.Drawing.Color.WhiteSmoke;

            TD = new TableCell();
            TD.Text = ino.ToString();
            TR.Cells.Add(TD);

            TD = new TableCell();
            TD.Text = idate.ToString();
            TR.Cells.Add(TD);

            TD = new TableCell();
            TD.Text = subject;
            TR.Cells.Add(TD);

            TD = new TableCell();
            TD.Text = String.Format("<input type='button' class='btn btn-primary' style='width:100%;' value='Edit' OnClick=document.location='./Write.aspx?itype=2&ibid={0}'; />", bid);
            TR.Cells.Add(TD);

            this.TBLLIST.Rows.Add(TR);
                  
        }

        
    }
}