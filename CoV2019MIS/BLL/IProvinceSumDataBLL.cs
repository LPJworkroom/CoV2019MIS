using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProvinceSumDataBLL
    {
        List<ProvinceSumData> selectALL();
        ProvinceSumData selectByProvince(string province);
        bool insert(ProvinceSumData psd);
        bool update(ProvinceSumData psd);
    }
}
