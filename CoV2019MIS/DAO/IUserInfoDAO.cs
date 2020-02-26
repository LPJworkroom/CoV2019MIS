using Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAO
{
    public interface IUserInfoDAO
    {
        List<UserInfo> selectALL();
        UserInfo selectByID(int uid);
        int insert(UserInfo uinfo);
        UserInfo selectByNick(string nick);
        int update(UserInfo uinfo);
    }
}
