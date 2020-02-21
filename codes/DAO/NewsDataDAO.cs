using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class NewsDataDAO : INewsDataDAO
    {
        public int insert(NewsData nd)
        {
            int line = 0;
            string sql = "insert into NewsData values (@date,@url,@title)";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@date", nd.date));
            plst.Add(new MySqlParameter("@url", nd.url));
            plst.Add(new MySqlParameter("@title", nd.title));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());
            return line;
        }

        public List<NewsData> selectALL()
        {
            List<NewsData> ndlst = new List<NewsData>();
            string sql = "select newsdate ,url,title from NewsData";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                NewsData nd = new NewsData(reader.GetString("newsdate"), reader.GetString("url"), reader.GetString("title"));
                ndlst.Add(nd);
            }
            reader.Close();

            return ndlst;
        }

        public List<NewsData> selectByDate(string date)
        {
            List<NewsData> ndlst = new List<NewsData>();
            string sql = "select newsdate ,url,title from NewsData where newsdate=@date";
            MySqlParameter p1 = new MySqlParameter("@date", date);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,p1);
            while (reader.Read())
            {
                NewsData nd = new NewsData(reader.GetString("newsdate"), reader.GetString("url"), reader.GetString("title"));
                ndlst.Add(nd);
            }
            reader.Close();

            return ndlst;
        }

        public NewsData selectByDate_Url(string date, string url)
        {
            NewsData nd = null;
            string sql = "select newsdate ,url,title from NewsData where newsdate=@date and url=@url";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@date", date));
            plst.Add(new MySqlParameter("@url", url));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            if (reader.Read())
            {
                nd = new NewsData(reader.GetString("newsdate"), reader.GetString("url"), reader.GetString("title"));
            }
            reader.Close();

            return nd;
        }

        public int update(NewsData nd)
        {
            int line = 0;

            string sql = "update NewsData set title=@title where newsdate=@date and url=@url";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@date", nd.date));
            plst.Add(new MySqlParameter("@url", nd.url));
            plst.Add(new MySqlParameter("@title", nd.title));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
