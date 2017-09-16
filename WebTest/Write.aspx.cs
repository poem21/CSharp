using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest
{
    public partial class Write : System.Web.UI.Page
    {
        private SqlConnection DB = new SqlConnection(ConfigurationManager.AppSettings["DBSTRING"]);
        private string SQL;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                this.itype.Value = Request["itype"].ToString();
                this.ibid.Value = Request["ibid"].ToString();

                UISET();
            }
        }

        private void UISET()
        {
            if (this.itype.Value == "1")
            {
                this.BTNNEW.Text = "신규작성";
            }
            else if (this.itype.Value == "2")
            {
                this.BTNNEW.Text = "정보수정";
                DBLOAD();
            }
            else
            {
                this.BTNNEW.Text = "정보삭제";
                DBLOAD();
            }
        }


        protected void BTNCAN_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Index.aspx");
        }

        protected void BTNNEW_Click(object sender, EventArgs e)
        {
            if (this.itype.Value == "1")
            {
                DBADD();
            }
            else if (this.itype.Value == "2")
            {
                DBEDIT();
            }
            else
            {
                DBDEL();
            }
            Response.Redirect("./Index.aspx");
        }

        private void DBLOAD()
        {
            SQL = "select * from tb_boardinfo where bid=@bid";
            SqlDataAdapter ADT = new SqlDataAdapter(SQL, DB);
            DataSet dbset = new DataSet();

            ADT.SelectCommand.Parameters.Add("@bid", SqlDbType.Char, 32).Value = this.ibid.Value;
            
            try
            {
                ADT.Fill(dbset);
                if (dbset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow irow in dbset.Tables[0].Rows)
                    {
                        this.TXTBNM.Text = irow["bnm"].ToString();
                        this.TXTBODY.Text = irow["bbody"].ToString();
                    }
                }

                dbset.Clear();

            } 
            catch
            {

            }
            dbset.Dispose();
            ADT.Dispose();

            dbset = null;
            ADT = null;
        }

        private void DBADD()
        {
            this.TXTBNM.Text = this.TXTBNM.Text.Trim();
            this.TXTBODY.Text = this.TXTBODY.Text.Trim();

            SQL = "     INSERT INTO TB_BOARDINFO (BID, BNM, BBODY, ADDDATE)";
            SQL += "    VALUES (REPLACE(NEWID(),'-',''), @BNM, @BBODY, GETDATE())";

            SqlCommand Cmd = DB.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = SQL;

            Cmd.Parameters.Add("@BNM", SqlDbType.NVarChar, 1000).Value = this.TXTBNM.Text;
            Cmd.Parameters.Add("@BBODY", SqlDbType.NText).Value = this.TXTBODY.Text;

            try
            {
                DB.Open();
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch
                {

                }
                DB.Close();
            }
            catch
            {

            }

            Cmd.Dispose();
            Cmd = null;

        }

        private void DBEDIT()
        {
            this.TXTBNM.Text = this.TXTBNM.Text.Trim();
            this.TXTBODY.Text = this.TXTBODY.Text.Trim();

            SQL = "     UPDATE TB_BOARDINFO SET BNM=@BNM, BBODY=@BBODY, ADDDATE=GETDATE()";
            SQL += "    WHERE BID=@BID";

            SqlCommand Cmd = DB.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = SQL;

            Cmd.Parameters.Add("@BID", SqlDbType.Char, 32).Value = this.ibid.Value;
            Cmd.Parameters.Add("@BNM", SqlDbType.NVarChar, 1000).Value = this.TXTBNM.Text;
            Cmd.Parameters.Add("@BBODY", SqlDbType.NText).Value = this.TXTBODY.Text;
            try
            {
                DB.Open();
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
                DB.Close();
            }
            catch
            {

            }

            Cmd.Dispose();
            Cmd = null;

        }

        private void DBDEL()
        {
            this.TXTBNM.Text = this.TXTBNM.Text.Trim();
            this.TXTBODY.Text = this.TXTBODY.Text.Trim();

            SQL = "     DELETE TB_BOARDINFO ";
            SQL += "    WHERE BID=@BID";

            SqlCommand Cmd = DB.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = SQL;

            Cmd.Parameters.Add("@BID", SqlDbType.Char, 32).Value = this.ibid.Value;

            try
            {
                DB.Open();
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch
                {

                }
                DB.Close();
            }
            catch
            {

            }

            Cmd.Dispose();
            Cmd = null;

        }
    }
}