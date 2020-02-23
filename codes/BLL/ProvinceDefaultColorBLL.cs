using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProvinceDefaultColorBLL : IProvinceDefaultColorBLL
    {
        private static IProvinceDefaultColorDAO pdcdao = new ProvinceDefaultColorDAO();
        public List<ProvinceDefaultColor> selectALL()
        {
            return pdcdao.selectALL();
        }

        public ProvinceDefaultColor selectByColor(int r, int g, int b)
        {
            return pdcdao.selectByColor(r,g,b);
        }

        public ProvinceDefaultColor selectByProvince(string province)
        {
            return pdcdao.selectByProvince(province);
        }
    }
}
