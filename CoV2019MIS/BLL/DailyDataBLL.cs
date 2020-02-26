using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class DailyDataBLL : IDailyDataBLL
    {
        private static IProvinceDailyDataBLL pddbll=new ProvinceDailyDataBLL();
        public DailyData GetDailyData(string date)
        {
            DailyData dd = new DailyData(date,0,0,0);
            List<ProvinceDailyData> pddlst = pddbll.selectByDate(date);
            foreach (ProvinceDailyData pdd in pddlst)
            {
                dd.confirmed += pdd.confirmed;
                dd.suspect += pdd.suspect;
                dd.death += pdd.death;
            }
            return dd;
        }
    }
}
