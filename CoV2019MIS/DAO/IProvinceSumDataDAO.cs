using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IProvinceSumDataDAO
    {
        List<ProvinceSumData> selectALL();
        ProvinceSumData selectByProvince(string province);
        int insert(ProvinceSumData psd);
        int update(ProvinceSumData psd);
    }
}
