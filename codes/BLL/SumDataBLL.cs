using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class SumDataBLL : ISumDataBLL
    {
        private static IProvinceSumDataBLL psdbll = new ProvinceSumDataBLL();
        public SumData GetSumData()
        {
            SumData sd = new SumData(0, 0, 0);
            List<ProvinceSumData> psdlst = psdbll.selectALL();
            foreach (ProvinceSumData psd in psdlst)
            {
                sd.confirmed += psd.confirmed;
                sd.suspect += psd.suspect;
                sd.death += psd.death;
            }
            return sd;
        }
    }
}
