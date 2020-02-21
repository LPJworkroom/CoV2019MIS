using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class UserInfo
    {
        public int userid { get; set; }
        public string nick { get; set; }
        public string password { get; set; }
        public UserInfo()
        {

        }

        public UserInfo(int userid, string nick, string password)
        {
            this.userid = userid;
            this.nick = nick;
            this.password = password;
        }
    }
}
