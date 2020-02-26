using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IPlagueColorBLL
    {
        List<PlagueColor> selectALL();
        PlagueColor selectByNum(int num);
    }
}
