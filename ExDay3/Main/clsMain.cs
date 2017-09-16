using System;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExDay3.Framework.User;

namespace ExDay3
{
    class clsMain
    {
        private SqlConnection DB = new SqlConnection("Server=127.0.0.1; Database=CS; User ID=sa; Password=vision21!");

        public void ProStart()
        {
            Console.WriteLine("프로그램 시작점");

            // 연결
            //SQLCon();

            // DB DATA SQLNONEQUERY TYPE PROC --> INSERT UPDATE DELETE OR NONEQUERY SP
            //SQLNONEQUERY();

            // DB DATA SYNC QUERYDATA TYPE PROC --> SELECT OR QUERY SP
            //SQLSYNCQUERY();

            // DB DATA ASYNC QUERYDATA TYPE PROC AND XML SAVE--> SELECT OR QUERY SP
            //ASQLSYNCQUERY();

            // XML FILE READ
            //XMLReader();

            // Stored Procedure Excute
            RunSP();


        }

        private void SQLCon()
        {
            SqlConnection DB = new SqlConnection();
            DB.ConnectionString = "Server=127.0.0.1; Database=CS; User ID=sa; Password=vision21!";

            try
            {
                DB.Open();
                Console.WriteLine("연결성공");
                DB.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Err : {0}", e.ToString());
            }

            DB.Dispose();
            DB = null;

        }

        private void SQLNONEQUERY()
        {
            SqlConnection DB = new SqlConnection();
            DB.ConnectionString = "Server=127.0.0.1; Database=CS; User ID=sa; Password=vision21!";

            try
            {
                DB.Open();

                try
                {
                    // DB명령을 실행한다.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DB;

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO TB_USERINFO (UID, UNM) VALUES ('304834',N'홍성호')";

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("데이터 등록완료");
                    cmd.Dispose();
                    cmd = null;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                DB.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Err : {0}", e.ToString());
            }

            DB.Dispose();
            DB = null;

        }

        private void SQLSYNCQUERY()
        {
            SqlCommand cmd = DB.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM TB_USERINFO WHERE UNM=@UNM ORDER BY UNM";

            cmd.Parameters.Add("@UNM", SqlDbType.NVarChar, 100).Value = "유종배";
            try
            {
                DB.Open();
                SqlDataReader RS = cmd.ExecuteReader();
                
                while (RS.Read())
                {
                    Console.WriteLine("UID : {0}, UNM : {1}", RS[0], RS[1]);
                    //Console.WriteLine("UID : {0}, UNM : {1}", RS["UID"], RS["UNM"]);
                }
                RS.Close();
                RS = null;

                DB.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        
        }

        private void ASQLSYNCQUERY()
        {

            SqlDataAdapter ADT = new SqlDataAdapter("SELECT * FROM TB_USERINFO ORDER BY UNM; SELECT GETDATE()", DB);
            DataSet DBSET = new DataSet();

            try
            {
                ADT.Fill(DBSET);
                foreach (DataRow row in DBSET.Tables[0].Select("uid like '%000%'","unm desc"))
                {
                    Console.WriteLine("UID : {0}, UNM : {1}", row["UID"], row["UNM"]);
                }

                foreach (DataRow row in DBSET.Tables[1].Rows)
                {
                    Console.WriteLine("RESULT : {0}", row[0]);
                }
                // XML FILE SAVE
                // DBSET.WriteXml(@"C:\TESTDB.XML");
                DBSET.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            DBSET.Dispose();
            ADT.Dispose();
            DBSET = null;
            ADT = null;

        }
        private void RunSP()
        {
            SqlCommand cmd = DB.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_TEST";

            cmd.Parameters.Add("@UID", SqlDbType.VarChar, 20).Value = "전두환1";
            cmd.Parameters.Add("@UNM", SqlDbType.NVarChar, 100).Value = "노태우";
            cmd.Parameters.Add("@Result", SqlDbType.VarChar, 2).Direction = ParameterDirection.Output;
            
            try
            {
                DB.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.Parameters["@Result"].Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                DB.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        private void XMLReader()
        {
            DataSet DBSET = new DataSet();
            DBSET.ReadXml(@"C:\TESTDB.XML");

            foreach (DataRow row in DBSET.Tables[0].Rows)
            {
                Console.WriteLine("UID : {0}, UNM : {1}", row["UID"], row["UNM"]);
            }

            foreach (DataRow row in DBSET.Tables[1].Rows)
            {
                Console.WriteLine("RESULT : {0}", row[0]);
            }

        }
    }
}
