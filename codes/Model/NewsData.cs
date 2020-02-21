using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class NewsData
    {
        public string date { get; set; }
        public string title { get; set; }
        public string url { get; set; }

        public NewsData()
        {

        }

        public NewsData(string date, string url, string title)
        {
            this.date = date;
            this.title = title;
            this.url = url;
        }
    }
}
