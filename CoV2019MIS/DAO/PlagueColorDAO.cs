using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class PlagueColorDAO : IPlagueColorDAO
    {
        public List<PlagueColor> selectALL()
        {
            List<PlagueColor> pclst = new List<PlagueColor>();
            string sql = "select numfloor,numceil,r,g,b from PlagueColor";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                PlagueColor pc = new PlagueColor(reader.GetInt32("numfloor"), reader.GetInt32("numceil"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"));
                pclst.Add(pc);
            }
            reader.Close();

            return pclst;
        }

        public PlagueColor selectByNum(int num)
        {
            PlagueColor pc = null;
            string sql = "select numfloor,numceil,r,g,b from PlagueColor where numfloor<=@num and numceil>@num";
            List<MySqlParameter> plst = new List<MySqlParameter>();
            plst.Add(new MySqlParameter("@num", num));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql,plst.ToArray());
            if (reader.Read())
            {
                pc = new PlagueColor(reader.GetInt32("numfloor"), reader.GetInt32("numceil"), reader.GetInt32("r"), reader.GetInt32("g"), reader.GetInt32("b"));
            }
            reader.Close();

            return pc;
        }
    }
}
