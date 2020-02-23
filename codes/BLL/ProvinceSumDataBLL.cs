using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProvinceSumDataBLL : IProvinceSumDataBLL
    {
        private static IProvinceSumDataDAO psddao = new ProvinceSumDataDAO();
        public bool insert(ProvinceSumData psd)
        {
            ProvinceSumData existPsd = psddao.selectByProvince(psd.province);
            if (existPsd != null)
            {
                return false;
            }
            int line = psddao.insert(psd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }

        public List<ProvinceSumData> selectALL()
        {
            return psddao.selectALL();
        }

        public List<ProvinceSumData> selectByProvince(string province)
        {
            return psddao.selectByProvince(province);
        }

        public bool update(ProvinceSumData psd)
        {
            ProvinceSumData existPsd = psddao.selectByProvince(psd.province);
            if (existPsd == null)
            {
                return false;
            }
            int line = psddao.update(psd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
