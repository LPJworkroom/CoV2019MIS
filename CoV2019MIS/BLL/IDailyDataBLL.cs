﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IDailyDataBLL
    {
        DailyData GetDailyData(string date);
    }
}
