using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProcessDataBLL
    {
        bool ProcessPlagueData(string jstr);
        bool ProcessNewsData(string jstr);
    }
}
