using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ProvinceDefaultColorDAO : IProvinceDefaultColorDAO
    {
        public List<ProvinceDefaultColor> selectALL()
        {
            List<ProvinceDefaultColor> pdclst = new List<ProvinceDefaultColor>();
            string sql = "select province,r,g,b,rOffset,gOffset,bOffset from ProvinceDefaultColor";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                ProvinceDefaultColor pdc = new ProvinceDefaultColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"), reader.GetInt32("rOffset"), reader.GetInt32("gOffset"), reader.GetInt32("bOffset"));
                pdclst.Add(pdc);
            }
            reader.Close();

            return pdclst;
        }

        public ProvinceDefaultColor selectByColor(int r, int g, int b)
        {
            ProvinceDefaultColor pdc = null;
            string sql = "select province,r,g,b,rOffset,gOffset,bOffset from ProvinceDefaultColor where r=@r and g=@g and b=@b";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@r", r));
            plst.Add(new MySqlParameter("@g", g));
            plst.Add(new MySqlParameter("@b", b));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,plst.ToArray());
            if (reader.Read())
            {
                pdc = new ProvinceDefaultColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"), reader.GetInt32("rOffset"), reader.GetInt32("gOffset"), reader.GetInt32("bOffset"));
            }
            reader.Close();

            return pdc;
        }

        public ProvinceDefaultColor selectByProvince(string province)
        {
            ProvinceDefaultColor pdc = null;
            string sql = "select province,r,g,b,rOffset,gOffset,bOffset from ProvinceDefaultColor where province=@province";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            MySqlParameter p1=new MySqlParameter("@province", province);

            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);
            if (reader.Read())
            {
                pdc = new ProvinceDefaultColor(reader.GetString("province"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"), reader.GetInt32("rOffset"), reader.GetInt32("gOffset"), reader.GetInt32("bOffset"));
            }
            reader.Close();

            return pdc;
        }
    }
}
