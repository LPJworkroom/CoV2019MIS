using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class KnowledgeDataDAO : IKnowledgeDataDAO
    {
        public int insert(KnowledgeData kd)
        {
            int line = 0;
            string sql = "insert into KnowledgeData values (@type,@title,@content)";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@type", kd.type));
            plst.Add(new MySqlParameter("@title", kd.title));
            plst.Add(new MySqlParameter("@content", kd.content));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());
            return line;
        }

        public List<KnowledgeData> selectALL()
        {
            List<KnowledgeData> kdlst = new List<KnowledgeData>();
            string sql = "select knowledgetype ,title,content from KnowledgeData";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                KnowledgeData kd = new KnowledgeData(reader.GetString("knowledgetype"), reader.GetString("title"), reader.GetString("content"));
                kdlst.Add(kd);
            }
            reader.Close();

            return kdlst;
        }

        public List<KnowledgeData> selectByType(string type)
        {
            List<KnowledgeData> kdlst = new List<KnowledgeData>();
            string sql = "select knowledgetype ,title,content from KnowledgeData where knowledgetype=@type";
            MySqlParameter p1 = new MySqlParameter("@type", type);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);
            while (reader.Read())
            {
                KnowledgeData kd = new KnowledgeData(reader.GetString("knowledgetype"), reader.GetString("title"), reader.GetString("content"));
                kdlst.Add(kd);
            }
            reader.Close();

            return kdlst;
        }

        public KnowledgeData selectByType_Title(string type,string title)
        {
            KnowledgeData kd = null;
            string sql = "select knowledgetype ,title,content from KnowledgeData where knowledgetype=@type and title=@title";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@type", type));
            plst.Add(new MySqlParameter("@title", title));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,plst.ToArray());
            if (reader.Read())
            {
                kd = new KnowledgeData(reader.GetString("knowledgetype"), reader.GetString("title"), reader.GetString("content"));
            }
            reader.Close();

            return kd;
        }

        public int update(KnowledgeData kd)
        {
            int line = 0;

            string sql = "update KnowledgeData set content=@content where type=@type and title=@title";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@type", kd.type));
            plst.Add(new MySqlParameter("@title", kd.title));
            plst.Add(new MySqlParameter("@content", kd.content));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
