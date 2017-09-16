using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExDay3.Framework.User
{
    class clsUserLogin
    {
        private string _ErrMsg;
        public string ErrMsg
        {
            get { return _ErrMsg; }
        }
        /// <summary>
        /// 사용자로그인 프로세스
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="Password"></param>
        /// <returns>성공 : true, 실패 : false</returns>
        public bool isLogin(string Userid, string Password)
        {
            bool iFlag = false;
            try
            {
                iFlag = true;
            }
            catch (Exception Ex)
            {
                _ErrMsg = Ex.Message.ToString();
            }
            return iFlag ;
        }
    }
}
