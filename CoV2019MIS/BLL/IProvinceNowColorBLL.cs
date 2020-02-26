using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProvinceNowColorBLL
    {
        List<ProvinceNowColor> selectALL();
        ProvinceNowColor selectByProvince(string province);
        ProvinceNowColor selectByColor(int r, int g, int b);
        bool update(ProvinceNowColor pnc);
    }
}
