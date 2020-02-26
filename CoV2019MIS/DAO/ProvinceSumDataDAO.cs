using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ProvinceSumDataDAO : IProvinceSumDataDAO
    {
        public int insert(ProvinceSumData psd)
        {
            int line = 0;
            string sql = "insert into ProvinceSumData values (@province,@confirmed,@suspect,@death)";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", psd.province));
            plst.Add(new MySqlParameter("@confirmed", psd.confirmed));
            plst.Add(new MySqlParameter("@suspect", psd.suspect));
            plst.Add(new MySqlParameter("@death", psd.death));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());
            return line;
        }

        public List<ProvinceSumData> selectALL()
        {
            List<ProvinceSumData> psdlst = new List<ProvinceSumData>();
            string sql = "select province,confirmed,suspect,death from ProvinceSumData";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                ProvinceSumData psd = new ProvinceSumData(reader.GetString("province"), reader.GetInt32("confirmed"), reader.GetInt32("suspect"), reader.GetInt32("death"));
                psdlst.Add(psd);
            }
            reader.Close();

            return psdlst;
        }

        public ProvinceSumData selectByProvince(string province)
        {
            ProvinceSumData psd = null;
            string sql = "select province,confirmed,suspect,death from ProvinceSumData where province=@province";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", province));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            if (reader.Read())
            {
                psd = new ProvinceSumData(reader.GetString("province"), reader.GetInt32("confirmed"), reader.GetInt32("suspect"), reader.GetInt32("death"));
            }
            reader.Close();

            return psd;
        }

        public int update(ProvinceSumData psd)
        {
            int line = 0;

            string sql = "update ProvinceSumData set confirmed=@confirmed,suspect=@suspect,death=@death where province=@province";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", psd.province));
            plst.Add(new MySqlParameter("@confirmed", psd.confirmed));
            plst.Add(new MySqlParameter("@suspect", psd.suspect));
            plst.Add(new MySqlParameter("@death", psd.death));
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
