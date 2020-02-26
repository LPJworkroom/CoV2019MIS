using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProvinceNowColorBLL : IProvinceNowColorBLL
    {
        private static IProvinceNowColorDAO pncdao = new ProvinceNowColorDAO();
        public List<ProvinceNowColor> selectALL()
        {
            return pncdao.selectALL();
        }

        public ProvinceNowColor selectByColor(int r, int g, int b)
        {
            return pncdao.selectByColor(r, g, b);
        }

        public ProvinceNowColor selectByProvince(string province)
        {
            return pncdao.selectByProvince(province);
        }

        public bool update(ProvinceNowColor pnc)
        {
            ProvinceNowColor existPnc = pncdao.selectByProvince(pnc.province);
            if (existPnc == null)
            {
                return false;
            }
            int line = pncdao.update(pnc);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
