using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class NewsDataBLL : INewsDataBLL
    {
        private static INewsDataDAO nddao = new NewsDataDAO();
        public bool insert(NewsData nd)
        {
            NewsData existNd = nddao.selectByDate_Url(nd.date,nd.url);
            if (existNd != null)
            {
                return false;
            }
            int line = nddao.insert(nd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }

        public List<NewsData> selectALL()
        {
            return nddao.selectALL();
        }

        public List<NewsData> selectByDate(string date)
        {
            return nddao.selectByDate(date);
        }

        public NewsData selectByDate_Url(string date, string url)
        {
            return nddao.selectByDate_Url(date,url);
        }

        public bool update(NewsData nd)
        {
            NewsData existNd = nddao.selectByDate_Url(nd.date, nd.url);
            if (existNd == null)
            {
                return false;
            }
            int line = nddao.update(nd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
