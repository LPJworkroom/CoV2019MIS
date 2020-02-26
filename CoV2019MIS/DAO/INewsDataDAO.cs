using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface INewsDataDAO
    {
        List<NewsData> selectALL();
        List<NewsData> selectByDate(string date);
        NewsData selectByDate_Url(string date, string url);
        int insert(NewsData nd);
        int update(NewsData nd);
    }
}
