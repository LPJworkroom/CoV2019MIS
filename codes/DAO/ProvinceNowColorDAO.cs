using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ProvinceNowColorDAO : IProvinceNowColorDAO
    {
        public List<ProvinceNowColor> selectALL()
        {
            List<ProvinceNowColor> pnclst = new List<ProvinceNowColor>();
            string sql = "select province,r,g,b from ProvinceNowColor";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                ProvinceNowColor pnc = new ProvinceNowColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"));
                pnclst.Add(pnc);
            }
            reader.Close();

            return pnclst;
        }

        public ProvinceNowColor selectByColor(int r, int g, int b)
        {
            ProvinceNowColor pnc = null;
            string sql = "select province,r,g,b from ProvinceNowColor where r=@r and g=@g and b=@b";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@r", r));
            plst.Add(new MySqlParameter("@g", g));
            plst.Add(new MySqlParameter("@b", b));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            if (reader.Read())
            {
                pnc = new ProvinceNowColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"));
            }
            reader.Close();

            return pnc;
        }

        public ProvinceNowColor selectByProvince(string province)
        {
            ProvinceNowColor pnc = null;
            string sql = "select province,r,g,b from ProvinceNowColor where province=@province";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", province));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, plst.ToArray());
            if (reader.Read())
            {
                pnc = new ProvinceNowColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"));
            }
            reader.Close();

            return pnc;
        }

        public int update(ProvinceNowColor pnc)
        {
            int line = 0;
            string sql = "update ProvinceNowColor set r=@r,g=@g,b=@b where province=@province";

            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@province", pnc.province));
            plst.Add(new MySqlParameter("@r", pnc.r));
            plst.Add(new MySqlParameter("@g", pnc.g));
            plst.Add(new MySqlParameter("@b", pnc.b));
            
            line = MySQLHelper.ExecuteSql(sql, plst.ToArray());

            return line;
        }
    }
}
