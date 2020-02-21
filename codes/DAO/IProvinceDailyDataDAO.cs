using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IProvinceDailyDataDAO
    {
        List<ProvinceDailyData> selectALL();
        List<ProvinceDailyData> selectByProvince(string province);
        List<ProvinceDailyData> selectByDate(string date);
        ProvinceDailyData selecctByProvince_Date(string province,string date);
        int insert(ProvinceDailyData pdd);
        int update(ProvinceDailyData pdd);
    }
}
