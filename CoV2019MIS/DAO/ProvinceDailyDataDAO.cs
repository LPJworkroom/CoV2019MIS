using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ProvinceDailyDataDAO : IProvinceDailyDataDAO
    {
        public int insert(ProvinceDailyData pdd)
        {
            int line = 0;
            string sql = "insert into ProvinceDailyData values (@province,@date,@confirmed,@suspect,@death)";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", pdd.province));
            plst.Add(new MySqlParameter("@date",pdd.date ));
            plst.Add(new MySqlParameter("@confirmed",pdd.confirmed ));
            plst.Add(new MySqlParameter("@suspect", pdd.suspect));
            plst.Add(new MySqlParameter("@death", pdd.death));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());
            return line;
        }

        public ProvinceDailyData selecctByProvince_Date(string province, string date)
        {
            ProvinceDailyData pdd = null;
            string sql = "select province,casedate,confirmed,suspect,death from ProvinceDailyData where province=@province and casedate=@date";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", province));
            plst.Add(new MySqlParameter("@date", date));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            if (reader.Read())
            {
                pdd = new ProvinceDailyData(reader.GetString("province"), reader.GetString("casedate"), reader.GetInt32("confirmed"),reader.GetInt32("suspect"),reader.GetInt32("death"));
            }
            reader.Close();

            return pdd;
        }

        public List<ProvinceDailyData> selectALL()
        {
            List<ProvinceDailyData> pddlst = new List<ProvinceDailyData>();
            string sql = "select province,casedate,confirmed,suspect,death from ProvinceDailyData";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                ProvinceDailyData pdd = new ProvinceDailyData(reader.GetString("province"), reader.GetString("casedate"), reader.GetInt32("confirmed"), reader.GetInt32("suspect"), reader.GetInt32("death"));
                pddlst.Add(pdd);
            }
            reader.Close();

            return pddlst;
        }

        public List<ProvinceDailyData> selectByDate(string date)
        {
            List<ProvinceDailyData> pddlst = new List<ProvinceDailyData>();
            string sql = "select province,casedate,confirmed,suspect,death from ProvinceDailyData where casedate=@date";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@date", date));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,plst.ToArray());
            while (reader.Read())
            {
                ProvinceDailyData pdd = new ProvinceDailyData(reader.GetString("province"), reader.GetString("casedate"), reader.GetInt32("confirmed"), reader.GetInt32("suspect"), reader.GetInt32("death"));
                pddlst.Add(pdd);
            }
            reader.Close();

            return pddlst;
        }

        public List<ProvinceDailyData> selectByProvince(string province)
        {
            List<ProvinceDailyData> pddlst = new List<ProvinceDailyData>();
            string sql = "select province,casedate,confirmed,suspect,death from ProvinceDailyData where province=@province";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", province));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            while (reader.Read())
            {
                ProvinceDailyData pdd = new ProvinceDailyData(reader.GetString("province"), reader.GetString("casedate"), reader.GetInt32("confirmed"), reader.GetInt32("suspect"), reader.GetInt32("death"));
                pddlst.Add(pdd);
            }
            reader.Close();

            return pddlst;
        }

        public int update(ProvinceDailyData pdd)
        {
            int line = 0;

            string sql = "update ProvinceDailyData set confirmed=@confirmed,suspect=@suspect,death=@death where province=@province and casedate=@date";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province",pdd.province ));
            plst.Add(new MySqlParameter("@date", pdd.date));
            plst.Add(new MySqlParameter("@confirmed", pdd.confirmed));
            plst.Add(new MySqlParameter("@suspect", pdd.suspect));
            plst.Add(new MySqlParameter("@death", pdd.death));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
