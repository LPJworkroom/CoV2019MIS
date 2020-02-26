using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IProvinceNowColorDAO
    {
        List<ProvinceNowColor> selectALL();
        ProvinceNowColor selectByProvince(string province);
        ProvinceNowColor selectByColor(int r, int g, int b);
        int update(ProvinceNowColor pnc);
    }
}
