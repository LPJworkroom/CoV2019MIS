using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProvinceDailyDataBLL : IProvinceDailyDataBLL
    {
        private static IProvinceDailyDataDAO pdddao = new ProvinceDailyDataDAO();
        public bool insert(ProvinceDailyData pdd)
        {
            ProvinceDailyData existPdd = pdddao.selecctByProvince_Date(pdd.province,pdd.date);
            if (existPdd != null)
            {
                return false;
            }
            int line = pdddao.insert(pdd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }

        public ProvinceDailyData selecctByProvince_Date(string province, string date)
        {
            return pdddao.selecctByProvince_Date(province,date);
        }

        public List<ProvinceDailyData> selectALL()
        {
            return pdddao.selectALL();
        }

        public List<ProvinceDailyData> selectByDate(string date)
        {
            return pdddao.selectByDate(date);
        }

        public List<ProvinceDailyData> selectByProvince(string province)
        {
            return pdddao.selectByProvince(province);
        }

        public bool update(ProvinceDailyData pdd)
        {
            ProvinceDailyData existPdd = pdddao.selecctByProvince_Date(pdd.province, pdd.date);
            if (existPdd == null)
            {
                return false;
            }
            int line = pdddao.update(pdd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
