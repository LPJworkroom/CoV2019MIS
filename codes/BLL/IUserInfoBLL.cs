using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IUserInfoBLL
    {
        List<UserInfo> selectALL();
        UserInfo selectByID(int uid);
        bool insert(UserInfo uinfo);
        bool update(UserInfo uinfo);
    }
}
