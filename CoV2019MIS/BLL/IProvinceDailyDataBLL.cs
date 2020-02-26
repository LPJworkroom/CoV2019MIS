using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProvinceDailyDataBLL
    {
        List<ProvinceDailyData> selectALL();
        List<ProvinceDailyData> selectByProvince(string province);
        List<ProvinceDailyData> selectByDate(string date);
        ProvinceDailyData selecctByProvince_Date(string province, string date);
        bool insert(ProvinceDailyData pdd);
        bool update(ProvinceDailyData pdd);
    }
}
