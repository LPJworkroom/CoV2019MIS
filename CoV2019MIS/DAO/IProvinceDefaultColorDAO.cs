using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IProvinceDefaultColorDAO
    {
        List<ProvinceDefaultColor> selectALL();
        ProvinceDefaultColor selectByProvince(string province);
        ProvinceDefaultColor selectByColor(int r, int g, int b);
    }
}
