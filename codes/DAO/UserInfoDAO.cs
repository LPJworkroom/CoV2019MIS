using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class UserInfoDAO : IUserInfoDAO
    {
        public int insert(UserInfo uinfo)
        {
            //throw new NotImplementedException();
            int line = 0;
            string sql = "insert into userinfo (nick,password) values (@nick,@password)";
            List<MySqlParameter> plst=new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@nick", uinfo.nick));
            plst.Add(new MySqlParameter("@password", uinfo.password));
            line = MySQLHelper.ExecuteSql(sql,plst.ToArray());
            return line;
        }

        public List<UserInfo> selectALL()
        {
            List<UserInfo> uinfolst = new List<UserInfo>();
            string sql = "select userid,nick,password from userinfo";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                UserInfo uinfo = new UserInfo(reader.GetInt32("userid"), reader.GetString("nick"), reader.GetString("password"));
                uinfolst.Add(uinfo);
            }
            reader.Close();

            return uinfolst;

        }

        public UserInfo selectByID(int uid)
        {
            //throw new NotImplementedException();
            UserInfo uinfo = null;
            string sql = "select userid,nick,password from userinfo where userid=@uid";
            MySqlParameter p1 = new MySqlParameter("@uid",uid);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,p1);
            if (reader.Read())
            {
                uinfo = new UserInfo(reader.GetInt32("userid"), reader.GetString("nick"), reader.GetString("password"));
            }
            reader.Close();
            
            return uinfo;
        }

        public UserInfo selectByNick(string nick)
        {
            //throw new NotImplementedException();
            UserInfo uinfo = null;
            string sql = "select userid,nick,password from userinfo where nick=@nick";
            MySqlParameter p1 = new MySqlParameter("@nick", nick);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);
            if (reader.Read())
            {
                uinfo = new UserInfo(reader.GetInt32("userid"), reader.GetString("nick"), reader.GetString("password"));
            }
            reader.Close();

            return uinfo;
        }

        public int update(UserInfo uinfo)
        {
            //throw new NotImplementedException();
            int line = 0;

            string sql = "update userinfo set nick=@nick,password=@password where userid=@userid";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@nick", uinfo.nick));
            plst.Add(new MySqlParameter("@password", uinfo.password));
            plst.Add(new MySqlParameter("@userid",uinfo.userid));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
