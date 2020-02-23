using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UserInfoBLL : IUserInfoBLL
    {
        private static IUserInfoDAO userinfodao = new UserInfoDAO();

        public bool insert(UserInfo uinfo)
        {
            //throw new NotImplementedException();

            UserInfo existU = userinfodao.selectByNick(uinfo.nick);
            if (existU != null)
            {
                return false;
            }
            int line = userinfodao.insert(uinfo);
            if (line == 1)
            {
                return true;
            }
            return false;
            
        }

        public List<UserInfo> selectALL()
        {
            //throw new NotImplementedException();
            return userinfodao.selectALL();
        }


        public UserInfo selectByID(int uid)
        {
            //throw new NotImplementedException();
            return userinfodao.selectByID(uid);
        }

        public bool update(UserInfo uinfo)
        {
            //throw new NotImplementedException();
            UserInfo existU = userinfodao.selectByNick(uinfo.nick);
            if (existU == null)
            {
                return false;
            }
            int line = userinfodao.update(uinfo);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
