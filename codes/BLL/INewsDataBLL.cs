using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface INewsDataBLL
    {
        List<NewsData> selectALL();
        List<NewsData> selectByDate(string date);
        NewsData selectByDate_Url(string date, string url);
        bool insert(NewsData nd);
        bool update(NewsData nd);
    }
}
