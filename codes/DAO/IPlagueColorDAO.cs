using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IPlagueColorDAO
    {
        List<PlagueColor> selectALL();
        PlagueColor selectByNum(int num);

    }
}
